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

namespace WebClientesPotencialesLEProp.WSConClientePotencial {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WSConClientePotencialSoap", Namespace="http://tempuri.org/")]
    public partial class WSConClientePotencial : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsClientePotencialOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsClientePotencialCorreoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSConClientePotencial() {
            this.Url = global::WebClientesPotencialesLEProp.Properties.Settings.Default.WebClientesPotencialesLEProp_WSConClientePotencial_WSConClientePotencial;
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
        public event ConsClientePotencialCompletedEventHandler ConsClientePotencialCompleted;
        
        /// <remarks/>
        public event ConsClientePotencialCorreoCompletedEventHandler ConsClientePotencialCorreoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsClientePotencial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsClientePotencial[] ConsClientePotencial(string CtePotencial) {
            object[] results = this.Invoke("ConsClientePotencial", new object[] {
                        CtePotencial});
            return ((CsClientePotencial[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsClientePotencialAsync(string CtePotencial) {
            this.ConsClientePotencialAsync(CtePotencial, null);
        }
        
        /// <remarks/>
        public void ConsClientePotencialAsync(string CtePotencial, object userState) {
            if ((this.ConsClientePotencialOperationCompleted == null)) {
                this.ConsClientePotencialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsClientePotencialOperationCompleted);
            }
            this.InvokeAsync("ConsClientePotencial", new object[] {
                        CtePotencial}, this.ConsClientePotencialOperationCompleted, userState);
        }
        
        private void OnConsClientePotencialOperationCompleted(object arg) {
            if ((this.ConsClientePotencialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsClientePotencialCompleted(this, new ConsClientePotencialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsClientePotencialCorreo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsClientePotencial[] ConsClientePotencialCorreo(string Correo) {
            object[] results = this.Invoke("ConsClientePotencialCorreo", new object[] {
                        Correo});
            return ((CsClientePotencial[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsClientePotencialCorreoAsync(string Correo) {
            this.ConsClientePotencialCorreoAsync(Correo, null);
        }
        
        /// <remarks/>
        public void ConsClientePotencialCorreoAsync(string Correo, object userState) {
            if ((this.ConsClientePotencialCorreoOperationCompleted == null)) {
                this.ConsClientePotencialCorreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsClientePotencialCorreoOperationCompleted);
            }
            this.InvokeAsync("ConsClientePotencialCorreo", new object[] {
                        Correo}, this.ConsClientePotencialCorreoOperationCompleted, userState);
        }
        
        private void OnConsClientePotencialCorreoOperationCompleted(object arg) {
            if ((this.ConsClientePotencialCorreoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsClientePotencialCorreoCompleted(this, new ConsClientePotencialCorreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class CsClientePotencial {
        
        private string udem_asuntoField;
        
        private string firstnameField;
        
        private string middlenameField;
        
        private string udem_apellidopaternoField;
        
        private string udem_apellidomaternoField;
        
        private string udem_fechadenacimientoField;
        
        private string udem_contactoprincipal_diceserexalumnoField;
        
        private string udem_informacionadicionalField;
        
        private string mobilephoneField;
        
        private string telephone2Field;
        
        private string emailaddress1Field;
        
        private string preferredcontactmethodcodeField;
        
        private string udem_niveldelegadoField;
        
        private string leadqualitycodeField;
        
        private string udem_informacion_parejaField;
        
        private string udem_pareja_diceserexalumnoField;
        
        private string udem_informacion_hijosField;
        
        private string udem_le_fuentedeleadField;
        
        private string udem_le_fuentedelead_subcategoriaField;
        
        private string udem_le_empresaocolegiodelafuenteField;
        
        private string udem_le_referidoField;
        
        private string udem_le_eventocatalogoField;
        
        private string udem_le_otroeventoField;
        
        private string udem_le_fechaeventoField;
        
        private string udem_touch_leField;
        
        private string udem_fechadeultimocontactoField;
        
        private string udem_le_fechaderpoximocontactoField;
        
        private string udem_ultimocomentarioField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string udem_asunto {
            get {
                return this.udem_asuntoField;
            }
            set {
                this.udem_asuntoField = value;
            }
        }
        
        /// <remarks/>
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                this.firstnameField = value;
            }
        }
        
        /// <remarks/>
        public string middlename {
            get {
                return this.middlenameField;
            }
            set {
                this.middlenameField = value;
            }
        }
        
        /// <remarks/>
        public string udem_apellidopaterno {
            get {
                return this.udem_apellidopaternoField;
            }
            set {
                this.udem_apellidopaternoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_apellidomaterno {
            get {
                return this.udem_apellidomaternoField;
            }
            set {
                this.udem_apellidomaternoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_fechadenacimiento {
            get {
                return this.udem_fechadenacimientoField;
            }
            set {
                this.udem_fechadenacimientoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_contactoprincipal_diceserexalumno {
            get {
                return this.udem_contactoprincipal_diceserexalumnoField;
            }
            set {
                this.udem_contactoprincipal_diceserexalumnoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_informacionadicional {
            get {
                return this.udem_informacionadicionalField;
            }
            set {
                this.udem_informacionadicionalField = value;
            }
        }
        
        /// <remarks/>
        public string mobilephone {
            get {
                return this.mobilephoneField;
            }
            set {
                this.mobilephoneField = value;
            }
        }
        
        /// <remarks/>
        public string telephone2 {
            get {
                return this.telephone2Field;
            }
            set {
                this.telephone2Field = value;
            }
        }
        
        /// <remarks/>
        public string emailaddress1 {
            get {
                return this.emailaddress1Field;
            }
            set {
                this.emailaddress1Field = value;
            }
        }
        
        /// <remarks/>
        public string preferredcontactmethodcode {
            get {
                return this.preferredcontactmethodcodeField;
            }
            set {
                this.preferredcontactmethodcodeField = value;
            }
        }
        
        /// <remarks/>
        public string udem_niveldelegado {
            get {
                return this.udem_niveldelegadoField;
            }
            set {
                this.udem_niveldelegadoField = value;
            }
        }
        
        /// <remarks/>
        public string leadqualitycode {
            get {
                return this.leadqualitycodeField;
            }
            set {
                this.leadqualitycodeField = value;
            }
        }
        
        /// <remarks/>
        public string udem_informacion_pareja {
            get {
                return this.udem_informacion_parejaField;
            }
            set {
                this.udem_informacion_parejaField = value;
            }
        }
        
        /// <remarks/>
        public string udem_pareja_diceserexalumno {
            get {
                return this.udem_pareja_diceserexalumnoField;
            }
            set {
                this.udem_pareja_diceserexalumnoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_informacion_hijos {
            get {
                return this.udem_informacion_hijosField;
            }
            set {
                this.udem_informacion_hijosField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_fuentedelead {
            get {
                return this.udem_le_fuentedeleadField;
            }
            set {
                this.udem_le_fuentedeleadField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_fuentedelead_subcategoria {
            get {
                return this.udem_le_fuentedelead_subcategoriaField;
            }
            set {
                this.udem_le_fuentedelead_subcategoriaField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_empresaocolegiodelafuente {
            get {
                return this.udem_le_empresaocolegiodelafuenteField;
            }
            set {
                this.udem_le_empresaocolegiodelafuenteField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_referido {
            get {
                return this.udem_le_referidoField;
            }
            set {
                this.udem_le_referidoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_eventocatalogo {
            get {
                return this.udem_le_eventocatalogoField;
            }
            set {
                this.udem_le_eventocatalogoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_otroevento {
            get {
                return this.udem_le_otroeventoField;
            }
            set {
                this.udem_le_otroeventoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_fechaevento {
            get {
                return this.udem_le_fechaeventoField;
            }
            set {
                this.udem_le_fechaeventoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_touch_le {
            get {
                return this.udem_touch_leField;
            }
            set {
                this.udem_touch_leField = value;
            }
        }
        
        /// <remarks/>
        public string udem_fechadeultimocontacto {
            get {
                return this.udem_fechadeultimocontactoField;
            }
            set {
                this.udem_fechadeultimocontactoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_le_fechaderpoximocontacto {
            get {
                return this.udem_le_fechaderpoximocontactoField;
            }
            set {
                this.udem_le_fechaderpoximocontactoField = value;
            }
        }
        
        /// <remarks/>
        public string udem_ultimocomentario {
            get {
                return this.udem_ultimocomentarioField;
            }
            set {
                this.udem_ultimocomentarioField = value;
            }
        }
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ConsClientePotencialCompletedEventHandler(object sender, ConsClientePotencialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsClientePotencialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsClientePotencialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsClientePotencial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsClientePotencial[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ConsClientePotencialCorreoCompletedEventHandler(object sender, ConsClientePotencialCorreoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsClientePotencialCorreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsClientePotencialCorreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsClientePotencial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsClientePotencial[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591