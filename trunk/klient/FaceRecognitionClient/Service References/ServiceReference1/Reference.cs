﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceRecognitionClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:hellowsdl", ConfigurationName="ServiceReference1.hellowsdlPortType")]
    public interface hellowsdlPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:hellowsdl#hello", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string hello(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface hellowsdlPortTypeChannel : FaceRecognitionClient.ServiceReference1.hellowsdlPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class hellowsdlPortTypeClient : System.ServiceModel.ClientBase<FaceRecognitionClient.ServiceReference1.hellowsdlPortType>, FaceRecognitionClient.ServiceReference1.hellowsdlPortType {
        
        public hellowsdlPortTypeClient() {
        }
        
        public hellowsdlPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public hellowsdlPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public hellowsdlPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public hellowsdlPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string hello(string name) {
            return base.Channel.hello(name);
        }
    }
}
