﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEvent.BusinessService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Business", Namespace="http://schemas.datacontract.org/2004/07/BusinessWcf.Data")]
    [System.SerializableAttribute()]
    public partial class Business : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageLinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> longitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telephoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool verifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string zipcodeField;
        
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
        public string adress {
            get {
                return this.adressField;
            }
            set {
                if ((object.ReferenceEquals(this.adressField, value) != true)) {
                    this.adressField = value;
                    this.RaisePropertyChanged("adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imageLink {
            get {
                return this.imageLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.imageLinkField, value) != true)) {
                    this.imageLinkField = value;
                    this.RaisePropertyChanged("imageLink");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((this.longitudeField.Equals(value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telephone {
            get {
                return this.telephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.telephoneField, value) != true)) {
                    this.telephoneField = value;
                    this.RaisePropertyChanged("telephone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool verified {
            get {
                return this.verifiedField;
            }
            set {
                if ((this.verifiedField.Equals(value) != true)) {
                    this.verifiedField = value;
                    this.RaisePropertyChanged("verified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string zipcode {
            get {
                return this.zipcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.zipcodeField, value) != true)) {
                    this.zipcodeField = value;
                    this.RaisePropertyChanged("zipcode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BusinessUser", Namespace="http://schemas.datacontract.org/2004/07/BusinessWcf")]
    [System.SerializableAttribute()]
    public partial class BusinessUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCEvent.BusinessService.Business1 BusinessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int businessIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userPasswordField;
        
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
        public MVCEvent.BusinessService.Business1 Business {
            get {
                return this.BusinessField;
            }
            set {
                if ((object.ReferenceEquals(this.BusinessField, value) != true)) {
                    this.BusinessField = value;
                    this.RaisePropertyChanged("Business");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int businessId {
            get {
                return this.businessIdField;
            }
            set {
                if ((this.businessIdField.Equals(value) != true)) {
                    this.businessIdField = value;
                    this.RaisePropertyChanged("businessId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userPassword {
            get {
                return this.userPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.userPasswordField, value) != true)) {
                    this.userPasswordField = value;
                    this.RaisePropertyChanged("userPassword");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Business", Namespace="http://schemas.datacontract.org/2004/07/BusinessWcf")]
    [System.SerializableAttribute()]
    public partial class Business1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MVCEvent.BusinessService.BusinessUser[] BusinessUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string imageLinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> longitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telephoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool verifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string zipcodeField;
        
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
        public MVCEvent.BusinessService.BusinessUser[] BusinessUser {
            get {
                return this.BusinessUserField;
            }
            set {
                if ((object.ReferenceEquals(this.BusinessUserField, value) != true)) {
                    this.BusinessUserField = value;
                    this.RaisePropertyChanged("BusinessUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string adress {
            get {
                return this.adressField;
            }
            set {
                if ((object.ReferenceEquals(this.adressField, value) != true)) {
                    this.adressField = value;
                    this.RaisePropertyChanged("adress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string imageLink {
            get {
                return this.imageLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.imageLinkField, value) != true)) {
                    this.imageLinkField = value;
                    this.RaisePropertyChanged("imageLink");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((this.longitudeField.Equals(value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telephone {
            get {
                return this.telephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.telephoneField, value) != true)) {
                    this.telephoneField = value;
                    this.RaisePropertyChanged("telephone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool verified {
            get {
                return this.verifiedField;
            }
            set {
                if ((this.verifiedField.Equals(value) != true)) {
                    this.verifiedField = value;
                    this.RaisePropertyChanged("verified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string zipcode {
            get {
                return this.zipcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.zipcodeField, value) != true)) {
                    this.zipcodeField = value;
                    this.RaisePropertyChanged("zipcode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BusinessUser", Namespace="http://schemas.datacontract.org/2004/07/BusinessWcf.Data")]
    [System.SerializableAttribute()]
    public partial class BusinessUser1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int businessIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userPasswordField;
        
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
        public int businessId {
            get {
                return this.businessIdField;
            }
            set {
                if ((this.businessIdField.Equals(value) != true)) {
                    this.businessIdField = value;
                    this.RaisePropertyChanged("businessId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                if ((object.ReferenceEquals(this.userNameField, value) != true)) {
                    this.userNameField = value;
                    this.RaisePropertyChanged("userName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string userPassword {
            get {
                return this.userPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.userPasswordField, value) != true)) {
                    this.userPasswordField = value;
                    this.RaisePropertyChanged("userPassword");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusinessService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        MVCEvent.BusinessService.Business[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAll", ReplyAction="http://tempuri.org/IService1/GetAllResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.Business[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBusinessUser", ReplyAction="http://tempuri.org/IService1/AddBusinessUserResponse")]
        void AddBusinessUser(MVCEvent.BusinessService.BusinessUser businessUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBusinessUser", ReplyAction="http://tempuri.org/IService1/AddBusinessUserResponse")]
        System.Threading.Tasks.Task AddBusinessUserAsync(MVCEvent.BusinessService.BusinessUser businessUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBusiness", ReplyAction="http://tempuri.org/IService1/AddBusinessResponse")]
        void AddBusiness(MVCEvent.BusinessService.Business1 business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddBusiness", ReplyAction="http://tempuri.org/IService1/AddBusinessResponse")]
        System.Threading.Tasks.Task AddBusinessAsync(MVCEvent.BusinessService.Business1 business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessById", ReplyAction="http://tempuri.org/IService1/GetBusinessByIdResponse")]
        MVCEvent.BusinessService.Business GetBusinessById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessById", ReplyAction="http://tempuri.org/IService1/GetBusinessByIdResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.Business> GetBusinessByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessByName", ReplyAction="http://tempuri.org/IService1/GetBusinessByNameResponse")]
        MVCEvent.BusinessService.Business[] GetBusinessByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessByName", ReplyAction="http://tempuri.org/IService1/GetBusinessByNameResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.Business[]> GetBusinessByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBusiness", ReplyAction="http://tempuri.org/IService1/UpdateBusinessResponse")]
        void UpdateBusiness(MVCEvent.BusinessService.Business1 business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBusiness", ReplyAction="http://tempuri.org/IService1/UpdateBusinessResponse")]
        System.Threading.Tasks.Task UpdateBusinessAsync(MVCEvent.BusinessService.Business1 business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBusiness", ReplyAction="http://tempuri.org/IService1/DeleteBusinessResponse")]
        void DeleteBusiness(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteBusiness", ReplyAction="http://tempuri.org/IService1/DeleteBusinessResponse")]
        System.Threading.Tasks.Task DeleteBusinessAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessNameById", ReplyAction="http://tempuri.org/IService1/GetBusinessNameByIdResponse")]
        string GetBusinessNameById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessNameById", ReplyAction="http://tempuri.org/IService1/GetBusinessNameByIdResponse")]
        System.Threading.Tasks.Task<string> GetBusinessNameByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUser", ReplyAction="http://tempuri.org/IService1/GetBusinessUserResponse")]
        MVCEvent.BusinessService.BusinessUser1 GetBusinessUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUser", ReplyAction="http://tempuri.org/IService1/GetBusinessUserResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUserById", ReplyAction="http://tempuri.org/IService1/GetBusinessUserByIdResponse")]
        MVCEvent.BusinessService.BusinessUser1 GetBusinessUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUserById", ReplyAction="http://tempuri.org/IService1/GetBusinessUserByIdResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoILive", ReplyAction="http://tempuri.org/IService1/DoILiveResponse")]
        string DoILive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoILive", ReplyAction="http://tempuri.org/IService1/DoILiveResponse")]
        System.Threading.Tasks.Task<string> DoILiveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUserByBusinessId", ReplyAction="http://tempuri.org/IService1/GetBusinessUserByBusinessIdResponse")]
        MVCEvent.BusinessService.BusinessUser1 GetBusinessUserByBusinessId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusinessUserByBusinessId", ReplyAction="http://tempuri.org/IService1/GetBusinessUserByBusinessIdResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserByBusinessIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBusinessUser", ReplyAction="http://tempuri.org/IService1/UpdateBusinessUserResponse")]
        void UpdateBusinessUser(MVCEvent.BusinessService.BusinessUser businessUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateBusinessUser", ReplyAction="http://tempuri.org/IService1/UpdateBusinessUserResponse")]
        System.Threading.Tasks.Task UpdateBusinessUserAsync(MVCEvent.BusinessService.BusinessUser businessUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusinessUsers", ReplyAction="http://tempuri.org/IService1/GetAllBusinessUsersResponse")]
        MVCEvent.BusinessService.BusinessUser1[] GetAllBusinessUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusinessUsers", ReplyAction="http://tempuri.org/IService1/GetAllBusinessUsersResponse")]
        System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1[]> GetAllBusinessUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerifyBusiness", ReplyAction="http://tempuri.org/IService1/VerifyBusinessResponse")]
        void VerifyBusiness(MVCEvent.BusinessService.Business1 business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerifyBusiness", ReplyAction="http://tempuri.org/IService1/VerifyBusinessResponse")]
        System.Threading.Tasks.Task VerifyBusinessAsync(MVCEvent.BusinessService.Business1 business);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MVCEvent.BusinessService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MVCEvent.BusinessService.IService1>, MVCEvent.BusinessService.IService1 {
        
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
        
        public MVCEvent.BusinessService.Business[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.Business[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void AddBusinessUser(MVCEvent.BusinessService.BusinessUser businessUser) {
            base.Channel.AddBusinessUser(businessUser);
        }
        
        public System.Threading.Tasks.Task AddBusinessUserAsync(MVCEvent.BusinessService.BusinessUser businessUser) {
            return base.Channel.AddBusinessUserAsync(businessUser);
        }
        
        public void AddBusiness(MVCEvent.BusinessService.Business1 business) {
            base.Channel.AddBusiness(business);
        }
        
        public System.Threading.Tasks.Task AddBusinessAsync(MVCEvent.BusinessService.Business1 business) {
            return base.Channel.AddBusinessAsync(business);
        }
        
        public MVCEvent.BusinessService.Business GetBusinessById(int id) {
            return base.Channel.GetBusinessById(id);
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.Business> GetBusinessByIdAsync(int id) {
            return base.Channel.GetBusinessByIdAsync(id);
        }
        
        public MVCEvent.BusinessService.Business[] GetBusinessByName(string name) {
            return base.Channel.GetBusinessByName(name);
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.Business[]> GetBusinessByNameAsync(string name) {
            return base.Channel.GetBusinessByNameAsync(name);
        }
        
        public void UpdateBusiness(MVCEvent.BusinessService.Business1 business) {
            base.Channel.UpdateBusiness(business);
        }
        
        public System.Threading.Tasks.Task UpdateBusinessAsync(MVCEvent.BusinessService.Business1 business) {
            return base.Channel.UpdateBusinessAsync(business);
        }
        
        public void DeleteBusiness(int id) {
            base.Channel.DeleteBusiness(id);
        }
        
        public System.Threading.Tasks.Task DeleteBusinessAsync(int id) {
            return base.Channel.DeleteBusinessAsync(id);
        }
        
        public string GetBusinessNameById(int id) {
            return base.Channel.GetBusinessNameById(id);
        }
        
        public System.Threading.Tasks.Task<string> GetBusinessNameByIdAsync(int id) {
            return base.Channel.GetBusinessNameByIdAsync(id);
        }
        
        public MVCEvent.BusinessService.BusinessUser1 GetBusinessUser(string userName) {
            return base.Channel.GetBusinessUser(userName);
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserAsync(string userName) {
            return base.Channel.GetBusinessUserAsync(userName);
        }
        
        public MVCEvent.BusinessService.BusinessUser1 GetBusinessUserById(int id) {
            return base.Channel.GetBusinessUserById(id);
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserByIdAsync(int id) {
            return base.Channel.GetBusinessUserByIdAsync(id);
        }
        
        public string DoILive() {
            return base.Channel.DoILive();
        }
        
        public System.Threading.Tasks.Task<string> DoILiveAsync() {
            return base.Channel.DoILiveAsync();
        }
        
        public MVCEvent.BusinessService.BusinessUser1 GetBusinessUserByBusinessId(int id) {
            return base.Channel.GetBusinessUserByBusinessId(id);
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1> GetBusinessUserByBusinessIdAsync(int id) {
            return base.Channel.GetBusinessUserByBusinessIdAsync(id);
        }
        
        public void UpdateBusinessUser(MVCEvent.BusinessService.BusinessUser businessUser) {
            base.Channel.UpdateBusinessUser(businessUser);
        }
        
        public System.Threading.Tasks.Task UpdateBusinessUserAsync(MVCEvent.BusinessService.BusinessUser businessUser) {
            return base.Channel.UpdateBusinessUserAsync(businessUser);
        }
        
        public MVCEvent.BusinessService.BusinessUser1[] GetAllBusinessUsers() {
            return base.Channel.GetAllBusinessUsers();
        }
        
        public System.Threading.Tasks.Task<MVCEvent.BusinessService.BusinessUser1[]> GetAllBusinessUsersAsync() {
            return base.Channel.GetAllBusinessUsersAsync();
        }
        
        public void VerifyBusiness(MVCEvent.BusinessService.Business1 business) {
            base.Channel.VerifyBusiness(business);
        }
        
        public System.Threading.Tasks.Task VerifyBusinessAsync(MVCEvent.BusinessService.Business1 business) {
            return base.Channel.VerifyBusinessAsync(business);
        }
    }
}
