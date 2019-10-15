using System.Xml.Serialization;

namespace TestUploadFileWebApi.Models.Peppol
{
    /// <summary>
    /// Host common properties of Order Transaction and Order Response Transaction
    /// </summary>
    public class PeppolOrderBase
    {
        [XmlElement("CustomizationID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CustomizationId { get; set; }

        [XmlElement("ProfileID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string ProfileId { get; set; }

        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("SalesOrderID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string SalesOrderId { get; set; }

        [XmlElement("IssueDate", Namespace = PeppolXmlNamespaces.Cbc)]
        public string IssueDate { get; set; }

        [XmlElement("IssueTime", Namespace = PeppolXmlNamespaces.Cbc)]
        public string IssueTime { get; set; }

        [XmlElement("Note", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Note { get; set; }

        [XmlElement("DocumentCurrencyCode", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CurrencyCode { get; set; }

        [XmlElement("CustomerReference", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CustomerReference { get; set; }
    }

    public class DeliveryPeriod
    {
        [XmlElement("StartDate", Namespace = PeppolXmlNamespaces.Cbc)]
        public string StartDate { get; set; }

        [XmlElement("EndDate", Namespace = PeppolXmlNamespaces.Cbc)]
        public string EndDate { get; set; }
    }
}
