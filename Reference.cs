namespace ExampleClient.MunicipalityTaxesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MunicipalityTaxDetails", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    [System.SerializableAttribute()]
    public partial class MunicipalityTaxDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxSchedule MunicipalityScheduleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TaxAmountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxSchedule MunicipalitySchedule {
            get {
                return this.MunicipalityScheduleField;
            }
            set {
                if ((object.ReferenceEquals(this.MunicipalityScheduleField, value) != true)) {
                    this.MunicipalityScheduleField = value;
                    this.RaisePropertyChanged("MunicipalitySchedule");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TaxAmount {
            get {
                return this.TaxAmountField;
            }
            set {
                if ((this.TaxAmountField.Equals(value) != true)) {
                    this.TaxAmountField = value;
                    this.RaisePropertyChanged("TaxAmount");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MunicipalityTaxSchedule", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    [System.SerializableAttribute()]
    public partial class MunicipalityTaxSchedule : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MunicipalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ScheduleBeginDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.ScheduleFrequency ScheduleTypeField;

        public MunicipalityTaxSchedule (string municipality, ScheduleFrequency frequency, DateTime dateTime)
        {
            this.MunicipalityField = municipality;
            this.ScheduleBeginDateField = dateTime;
            this.ScheduleTypeField = frequency;
        }

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Municipality {
            get {
                return this.MunicipalityField;
            }
            set {
                if ((object.ReferenceEquals(this.MunicipalityField, value) != true)) {
                    this.MunicipalityField = value;
                    this.RaisePropertyChanged("Municipality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ScheduleBeginDate {
            get {
                return this.ScheduleBeginDateField;
            }
            set {
                if ((this.ScheduleBeginDateField.Equals(value) != true)) {
                    this.ScheduleBeginDateField = value;
                    this.RaisePropertyChanged("ScheduleBeginDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.ScheduleFrequency ScheduleType {
            get {
                return this.ScheduleTypeField;
            }
            set {
                if ((this.ScheduleTypeField.Equals(value) != true)) {
                    this.ScheduleTypeField = value;
                    this.RaisePropertyChanged("ScheduleType");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScheduleFrequency", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    public enum ScheduleFrequency : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Yearly = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Monthly = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Weekly = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Daily = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    [System.SerializableAttribute()]
    public partial class TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleInsertionResult ActionResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleValidationResult ValidityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleInsertionResult ActionResult {
            get {
                return this.ActionResultField;
            }
            set {
                if ((this.ActionResultField.Equals(value) != true)) {
                    this.ActionResultField = value;
                    this.RaisePropertyChanged("ActionResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleValidationResult Validity {
            get {
                return this.ValidityField;
            }
            set {
                if ((this.ValidityField.Equals(value) != true)) {
                    this.ValidityField = value;
                    this.RaisePropertyChanged("Validity");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxScheduleInsertionResult", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    public enum TaxScheduleInsertionResult : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InsertionNotAttempted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaxScheduleAlreadyExists = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownFailure = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxScheduleValidationResult", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    public enum TaxScheduleValidationResult : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Valid = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DateUnsuitableForSchedule = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MunicipalityInvalid = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaxAmountInvalid = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    [System.SerializableAttribute()]
    public partial class TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleUpdateResult ActionResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleValidationResult ValidityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleUpdateResult ActionResult {
            get {
                return this.ActionResultField;
            }
            set {
                if ((this.ActionResultField.Equals(value) != true)) {
                    this.ActionResultField = value;
                    this.RaisePropertyChanged("ActionResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleValidationResult Validity {
            get {
                return this.ValidityField;
            }
            set {
                if ((this.ValidityField.Equals(value) != true)) {
                    this.ValidityField = value;
                    this.RaisePropertyChanged("Validity");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxScheduleUpdateResult", Namespace="http://schemas.datacontract.org/2004/07/MunicipalityTaxes")]
    public enum TaxScheduleUpdateResult : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UpdateNotAttempted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ExistingTaxScheduleNotFound = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownFailure = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MunicipalityTaxesServiceReference.IMunicipalityTaxesService")]
    public interface IMunicipalityTaxesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/InsertTaxScheduleDetails", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/InsertTaxScheduleDetailsResponse")]
        ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg InsertTaxScheduleDetails(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/InsertTaxScheduleDetails", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/InsertTaxScheduleDetailsResponse")]
        System.Threading.Tasks.Task<ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg> InsertTaxScheduleDetailsAsync(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/GetTax", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/GetTaxResponse")]
        System.Nullable<double> GetTax(string Muncipality, System.DateTime at);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/GetTax", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/GetTaxResponse")]
        System.Threading.Tasks.Task<System.Nullable<double>> GetTaxAsync(string Muncipality, System.DateTime at);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/UpdateTaxScheduleDetails", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/UpdateTaxScheduleDetailsResponse")]
        ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg UpdateTaxScheduleDetails(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMunicipalityTaxesService/UpdateTaxScheduleDetails", ReplyAction="http://tempuri.org/IMunicipalityTaxesService/UpdateTaxScheduleDetailsResponse")]
        System.Threading.Tasks.Task<ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg> UpdateTaxScheduleDetailsAsync(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMunicipalityTaxesServiceChannel : ExampleClient.MunicipalityTaxesServiceReference.IMunicipalityTaxesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MunicipalityTaxesServiceClient : System.ServiceModel.ClientBase<ExampleClient.MunicipalityTaxesServiceReference.IMunicipalityTaxesService>, ExampleClient.MunicipalityTaxesServiceReference.IMunicipalityTaxesService {
        
        public MunicipalityTaxesServiceClient() {
        }
        
        public MunicipalityTaxesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MunicipalityTaxesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MunicipalityTaxesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MunicipalityTaxesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg InsertTaxScheduleDetails(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax) {
            return base.Channel.InsertTaxScheduleDetails(tax);
        }
        
        public System.Threading.Tasks.Task<ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleInsertionResult72mr6BFg> InsertTaxScheduleDetailsAsync(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax) {
            return base.Channel.InsertTaxScheduleDetailsAsync(tax);
        }
        
        public System.Nullable<double> GetTax(string Muncipality, System.DateTime at) {
            return base.Channel.GetTax(Muncipality, at);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<double>> GetTaxAsync(string Muncipality, System.DateTime at) {
            return base.Channel.GetTaxAsync(Muncipality, at);
        }
        
        public ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg UpdateTaxScheduleDetails(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax) {
            return base.Channel.UpdateTaxScheduleDetails(tax);
        }
        
        public System.Threading.Tasks.Task<ExampleClient.MunicipalityTaxesServiceReference.TaxScheduleActionResultOfTaxScheduleUpdateResult72mr6BFg> UpdateTaxScheduleDetailsAsync(ExampleClient.MunicipalityTaxesServiceReference.MunicipalityTaxDetails tax) {
            return base.Channel.UpdateTaxScheduleDetailsAsync(tax);
        }
    }
}
