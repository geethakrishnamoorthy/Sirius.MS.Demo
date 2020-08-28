
namespace Sirius.MS.Service.Helpers
{
    public class VBooksServiceAPIUrls
    {
        // If any Common url declare here
        //CRUD Urls
        public const string LoadList = "LoadList";
        public const string LoadById = "LoadById/{id}";
        public const string Create = "Create";
        public const string Update = "Update";
        public const string Delete = "Delete/{id}";

        public static class ProductApiUrl
        {
            public const string GetProductByCode = "GetProductByCode/{code}";
        }

    }
}