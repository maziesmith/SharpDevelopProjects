﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.RegistrationService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/QueryUCRNService")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegistrationTypes")]
    public partial class ResponseBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UCRNType uCRNField;
        
        private UPRNType uPRNField;
        
        private string usernameField;
        
        private string emailAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public UCRNType UCRN {
            get {
                return this.uCRNField;
            }
            set {
                this.uCRNField = value;
                this.RaisePropertyChanged("UCRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public UPRNType UPRN {
            get {
                return this.uPRNField;
            }
            set {
                this.uPRNField = value;
                this.RaisePropertyChanged("UPRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UCRNType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uCRNType1Field;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UCRNType")]
        public string UCRNType1 {
            get {
                return this.uCRNType1Field;
            }
            set {
                this.uCRNType1Field = value;
                this.RaisePropertyChanged("UCRNType1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class UPRNType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string uPRNType1Field;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("UPRNType")]
        public string UPRNType1 {
            get {
                return this.uPRNType1Field;
            }
            set {
                this.uPRNType1Field = value;
                this.RaisePropertyChanged("UPRNType1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class ResponseHead : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string responseCodeField;
        
        private string responseMessageField;
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string ResponseCode {
            get {
                return this.responseCodeField;
            }
            set {
                this.responseCodeField = value;
                this.RaisePropertyChanged("ResponseCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ResponseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                this.responseMessageField = value;
                this.RaisePropertyChanged("ResponseMessage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegistrationTypes")]
    public partial class RegistrationResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private ResponseHead responseHeadField;
        
        private ResponseBody responseBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ResponseHead ResponseHead {
            get {
                return this.responseHeadField;
            }
            set {
                this.responseHeadField = value;
                this.RaisePropertyChanged("ResponseHead");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public ResponseBody ResponseBody {
            get {
                return this.responseBodyField;
            }
            set {
                this.responseBodyField = value;
                this.RaisePropertyChanged("ResponseBody");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService")]
    public partial class addNewUserResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RegistrationResponse registrationResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RegistrationResponse RegistrationResponse {
            get {
                return this.registrationResponseField;
            }
            set {
                this.registrationResponseField = value;
                this.RaisePropertyChanged("RegistrationResponse");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressLine : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string addressLine3Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string AddressLine1 {
            get {
                return this.addressLine1Field;
            }
            set {
                this.addressLine1Field = value;
                this.RaisePropertyChanged("AddressLine1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string AddressLine2 {
            get {
                return this.addressLine2Field;
            }
            set {
                this.addressLine2Field = value;
                this.RaisePropertyChanged("AddressLine2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string AddressLine3 {
            get {
                return this.addressLine3Field;
            }
            set {
                this.addressLine3Field = value;
                this.RaisePropertyChanged("AddressLine3");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class AddressInput : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AddressLine addressLineField;
        
        private string townField;
        
        private string postCodeField;
        
        private string lACodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public AddressLine AddressLine {
            get {
                return this.addressLineField;
            }
            set {
                this.addressLineField = value;
                this.RaisePropertyChanged("AddressLine");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Town {
            get {
                return this.townField;
            }
            set {
                this.townField = value;
                this.RaisePropertyChanged("Town");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string LACode {
            get {
                return this.lACodeField;
            }
            set {
                this.lACodeField = value;
                this.RaisePropertyChanged("LACode");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class Contact : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string mobileNumberField;
        
        private string landlineNumberField;
        
        private string emailAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string MobileNumber {
            get {
                return this.mobileNumberField;
            }
            set {
                this.mobileNumberField = value;
                this.RaisePropertyChanged("MobileNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string LandlineNumber {
            get {
                return this.landlineNumberField;
            }
            set {
                this.landlineNumberField = value;
                this.RaisePropertyChanged("LandlineNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class Name : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string firstNameField;
        
        private string middleNameField;
        
        private string lastNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
                this.RaisePropertyChanged("FirstName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string MiddleName {
            get {
                return this.middleNameField;
            }
            set {
                this.middleNameField = value;
                this.RaisePropertyChanged("MiddleName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("LastName");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/CommonTypes")]
    public partial class CitizenDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Name nameField;
        
        private string genderField;
        
        private System.DateTime dateOfBirthField;
        
        private bool dateOfBirthFieldSpecified;
        
        private string placeOfBirthField;
        
        private string mothersBirthSurnameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public Name Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
                this.RaisePropertyChanged("Gender");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime DateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
                this.RaisePropertyChanged("DateOfBirth");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfBirthSpecified {
            get {
                return this.dateOfBirthFieldSpecified;
            }
            set {
                this.dateOfBirthFieldSpecified = value;
                this.RaisePropertyChanged("DateOfBirthSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string PlaceOfBirth {
            get {
                return this.placeOfBirthField;
            }
            set {
                this.placeOfBirthField = value;
                this.RaisePropertyChanged("PlaceOfBirth");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string MothersBirthSurname {
            get {
                return this.mothersBirthSurnameField;
            }
            set {
                this.mothersBirthSurnameField = value;
                this.RaisePropertyChanged("MothersBirthSurname");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegistrationTypes")]
    public partial class RequestBody : object, System.ComponentModel.INotifyPropertyChanged {
        
        private CitizenDetails citizenDetailsField;
        
        private UCRNType uCRNField;
        
        private Contact contactField;
        
        private AddressInput addressInputField;
        
        private UPRNType uPRNField;
        
        private string usernameField;
        
        private bool consentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public CitizenDetails CitizenDetails {
            get {
                return this.citizenDetailsField;
            }
            set {
                this.citizenDetailsField = value;
                this.RaisePropertyChanged("CitizenDetails");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public UCRNType UCRN {
            get {
                return this.uCRNField;
            }
            set {
                this.uCRNField = value;
                this.RaisePropertyChanged("UCRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public Contact Contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
                this.RaisePropertyChanged("Contact");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public AddressInput AddressInput {
            get {
                return this.addressInputField;
            }
            set {
                this.addressInputField = value;
                this.RaisePropertyChanged("AddressInput");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public UPRNType UPRN {
            get {
                return this.uPRNField;
            }
            set {
                this.uPRNField = value;
                this.RaisePropertyChanged("UPRN");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool Consent {
            get {
                return this.consentField;
            }
            set {
                this.consentField = value;
                this.RaisePropertyChanged("Consent");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/schemas/RegistrationTypes")]
    public partial class RegistrationRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestBody requestBodyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RequestBody RequestBody {
            get {
                return this.requestBodyField;
            }
            set {
                this.requestBodyField = value;
                this.RaisePropertyChanged("RequestBody");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService")]
    public partial class addNewUser : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RegistrationRequest registrationRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public RegistrationRequest registrationRequest {
            get {
                return this.registrationRequestField;
            }
            set {
                this.registrationRequestField = value;
                this.RaisePropertyChanged("registrationRequest");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService", ConfigurationName="RegistrationService.RegistrationService")]
    public interface RegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/AddNewUser", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(WindowsFormsApplication1.RegistrationService.Exception), Action="https://www.mycas.org.uk/services/AddNewUser", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsFormsApplication1.RegistrationService.addNewUserResponse1 addNewUser(WindowsFormsApplication1.RegistrationService.addNewUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.mycas.org.uk/services/AddNewUser", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.RegistrationService.addNewUserResponse1> addNewUserAsync(WindowsFormsApplication1.RegistrationService.addNewUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewUserRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CallerToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService", Order=0)]
        public WindowsFormsApplication1.RegistrationService.addNewUser addNewUser;
        
        public addNewUserRequest() {
        }
        
        public addNewUserRequest(string CallerToken, WindowsFormsApplication1.RegistrationService.addNewUser addNewUser) {
            this.CallerToken = CallerToken;
            this.addNewUser = addNewUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addNewUserResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://www.mycas.org.uk/services/RegistrationService", Order=0)]
        public WindowsFormsApplication1.RegistrationService.addNewUserResponse addNewUserResponse;
        
        public addNewUserResponse1() {
        }
        
        public addNewUserResponse1(WindowsFormsApplication1.RegistrationService.addNewUserResponse addNewUserResponse) {
            this.addNewUserResponse = addNewUserResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegistrationServiceChannel : WindowsFormsApplication1.RegistrationService.RegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrationServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.RegistrationService.RegistrationService>, WindowsFormsApplication1.RegistrationService.RegistrationService {
        
        public RegistrationServiceClient() {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApplication1.RegistrationService.addNewUserResponse1 addNewUser(WindowsFormsApplication1.RegistrationService.addNewUserRequest request) {
            return base.Channel.addNewUser(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.RegistrationService.addNewUserResponse1> addNewUserAsync(WindowsFormsApplication1.RegistrationService.addNewUserRequest request) {
            return base.Channel.addNewUserAsync(request);
        }
    }
}
