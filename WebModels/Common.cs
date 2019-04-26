using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.WebModels
{
    class Common
    {
    }
    public class CleanerViewJobsFilter
    {
        public string price { get; set; }
        public string distance { get; set; }
        public ClassLibrary.Enum.PropertyType type { get; set; }
        public long cleanerId { get; set; }
        public long index { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }

    }

    public class CleanerViewJobsPagination
    {
        public string price { get; set; }
        public string distance { get; set; }
        public ClassLibrary.Enum.PropertyType type { get; set; }
        public long cleanerId { get; set; }
        public long nextIndex { get; set; }
        public long currentIndex { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }

    }

    public class CleanerMyJobsModel
    {
        public long cleanerId { get; set; }
        public long index { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
    }

    public class CleanerMyJobsModelPagenation
    {
        public long cleanerId { get; set; }
        public long currentIndex { get; set; }
        public long nextIndex { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
    }


    public class CleanerDeleteJobFromList
    {
        public long cleanerId { get; set; }
        public long jobId { get; set; }
    }
    public class UserMyPropertiesModel
    {
        public long index { get; set; }
    }
   
    public class UserMyPropertiesPaginationModel
    {
        public long nextIndex { get; set; }
        public long currenttIndex { get; set; }
    }
    public class MyCleanersViewModelUserMyPropertiesPaginationModel
    {
        public long nextIndex { get; set; }
        public long currenttIndex { get; set; }
        public long userId { get; set; }
    }
    public class UserDeletePropertyFromList
    {
        public long userId { get; set; }
        public long propertyId { get; set; }
    }
    public class UserViewProperty
    {
        public long propertyId { get; set; }
    }
    public class UserMyJobsModel
    {
        public long userId { get; set; }
        public long index { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }

        public List<UserPorpertyModel> UserProperties { get; set; }

        public string startDate { get; set; }
        public string endDate { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }

    }

    public class UserPorpertyModel
    {
        public long propertyId { get; set; }
        public string propertyName { get; set; }
    }
    public class UserMyJobsPaginationModel
    {
        public long userId { get; set; }
        public long currentIndex { get; set; }
        public long nextIndex { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }

        public List<UserPorpertyModel> UserProperties { get; set; }

        public string startDate { get; set; }
        public string endDate { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }

    }
    public class UserViewJobModel
    {
        public long userId { get; set; }
        public long jobId { get; set; }
    }

    public class UserJobCounterOfferModel
    {
        public long userId { get; set; }
        public long jobId { get; set; }
        public long index { get; set; }
    }
    public class UserJobCounterOfferPaginationModel
    {
        public long userId { get; set; }
        public long jobId { get; set; }
        public long currentIndex { get; set; }
        public long nextIndex { get; set; }
    }
    public class UserDeleteCounterOffer
    {
        public long userId { get; set; }
        public long counterOfferId { get; set; }
    }
    public class CounterOfferDetailModel
    {
        public long userId { get; set; }
        public long counterOfferId { get; set; }
        public long jobId { get; set; }
    }

    public class AcceptCounterOffer
    {
        public long userId { get; set; }
        public long counterOfferId { get; set; }
    }
    public class AcceptJob
    {
        public long cleanerId { get; set; }
        public long jobId { get; set; }
    }
    public class ViewAllJobs
    {
        public long cleanerId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string All { get; set; }
        public string TimeZone { get; set; }
        public int index { get; set; }


        public long companyId { get; set; }
        public string isCompany { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }
    }
    public class ViewJobDetailsModel
    {
        public long jobId { get; set; }
    }
    public class MyJobDetailsModel
    {
        public long jobId { get; set; }
    }
    public class SettingsModel
    {
        public long Id { get; set; }
        public string Status { get; set; }
    }

    public class RemoveSelectedCleaners
    {
        public long userId { get; set; }
        public long cleanerId { get; set; }
        public int index { get; set; }
    }

    public class PostSelectedCleaner
    {
        public long userId { get; set; }
        //public long cleanerId { get; set; }
        //public List<SelectedCleaner> cleanerIds { get; set; }
        //public List<string> cleanerIds { get; set; }
        public string cleanerIds { get; set; }
    }
    public class SelectedCleaner
    {
        public string cleanerId { get; set; }
    }
    public class RefreshMyCleanersDropdown
    {
        public long userId { get; set; }
    
    }

    public class JobReminderModel
    {
        public string cleanerId { get; set; }
        public string Value { get; set; }
    }
    public class ChangePasswordModel
    {
        public string Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
    public class MakeJobLiveModel
    {
        public string cleanerId { get; set; }
        public string newPrice { get; set; }
        public string jobId { get; set; }
        public string forAll { get; set; }
        public string cleanerIds { get; set; }
        public string AdminInstructions { get; set; }
    }
    public class PostCounterOfferModel
    {
        public string CleanerId { get; set; }
        public string JobId { get; set; }
        public string Price { get; set; }
    }
    public class CleanerFinalizeJobModel
    {
        public string CleanerId { get; set; }
        public string JobId { get; set; }
        public string Comment { get; set; }
        public string IsFinalized { get; set; }
        public List<DataClassValues> Values { get; set; }
        public string ListValues { get; set; }
    }
    public class DataClassValues
    {
        public string OptionText { get; set; }
        public string OptionId { get; set; }
        public string IsChecked { get; set; }
    }

    public class CompletedJobDates
    {
        public string Date { get; set; }
    }
    public class PendingJobDates
    {
        public string Date { get; set; }
    }
    public class DateclassList
    {
        public List<CompletedJobDates> CompletedJobDates { get; set; }
        public List<PendingJobDates> PendingJobDates { get; set; }
    }
    public class CLeanerJobsByDate
    {
        public string CleanerId { get; set; }
        public string Date { get; set; }
        public string TimeZone { get; set; }
    }
    public class CleanerAllJobsModelPagenation
    {
        public long cleanerId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string All { get; set; }
        public string TimeZone { get; set; }
        public int currentIndex { get; set; }
        public int nextIndex { get; set; }

        public long companyId { get; set; }
        public string isCompany { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }

    }
    public class SubmitJobFeedbackModel
    {
        public string CleanerId { get; set; }
        public string JobId { get; set; }
        public string Text { get; set; }
        public string Rating { get; set; }
    }

    public class MyCleanersViewModel
    {
        public long userId { get; set; }
        public int index { get; set; }
    }
    public class UpdateJobsSelectedCleaner
    {
        public long jobId { get; set; }
        public long NextCleanerId { get; set; }
    }

    public class ManageUsersModel
    {
        public long cleanerId { get; set; }
        public long index { get; set; }
        public ClassLibrary.Enum.UserRole userRole { get; set; }
    }

    public class ManageUsersModelPagenation
    {
        public long cleanerId { get; set; }
        public long currentIndex { get; set; }
        public long nextIndex { get; set; }
        public ClassLibrary.Enum.UserRole userRole { get; set; }
    }
    public class AdminDeleteUser
    {
        public long userId { get; set; }
    }


    public class ManageJobsModel
    {
        public long cleanerId { get; set; }
        public long index { get; set; }
        public ClassLibrary.Enum.JobStatus jobStatus { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }
    }

    public class ManageJobsModelPagenation
    {
        public long cleanerId { get; set; }
        public long currentIndex { get; set; }
        public long nextIndex { get; set; }
        public ClassLibrary.Enum.JobStatus jobStatus { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }
    }

    public class EditJobAdmin
    {
        public string cleanerId { get; set; }
        public string JobId { get; set; }
        public string UserId { get; set; }
        public string PropertyId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IsEditedProperty { get; set; }
        public string Instructions { get; set; }
        public ClassLibrary.Enum.WorkType WorkType { get; set; }
        public string IsNewProperty { get; set; }
        public string PropertyString { get; set; }
        public string TimeZone { get; set; }
        public EditUserPropertyModel Property { get; set; }
        public string CurrentCleanerId { get; set; }
        public string NextCleanerId { get; set; }
        public bool hasMadeAnyChange { get; set; }
    }

    public class AdminViewJobModel
    {
        public long userId { get; set; }
        public long cleanerId { get; set; }
        public long jobId { get; set; }
    }

}
