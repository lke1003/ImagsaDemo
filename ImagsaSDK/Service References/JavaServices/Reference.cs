﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImagsaSDK.JavaServices {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservice.hypertech.com/")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservice.hypertech.com/", ConfigurationName="JavaServices.ICarEnter")]
    public interface ICarEnter {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ImagsaSDK.JavaServices.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void outStatus();
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ImagsaSDK.JavaServices.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ImagsaSDK.JavaServices.getVehicleNoResponse getVehicleNo(ImagsaSDK.JavaServices.getVehicleNo request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ImagsaSDK.JavaServices.startResponse start(ImagsaSDK.JavaServices.start request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVehicleNo", WrapperNamespace="http://webservice.hypertech.com/", IsWrapped=true)]
    public partial class getVehicleNo {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.hypertech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public getVehicleNo() {
        }
        
        public getVehicleNo(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVehicleNoResponse", WrapperNamespace="http://webservice.hypertech.com/", IsWrapped=true)]
    public partial class getVehicleNoResponse {
        
        public getVehicleNoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="start", WrapperNamespace="http://webservice.hypertech.com/", IsWrapped=true)]
    public partial class start {
        
        public start() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="startResponse", WrapperNamespace="http://webservice.hypertech.com/", IsWrapped=true)]
    public partial class startResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservice.hypertech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public startResponse() {
        }
        
        public startResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarEnterChannel : ImagsaSDK.JavaServices.ICarEnter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarEnterClient : System.ServiceModel.ClientBase<ImagsaSDK.JavaServices.ICarEnter>, ImagsaSDK.JavaServices.ICarEnter {
        
        public CarEnterClient() {
        }
        
        public CarEnterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarEnterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarEnterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarEnterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void outStatus() {
            base.Channel.outStatus();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ImagsaSDK.JavaServices.getVehicleNoResponse ImagsaSDK.JavaServices.ICarEnter.getVehicleNo(ImagsaSDK.JavaServices.getVehicleNo request) {
            return base.Channel.getVehicleNo(request);
        }
        
        public void getVehicleNo(string arg0) {
            ImagsaSDK.JavaServices.getVehicleNo inValue = new ImagsaSDK.JavaServices.getVehicleNo();
            inValue.arg0 = arg0;
            ImagsaSDK.JavaServices.getVehicleNoResponse retVal = ((ImagsaSDK.JavaServices.ICarEnter)(this)).getVehicleNo(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ImagsaSDK.JavaServices.startResponse ImagsaSDK.JavaServices.ICarEnter.start(ImagsaSDK.JavaServices.start request) {
            return base.Channel.start(request);
        }
        
        public int start() {
            ImagsaSDK.JavaServices.start inValue = new ImagsaSDK.JavaServices.start();
            ImagsaSDK.JavaServices.startResponse retVal = ((ImagsaSDK.JavaServices.ICarEnter)(this)).start(inValue);
            return retVal.@return;
        }
    }
}
