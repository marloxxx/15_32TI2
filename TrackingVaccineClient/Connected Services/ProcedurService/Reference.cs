﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackingVaccineClient.ProcedurService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProcedurService.IProcedurService")]
    public interface IProcedurService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/GetVaccines", ReplyAction="http://tempuri.org/IProcedurService/GetVaccinesResponse")]
        TrackingVaccineService.Vaccine[] GetVaccines();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/GetVaccines", ReplyAction="http://tempuri.org/IProcedurService/GetVaccinesResponse")]
        System.Threading.Tasks.Task<TrackingVaccineService.Vaccine[]> GetVaccinesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/update", ReplyAction="http://tempuri.org/IProcedurService/updateResponse")]
        bool update(TrackingVaccineService.Vaccine vaccine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/update", ReplyAction="http://tempuri.org/IProcedurService/updateResponse")]
        System.Threading.Tasks.Task<bool> updateAsync(TrackingVaccineService.Vaccine vaccine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/delete", ReplyAction="http://tempuri.org/IProcedurService/deleteResponse")]
        bool delete(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcedurService/delete", ReplyAction="http://tempuri.org/IProcedurService/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(string code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProcedurServiceChannel : TrackingVaccineClient.ProcedurService.IProcedurService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProcedurServiceClient : System.ServiceModel.ClientBase<TrackingVaccineClient.ProcedurService.IProcedurService>, TrackingVaccineClient.ProcedurService.IProcedurService {
        
        public ProcedurServiceClient() {
        }
        
        public ProcedurServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProcedurServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcedurServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcedurServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TrackingVaccineService.Vaccine[] GetVaccines() {
            return base.Channel.GetVaccines();
        }
        
        public System.Threading.Tasks.Task<TrackingVaccineService.Vaccine[]> GetVaccinesAsync() {
            return base.Channel.GetVaccinesAsync();
        }
        
        public bool update(TrackingVaccineService.Vaccine vaccine) {
            return base.Channel.update(vaccine);
        }
        
        public System.Threading.Tasks.Task<bool> updateAsync(TrackingVaccineService.Vaccine vaccine) {
            return base.Channel.updateAsync(vaccine);
        }
        
        public bool delete(string code) {
            return base.Channel.delete(code);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(string code) {
            return base.Channel.deleteAsync(code);
        }
    }
}