using System.Xml.Serialization;
using TestUploadFileWebApi.Models.Peppol.SubModels;

namespace TestUploadFileWebApi.Models.Peppol
{
    /// <summary>
    /// Peppol Order Response Transaction 3.0
    /// https://docs.peppol.eu/poacc/upgrade-3/syntax/OrderResponse/tree/
    /// </summary>

    [XmlRoot("OrderResponse", Namespace = PeppolXmlNamespaces.OrderResponse)]
    public class PeppolOrderResponseXmlModel : PeppolOrderBase
    {
        [XmlElement("OrderResponseCode", Namespace = PeppolXmlNamespaces.Cbc)]
        public string OrderResponseCode { get; set; }

        [XmlElement("OrderReference", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference OrderReference { get; set; }

        [XmlElement("SellerSupplierParty", Namespace = PeppolXmlNamespaces.Cac)]
        public ResponsePartyWrapper SellerSupplierParty { get; set; }

        [XmlElement("BuyerCustomerParty", Namespace = PeppolXmlNamespaces.Cac)]
        public ResponsePartyWrapper BuyerCustomerParty { get; set; }

        [XmlElement("Delivery", Namespace = PeppolXmlNamespaces.Cac)]
        public ResponseDelivery Delivery { get; set; }

        [XmlElement("OrderLine", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderResponseLine[] Lines { get; set; }
    }

    public class ResponseDelivery
    {
        [XmlElement("PromisedDeliveryPeriod", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryPeriod PromisedDeliveryPeriod { get; set; }
    }
}
