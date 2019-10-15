using System.Xml.Serialization;

namespace TestUploadFileWebApi.Models.Peppol.SubModels
{
    public class OrderLinePeppol
    {
        [XmlElement("Note", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Note { get; set; }

        [XmlElement("LineItem", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderLineItem LineItem { get; set; }
    }

    public class OrderResponseLine
    {
        [XmlElement("LineItem", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderResponseLineItem LineItem { get; set; }

        [XmlElement("SellerSubstitutedLineItem", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderLineItem SellerSubstitutedLineItem { get; set; }

        [XmlElement("OrderLineReference", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderLineReference OrderLineReference { get; set; }
    }

    public class LineItemBase
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("Quantity", Namespace = PeppolXmlNamespaces.Cbc)]
        public Quantity Quantity { get; set; }

        [XmlElement("Price", Namespace = PeppolXmlNamespaces.Cac)]
        public LinePrice Price { get; set; }

        [XmlElement("Item", Namespace = PeppolXmlNamespaces.Cac)]
        public Item Item { get; set; }
    }
    public class OrderLineItem : LineItemBase
    {
        [XmlElement("LineExtensionAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount LineExtensionAmount { get; set; }

        [XmlElement("PartialDeliveryIndicator", Namespace = PeppolXmlNamespaces.Cbc)]
        public bool PartialDeliveryIndicator { get; set; }

        [XmlElement("AccountingCost", Namespace = PeppolXmlNamespaces.Cbc)]
        public string AccountingCost { get; set; }

        [XmlElement("Delivery", Namespace = PeppolXmlNamespaces.Cac)]
        public LineDelivery Delivery { get; set; }

        // OriginatorParty here if we need it

        // AllowanceCharge here if we need it
    }

    public class OrderResponseLineItem : LineItemBase
    {
        [XmlElement("Note", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Note { get; set; }

        [XmlElement("LineStatusCode", Namespace = PeppolXmlNamespaces.Cbc)]
        public LineStatusCode LineStatusCode { get; set; }

        [XmlElement("MaximumBackorderQuantity", Namespace = PeppolXmlNamespaces.Cbc)]
        public int MaximumBackorderQuantity { get; set; }

        [XmlElement("PromisedDeliveryPeriod", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryPeriod PromisedDeliveryPeriod { get; set; }
    }

    public enum LineStatusCode
    {
        [XmlEnum("1")]
        Added = 1,

        [XmlEnum("3")]
        Changed = 3,

        [XmlEnum("5")]
        AcceptedWithoutAmendment = 5,

        [XmlEnum("7")]
        NotAccepted = 7,

        [XmlEnum("42")]
        AlreadyDelivered = 42
    }

    public class Quantity
    {
        [XmlAttribute("unitCode")]
        public string UnitCode { get; set; }

        [XmlText]
        public double Number { get; set; }
    }

    public class LineDelivery
    {
        [XmlElement("RequestedDeliveryPeriod", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryPeriod RequestedDeliveryPeriod { get; set; }
    }

    public class LinePrice
    {
        [XmlElement("PriceAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount PriceAmount { get; set; }

        [XmlElement("BaseQuantity", Namespace = PeppolXmlNamespaces.Cbc)]
        public Quantity BaseQuantity { get; set; }
    }

    public class Item
    {
        [XmlElement("Name", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Name { get; set; }

        [XmlElement("Description", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Description { get; set; }

        [XmlElement("BuyersItemIdentification", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference BuyersItemIdentification { get; set; }

        [XmlElement("SellersItemIdentification", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference SellersItemIdentification { get; set; }

        [XmlElement("StandardItemIdentification", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference StandardItemIdentification { get; set; }

        [XmlElement("ClassifiedTaxCategory", Namespace = PeppolXmlNamespaces.Cac)]
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }
    }

    public class ClassifiedTaxCategory
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("Percent", Namespace = PeppolXmlNamespaces.Cbc)]
        public double Percent { get; set; }
    }

    public class OrderLineReference
    {
        [XmlElement("LineID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string LineId { get; set; }
    }
}
