﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CASRefreshWebserviceSampleApplication.CAS.ChangeAddress
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Xml.Serialization.XmlSchemaProviderAttribute("ExportSchema")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName="Exception", Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class Exception : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Xml.XmlNode[] nodesField;
        
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("Exception", "https://www.mycas.org.uk/services/ChangeConsentService");
        
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
    [System.Xml.Serialization.XmlRootAttribute(ElementName="ServiceException", Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class ServiceException : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Xml.XmlNode[] nodesField;
        
        private static System.Xml.XmlQualifiedName typeName = new System.Xml.XmlQualifiedName("ServiceException", "https://www.mycas.org.uk/services/ChangeConsentService");
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService", ConfigurationName="CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService")]
    public interface ChangeAddressService
    {
        
        // CODEGEN: Generating message contract since the operation changeAddressDetail is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tcs/cas/webservice_producer/changeAddressDetail", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.Exception), Action="http://tcs/cas/webservice_producer/changeAddressDetail", Name="Exception")]
        [System.ServiceModel.FaultContractAttribute(typeof(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ServiceException), Action="http://tcs/cas/webservice_producer/changeAddressDetail", Name="ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse1 changeAddressDetail(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressDetail
    {
        
        private changeAddressRequest changeAddressRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public changeAddressRequest changeAddressRequest
        {
            get
            {
                return this.changeAddressRequestField;
            }
            set
            {
                this.changeAddressRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressRequest
    {
        
        private changeAddressRequestBody changeAddressRequestBodyField;
        
        private RequestHead requestHeadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public changeAddressRequestBody changeAddressRequestBody
        {
            get
            {
                return this.changeAddressRequestBodyField;
            }
            set
            {
                this.changeAddressRequestBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public RequestHead requestHead
        {
            get
            {
                return this.requestHeadField;
            }
            set
            {
                this.requestHeadField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressRequestBody
    {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string addressLine3Field;
        
        private long lACodeField;
        
        private bool lACodeFieldSpecified;
        
        private string operationCodeField;
        
        private string postCodeField;
        
        private string townField;
        
        private string uCRNField;
        
        private string uCRNTypeField;
        
        private string uPRNField;
        
        private string uPRNTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string addressLine1
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string addressLine2
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string addressLine3
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LACodeSpecified
        {
            get
            {
                return this.lACodeFieldSpecified;
            }
            set
            {
                this.lACodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string operationCode
        {
            get
            {
                return this.operationCodeField;
            }
            set
            {
                this.operationCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string postCode
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string town
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string UCRN
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string UCRNType
        {
            get
            {
                return this.uCRNTypeField;
            }
            set
            {
                this.uCRNTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string UPRN
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string UPRNType
        {
            get
            {
                return this.uPRNTypeField;
            }
            set
            {
                this.uPRNTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead
    {
        
        private string responseCodeField;
        
        private string responseMessageField;
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressResponseBody
    {
        
        private string uPRNField;
        
        private string uPRNTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string UPRN
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string UPRNType
        {
            get
            {
                return this.uPRNTypeField;
            }
            set
            {
                this.uPRNTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressResponse
    {
        
        private changeAddressResponseBody changeAddressResponseBodyField;
        
        private ResponseHead responseHeadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public changeAddressResponseBody changeAddressResponseBody
        {
            get
            {
                return this.changeAddressResponseBodyField;
            }
            set
            {
                this.changeAddressResponseBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ResponseHead responseHead
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService")]
    public partial class changeAddressDetailResponse
    {
        
        private changeAddressResponse changeAddressDetailResponse1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("changeAddressDetailResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public changeAddressResponse changeAddressDetailResponse1
        {
            get
            {
                return this.changeAddressDetailResponse1Field;
            }
            set
            {
                this.changeAddressDetailResponse1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class RequestHead
    {
        
        private string userCodeField;
        
        private long orgCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string UserCode
        {
            get
            {
                return this.userCodeField;
            }
            set
            {
                this.userCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long OrgCode
        {
            get
            {
                return this.orgCodeField;
            }
            set
            {
                this.orgCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class changeAddressDetailRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService", Order=0)]
        public CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetail changeAddressDetail;
        
        public changeAddressDetailRequest()
        {
        }
        
        public changeAddressDetailRequest(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetail changeAddressDetail)
        {
            this.changeAddressDetail = changeAddressDetail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class changeAddressDetailResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/ChangeAddressService", Order=0)]
        public CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse changeAddressDetailResponse;
        
        public changeAddressDetailResponse1()
        {
        }
        
        public changeAddressDetailResponse1(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse changeAddressDetailResponse)
        {
            this.changeAddressDetailResponse = changeAddressDetailResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ChangeAddressServiceChannel : CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChangeAddressServiceClient : System.ServiceModel.ClientBase<CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService>, CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService
    {
        
        public ChangeAddressServiceClient()
        {
        }
        
        public ChangeAddressServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ChangeAddressServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ChangeAddressServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ChangeAddressServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse1 CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService.changeAddressDetail(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailRequest request)
        {
            return base.Channel.changeAddressDetail(request);
        }
        
        public CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse changeAddressDetail(CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetail changeAddressDetail1)
        {
            CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailRequest inValue = new CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailRequest();
            inValue.changeAddressDetail = changeAddressDetail1;
            CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.changeAddressDetailResponse1 retVal = ((CASRefreshWebserviceSampleApplication.CAS.ChangeAddress.ChangeAddressService)(this)).changeAddressDetail(inValue);
            return retVal.changeAddressDetailResponse;
        }
    }
}
