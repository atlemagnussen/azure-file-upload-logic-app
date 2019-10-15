using System.Xml.Serialization;

namespace TestUploadFileWebApi.Models.Peppol.SubModels
{
    public class DeliveryAddress : PostalAddress
    {
        [XmlElement("AdditionalStreetName", Namespace = PeppolXmlNamespaces.Cbc)]
        public string AdditionalStreetName { get; set; }
    }

    public class PostalAddress : RegistrationAddress
    {
        [XmlElement("StreetName", Namespace = PeppolXmlNamespaces.Cbc)]
        public string StreetName { get; set; }

        [XmlElement("PostalZone", Namespace = PeppolXmlNamespaces.Cbc)]
        public string PostalZone { get; set; }

        [XmlElement("CountrySubentity", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CountrySubentity { get; set; }
    }

    public class RegistrationAddress
    {
        [XmlElement("CityName", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CityName { get; set; }

        [XmlElement("Country", Namespace = PeppolXmlNamespaces.Cac)]
        public Country Country { get; set; }
    }
    public class Country
    {
        [XmlElement("IdentificationCode", Namespace = PeppolXmlNamespaces.Cbc)]
        public string IdentificationCode { get; set; }
    }
}
