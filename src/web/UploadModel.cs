using Microsoft.AspNetCore.Http;

namespace TestUploadFileWebApi
{
    public class UploadModel
    {
        public IFormFile UploadFile { get; set; }

        public string Additional { get; set; }
    }
}