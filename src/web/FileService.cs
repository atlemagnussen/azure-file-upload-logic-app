using System.IO;
using System.Xml.Serialization;
using TestUploadFileWebApi.Models.Peppol;

namespace TestUploadFileWebApi
{
    public class FileService
    {
        public PeppolOrderTransactionXmlModel GetImportDoc(Stream stream)
        {
            stream.Position = 0;
            XmlSerializer serializer = new XmlSerializer(typeof(PeppolOrderTransactionXmlModel));
            var doc = (PeppolOrderTransactionXmlModel)serializer.Deserialize(stream);
            return doc;
        }
    }
}
