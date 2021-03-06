﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C_DentalClaimTracker.OMPropel {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestServiceResponse", Namespace="http://schemas.datacontract.org/2004/07/MDE.TransactionServices.External")]
    [System.SerializableAttribute()]
    public partial class RequestServiceResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string[] ErrorsField;
        
        private bool IsTranslationSuccessfulField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool IsTranslationSuccessful {
            get {
                return this.IsTranslationSuccessfulField;
            }
            set {
                if ((this.IsTranslationSuccessfulField.Equals(value) != true)) {
                    this.IsTranslationSuccessfulField = value;
                    this.RaisePropertyChanged("IsTranslationSuccessful");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OMPropel.IRequestInbound")]
    public interface IRequestInbound {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRequestInbound/UploadEligibilityRequest", ReplyAction="http://tempuri.org/IRequestInbound/UploadEligibilityRequestResponse")]
        C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadEligibilityRequest(string key, string name, string requestXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRequestInbound/UploadClaim", ReplyAction="http://tempuri.org/IRequestInbound/UploadClaimResponse")]
        C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadClaim(string key, string name, string claimXml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRequestInbound/UploadMessage", ReplyAction="http://tempuri.org/IRequestInbound/UploadMessageResponse")]
        C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadMessage(string key, string name, string messageXml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRequestInboundChannel : C_DentalClaimTracker.OMPropel.IRequestInbound, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RequestInboundClient : System.ServiceModel.ClientBase<C_DentalClaimTracker.OMPropel.IRequestInbound>, C_DentalClaimTracker.OMPropel.IRequestInbound {
        
        public RequestInboundClient() {
        }
        
        public RequestInboundClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RequestInboundClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RequestInboundClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RequestInboundClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadEligibilityRequest(string key, string name, string requestXml) {
            return base.Channel.UploadEligibilityRequest(key, name, requestXml);
        }
        
        public C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadClaim(string key, string name, string claimXml) {
            return base.Channel.UploadClaim(key, name, claimXml);
        }
        
        public C_DentalClaimTracker.OMPropel.RequestServiceResponse UploadMessage(string key, string name, string messageXml) {
            return base.Channel.UploadMessage(key, name, messageXml);
        }
    }
}
