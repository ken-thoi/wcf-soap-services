﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServicesApp.ClientAppReferences.MainServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="StaffDto", Namespace="http://schemas.datacontract.org/2004/07/WcfServicesApp.WcfServiceLib.DataContract")]
    [Serializable()]
    public partial class StaffDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthOfDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public System.DateTime BirthOfDay {
            get {
                return this.BirthOfDayField;
            }
            set {
                if ((this.BirthOfDayField.Equals(value) != true)) {
                    this.BirthOfDayField = value;
                    this.RaisePropertyChanged("BirthOfDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descriptions {
            get {
                return this.DescriptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionsField, value) != true)) {
                    this.DescriptionsField = value;
                    this.RaisePropertyChanged("Descriptions");
                }
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
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainServiceClient.IMainService")]
    public interface IMainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetAllStaffs", ReplyAction="http://tempuri.org/IMainService/GetAllStaffsResponse")]
        WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto[] GetAllStaffs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetAllStaffs", ReplyAction="http://tempuri.org/IMainService/GetAllStaffsResponse")]
        System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto[]> GetAllStaffsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetStaffById", ReplyAction="http://tempuri.org/IMainService/GetStaffByIdResponse")]
        WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto GetStaffById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetStaffById", ReplyAction="http://tempuri.org/IMainService/GetStaffByIdResponse")]
        System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto> GetStaffByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/AddStaff", ReplyAction="http://tempuri.org/IMainService/AddStaffResponse")]
        WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto AddStaff(WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto staffDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/AddStaff", ReplyAction="http://tempuri.org/IMainService/AddStaffResponse")]
        System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto> AddStaffAsync(WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto staffDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainServiceChannel : WcfServicesApp.ClientAppReferences.MainServiceClient.IMainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServiceClient : System.ServiceModel.ClientBase<WcfServicesApp.ClientAppReferences.MainServiceClient.IMainService>, WcfServicesApp.ClientAppReferences.MainServiceClient.IMainService {
        
        public MainServiceClient() {
        }
        
        public MainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto[] GetAllStaffs() {
            return base.Channel.GetAllStaffs();
        }
        
        public System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto[]> GetAllStaffsAsync() {
            return base.Channel.GetAllStaffsAsync();
        }
        
        public WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto GetStaffById(string id) {
            return base.Channel.GetStaffById(id);
        }
        
        public System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto> GetStaffByIdAsync(string id) {
            return base.Channel.GetStaffByIdAsync(id);
        }
        
        public WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto AddStaff(WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto staffDto) {
            return base.Channel.AddStaff(staffDto);
        }
        
        public System.Threading.Tasks.Task<WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto> AddStaffAsync(WcfServicesApp.ClientAppReferences.MainServiceClient.StaffDto staffDto) {
            return base.Channel.AddStaffAsync(staffDto);
        }
    }
}
