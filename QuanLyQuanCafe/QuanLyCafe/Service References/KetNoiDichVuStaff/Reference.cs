﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCafe.KetNoiDichVuStaff {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Staff", Namespace="http://schemas.datacontract.org/2004/07/QuanLyQuanCafe.Entity")]
    [System.SerializableAttribute()]
    public partial class Staff : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime birthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sexField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime birthday {
            get {
                return this.birthdayField;
            }
            set {
                if ((this.birthdayField.Equals(value) != true)) {
                    this.birthdayField = value;
                    this.RaisePropertyChanged("birthday");
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
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sex {
            get {
                return this.sexField;
            }
            set {
                if ((object.ReferenceEquals(this.sexField, value) != true)) {
                    this.sexField = value;
                    this.RaisePropertyChanged("sex");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KetNoiDichVuStaff.IServiceStaff")]
    public interface IServiceStaff {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/GetStaff", ReplyAction="http://tempuri.org/IServiceStaff/GetStaffResponse")]
        System.Data.DataSet GetStaff();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/GetStaff", ReplyAction="http://tempuri.org/IServiceStaff/GetStaffResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStaffAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/AddStaff", ReplyAction="http://tempuri.org/IServiceStaff/AddStaffResponse")]
        int AddStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/AddStaff", ReplyAction="http://tempuri.org/IServiceStaff/AddStaffResponse")]
        System.Threading.Tasks.Task<int> AddStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/UpdateStaff", ReplyAction="http://tempuri.org/IServiceStaff/UpdateStaffResponse")]
        int UpdateStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/UpdateStaff", ReplyAction="http://tempuri.org/IServiceStaff/UpdateStaffResponse")]
        System.Threading.Tasks.Task<int> UpdateStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/DeleteStaff", ReplyAction="http://tempuri.org/IServiceStaff/DeleteStaffResponse")]
        int DeleteStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceStaff/DeleteStaff", ReplyAction="http://tempuri.org/IServiceStaff/DeleteStaffResponse")]
        System.Threading.Tasks.Task<int> DeleteStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceStaffChannel : QuanLyCafe.KetNoiDichVuStaff.IServiceStaff, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceStaffClient : System.ServiceModel.ClientBase<QuanLyCafe.KetNoiDichVuStaff.IServiceStaff>, QuanLyCafe.KetNoiDichVuStaff.IServiceStaff {
        
        public ServiceStaffClient() {
        }
        
        public ServiceStaffClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceStaffClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStaffClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceStaffClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetStaff() {
            return base.Channel.GetStaff();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStaffAsync() {
            return base.Channel.GetStaffAsync();
        }
        
        public int AddStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.AddStaff(nv);
        }
        
        public System.Threading.Tasks.Task<int> AddStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.AddStaffAsync(nv);
        }
        
        public int UpdateStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.UpdateStaff(nv);
        }
        
        public System.Threading.Tasks.Task<int> UpdateStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.UpdateStaffAsync(nv);
        }
        
        public int DeleteStaff(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.DeleteStaff(nv);
        }
        
        public System.Threading.Tasks.Task<int> DeleteStaffAsync(QuanLyCafe.KetNoiDichVuStaff.Staff nv) {
            return base.Channel.DeleteStaffAsync(nv);
        }
    }
}
