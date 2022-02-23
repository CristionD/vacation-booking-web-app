﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripBookingWebApp.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        string[] Weather5day(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Weather5day", ReplyAction="http://tempuri.org/IService1/Weather5dayResponse")]
        System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AnnualSolar", ReplyAction="http://tempuri.org/IService1/AnnualSolarResponse")]
        double AnnualSolar(decimal latitude, decimal longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AnnualSolar", ReplyAction="http://tempuri.org/IService1/AnnualSolarResponse")]
        System.Threading.Tasks.Task<double> AnnualSolarAsync(decimal latitude, decimal longitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TripBookingWebApp.WeatherService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TripBookingWebApp.WeatherService.IService1>, TripBookingWebApp.WeatherService.IService1 {
        
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
        
        public string[] Weather5day(string zipcode) {
            return base.Channel.Weather5day(zipcode);
        }
        
        public System.Threading.Tasks.Task<string[]> Weather5dayAsync(string zipcode) {
            return base.Channel.Weather5dayAsync(zipcode);
        }
        
        public double AnnualSolar(decimal latitude, decimal longitude) {
            return base.Channel.AnnualSolar(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<double> AnnualSolarAsync(decimal latitude, decimal longitude) {
            return base.Channel.AnnualSolarAsync(latitude, longitude);
        }
    }
}
