﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfVidimoe.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegUser", Namespace="http://schemas.datacontract.org/2004/07/KR_PritulTvar")]
    [System.SerializableAttribute()]
    public partial class RegUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_RegistrsField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SurName {
            get {
                return this.SurNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurNameField, value) != true)) {
                    this.SurNameField = value;
                    this.RaisePropertyChanged("SurName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_Registrs {
            get {
                return this.Tvar_RegistrsField;
            }
            set {
                if ((object.ReferenceEquals(this.Tvar_RegistrsField, value) != true)) {
                    this.Tvar_RegistrsField = value;
                    this.RaisePropertyChanged("Tvar_Registrs");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Tvar_ADD", Namespace="http://schemas.datacontract.org/2004/07/KR_PritulTvar")]
    [System.SerializableAttribute()]
    public partial class Tvar_ADD : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Breed BreedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CastrationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Color ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.RegUser RegisterUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Type TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VaccinationField;
        
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
        public double Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Breed Breed {
            get {
                return this.BreedField;
            }
            set {
                if ((object.ReferenceEquals(this.BreedField, value) != true)) {
                    this.BreedField = value;
                    this.RaisePropertyChanged("Breed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Castration {
            get {
                return this.CastrationField;
            }
            set {
                if ((this.CastrationField.Equals(value) != true)) {
                    this.CastrationField = value;
                    this.RaisePropertyChanged("Castration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Color Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Information {
            get {
                return this.InformationField;
            }
            set {
                if ((object.ReferenceEquals(this.InformationField, value) != true)) {
                    this.InformationField = value;
                    this.RaisePropertyChanged("Information");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Kg {
            get {
                return this.KgField;
            }
            set {
                if ((this.KgField.Equals(value) != true)) {
                    this.KgField = value;
                    this.RaisePropertyChanged("Kg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nick {
            get {
                return this.NickField;
            }
            set {
                if ((object.ReferenceEquals(this.NickField, value) != true)) {
                    this.NickField = value;
                    this.RaisePropertyChanged("Nick");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.RegUser RegisterUser {
            get {
                return this.RegisterUserField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterUserField, value) != true)) {
                    this.RegisterUserField = value;
                    this.RaisePropertyChanged("RegisterUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Type Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Vaccination {
            get {
                return this.VaccinationField;
            }
            set {
                if ((this.VaccinationField.Equals(value) != true)) {
                    this.VaccinationField = value;
                    this.RaisePropertyChanged("Vaccination");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Breed", Namespace="http://schemas.datacontract.org/2004/07/KR_PritulTvar")]
    [System.SerializableAttribute()]
    public partial class Breed : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameBreedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_RegistrsField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameBreed {
            get {
                return this.NameBreedField;
            }
            set {
                if ((object.ReferenceEquals(this.NameBreedField, value) != true)) {
                    this.NameBreedField = value;
                    this.RaisePropertyChanged("NameBreed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_Registrs {
            get {
                return this.Tvar_RegistrsField;
            }
            set {
                if ((object.ReferenceEquals(this.Tvar_RegistrsField, value) != true)) {
                    this.Tvar_RegistrsField = value;
                    this.RaisePropertyChanged("Tvar_Registrs");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/KR_PritulTvar")]
    [System.SerializableAttribute()]
    public partial class Color : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_RegistrsField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameColor {
            get {
                return this.NameColorField;
            }
            set {
                if ((object.ReferenceEquals(this.NameColorField, value) != true)) {
                    this.NameColorField = value;
                    this.RaisePropertyChanged("NameColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_Registrs {
            get {
                return this.Tvar_RegistrsField;
            }
            set {
                if ((object.ReferenceEquals(this.Tvar_RegistrsField, value) != true)) {
                    this.Tvar_RegistrsField = value;
                    this.RaisePropertyChanged("Tvar_Registrs");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Type", Namespace="http://schemas.datacontract.org/2004/07/KR_PritulTvar")]
    [System.SerializableAttribute()]
    public partial class Type : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_RegistrsField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameType {
            get {
                return this.NameTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.NameTypeField, value) != true)) {
                    this.NameTypeField = value;
                    this.RaisePropertyChanged("NameType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfVidimoe.ServiceReference1.Tvar_ADD[] Tvar_Registrs {
            get {
                return this.Tvar_RegistrsField;
            }
            set {
                if ((object.ReferenceEquals(this.Tvar_RegistrsField, value) != true)) {
                    this.Tvar_RegistrsField = value;
                    this.RaisePropertyChanged("Tvar_Registrs");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUser", ReplyAction="http://tempuri.org/IService1/SetUserResponse")]
        void SetUser(WpfVidimoe.ServiceReference1.RegUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetUser", ReplyAction="http://tempuri.org/IService1/SetUserResponse")]
        System.Threading.Tasks.Task SetUserAsync(WpfVidimoe.ServiceReference1.RegUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetTvarina", ReplyAction="http://tempuri.org/IService1/SetTvarinaResponse")]
        void SetTvarina(WpfVidimoe.ServiceReference1.Tvar_ADD tvar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetTvarina", ReplyAction="http://tempuri.org/IService1/SetTvarinaResponse")]
        System.Threading.Tasks.Task SetTvarinaAsync(WpfVidimoe.ServiceReference1.Tvar_ADD tvar);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfVidimoe.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfVidimoe.ServiceReference1.IService1>, WpfVidimoe.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetUser(WpfVidimoe.ServiceReference1.RegUser user) {
            base.Channel.SetUser(user);
        }
        
        public System.Threading.Tasks.Task SetUserAsync(WpfVidimoe.ServiceReference1.RegUser user) {
            return base.Channel.SetUserAsync(user);
        }
        
        public void SetTvarina(WpfVidimoe.ServiceReference1.Tvar_ADD tvar) {
            base.Channel.SetTvarina(tvar);
        }
        
        public System.Threading.Tasks.Task SetTvarinaAsync(WpfVidimoe.ServiceReference1.Tvar_ADD tvar) {
            return base.Channel.SetTvarinaAsync(tvar);
        }
    }
}