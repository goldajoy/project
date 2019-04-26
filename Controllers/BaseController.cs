using EntitiesLibrary;
using EntitiesLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirbncleanWeb.Controllers
{
    public class BaseController : Controller
    {
        protected AirbncleanNewEntities _entities = new AirbncleanNewEntities();
        public WebRepository _repository = new WebRepository();
        public DateTime currentTime = DateTime.UtcNow;


        public tRegistration _AccountDetails;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //check whether the user is logged in or else
            if (User != null && User.Identity.IsAuthenticated)
            {

                if (Session["AccountDetails"] == null)
                {
                    var accountId = long.Parse(User.Identity.Name);
                    var data = getAccountById(accountId);
                    Session["AccountDetails"] = data;
                }
                else
                {
                    UpdateSession();
                }
                _AccountDetails = (tRegistration)Session["AccountDetails"];
                if (Session["AccountDetails"] != null)
                {
                    _AccountDetails = (tRegistration)Session["AccountDetails"];
                    if (_AccountDetails != null)
                    {
                        if (_AccountDetails.UserRole == (int)ClassLibrary.Enum.UserRole.User)
                        {
                            filterContext.Result = new RedirectResult("/User/home");
                        }
                    }
                }
            }
            else
            {
                filterContext.Result = new RedirectResult("/Account/home");
            }
        }
        public object UpdateSession()
        {
            if (User != null && User.Identity.IsAuthenticated)
            {
                var accountId = long.Parse(User.Identity.Name);
                var data = getAccountById(accountId);
                Session["AccountDetails"] = data;
                _AccountDetails = (tRegistration)Session["AccountDetails"];
            }
            return true;
        }

        public tRegistration getAccountById(long Id)
        {
            return _entities.tRegistrations.Where(z => z.Id == Id).FirstOrDefault();
        }


    }
}
