﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebLegadoEducativo02.WS_LE_Oportunidad {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_OportunidadSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_Oportunidad : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertaOportunidadOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsOportunidadContactoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizaOppContactoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_Oportunidad() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_Oportunidad_WS_LE_Oportunidad;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertaOportunidadCompletedEventHandler InsertaOportunidadCompleted;
        
        /// <remarks/>
        public event InsOportunidadContactoCompletedEventHandler InsOportunidadContactoCompleted;
        
        /// <remarks/>
        public event ActualizaOppContactoCompletedEventHandler ActualizaOppContactoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertaOportunidad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta InsertaOportunidad(string customerid, string nivelacademico, string udem_nombredelainstitucion, string recr_nombreinstitucion, string udem_tienebeca) {
            object[] results = this.Invoke("InsertaOportunidad", new object[] {
                        customerid,
                        nivelacademico,
                        udem_nombredelainstitucion,
                        recr_nombreinstitucion,
                        udem_tienebeca});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void InsertaOportunidadAsync(string customerid, string nivelacademico, string udem_nombredelainstitucion, string recr_nombreinstitucion, string udem_tienebeca) {
            this.InsertaOportunidadAsync(customerid, nivelacademico, udem_nombredelainstitucion, recr_nombreinstitucion, udem_tienebeca, null);
        }
        
        /// <remarks/>
        public void InsertaOportunidadAsync(string customerid, string nivelacademico, string udem_nombredelainstitucion, string recr_nombreinstitucion, string udem_tienebeca, object userState) {
            if ((this.InsertaOportunidadOperationCompleted == null)) {
                this.InsertaOportunidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertaOportunidadOperationCompleted);
            }
            this.InvokeAsync("InsertaOportunidad", new object[] {
                        customerid,
                        nivelacademico,
                        udem_nombredelainstitucion,
                        recr_nombreinstitucion,
                        udem_tienebeca}, this.InsertaOportunidadOperationCompleted, userState);
        }
        
        private void OnInsertaOportunidadOperationCompleted(object arg) {
            if ((this.InsertaOportunidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertaOportunidadCompleted(this, new InsertaOportunidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsOportunidadContacto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta InsOportunidadContacto(string name, string udem_area, string udem_asunto, string customerid, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid) {
            object[] results = this.Invoke("InsOportunidadContacto", new object[] {
                        name,
                        udem_area,
                        udem_asunto,
                        customerid,
                        new_fechadecompromiso,
                        udem_solicituddecompra,
                        pricelevelid});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void InsOportunidadContactoAsync(string name, string udem_area, string udem_asunto, string customerid, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid) {
            this.InsOportunidadContactoAsync(name, udem_area, udem_asunto, customerid, new_fechadecompromiso, udem_solicituddecompra, pricelevelid, null);
        }
        
        /// <remarks/>
        public void InsOportunidadContactoAsync(string name, string udem_area, string udem_asunto, string customerid, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid, object userState) {
            if ((this.InsOportunidadContactoOperationCompleted == null)) {
                this.InsOportunidadContactoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsOportunidadContactoOperationCompleted);
            }
            this.InvokeAsync("InsOportunidadContacto", new object[] {
                        name,
                        udem_area,
                        udem_asunto,
                        customerid,
                        new_fechadecompromiso,
                        udem_solicituddecompra,
                        pricelevelid}, this.InsOportunidadContactoOperationCompleted, userState);
        }
        
        private void OnInsOportunidadContactoOperationCompleted(object arg) {
            if ((this.InsOportunidadContactoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsOportunidadContactoCompleted(this, new InsOportunidadContactoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ActualizaOppContacto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta ActualizaOppContacto(string name, string udem_area, string opportunityId, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid) {
            object[] results = this.Invoke("ActualizaOppContacto", new object[] {
                        name,
                        udem_area,
                        opportunityId,
                        new_fechadecompromiso,
                        udem_solicituddecompra,
                        pricelevelid});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizaOppContactoAsync(string name, string udem_area, string opportunityId, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid) {
            this.ActualizaOppContactoAsync(name, udem_area, opportunityId, new_fechadecompromiso, udem_solicituddecompra, pricelevelid, null);
        }
        
        /// <remarks/>
        public void ActualizaOppContactoAsync(string name, string udem_area, string opportunityId, string new_fechadecompromiso, string udem_solicituddecompra, string pricelevelid, object userState) {
            if ((this.ActualizaOppContactoOperationCompleted == null)) {
                this.ActualizaOppContactoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizaOppContactoOperationCompleted);
            }
            this.InvokeAsync("ActualizaOppContacto", new object[] {
                        name,
                        udem_area,
                        opportunityId,
                        new_fechadecompromiso,
                        udem_solicituddecompra,
                        pricelevelid}, this.ActualizaOppContactoOperationCompleted, userState);
        }
        
        private void OnActualizaOppContactoOperationCompleted(object arg) {
            if ((this.ActualizaOppContactoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizaOppContactoCompleted(this, new ActualizaOppContactoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Respuesta {
        
        private string codigoMsField;
        
        private string mensajeField;
        
        private string guidField;
        
        /// <remarks/>
        public string CodigoMs {
            get {
                return this.codigoMsField;
            }
            set {
                this.codigoMsField = value;
            }
        }
        
        /// <remarks/>
        public string Mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string Guid {
            get {
                return this.guidField;
            }
            set {
                this.guidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsertaOportunidadCompletedEventHandler(object sender, InsertaOportunidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertaOportunidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertaOportunidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Respuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Respuesta)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsOportunidadContactoCompletedEventHandler(object sender, InsOportunidadContactoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsOportunidadContactoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsOportunidadContactoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Respuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Respuesta)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ActualizaOppContactoCompletedEventHandler(object sender, ActualizaOppContactoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizaOppContactoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizaOppContactoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Respuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Respuesta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591