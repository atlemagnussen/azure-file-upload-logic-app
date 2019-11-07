using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading.Tasks;

namespace TestUploadFileWebApi
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        private readonly ILogger<UploadController> _logger;
        private readonly FileService _fileService;

        public UploadController(ILogger<UploadController> logger, FileService fileService)
        {
            _logger = logger;
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] UploadModel model)
        {
            _logger.LogInformation("Upload method called");
            if (model.UploadFile != null)
            {
                System.Diagnostics.Trace.WriteLine($"Uploaded File {model.UploadFile.FileName} {model.UploadFile.ContentType} {model.UploadFile.Length}");

                _logger.LogInformation("Got UploadFile");
                _logger.LogInformation($"Filename={model.UploadFile.FileName}");
                _logger.LogInformation($"ContentType={model.UploadFile.ContentType}");
                _logger.LogInformation($"Length={model.UploadFile.Length}");

                if (model.UploadFile.ContentType == "text/xml")
                {
                    _logger.LogInformation("Try read xml file");
                    var ms = new MemoryStream();
                    await model.UploadFile.CopyToAsync(ms);
                    var doc = _fileService.GetImportDoc(ms);
                    _logger.LogInformation($"Customer = {doc.BuyerCustomerParty.Party.PartyName.Name}");
                    _logger.LogInformation($"Supplier = {doc.SellerSupplierParty.Party.PartyName.Name}");
                }

                return Ok(new
                {
                    model.UploadFile.FileName,
                    model.UploadFile.ContentType,
                    model.UploadFile.Length,
                    model.Additional,
                    Message = "Using FromForm works perfectly fine!"
                });
            }
            else
            {
                _logger.LogWarning("File not found in request");
                return NotFound(new
                {
                    Error = "no file posted"
                });
            }
        }
        [HttpPost, Route("Message")]
        public async Task<IActionResult> UploadMessageResponse([FromForm] UploadModel model)
        {
            _logger.LogInformation("Upload method called");
            return NotFound();
        }
    }
}