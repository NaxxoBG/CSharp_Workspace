﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSTest.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.tier2", ConfigurationName="ServiceReference1.WarehouseWSPortType")]
    public interface WarehouseWSPortType {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:executeOrder", ReplyAction="urn:executeOrderResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSTest.ServiceReference1.executeOrderResponse executeOrder(WSTest.ServiceReference1.executeOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:executeOrder", ReplyAction="urn:executeOrderResponse")]
        System.Threading.Tasks.Task<WSTest.ServiceReference1.executeOrderResponse> executeOrderAsync(WSTest.ServiceReference1.executeOrderRequest request);
        
        // CODEGEN: Parameter 'args0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:insertPallet", ReplyAction="urn:insertPalletResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSTest.ServiceReference1.insertPalletResponse insertPallet(WSTest.ServiceReference1.insertPalletRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:insertPallet", ReplyAction="urn:insertPalletResponse")]
        System.Threading.Tasks.Task<WSTest.ServiceReference1.insertPalletResponse> insertPalletAsync(WSTest.ServiceReference1.insertPalletRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model/xsd")]
    public partial class Order : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Good[] goodsField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("goods", IsNullable=true, Order=0)]
        public Good[] goods {
            get {
                return this.goodsField;
            }
            set {
                this.goodsField = value;
                this.RaisePropertyChanged("goods");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model/xsd")]
    public partial class Good : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string manufacturerField;
        
        private string nameField;
        
        private int palletIdField;
        
        private bool palletIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
                this.RaisePropertyChanged("manufacturer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int palletId {
            get {
                return this.palletIdField;
            }
            set {
                this.palletIdField = value;
                this.RaisePropertyChanged("palletId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool palletIdSpecified {
            get {
                return this.palletIdFieldSpecified;
            }
            set {
                this.palletIdFieldSpecified = value;
                this.RaisePropertyChanged("palletIdSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model/xsd")]
    public partial class Pallet : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int countField;
        
        private bool countFieldSpecified;
        
        private int goodidField;
        
        private bool goodidFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("count");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool countSpecified {
            get {
                return this.countFieldSpecified;
            }
            set {
                this.countFieldSpecified = value;
                this.RaisePropertyChanged("countSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int goodid {
            get {
                return this.goodidField;
            }
            set {
                this.goodidField = value;
                this.RaisePropertyChanged("goodid");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool goodidSpecified {
            get {
                return this.goodidFieldSpecified;
            }
            set {
                this.goodidFieldSpecified = value;
                this.RaisePropertyChanged("goodidSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeOrder", WrapperNamespace="http://ws.tier2", IsWrapped=true)]
    public partial class executeOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.tier2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WSTest.ServiceReference1.Order args0;
        
        public executeOrderRequest() {
        }
        
        public executeOrderRequest(WSTest.ServiceReference1.Order args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="executeOrderResponse", WrapperNamespace="http://ws.tier2", IsWrapped=true)]
    public partial class executeOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.tier2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public WSTest.ServiceReference1.Pallet[] @return;
        
        public executeOrderResponse() {
        }
        
        public executeOrderResponse(WSTest.ServiceReference1.Pallet[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertPallet", WrapperNamespace="http://ws.tier2", IsWrapped=true)]
    public partial class insertPalletRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.tier2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public WSTest.ServiceReference1.Pallet args0;
        
        public insertPalletRequest() {
        }
        
        public insertPalletRequest(WSTest.ServiceReference1.Pallet args0) {
            this.args0 = args0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertPalletResponse", WrapperNamespace="http://ws.tier2", IsWrapped=true)]
    public partial class insertPalletResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.tier2", Order=0)]
        public bool @return;
        
        public insertPalletResponse() {
        }
        
        public insertPalletResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WarehouseWSPortTypeChannel : WSTest.ServiceReference1.WarehouseWSPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseWSPortTypeClient : System.ServiceModel.ClientBase<WSTest.ServiceReference1.WarehouseWSPortType>, WSTest.ServiceReference1.WarehouseWSPortType {
        
        public WarehouseWSPortTypeClient() {
        }
        
        public WarehouseWSPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseWSPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseWSPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseWSPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTest.ServiceReference1.executeOrderResponse WSTest.ServiceReference1.WarehouseWSPortType.executeOrder(WSTest.ServiceReference1.executeOrderRequest request) {
            return base.Channel.executeOrder(request);
        }
        
        public WSTest.ServiceReference1.Pallet[] executeOrder(WSTest.ServiceReference1.Order args0) {
            WSTest.ServiceReference1.executeOrderRequest inValue = new WSTest.ServiceReference1.executeOrderRequest();
            inValue.args0 = args0;
            WSTest.ServiceReference1.executeOrderResponse retVal = ((WSTest.ServiceReference1.WarehouseWSPortType)(this)).executeOrder(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSTest.ServiceReference1.executeOrderResponse> WSTest.ServiceReference1.WarehouseWSPortType.executeOrderAsync(WSTest.ServiceReference1.executeOrderRequest request) {
            return base.Channel.executeOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSTest.ServiceReference1.executeOrderResponse> executeOrderAsync(WSTest.ServiceReference1.Order args0) {
            WSTest.ServiceReference1.executeOrderRequest inValue = new WSTest.ServiceReference1.executeOrderRequest();
            inValue.args0 = args0;
            return ((WSTest.ServiceReference1.WarehouseWSPortType)(this)).executeOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSTest.ServiceReference1.insertPalletResponse WSTest.ServiceReference1.WarehouseWSPortType.insertPallet(WSTest.ServiceReference1.insertPalletRequest request) {
            return base.Channel.insertPallet(request);
        }
        
        public bool insertPallet(WSTest.ServiceReference1.Pallet args0) {
            WSTest.ServiceReference1.insertPalletRequest inValue = new WSTest.ServiceReference1.insertPalletRequest();
            inValue.args0 = args0;
            WSTest.ServiceReference1.insertPalletResponse retVal = ((WSTest.ServiceReference1.WarehouseWSPortType)(this)).insertPallet(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSTest.ServiceReference1.insertPalletResponse> WSTest.ServiceReference1.WarehouseWSPortType.insertPalletAsync(WSTest.ServiceReference1.insertPalletRequest request) {
            return base.Channel.insertPalletAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSTest.ServiceReference1.insertPalletResponse> insertPalletAsync(WSTest.ServiceReference1.Pallet args0) {
            WSTest.ServiceReference1.insertPalletRequest inValue = new WSTest.ServiceReference1.insertPalletRequest();
            inValue.args0 = args0;
            return ((WSTest.ServiceReference1.WarehouseWSPortType)(this)).insertPalletAsync(inValue);
        }
    }
}