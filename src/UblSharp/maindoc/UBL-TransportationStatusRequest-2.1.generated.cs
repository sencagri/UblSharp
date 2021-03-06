// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UblSharp.CommonAggregateComponents;
    using UblSharp.UnqualifiedDataTypes;
    using UblSharp.CommonExtensionComponents;
    
    
    /// <summary>
    /// A document requesting a Transportation Status report.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Transportation Status Request. Details
    /// <para />ObjectClass: Transportation Status Request
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TransportationStatusRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatusRequest-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportationStatusRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatusRequest-2", IsNullable=false)]
    public partial class TransportationStatusRequestType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CarrierAssignedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IdentifierType @__CarrierAssignedID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public NameType @__Name;
        
        private System.Collections.Generic.List<TextType> _description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType[] @__Description
        {
            get
            {
                return _description?.ToArray();
            }
            set
            {
                _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ShippingOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public IdentifierType @__ShippingOrderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OtherInstruction", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public TextType @__OtherInstruction;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportationStatusTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
        public CodeType @__TransportationStatusTypeCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportExecutionPlanDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public DocumentReferenceType @__TransportExecutionPlanDocumentReference;
        
        private System.Collections.Generic.List<ConsignmentType> _consignment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public ConsignmentType[] @__Consignment
        {
            get
            {
                return _consignment?.ToArray();
            }
            set
            {
                _consignment = value == null ? null : new System.Collections.Generic.List<ConsignmentType>(value);
            }
        }
        
        private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public DocumentReferenceType[] @__DocumentReference
        {
            get
            {
                return _documentReference?.ToArray();
            }
            set
            {
                _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        private System.Collections.Generic.List<LocationType> _requestedStatusLocation;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RequestedStatusLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public LocationType[] @__RequestedStatusLocation
        {
            get
            {
                return _requestedStatusLocation?.ToArray();
            }
            set
            {
                _requestedStatusLocation = value == null ? null : new System.Collections.Generic.List<LocationType>(value);
            }
        }
        
        private System.Collections.Generic.List<PeriodType> _requestedStatusPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RequestedStatusPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public PeriodType[] @__RequestedStatusPeriod
        {
            get
            {
                return _requestedStatusPeriod?.ToArray();
            }
            set
            {
                _requestedStatusPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// A textual description of the document instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Description
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Description
        {
            get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
            set { _description = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A consignment regarding which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Consignment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Consignment
        /// <para />AssociatedObjectClass: Consignment
        /// <para />RepresentationTerm: Consignment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ConsignmentType> Consignment
        {
            get { return _consignment ?? (_consignment = new System.Collections.Generic.List<ConsignmentType>()); }
            set { _consignment = value; }
        }

        
        /// <summary>
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
        {
            get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _documentReference = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// A location for which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Requested Status_ Location. Location
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Requested Status
        /// <para />PropertyTerm: Location
        /// <para />AssociatedObjectClass: Location
        /// <para />RepresentationTerm: Location
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<LocationType> RequestedStatusLocation
        {
            get { return _requestedStatusLocation ?? (_requestedStatusLocation = new System.Collections.Generic.List<LocationType>()); }
            set { _requestedStatusLocation = value; }
        }

        
        /// <summary>
        /// A period for which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Requested Status_ Period. Period
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Requested Status
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PeriodType> RequestedStatusPeriod
        {
            get { return _requestedStatusPeriod ?? (_requestedStatusPeriod = new System.Collections.Generic.List<PeriodType>()); }
            set { _requestedStatusPeriod = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BPP-1001</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// A reference number assigned by a carrier or its agent to identify a specific shipment, such as a booking reference number when cargo space is reserved prior to loading.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Carrier Assigned_ Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Carrier Assigned
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType CarrierAssignedID
        {
            get
            {
                if (__CarrierAssignedID == null) { __CarrierAssignedID = new IdentifierType(); }
                return __CarrierAssignedID;
            }
            set
            {
                __CarrierAssignedID = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Issue Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// Text, assigned by the sender, that identifies this document to business users.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Name
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Name
        /// <para />RepresentationTerm: Name
        /// <para />DataType: Name. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NameType Name
        {
            get
            {
                if (__Name == null) { __Name = new NameType(); }
                return __Name;
            }
            set
            {
                __Name = value;
            }
        }

        
        /// <summary>
        /// A reference number for a shipping order.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Shipping Order Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Shipping Order Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ShippingOrderID
        {
            get
            {
                if (__ShippingOrderID == null) { __ShippingOrderID = new IdentifierType(); }
                return __ShippingOrderID;
            }
            set
            {
                __ShippingOrderID = value;
            }
        }

        
        /// <summary>
        /// An instruction regarding this message.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Other_ Instruction. Text
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Other
        /// <para />PropertyTerm: Instruction
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TextType OtherInstruction
        {
            get
            {
                if (__OtherInstruction == null) { __OtherInstruction = new TextType(); }
                return __OtherInstruction;
            }
            set
            {
                __OtherInstruction = value;
            }
        }

        
        /// <summary>
        /// A code signifying the type of status requested in a Transportation Status document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Transportation Status Type Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTerm: Transportation Status Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType TransportationStatusTypeCode
        {
            get
            {
                if (__TransportationStatusTypeCode == null) { __TransportationStatusTypeCode = new CodeType(); }
                return __TransportationStatusTypeCode;
            }
            set
            {
                __TransportationStatusTypeCode = value;
            }
        }

        
        /// <summary>
        /// The party sending this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Sender_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        
        /// <summary>
        /// A reference to the Transport Execution Plan associated with the transport service for which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transportation Status Request. Transport Execution Plan_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transportation Status Request
        /// <para />PropertyTermQualifier: Transport Execution Plan
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType TransportExecutionPlanDocumentReference
        {
            get
            {
                if (__TransportExecutionPlanDocumentReference == null) { __TransportExecutionPlanDocumentReference = new DocumentReferenceType(); }
                return __TransportExecutionPlanDocumentReference;
            }
            set
            {
                __TransportExecutionPlanDocumentReference = value;
            }
        }

    }
}
