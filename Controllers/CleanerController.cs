using AirbncleanWeb.Models;
using ClassLibrary.WebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AirbncleanWeb.Controllers
{
    public class CleanerController : BaseController
    {
        public ActionResult home()
        {
            return View();
        }


        [HttpGet]
        public ActionResult logout()
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("home", "Account", new { area = "" });
        }

        [HttpGet]
        public ActionResult viewjobs()
        {
            var model = new CleanerViewJobsFilter();
            if (_AccountDetails != null)
            {
                model.cleanerId = _AccountDetails.Id;
                model.Lat = _AccountDetails.Latitude == null ? "0" : _AccountDetails.Latitude == string.Empty ? "0" : _AccountDetails.Latitude;
                model.Long = _AccountDetails.Longitude == null ? "0" : _AccountDetails.Longitude == string.Empty ? "0" : _AccountDetails.Longitude;
                model.type = ClassLibrary.Enum.PropertyType.All;
                model.distance = "All";
                model.price = "All";
                model.index = Convert.ToInt64(0);
            }
            return View(model);
        }

        [HttpPost]
        public object checkViewJobsCount(CleanerViewJobsFilter model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string, long> t = _repository.checkViewJobsCount(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message, Count = t.Item3 }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }


        public PartialViewResult RefreshViewJobsList(CleanerViewJobsFilter model)
        {
            return PartialView("~/Views/Cleaner/_pv_Cleaner_Viewjobs_list.cshtml", model);
        }
        public PartialViewResult RefreshViewJobsListPagination(CleanerViewJobsPagination model)
        {
            return PartialView("~/Views/Cleaner/_pv_CleanerViewJobsPagination.cshtml", model);
        }
        public PartialViewResult RefreshMyJobsList(CleanerMyJobsModel model)
        {
            return PartialView("~/Views/Cleaner/_pv_Cleaner_Myjobs_list.cshtml", model);
        }

        public PartialViewResult RefreshMyJobsListPagination(CleanerMyJobsModelPagenation model)
        {
            return PartialView("~/Views/Cleaner/_pv_CleanerMyJobsPagination.cshtml", model);
        }

        [HttpGet]
        public ActionResult myjobs()
        {
            var model = new CleanerMyJobsModel();
            if (_AccountDetails != null)
            {
                model.cleanerId = _AccountDetails.Id;
                model.JobStatus = ClassLibrary.Enum.JobStatus.Accepted;
                model.index = Convert.ToInt64(0);
            }
            return View(model);
        }

        [HttpGet]
        public void Refreshtimezone(string id)
        {
            EntitiesLibrary.Data.BaseReference obj = new EntitiesLibrary.Data.BaseReference(id);
        }

        [HttpPost]
        public object removeJobFromList(CleanerDeleteJobFromList model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.removeJobFromList(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpGet]
        public ActionResult alljobs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult viewjobdetails(string id)
        {
            var model = new ViewJobDetailsModel();
            model.jobId = Convert.ToInt64(id);
            return View(model);
        }

        [HttpPost]
        public object acceptjob(AcceptJob model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.acceptjob(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpPost]
        public object makejoblive(MakeJobLiveModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.makejoblive(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpPost]
        public object postcounteroffer(PostCounterOfferModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.postcounteroffer(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpGet]
        public ActionResult myjobdetails(string id)
        {
            var model = new MyJobDetailsModel();
            model.jobId = Convert.ToInt64(id);
            return View(model);
        }

        [HttpPost]
        public object finalizejob(CleanerFinalizeJobModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.finalizejob(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpGet]
        public ActionResult mycalender()
        {
            return View();
        }

        [HttpGet]
        public object getCleanerDates(string id)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string, DateclassList> t = _repository.getCleanerDates(id);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message, Dates = t.Item3 }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        public PartialViewResult RefreshMyCalenderJobList(CLeanerJobsByDate model)
        {
            return PartialView("~/Views/Cleaner/_pv_ViewCleanerJobsByDate.cshtml", model);
        }

        [HttpPost]
        public ActionResult alljobsdetails(ViewAllJobs model)
        {
            return View(model);
        }

        public PartialViewResult RefreshAllJobList(ViewAllJobs model)
        {
            return PartialView("~/Views/Cleaner/_pv_allJobs_detail_joblist.cshtml", model);
        }

        public PartialViewResult RefreshAllJobListPagenation(CleanerAllJobsModelPagenation model)
        {
            return PartialView("~/Views/Cleaner/_pv_CleanerAlljobsPagination.cshtml", model);
        }

        [HttpGet]
        public ActionResult jobdetails(string id)
        {
            var model = new MyJobDetailsModel();
            model.jobId = Convert.ToInt64(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult settings()
        {
            var model = new SettingsModel();
            model.Id = _AccountDetails.Id;
            model.Status = Convert.ToString(_AccountDetails.PushStatus);
            return View(model);
        }

        [HttpPost]
        public object RefreshPushStatus(SettingsModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.RefreshPushStatus(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpPost]
        public object UpdateJobReminder(JobReminderModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {

                Tuple<bool, string> t = _repository.updatejobreminder(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message, };
            }
        }

        [HttpPost]
        public object changePassword(ChangePasswordModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {

                Tuple<bool, string> t = _repository.changePassword(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message, };
            }
        }

        [HttpGet]
        public ActionResult profile()
        {
            return View();
        }


        [HttpGet]
        public object getPropertyList(long userId)
        {
            var list = new EntitiesLibrary.Data.WebService().getPropertyList(userId);
            return Json(new { Status = true, Message = "success", list = list }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult manageusers()
        {
            ClassLibrary.WebModels.ManageUsersModel model = new ManageUsersModel();
            if (_AccountDetails != null)
            {
                model.cleanerId = _AccountDetails.Id;
                model.userRole = ClassLibrary.Enum.UserRole.User;
                model.index = Convert.ToInt64(0);
            }
            return View(model);
        }

        public PartialViewResult RefreshManageusersList(ManageUsersModel model)
        {
            return PartialView("~/Views/Cleaner/_pv_Manageusers_user_list.cshtml", model);
        }

        public PartialViewResult RefreshManageusersListPagenation(ManageUsersModelPagenation model)
        {
            return PartialView("~/Views/Cleaner/_pv_Manageusers_user_list_pagination.cshtml", model);
        }

        [HttpPost]
        public object adminDeleteUser(AdminDeleteUser model)
        {
            bool status = false;
            string message = "Failed";
            try
            {

                Tuple<bool, string> t = _repository.adminDeleteUser(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message, };
            }
        }


        [HttpGet]
        public ActionResult managejobs()
        {
            ClassLibrary.WebModels.ManageJobsModel model = new ManageJobsModel();
            if (_AccountDetails != null)
            {
                model.cleanerId = _AccountDetails == null ? 0 : _AccountDetails.Id;
                model.index = 0;
                model.jobStatus = ClassLibrary.Enum.JobStatus.fetchAll;
                model.workType = ClassLibrary.Enum.WorkType.All;
            }
            return View(model);
        }

        public PartialViewResult RefreshManagejobsList(ManageJobsModel model)
        {
            return PartialView("~/Views/Cleaner/_pv_Cleaner_ManageJob_list.cshtml", model);
        }

        public PartialViewResult RefreshManagejobsListPagenation(ManageJobsModelPagenation model)
        {
            return PartialView("~/Views/Cleaner/_pv_Cleaner_ManageJob_list_Pagination.cshtml", model);
        }

        [HttpGet]
        public ActionResult editjob(string id)
        {
            var model = new EditJobAdmin();
            model.JobId =id;
            model.cleanerId = Convert.ToString(_AccountDetails == null ? 0 : _AccountDetails.Id);
            return View(model);
        }


        [HttpPost]
        public object editjob(EditJobAdmin model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.editjobAdmin(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message, jobid = model.JobId }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        public ActionResult viewuserjobdetails(string id)
        {
            var model = new AdminViewJobModel();
            model.cleanerId = _AccountDetails == null ? 0 : _AccountDetails.Id;
            model.jobId = Convert.ToInt64(id);
            return View(model);
        }

        [HttpGet]
        public object deleteUserJobAdmin(string id)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.deleteuserjobadmin(id);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpPost]
        public object submituserjobfeedbackadmin(SubmitJobFeedbackModel model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.submituserjobfeedbackadmin(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                {
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                }
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message };
            }
        }

        [HttpPost]
        public object changeSelectedCleanerAdmin(UpdateJobsSelectedCleaner model)
        {
            bool status = false;
            string message = "Failed";
            try
            {
                Tuple<bool, string> t = _repository.changeSelectedCleanerAdmin(model);
                status = t.Item1;
                message = t.Item2;
                if (status)
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
                else
                    return Json(new { Status = status, Message = message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return new { Status = status, Message = ex.Message, List = new { } };
            }
        }

    }
}
