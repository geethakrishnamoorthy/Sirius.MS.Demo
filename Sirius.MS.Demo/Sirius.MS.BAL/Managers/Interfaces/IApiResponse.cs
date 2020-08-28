
namespace Sirius.MS.BAL.Managers.Interfaces
{
    public interface IApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object ResponseObject { get; set; }
    }
}
