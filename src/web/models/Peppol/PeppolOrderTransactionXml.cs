using System.Xml.Serialization;
using TestUploadFileWebApi.Models.Peppol.SubModels;

namespace TestUploadFileWebApi.Models.Peppol
{
    /// <summary>
    /// Peppol Order Transaction 3.0
    /// https://docs.peppol.eu/poacc/upgrade-3/syntax/Order/tree/
    /// Only implement the things we need in eye-share and not necessarily everything
    /// </summary>
    [XmlRoot("Order", Namespace = PeppolXmlNamespaces.Order)]
    public class PeppolOrderTransactionXmlModel : PeppolOrderBase
    {
        [XmlElement("OrderTypeCode", Namespace = PeppolXmlNamespaces.Cbc)]
        public string OrderTypeCode { get; set; }

        [XmlElement("AccountingCost", Namespace = PeppolXmlNamespaces.Cbc)]
        public string AccountingCost { get; set; }

        [XmlElement("ValidityPeriod", Namespace = PeppolXmlNamespaces.Cac)]
        public ValidityPeriod ValidityPeriod { get; set; }

        [XmlElement("QuotationDocumentReference", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference QuotationDocumentReference { get;set; }

        [XmlElement("OrderDocumentReference", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference OrderDocumentReference { get; set; }

        [XmlElement("OriginatorDocumentReference", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference OriginatorDocumentReference { get; set; }

        [XmlElement("AdditionalDocumentReference", Namespace = PeppolXmlNamespaces.Cac)]
        public AdditionalDocumentReference[] AdditionalDocumentReferences { get; set; }

        [XmlElement("Contract", Namespace = PeppolXmlNamespaces.Cac)]
        public IdReference Contract { get; set; }

        [XmlElement("BuyerCustomerParty", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderPartyWrapper BuyerCustomerParty { get; set; }

        [XmlElement("SellerSupplierParty", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderPartyWrapper SellerSupplierParty { get; set; }

        [XmlElement("AnticipatedMonetaryTotal", Namespace = PeppolXmlNamespaces.Cac)]
        public AnticipatedMonetaryTotal AnticipatedMonetaryTotal { get; set; }

        [XmlElement("Delivery", Namespace = PeppolXmlNamespaces.Cac)]
        public Delivery Delivery { get; set; }

        [XmlElement("DeliveryTerms", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryTerms DeliveryTerms { get; set; }

        [XmlElement("PaymentTerms", Namespace = PeppolXmlNamespaces.Cac)]
        public PaymentTerms PaymentTerms { get; set; }

        [XmlElement("OrderLine", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderLinePeppol[] OrderLines { get; set; }
    }

    public class AdditionalDocumentReference
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("DocumentType", Namespace = PeppolXmlNamespaces.Cbc)]
        public string DocumentType { get; set; }

        [XmlElement("Attachment", Namespace = PeppolXmlNamespaces.Cac)]
        public AttachmentFile Attachment { get; set; }
    }

    public class AttachmentFile
    {
        [XmlElement("EmbeddedDocumentBinaryObject", Namespace = PeppolXmlNamespaces.Cbc)]
        public EmbeddedDocumentBinaryObject EmbeddedDocumentBinaryObject { get; set; }

        [XmlElement("ExternalReference", Namespace = PeppolXmlNamespaces.Cac)]
        public ExternalReference ExternalReference { get; set; }
    }

    public class EmbeddedDocumentBinaryObject
    {
        [XmlAttribute("filename")]
        public string FileName { get; set; }

        [XmlAttribute("mimeCode")]
        public string MimeCode { get; set; }

        [XmlText]
        public string Base64 { get; set; }
    }


    public class ExternalReference
    {
        [XmlElement("URI", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Uri { get; set; }
    }

    public class OrderPartyWrapper
    {
        [XmlElement("Party", Namespace = PeppolXmlNamespaces.Cac)]
        public OrderParty Party { get; set; }
    }

    public class Contact
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("Name", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Name { get; set; }

        [XmlElement("Telephone", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Telephone { get; set; }

        [XmlElement("ElectronicMail", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Email { get; set; }
    }

    public class Delivery
    {
        [XmlElement("DeliveryLocation", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryLocation DeliveryLocation { get; set; }

        [XmlElement("RequestedDeliveryPeriod", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryPeriod RequestedDeliveryPeriod { get; set; }
    }

    public class DeliveryTerms
    {
        // Incoterms
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("SpecialTerms", Namespace = PeppolXmlNamespaces.Cbc)]
        public string SpecialTerms { get; set; }
    }

    public class PaymentTerms
    {
        [XmlElement("Note", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Note { get; set; }
    }

    public class DeliveryLocation
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }

        [XmlElement("Address", Namespace = PeppolXmlNamespaces.Cac)]
        public DeliveryAddress Address { get; set;}
    }

    public class ValidityPeriod
    {
        [XmlElement("ValidityPeriod", Namespace = PeppolXmlNamespaces.Cbc)]
        public string EndDate { get; set; }
    }

    public class IdReference
    {
        [XmlElement("ID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string Id { get; set; }
    }

    public class AnticipatedMonetaryTotal
    {
        [XmlElement("LineExtensionAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount LineExtensionAmount { get; set; }

        [XmlElement("TaxExclusiveAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount TaxExclusiveAmount { get; set; }

        [XmlElement("TaxInclusiveAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount TaxInclusiveAmount { get; set; }

        [XmlElement("AllowanceTotalAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount AllowanceTotalAmount { get; set; }

        [XmlElement("ChargeTotalAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount ChargeTotalAmount { get; set; }

        [XmlElement("PrepaidAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount PrepaidAmount { get; set; }

        [XmlElement("PayableRoundingAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount PayableRoundingAmount { get; set; }

        [XmlElement("PayableAmount", Namespace = PeppolXmlNamespaces.Cbc)]
        public CurrencyAmount PayableAmount { get; set; }
    }

    public class CurrencyAmount
    {
        [XmlAttribute("currencyID", Namespace = PeppolXmlNamespaces.Cbc)]
        public string CurrencyId { get; set; }

        [XmlText]
        public double Amount { get; set; }

        public override string ToString()
        {
            if (CurrencyId != null)
                return $"{CurrencyId} : {Amount}";
            return Amount.ToString();
        }
    }
}
