using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirbncleanWeb.Controllers
{
    public class ResetController : PreLoginBaseController
    {

        [HttpGet]
        public ActionResult Reset(string id)
        {
            Guid ResetGuid = new Guid(id);
            var model = new WebApi.Models.ResetPasswordModel();
            var reset = _entities.tPasswordResets.Where(z => z.ResetGuid == ResetGuid && z.IsExpired == false).FirstOrDefault();
            if (reset != null)
            {
                var user = _entities.tRegistrations.FirstOrDefault(z => z.Id == reset.UserId && z.IsActive);
                if (user != null)
                {
                    model.UserId = user.Id;
                    model.UserGuid = user.Guid ?? Guid.Empty;
                    model.isExpired = false;
                }
                else
                {
                    model.isExpired = true;
                }
            }
            else
            {
                model.isExpired = true;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult status(string id)
        {
            var model = new ClassLibrary.PostModel.Status();
            model.status = Convert.ToBoolean(id);
            return View(model);
        }


        [HttpPost]
        public object ChangePassword(WebApi.Models.ResetPasswordModel model)
        {
            var status = false;
            var msg = "failed";
            var resetAll = _entities.tPasswordResets.Where(z => z.UserId == model.UserId && z.IsExpired == false).ToList();
            if (resetAll != null)
            {
                var result = _entities.tRegistrations.Where(z => z.Id == model.UserId && z.IsActive).FirstOrDefault();
                if (result != null)
                {
                    var userList = _entities.tRegistrations.Where(z => z.Email.ToLower() == result.Email.ToLower()).ToList();
                    if (userList.Count > 0)
                    {
                        foreach (var item in userList)
                        {
                            if (item.Password != model.NewPassword)
                            {
                                item.Password = model.NewPassword;
                                status = _entities.SaveChanges() > 0;
                            }
                            else
                            {
                                status = true;
                            }
                        }
                            msg = status ? "success" : "failed";
                            if (status)
                            {
                                foreach (var res in resetAll)
                                {
                                    res.IsExpired = true;
                                }
                                _entities.SaveChanges();
                            }
                    }
                }
            }
            return Json(new { status = status, msg = msg }, JsonRequestBehavior.AllowGet);
        }

    }
}
