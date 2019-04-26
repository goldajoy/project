using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    class Common
    {
    }
    public class JobFeedbackModel
    {
        public string JobId { get; set; }
    }
    public class SubmitJobFeedbackModel
    {
        public string CleanerId { get; set; }
        public string JobId { get; set; }
        public string Text { get; set; }
        public string Rating { get; set; }
    }
    public class CustomDataClass
    {
        public string Text { get; set; }
        public List<DataClassValues> Values { get; set; }
    }
    public class DataClassValues
    {
        public string OptionText { get; set; }
        public string OptionId { get; set; }
        public string IsChecked { get; set; }
    }
    public class CleanerJobsDate
    {
        public string CleanerId { get; set; }
    }
    public class CompletedJobDates
    {
        public string Date { get; set; }
    }
    public class PendingJobDates
    {
        public string Date { get; set; }
    }
    public class CurrentDate
    {
        public string Date { get; set; }
    }
    public class DateclassList
    {
        public List<CompletedJobDates> CompletedJobDates { get; set; }
        public List<PendingJobDates> PendingJobDates { get; set; }
    }
    public class PushStatusModel
    {
        public string UserId { get; set; }
    }
    public class CLeanerJobsByDate
    {
        public string CleanerId { get; set; }
        public string Date { get; set; }
        public string TimeZone { get; set; }
    }
    public class ForgotPasswordModel
    {
        public string Email { get; set; }
    }
    public class Status
    {
        public bool status { get; set; }
    }
    public class UserResetPassword
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class ResetBadge
    {
        public string UserId { get; set; }
    }

    public class UserDeleteCounterOffer
    {
        public string UserId { get; set; }
        public string CounterOfferId { get; set; }
    }
    public class JobDetails
    {
        public string JobId { get; set; }
    }
    public class LogoutModel
    {
        public string userId { get; set; }
        public string DeviceToken { get; set; }
    }
    public class GetAccountDetails
    {
        public string AccountId { get; set; }
    }

    public class SwitchAccount
    {
        public string Email { get; set; }
        public string DeviceToken { get; set; }
        public ClassLibrary.Enum.UserRole UserRole { get; set; }
    }

    public class MakeJobLive
    {
        public string cleanerId { get; set; }
        public string newPrice { get; set; }
        public string jobId { get; set; }
        public string forAll { get; set; }
        public string userIds { get; set; }
        public string AdminInstructions { get; set; }
    }
    public class JobReminderModel
    {
        public string cleanerId { get; set; }
        public string Value { get; set; }
    }

    public class GetCleanerJobsAdmin
    {
        public string cleanerId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string All { get; set; }
        public string isCompany { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }
    }

    public class GetCleanerJobsAdminResponse
    {
        public string AllJobsCount { get; set; }
        public string CompletedJobsCount { get; set; }
        public string PendingJobsCount { get; set; }
    }
    public class GetCleanerList
    {
        public string cleanerId { get; set; }
    }

    public class CleanerResponse
    {
        public long CLEANERID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string SUBURB { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string ZIP { get; set; }
        public string EMAIL { get; set; }
        public string PROFILEIMAGE { get; set; }
        public int RATING { get; set; }
    }

    public class UserResponse
    {
        public long USERID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string SUBURB { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public string ZIP { get; set; }
        public string EMAIL { get; set; }
        public string PROFILEIMAGE { get; set; }
        public int RATING { get; set; }
    }

    public class SelectedCleaner
    {
        public long cleanerId { get; set; }
    }


    public class PostSelectedCleanerApi
    {
        public long userId { get; set; }
        public List<SelectedCleaner> cleanerIds { get; set; }
    }
    public class DeleteSelectedCleanerApi
    {
        public long userId { get; set; }
        public long cleanerId { get; set; }
    }


    public class GetUserSelectedCleanerListPostModel
    {
        public long userId { get; set; }
    }

    public class GetNotSelectedleanerList
    {
        public long userId { get; set; }
    }

    public class GetUserPropertyList
    {
        public long userId { get; set; }
    }

    public class GetUserPropertyListResponse
    {
        public List<PropertyData> list { get; set; }
    }

    public class PropertyData
    {
        public long propertyId { get; set; }
        public string propertyName { get; set; }
    }

    public class UpdateJobsSelectedCleaner
    {
        public long jobId { get; set; }
        public long NextCleanerId { get; set; }
    }

    public class ListUsersRequest
    {
        public long userId { get; set; }
        public int index { get; set; }
        public int listCount { get; set; }
    }

    public class ListCleanersRequest
    {
        public long cleanerId { get; set; }
        public int index { get; set; }
        public int listCount { get; set; }
    }

    public class DeleteUserRequest
    { 
        public long userId { get; set; }
    }

    public class ListAllPendingJobsRequest
    {
        public int index { get; set; }
        public int listCount { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }

        public string startDate { get; set; }
        public string endDate { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }
    }

    public class GetUserDetails
    {
        public long userId { get; set; }
    }

}
