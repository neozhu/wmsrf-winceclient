﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5446.
// 
namespace RFDeviceAPP.InfoWms.Api {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WmsWebServiceHttpBinding", Namespace="http://com.ssaglobal.com")]
    public partial class WmsWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public WmsWebService() {
            this.Timeout = 900000;
            //this.Url = "http://172.20.70.95/WMSWebServiceTest/services/WmsWebService";
            this.Url = "http://172.20.70.95/WMSWebService/services/WmsWebService";
            //this.Url = "http://172.20.70.58:8080/WMSWebService/services/WmsWebService";
        }

        public WmsWebService(string url)
        {
            this.Timeout = 900000;
            //this.Url = "http://172.20.70.95/WMSWebServiceTest/services/WmsWebService";
            this.Url = string.Format("{0}/services/WmsWebService",url);
            //this.Url = "http://172.20.70.58:8080/WMSWebService/services/WmsWebService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://com.ssaglobal.com", ResponseNamespace="http://com.ssaglobal.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string callBackEnd([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in2, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in3) {
            object[] results = this.Invoke("callBackEnd", new object[] {
                        in0,
                        in1,
                        in2,
                        in3});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegincallBackEnd(string in0, string in1, string in2, string in3, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("callBackEnd", new object[] {
                        in0,
                        in1,
                        in2,
                        in3}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndcallBackEnd(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}