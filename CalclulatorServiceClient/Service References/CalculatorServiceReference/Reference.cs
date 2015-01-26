﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalclulatorServiceClient.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.IMyCalculatorService")]
    public interface IMyCalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Add", ReplyAction="http://tempuri.org/IMyCalculatorService/AddResponse")]
        int Add(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Add", ReplyAction="http://tempuri.org/IMyCalculatorService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Subtract", ReplyAction="http://tempuri.org/IMyCalculatorService/SubtractResponse")]
        int Subtract(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Subtract", ReplyAction="http://tempuri.org/IMyCalculatorService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Multiply", ReplyAction="http://tempuri.org/IMyCalculatorService/MultiplyResponse")]
        int Multiply(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyCalculatorService/Multiply", ReplyAction="http://tempuri.org/IMyCalculatorService/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyCalculatorServiceChannel : CalclulatorServiceClient.CalculatorServiceReference.IMyCalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCalculatorServiceClient : System.ServiceModel.ClientBase<CalclulatorServiceClient.CalculatorServiceReference.IMyCalculatorService>, CalclulatorServiceClient.CalculatorServiceReference.IMyCalculatorService {
        
        public MyCalculatorServiceClient() {
        }
        
        public MyCalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int Num1, int Num2) {
            return base.Channel.Add(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int Num1, int Num2) {
            return base.Channel.AddAsync(Num1, Num2);
        }
        
        public int Subtract(int Num1, int Num2) {
            return base.Channel.Subtract(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int Num1, int Num2) {
            return base.Channel.SubtractAsync(Num1, Num2);
        }
        
        public int Multiply(int Num1, int Num2) {
            return base.Channel.Multiply(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2) {
            return base.Channel.MultiplyAsync(Num1, Num2);
        }
    }
}