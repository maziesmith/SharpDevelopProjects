﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ListNotifications {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tcs/cas/webservice_producer")]
    public partial class ServiceException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string exceptionStackTraceField;
        
        private string messageField;
        
        private string messageIdField;
        
        private string[] placeHolderValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string exceptionStackTrace {
            get {
                return this.exceptionStackTraceField;
            }
            set {
                this.exceptionStackTraceField = value;
                this.RaisePropertyChanged("exceptionStackTrace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string messageId {
            get {
                return this.messageIdField;
            }
            set {
                this.messageIdField = value;
                this.RaisePropertyChanged("messageId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("placeHolderValues", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string[] placeHolderValues {
            get {
                return this.placeHolderValuesField;
            }
            set {
                this.placeHolderValuesField = value;
                this.RaisePropertyChanged("placeHolderValues");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tcs/cas/webservice_producer")]
    public partial class addValuesResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string addValuesResponse1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("addValuesResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string addValuesResponse1 {
            get {
                return this.addValuesResponse1Field;
            }
            set {
                this.addValuesResponse1Field = value;
                this.RaisePropertyChanged("addValuesResponse1");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tcs/cas/webservice_producer")]
    public partial class coreSampleVO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int aField;
        
        private int bField;
        
        private int cField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int a {
            get {
                return this.aField;
            }
            set {
                this.aField = value;
                this.RaisePropertyChanged("a");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int b {
            get {
                return this.bField;
            }
            set {
                this.bField = value;
                this.RaisePropertyChanged("b");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int c {
            get {
                return this.cField;
            }
            set {
                this.cField = value;
                this.RaisePropertyChanged("c");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tcs/cas/webservice_producer")]
    public partial class addValues : object, System.ComponentModel.INotifyPropertyChanged {
        
        private coreSampleVO coreSampleVOField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public coreSampleVO coreSampleVO {
            get {
                return this.coreSampleVOField;
            }
            set {
                this.coreSampleVOField = value;
                this.RaisePropertyChanged("coreSampleVO");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tcs/cas/webservice_producer", ConfigurationName="ListNotifications.coreSampleClass")]
    public interface coreSampleClass {
        
        // CODEGEN: Generating message contract since the operation addValues is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tcs/cas/webservice_producer/addValues", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.ListNotifications.ServiceException), Action="http://tcs/cas/webservice_producer/addValues", Name="ServiceException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsFormsApplication1.ListNotifications.addValuesResponse1 addValues(WindowsFormsApplication1.ListNotifications.addValuesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tcs/cas/webservice_producer/addValues", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.addValuesResponse1> addValuesAsync(WindowsFormsApplication1.ListNotifications.addValuesRequest request);
        
        // CODEGEN: Generating message contract since the operation generateStr is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tcs/cas/webservice_producer/generateStr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsFormsApplication1.ListNotifications.generateStrResponse1 generateStr(WindowsFormsApplication1.ListNotifications.generateStrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tcs/cas/webservice_producer/generateStr", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.generateStrResponse1> generateStrAsync(WindowsFormsApplication1.ListNotifications.generateStrRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addValuesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tcs/cas/webservice_producer", Order=0)]
        public WindowsFormsApplication1.ListNotifications.addValues addValues;
        
        public addValuesRequest() {
        }
        
        public addValuesRequest(WindowsFormsApplication1.ListNotifications.addValues addValues) {
            this.addValues = addValues;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addValuesResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tcs/cas/webservice_producer", Order=0)]
        public WindowsFormsApplication1.ListNotifications.addValuesResponse addValuesResponse;
        
        public addValuesResponse1() {
        }
        
        public addValuesResponse1(WindowsFormsApplication1.ListNotifications.addValuesResponse addValuesResponse) {
            this.addValuesResponse = addValuesResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tcs/cas/webservice_producer")]
    public partial class generateStrResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string generateStrResponse1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("generateStrResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string generateStrResponse1 {
            get {
                return this.generateStrResponse1Field;
            }
            set {
                this.generateStrResponse1Field = value;
                this.RaisePropertyChanged("generateStrResponse1");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generateStrRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tcs/cas/webservice_producer", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("arg0", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public string[] generateStr;
        
        public generateStrRequest() {
        }
        
        public generateStrRequest(string[] generateStr) {
            this.generateStr = generateStr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generateStrResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tcs/cas/webservice_producer", Order=0)]
        public WindowsFormsApplication1.ListNotifications.generateStrResponse generateStrResponse;
        
        public generateStrResponse1() {
        }
        
        public generateStrResponse1(WindowsFormsApplication1.ListNotifications.generateStrResponse generateStrResponse) {
            this.generateStrResponse = generateStrResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface coreSampleClassChannel : WindowsFormsApplication1.ListNotifications.coreSampleClass, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class coreSampleClassClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ListNotifications.coreSampleClass>, WindowsFormsApplication1.ListNotifications.coreSampleClass {
        
        public coreSampleClassClient() {
        }
        
        public coreSampleClassClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public coreSampleClassClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public coreSampleClassClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public coreSampleClassClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ListNotifications.addValuesResponse1 WindowsFormsApplication1.ListNotifications.coreSampleClass.addValues(WindowsFormsApplication1.ListNotifications.addValuesRequest request) {
            return base.Channel.addValues(request);
        }
        
        public WindowsFormsApplication1.ListNotifications.addValuesResponse addValues(WindowsFormsApplication1.ListNotifications.addValues addValues1) {
            WindowsFormsApplication1.ListNotifications.addValuesRequest inValue = new WindowsFormsApplication1.ListNotifications.addValuesRequest();
            inValue.addValues = addValues1;
            WindowsFormsApplication1.ListNotifications.addValuesResponse1 retVal = ((WindowsFormsApplication1.ListNotifications.coreSampleClass)(this)).addValues(inValue);
            return retVal.addValuesResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.addValuesResponse1> WindowsFormsApplication1.ListNotifications.coreSampleClass.addValuesAsync(WindowsFormsApplication1.ListNotifications.addValuesRequest request) {
            return base.Channel.addValuesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.addValuesResponse1> addValuesAsync(WindowsFormsApplication1.ListNotifications.addValues addValues) {
            WindowsFormsApplication1.ListNotifications.addValuesRequest inValue = new WindowsFormsApplication1.ListNotifications.addValuesRequest();
            inValue.addValues = addValues;
            return ((WindowsFormsApplication1.ListNotifications.coreSampleClass)(this)).addValuesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ListNotifications.generateStrResponse1 WindowsFormsApplication1.ListNotifications.coreSampleClass.generateStr(WindowsFormsApplication1.ListNotifications.generateStrRequest request) {
            return base.Channel.generateStr(request);
        }
        
        public WindowsFormsApplication1.ListNotifications.generateStrResponse generateStr(string[] generateStr1) {
            WindowsFormsApplication1.ListNotifications.generateStrRequest inValue = new WindowsFormsApplication1.ListNotifications.generateStrRequest();
            inValue.generateStr = generateStr1;
            WindowsFormsApplication1.ListNotifications.generateStrResponse1 retVal = ((WindowsFormsApplication1.ListNotifications.coreSampleClass)(this)).generateStr(inValue);
            return retVal.generateStrResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.generateStrResponse1> WindowsFormsApplication1.ListNotifications.coreSampleClass.generateStrAsync(WindowsFormsApplication1.ListNotifications.generateStrRequest request) {
            return base.Channel.generateStrAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ListNotifications.generateStrResponse1> generateStrAsync(string[] generateStr) {
            WindowsFormsApplication1.ListNotifications.generateStrRequest inValue = new WindowsFormsApplication1.ListNotifications.generateStrRequest();
            inValue.generateStr = generateStr;
            return ((WindowsFormsApplication1.ListNotifications.coreSampleClass)(this)).generateStrAsync(inValue);
        }
    }
}