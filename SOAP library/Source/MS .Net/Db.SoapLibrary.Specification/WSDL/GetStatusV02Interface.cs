﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB.SoapLibrary.Specification.GetStatusV02
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.danskebank.com/services/", ConfigurationName = "GetStatusV02")]
    public interface GetStatusV02
    {

        // CODEGEN: Generating message contract since message GetStatusRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        GetStatusResponse GetStatus(GetStatusRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        System.Threading.Tasks.Task<GetStatusResponse> GetStatusAsync(GetStatusRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class SecurityHeaderType
    {

        private System.Xml.XmlElement[] anyField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order = 0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.danskebank.com/SecureSoapSGW")]
    public partial class RequestHeaderType
    {

        private string senderIdField;

        private string signerId1Field;

        private string signerId2Field;

        private string signerId3Field;

        private string dBCryptIdField;

        private string requestIdField;

        private string timestampField;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SenderId
        {
            get
            {
                return this.senderIdField;
            }
            set
            {
                this.senderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string SignerId1
        {
            get
            {
                return this.signerId1Field;
            }
            set
            {
                this.signerId1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string SignerId2
        {
            get
            {
                return this.signerId2Field;
            }
            set
            {
                this.signerId2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string SignerId3
        {
            get
            {
                return this.signerId3Field;
            }
            set
            {
                this.signerId3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string DBCryptId
        {
            get
            {
                return this.dBCryptIdField;
            }
            set
            {
                this.dBCryptIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.danskebank.com/services/")]
    public partial class dacGetStatusOutput
    {

        private string returnCodeField;

        private string reasonCodeField;

        private string latestPaymentStatusField;

        private string originalTransactionIdField;

        private decimal originalAmountField;

        private string numOfTransactionsField;

        private dacGetStatusOutputTransactions[] transactionsField;

        public dacGetStatusOutput()
        {
            this.originalAmountField = ((decimal)(0.0m));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string LatestPaymentStatus
        {
            get
            {
                return this.latestPaymentStatusField;
            }
            set
            {
                this.latestPaymentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string OriginalTransactionId
        {
            get
            {
                return this.originalTransactionIdField;
            }
            set
            {
                this.originalTransactionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public decimal OriginalAmount
        {
            get
            {
                return this.originalAmountField;
            }
            set
            {
                this.originalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string NumOfTransactions
        {
            get
            {
                return this.numOfTransactionsField;
            }
            set
            {
                this.numOfTransactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transactions", Order = 6)]
        public dacGetStatusOutputTransactions[] transactions
        {
            get
            {
                return this.transactionsField;
            }
            set
            {
                this.transactionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.danskebank.com/services/")]
    public partial class dacGetStatusOutputTransactions
    {

        private string timeStampField;

        private string paymentStatusField;

        private string transactionIdField;

        private decimal amountField;

        public dacGetStatusOutputTransactions()
        {
            this.amountField = ((decimal)(0.0m));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string PaymentStatus
        {
            get
            {
                return this.paymentStatusField;
            }
            set
            {
                this.paymentStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string TransactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.danskebank.com/services/")]
    public partial class dacGetStatusInput
    {

        private string merchantIdField;

        private string orderIdField;

        private string customerIdField;

        private string actionCodeField;

        private string testField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string MerchantId
        {
            get
            {
                return this.merchantIdField;
            }
            set
            {
                this.merchantIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string OrderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Test
        {
            get
            {
                return this.testField;
            }
            set
            {
                this.testField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetStatus", WrapperNamespace = "http://www.danskebank.com/services/", IsWrapped = true)]
    public partial class GetStatusRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]
        public SecurityHeaderType Security;

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://www.danskebank.com/SecureSoapSGW")]
        public RequestHeaderType RequestHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.danskebank.com/services/", Order = 0)]
        public dacGetStatusInput dacGetStatusInput;

        public GetStatusRequest()
        {
        }

        public GetStatusRequest(SecurityHeaderType Security, RequestHeaderType RequestHeader, dacGetStatusInput dacGetStatusInput)
        {
            this.Security = Security;
            this.RequestHeader = RequestHeader;
            this.dacGetStatusInput = dacGetStatusInput;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetStatusResponse", WrapperNamespace = "http://www.danskebank.com/services/", IsWrapped = true)]
    public partial class GetStatusResponse
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]
        public SecurityHeaderType Security;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.danskebank.com/services/", Order = 0)]
        public dacGetStatusOutput dacGetStatusOutput;

        public GetStatusResponse()
        {
        }

        public GetStatusResponse(SecurityHeaderType Security, dacGetStatusOutput dacGetStatusOutput)
        {
            this.Security = Security;
            this.dacGetStatusOutput = dacGetStatusOutput;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GetStatusV02Channel : GetStatusV02, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStatusV02Client : System.ServiceModel.ClientBase<GetStatusV02>, GetStatusV02
    {

        public GetStatusV02Client()
        {
        }

        public GetStatusV02Client(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public GetStatusV02Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public GetStatusV02Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public GetStatusV02Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetStatusResponse GetStatusV02.GetStatus(GetStatusRequest request)
        {
            return base.Channel.GetStatus(request);
        }

        public dacGetStatusOutput GetStatus(ref SecurityHeaderType Security, RequestHeaderType RequestHeader, dacGetStatusInput dacGetStatusInput)
        {
            GetStatusRequest inValue = new GetStatusRequest();
            inValue.Security = Security;
            inValue.RequestHeader = RequestHeader;
            inValue.dacGetStatusInput = dacGetStatusInput;
            GetStatusResponse retVal = ((GetStatusV02)(this)).GetStatus(inValue);
            Security = retVal.Security;
            return retVal.dacGetStatusOutput;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetStatusResponse> GetStatusV02.GetStatusAsync(GetStatusRequest request)
        {
            return base.Channel.GetStatusAsync(request);
        }

        public System.Threading.Tasks.Task<GetStatusResponse> GetStatusAsync(SecurityHeaderType Security, RequestHeaderType RequestHeader, dacGetStatusInput dacGetStatusInput)
        {
            GetStatusRequest inValue = new GetStatusRequest();
            inValue.Security = Security;
            inValue.RequestHeader = RequestHeader;
            inValue.dacGetStatusInput = dacGetStatusInput;
            return ((GetStatusV02)(this)).GetStatusAsync(inValue);
        }
    }
}