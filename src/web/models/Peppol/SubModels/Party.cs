using System.Xml.Serialization;

namespace TestUploadFileWebApi.Models.Peppol.SubModels
{
    public class PartyBase
    {
        [XmlElement("EndpointID", Namespace = PeppolXmlNamespaces.Cbc)]
        public IdWithScheme EndPointId { get; set; }

        [XmlElement("PartyIdentification", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference PartyIdentification { get; set; }

        [XmlElement("Contact", Namespace = PeppolXmlNamespaces.Cac)]
        public Contact Contact { get; set; }
    }

    public class IdWithScheme
    {
        [XmlAttribute("schemeID")]
        public string SchemeId { get; set; }

        [XmlText]
        public string Id { get; set; }
    }
    public class PartyLegalEntityBase
    {
        [XmlElement("RegistrationName", Namespace = PeppolXmlNamespaces.Cbc)]
        public string RegistrationName { get; set; }
    }

    public class ResponsePartyWrapper
    {
        [XmlElement("Party", Namespace = PeppolXmlNamespaces.Cac)]
        public ResponseParty Party { get; set; }
    }

    public class ResponseParty : PartyBase
    {
        [XmlElement("PartyLegalEntity", Namespace = PeppolXmlNamespaces.Cac)]
        public PartyLegalEntityBase PartyLegalEntity { get; set; }
    }

    public class OrderParty : PartyBase
    {
        [XmlElement("PartyName", Namespace = PeppolXmlNamespaces.Cac)]
        public PartyName PartyName { get; set; }

        [XmlElement("PostalAddress", Namespace = PeppolXmlNamespaces.Cac)]
        public PostalAddress PostalAddress { get; set; }

        [XmlElement("PartyLegalEntity", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderPartyLegalEntity PartyLegalEntity { get; set; }
    }

    public class OrderPartyLegalEntity : PartyLegalEntityBase
    {
        [XmlElement("CompanyID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CompanyId { get; set; }

        [XmlElement("RegistrationAddress", Namespace = PeppolXmlNamespaces.Cac)]
        public RegistrationAddress RegistrationAddress { get; set; }
    }
    public class PartyName
    {
        [XmlElement("Name", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Name { get; set; }
    }
}
