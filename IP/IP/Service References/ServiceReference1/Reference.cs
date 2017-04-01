﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IP.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/IP_WcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        IP.ServiceReference1.CompositeType GetDataUsingDataContract(IP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<IP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(IP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecturer", ReplyAction="http://tempuri.org/IService1/addLecturerResponse")]
        string addLecturer(string nic, string lid, string fname, string lname, string cont_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecturer", ReplyAction="http://tempuri.org/IService1/addLecturerResponse")]
        System.Threading.Tasks.Task<string> addLecturerAsync(string nic, string lid, string fname, string lname, string cont_num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLecturer", ReplyAction="http://tempuri.org/IService1/viewLecturerResponse")]
        System.Data.DataTable viewLecturer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLecturer", ReplyAction="http://tempuri.org/IService1/viewLecturerResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewLecturerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addGrp", ReplyAction="http://tempuri.org/IService1/addGrpResponse")]
        string addGrp(string gid, string no, string eno, string sno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addGrp", ReplyAction="http://tempuri.org/IService1/addGrpResponse")]
        System.Threading.Tasks.Task<string> addGrpAsync(string gid, string no, string eno, string sno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewGroup", ReplyAction="http://tempuri.org/IService1/viewGroupResponse")]
        System.Data.DataTable viewGroup();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewGroup", ReplyAction="http://tempuri.org/IService1/viewGroupResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewGroupAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addIns", ReplyAction="http://tempuri.org/IService1/addInsResponse")]
        string addIns(string nic, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addIns", ReplyAction="http://tempuri.org/IService1/addInsResponse")]
        System.Threading.Tasks.Task<string> addInsAsync(string nic, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewIns", ReplyAction="http://tempuri.org/IService1/viewInsResponse")]
        System.Data.DataTable viewIns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewIns", ReplyAction="http://tempuri.org/IService1/viewInsResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewInsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLabs", ReplyAction="http://tempuri.org/IService1/viewLabsResponse")]
        System.Data.DataTable viewLabs(string day, string time, string gid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLabs", ReplyAction="http://tempuri.org/IService1/viewLabsResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewLabsAsync(string day, string time, string gid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPracSession", ReplyAction="http://tempuri.org/IService1/addPracSessionResponse")]
        string addPracSession(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, System.DateTime sdt, System.DateTime edt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPracSession", ReplyAction="http://tempuri.org/IService1/addPracSessionResponse")]
        System.Threading.Tasks.Task<string> addPracSessionAsync(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, System.DateTime sdt, System.DateTime edt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPracDates", ReplyAction="http://tempuri.org/IService1/addPracDatesResponse")]
        void addPracDates(System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPracDates", ReplyAction="http://tempuri.org/IService1/addPracDatesResponse")]
        System.Threading.Tasks.Task addPracDatesAsync(System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecSession", ReplyAction="http://tempuri.org/IService1/addLecSessionResponse")]
        string addLecSession(string bid, string mid, string lid, string tid, string day, string time, string hid, System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecSession", ReplyAction="http://tempuri.org/IService1/addLecSessionResponse")]
        System.Threading.Tasks.Task<string> addLecSessionAsync(string bid, string mid, string lid, string tid, string day, string time, string hid, System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecDates", ReplyAction="http://tempuri.org/IService1/addLecDatesResponse")]
        void addLecDates(System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addLecDates", ReplyAction="http://tempuri.org/IService1/addLecDatesResponse")]
        System.Threading.Tasks.Task addLecDatesAsync(System.DateTime d1, System.DateTime d2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewHalls", ReplyAction="http://tempuri.org/IService1/viewHallsResponse")]
        System.Data.DataTable viewHalls(string day, string bid, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewHalls", ReplyAction="http://tempuri.org/IService1/viewHallsResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewHallsAsync(string day, string bid, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLectureSessions", ReplyAction="http://tempuri.org/IService1/viewLectureSessionsResponse")]
        System.Data.DataTable viewLectureSessions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLectureSessions", ReplyAction="http://tempuri.org/IService1/viewLectureSessionsResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewLectureSessionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLectureSchedule", ReplyAction="http://tempuri.org/IService1/viewLectureScheduleResponse")]
        System.Data.DataTable viewLectureSchedule(string bid, string mid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/viewLectureSchedule", ReplyAction="http://tempuri.org/IService1/viewLectureScheduleResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> viewLectureScheduleAsync(string bid, string mid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : IP.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<IP.ServiceReference1.IService1>, IP.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public IP.ServiceReference1.CompositeType GetDataUsingDataContract(IP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<IP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(IP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string addLecturer(string nic, string lid, string fname, string lname, string cont_num) {
            return base.Channel.addLecturer(nic, lid, fname, lname, cont_num);
        }
        
        public System.Threading.Tasks.Task<string> addLecturerAsync(string nic, string lid, string fname, string lname, string cont_num) {
            return base.Channel.addLecturerAsync(nic, lid, fname, lname, cont_num);
        }
        
        public System.Data.DataTable viewLecturer() {
            return base.Channel.viewLecturer();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewLecturerAsync() {
            return base.Channel.viewLecturerAsync();
        }
        
        public string addGrp(string gid, string no, string eno, string sno) {
            return base.Channel.addGrp(gid, no, eno, sno);
        }
        
        public System.Threading.Tasks.Task<string> addGrpAsync(string gid, string no, string eno, string sno) {
            return base.Channel.addGrpAsync(gid, no, eno, sno);
        }
        
        public System.Data.DataTable viewGroup() {
            return base.Channel.viewGroup();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewGroupAsync() {
            return base.Channel.viewGroupAsync();
        }
        
        public string addIns(string nic, string id) {
            return base.Channel.addIns(nic, id);
        }
        
        public System.Threading.Tasks.Task<string> addInsAsync(string nic, string id) {
            return base.Channel.addInsAsync(nic, id);
        }
        
        public System.Data.DataTable viewIns() {
            return base.Channel.viewIns();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewInsAsync() {
            return base.Channel.viewInsAsync();
        }
        
        public System.Data.DataTable viewLabs(string day, string time, string gid) {
            return base.Channel.viewLabs(day, time, gid);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewLabsAsync(string day, string time, string gid) {
            return base.Channel.viewLabsAsync(day, time, gid);
        }
        
        public string addPracSession(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, System.DateTime sdt, System.DateTime edt) {
            return base.Channel.addPracSession(mid, day, time, bid, trm, grp, lid, ins, sdt, edt);
        }
        
        public System.Threading.Tasks.Task<string> addPracSessionAsync(string mid, string day, string time, string bid, string trm, string grp, string lid, string ins, System.DateTime sdt, System.DateTime edt) {
            return base.Channel.addPracSessionAsync(mid, day, time, bid, trm, grp, lid, ins, sdt, edt);
        }
        
        public void addPracDates(System.DateTime d1, System.DateTime d2) {
            base.Channel.addPracDates(d1, d2);
        }
        
        public System.Threading.Tasks.Task addPracDatesAsync(System.DateTime d1, System.DateTime d2) {
            return base.Channel.addPracDatesAsync(d1, d2);
        }
        
        public string addLecSession(string bid, string mid, string lid, string tid, string day, string time, string hid, System.DateTime d1, System.DateTime d2) {
            return base.Channel.addLecSession(bid, mid, lid, tid, day, time, hid, d1, d2);
        }
        
        public System.Threading.Tasks.Task<string> addLecSessionAsync(string bid, string mid, string lid, string tid, string day, string time, string hid, System.DateTime d1, System.DateTime d2) {
            return base.Channel.addLecSessionAsync(bid, mid, lid, tid, day, time, hid, d1, d2);
        }
        
        public void addLecDates(System.DateTime d1, System.DateTime d2) {
            base.Channel.addLecDates(d1, d2);
        }
        
        public System.Threading.Tasks.Task addLecDatesAsync(System.DateTime d1, System.DateTime d2) {
            return base.Channel.addLecDatesAsync(d1, d2);
        }
        
        public System.Data.DataTable viewHalls(string day, string bid, string time) {
            return base.Channel.viewHalls(day, bid, time);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewHallsAsync(string day, string bid, string time) {
            return base.Channel.viewHallsAsync(day, bid, time);
        }
        
        public System.Data.DataTable viewLectureSessions() {
            return base.Channel.viewLectureSessions();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewLectureSessionsAsync() {
            return base.Channel.viewLectureSessionsAsync();
        }
        
        public System.Data.DataTable viewLectureSchedule(string bid, string mid) {
            return base.Channel.viewLectureSchedule(bid, mid);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> viewLectureScheduleAsync(string bid, string mid) {
            return base.Channel.viewLectureScheduleAsync(bid, mid);
        }
    }
}
