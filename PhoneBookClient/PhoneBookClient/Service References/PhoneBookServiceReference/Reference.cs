﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBookClient.PhoneBookServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="PhoneBookServiceReference.IPhoneBook")]
    public interface IPhoneBook {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPhoneBook/GetFullNameByPhone", ReplyAction="http://Microsoft.ServiceModel.Samples/IPhoneBook/GetFullNameByPhoneResponse")]
        string GetFullNameByPhone(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPhoneBook/GetFullNameByPhone", ReplyAction="http://Microsoft.ServiceModel.Samples/IPhoneBook/GetFullNameByPhoneResponse")]
        System.Threading.Tasks.Task<string> GetFullNameByPhoneAsync(string phone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPhoneBookChannel : IPhoneBook, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PhoneBookClient : System.ServiceModel.ClientBase<IPhoneBook>, IPhoneBook {
        
        public PhoneBookClient() {
        }
        
        public PhoneBookClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PhoneBookClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhoneBookClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhoneBookClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetFullNameByPhone(string phone) {
            return base.Channel.GetFullNameByPhone(phone);
        }
        
        public System.Threading.Tasks.Task<string> GetFullNameByPhoneAsync(string phone) {
            return base.Channel.GetFullNameByPhoneAsync(phone);
        }
    }
}