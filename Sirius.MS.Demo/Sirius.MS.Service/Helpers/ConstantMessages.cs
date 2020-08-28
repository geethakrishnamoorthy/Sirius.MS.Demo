
namespace Sirius.MS.Service.Helpers
{
    public static class ConstantMessages
    {
        public static string Load = "{event} Loaded Successfully.";
        public static string Create = "{event} created Successfully";
        public static string Update = "{event} updated Successfully.";
        public static string Delete = "{event} deleted Successfully.";

        public static string LoadFailure = "Failed to retrieve the {event}.";
        public static string CreateFailure = "Failed to create {event}";
        public static string UpdateFailure = "Failed to update {event}";
        public static string DeleteFailure = "Failed to delete {event}";
        public static string ExistsFailure = "{event} not exists.";
        public static string NoRecordsFound = "No records found in {event}";
        public static string InvalidParameter = "Invalid Parameter";
    }
}
