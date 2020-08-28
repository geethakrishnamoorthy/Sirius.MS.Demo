using Sirius.MS.BAL.Managers.Interfaces;

namespace Sirius.MS.BAL.Models
{
    public class ApiResponse : IApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object ResponseObject { get; set; }
    }
}
