﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("https://www.mycas.org.uk/services/RegisterOfflineService", ClrNamespace="www.mycas.org.uk.services.RegisterOfflineService")]

namespace MyGovScot.MyAccount.RegisterOfflineService
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "https://www.mycas.org.uk/services/RegisterOfflineService", ConfigurationName = "RegisterOfflineService")]
    public interface RegisterOfflineService
    {

        // CODEGEN: Generating message contract since the operation registerOffline is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "https://www.mycas.org.uk/services/RegisterOffline", ReplyAction = "*")]
        [System.ServiceModel.FaultContractAttribute(typeof(www.mycas.org.uk.services.RegisterOfflineService.Exception), Action = "https://www.mycas.org.uk/services/RegisterOffline", Name = "Exception")]
        [System.ServiceModel.FaultContractAttribute(typeof(www.mycas.org.uk.services.RegisterOfflineService.ServiceException), Action = "https://www.mycas.org.uk/services/RegisterOffline", Name = "ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        registerOfflineResponse1 registerOffline(registerOfflineRequest1 request);

        [System.ServiceModel.OperationContractAttribute(Action = "https://www.mycas.org.uk/services/RegisterOffline", ReplyAction = "*")]
        System.Threading.Tasks.Task<registerOfflineResponse1> registerOfflineAsync(registerOfflineRequest1 request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/services/RegisterOfflineService")]
    public partial class registerOffline
    {

        private RegisterOfflineRequest registerOfflineRequestField;

        private string callerTokenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RegisterOfflineRequest registerOfflineRequest
        {
            get
            {
                return this.registerOfflineRequestField;
            }
            set
            {
                this.registerOfflineRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string CallerToken
        {
            get
            {
                return this.callerTokenField;
            }
            set
            {
                this.callerTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/RegisterOfflineTypes")]
    public partial class RegisterOfflineRequest
    {

        private RequestBody requestBodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RequestBody RequestBody
        {
            get
            {
                return this.requestBodyField;
            }
            set
            {
                this.requestBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/RegisterOfflineTypes")]
    public partial class RequestBody
    {

        private object itemField;

        private Contact contactField;

        private object item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CitizenDetails", typeof(CitizenDetails), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("UCRN", typeof(UCRNType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressInput", typeof(AddressInput), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("UPRN", typeof(UPRNType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class CitizenDetails
    {

        private Name nameField;

        private GenderType genderField;

        private System.DateTime dateOfBirthField;

        private string placeOfBirthField;

        private string mothersBirthSurnameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public Name Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public GenderType Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string PlaceOfBirth
        {
            get
            {
                return this.placeOfBirthField;
            }
            set
            {
                this.placeOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string MothersBirthSurname
        {
            get
            {
                return this.mothersBirthSurnameField;
            }
            set
            {
                this.mothersBirthSurnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class Name
    {

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/RegisterOfflineTypes")]
    public partial class ResponseBody
    {

        private UCRNType uCRNField;

        private UPRNType uPRNField;

        private string emailAddressField;

        private LoAType loAField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public UCRNType UCRN
        {
            get
            {
                return this.uCRNField;
            }
            set
            {
                this.uCRNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public UPRNType UPRN
        {
            get
            {
                return this.uPRNField;
            }
            set
            {
                this.uPRNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public LoAType LoA
        {
            get
            {
                return this.loAField;
            }
            set
            {
                this.loAField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UCRNType
    {

        private UCRNTypeUCRNType uCRNType1Field;

        private bool uCRNType1FieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UCRNType")]
        public UCRNTypeUCRNType UCRNType1
        {
            get
            {
                return this.uCRNType1Field;
            }
            set
            {
                this.uCRNType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UCRNType1Specified
        {
            get
            {
                return this.uCRNType1FieldSpecified;
            }
            set
            {
                this.uCRNType1FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum UCRNTypeUCRNType
    {

        /// <remarks/>
        P,

        /// <remarks/>
        T,

        /// <remarks/>
        PU,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UPRNType
    {

        private UPRNTypeUPRNType uPRNType1Field;

        private bool uPRNType1FieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UPRNType")]
        public UPRNTypeUPRNType UPRNType1
        {
            get
            {
                return this.uPRNType1Field;
            }
            set
            {
                this.uPRNType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UPRNType1Specified
        {
            get
            {
                return this.uPRNType1FieldSpecified;
            }
            set
            {
                this.uPRNType1FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum UPRNTypeUPRNType
    {

        /// <remarks/>
        P,

        /// <remarks/>
        T,

        /// <remarks/>
        PU,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum LoAType
    {

        /// <remarks/>
        LoA0,

        /// <remarks/>
        LoA1,

        /// <remarks/>
        LoA2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead
    {

        private string responseCodeField;

        private string responseMessageField;

        private bool resultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ResponseCode
        {
            get
            {
                return this.responseCodeField;
            }
            set
            {
                this.responseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string ResponseMessage
        {
            get
            {
                return this.responseMessageField;
            }
            set
            {
                this.responseMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public bool Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/RegisterOfflineTypes")]
    public partial class RegisterOfflineResponse
    {

        private ResponseHead responseHeadField;

        private ResponseBody responseBodyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ResponseHead ResponseHead
        {
            get
            {
                return this.responseHeadField;
            }
            set
            {
                this.responseHeadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public ResponseBody ResponseBody
        {
            get
            {
                return this.responseBodyField;
            }
            set
            {
                this.responseBodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/services/RegisterOfflineService")]
    public partial class registerOfflineResponse
    {

        private RegisterOfflineResponse registerOfflineResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public RegisterOfflineResponse RegisterOfflineResponse
        {
            get
            {
                return this.registerOfflineResponseField;
            }
            set
            {
                this.registerOfflineResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressLine
    {

        private string addressLine1Field;

        private string addressLine2Field;

        private string addressLine3Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string AddressLine3
        {
            get
            {
                return this.addressLine3Field;
            }
            set
            {
                this.addressLine3Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressInput
    {

        private AddressLine addressLineField;

        private string townField;

        private string postCodeField;

        private long lACodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AddressLine AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string PostCode
        {
            get
            {
                return this.postCodeField;
            }
            set
            {
                this.postCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public long LACode
        {
            get
            {
                return this.lACodeField;
            }
            set
            {
                this.lACodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class Contact
    {

        private string mobileNumberField;

        private string landlineNumberField;

        private string emailAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string MobileNumber
        {
            get
            {
                return this.mobileNumberField;
            }
            set
            {
                this.mobileNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string LandlineNumber
        {
            get
            {
                return this.landlineNumberField;
            }
            set
            {
                this.landlineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://www.mycas.org.uk/schemas/CommonTypes")]
    public enum GenderType
    {

        /// <remarks/>
        M,

        /// <remarks/>
        F,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class registerOfflineRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "https://www.mycas.org.uk/services/RegisterOfflineService", Order = 0)]
        public registerOffline registerOffline;

        public registerOfflineRequest1()
        {
        }

        public registerOfflineRequest1(registerOffline registerOffline)
        {
            this.registerOffline = registerOffline;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class registerOfflineResponse1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "https://www.mycas.org.uk/services/RegisterOfflineService", Order = 0)]
        public registerOfflineResponse registerOfflineResponse;

        public registerOfflineResponse1()
        {
        }

        public registerOfflineResponse1(registerOfflineResponse registerOfflineResponse)
        {
            this.registerOfflineResponse = registerOfflineResponse;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegisterOfflineServiceChannel : RegisterOfflineService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegisterOfflineServiceClient : System.ServiceModel.ClientBase<RegisterOfflineService>, RegisterOfflineService
    {

        public RegisterOfflineServiceClient()
        {
        }

        public RegisterOfflineServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public RegisterOfflineServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RegisterOfflineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RegisterOfflineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        registerOfflineResponse1 RegisterOfflineService.registerOffline(registerOfflineRequest1 request)
        {
            return base.Channel.registerOffline(request);
        }

        public registerOfflineResponse registerOffline(registerOffline registerOffline1)
        {
            registerOfflineRequest1 inValue = new registerOfflineRequest1();
            inValue.registerOffline = registerOffline1;
            registerOfflineResponse1 retVal = ((RegisterOfflineService)(this)).registerOffline(inValue);
            return retVal.registerOfflineResponse;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<registerOfflineResponse1> RegisterOfflineService.registerOfflineAsync(registerOfflineRequest1 request)
        {
            return base.Channel.registerOfflineAsync(request);
        }

        public System.Threading.Tasks.Task<registerOfflineResponse1> registerOfflineAsync(registerOffline registerOffline)
        {
            registerOfflineRequest1 inValue = new registerOfflineRequest1();
            inValue.registerOffline = registerOffline;
            return ((RegisterOfflineService)(this)).registerOfflineAsync(inValue);
        }
    }
    namespace www.mycas.org.uk.services.RegisterOfflineService
    {


        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
        [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
        public partial class Exception : object, System.Xml.Serialization.IXmlSerializable
        {

            private System.Xml.XmlNode[] nodesField;

            private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Exception", "https://www.mycas.org.uk/services/RegisterOfflineService");

            public System.Xml.XmlNode[] Nodes
            {
                get
                {
                    return this.nodesField;
                }
                set
                {
                    this.nodesField = value;
                }
            }

            public void ReadXml(System.Xml.XmlReader reader)
            {
                this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
            }

            public void WriteXml(System.Xml.XmlWriter writer)
            {
                System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
            }

            public System.Xml.Schema.XmlSchema GetSchema()
            {
                return null;
            }

            public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
            {
                System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
                return typeName;
            }
        }

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
        [System.Xml.Serialization.XmlRootAttribute(IsNullable = false)]
        public partial class ServiceException : object, System.Xml.Serialization.IXmlSerializable
        {

            private System.Xml.XmlNode[] nodesField;

            private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ServiceException", "https://www.mycas.org.uk/services/RegisterOfflineService");

            public System.Xml.XmlNode[] Nodes
            {
                get
                {
                    return this.nodesField;
                }
                set
                {
                    this.nodesField = value;
                }
            }

            public void ReadXml(System.Xml.XmlReader reader)
            {
                this.nodesField = System.Runtime.Serialization.XmlSerializableServices.ReadNodes(reader);
            }

            public void WriteXml(System.Xml.XmlWriter writer)
            {
                System.Runtime.Serialization.XmlSerializableServices.WriteNodes(writer, this.Nodes);
            }

            public System.Xml.Schema.XmlSchema GetSchema()
            {
                return null;
            }

            public static System.Xml.XmlQualifiedName ExportSchema(System.Xml.Schema.XmlSchemaSet schemas)
            {
                System.Runtime.Serialization.XmlSerializableServices.AddDefaultSchema(schemas, typeName);
                return typeName;
            }
        }
    }
}