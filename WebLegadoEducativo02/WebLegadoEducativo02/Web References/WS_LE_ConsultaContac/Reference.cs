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

namespace WebLegadoEducativo02.WS_LE_ConsultaContac {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsultaContacSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsultaContac : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsultaContactOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultaContactMatriculaOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultaContactCorreoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsultaContac() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsultaContac_WS_LE_ConsultaContac;
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
        public event ConsultaContactCompletedEventHandler ConsultaContactCompleted;
        
        /// <remarks/>
        public event ConsultaContactMatriculaCompletedEventHandler ConsultaContactMatriculaCompleted;
        
        /// <remarks/>
        public event ConsultaContactCorreoCompletedEventHandler ConsultaContactCorreoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsultaContact", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Recuperacontact[] ConsultaContact(string folio, string nombre) {
            object[] results = this.Invoke("ConsultaContact", new object[] {
                        folio,
                        nombre});
            return ((Recuperacontact[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultaContactAsync(string folio, string nombre) {
            this.ConsultaContactAsync(folio, nombre, null);
        }
        
        /// <remarks/>
        public void ConsultaContactAsync(string folio, string nombre, object userState) {
            if ((this.ConsultaContactOperationCompleted == null)) {
                this.ConsultaContactOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultaContactOperationCompleted);
            }
            this.InvokeAsync("ConsultaContact", new object[] {
                        folio,
                        nombre}, this.ConsultaContactOperationCompleted, userState);
        }
        
        private void OnConsultaContactOperationCompleted(object arg) {
            if ((this.ConsultaContactCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultaContactCompleted(this, new ConsultaContactCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsultaContactMatricula", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Recuperacontact[] ConsultaContactMatricula(string folio) {
            object[] results = this.Invoke("ConsultaContactMatricula", new object[] {
                        folio});
            return ((Recuperacontact[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultaContactMatriculaAsync(string folio) {
            this.ConsultaContactMatriculaAsync(folio, null);
        }
        
        /// <remarks/>
        public void ConsultaContactMatriculaAsync(string folio, object userState) {
            if ((this.ConsultaContactMatriculaOperationCompleted == null)) {
                this.ConsultaContactMatriculaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultaContactMatriculaOperationCompleted);
            }
            this.InvokeAsync("ConsultaContactMatricula", new object[] {
                        folio}, this.ConsultaContactMatriculaOperationCompleted, userState);
        }
        
        private void OnConsultaContactMatriculaOperationCompleted(object arg) {
            if ((this.ConsultaContactMatriculaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultaContactMatriculaCompleted(this, new ConsultaContactMatriculaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsultaContactCorreo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Recuperacontact[] ConsultaContactCorreo(string Correo, string dummy1, string dummy2) {
            object[] results = this.Invoke("ConsultaContactCorreo", new object[] {
                        Correo,
                        dummy1,
                        dummy2});
            return ((Recuperacontact[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultaContactCorreoAsync(string Correo, string dummy1, string dummy2) {
            this.ConsultaContactCorreoAsync(Correo, dummy1, dummy2, null);
        }
        
        /// <remarks/>
        public void ConsultaContactCorreoAsync(string Correo, string dummy1, string dummy2, object userState) {
            if ((this.ConsultaContactCorreoOperationCompleted == null)) {
                this.ConsultaContactCorreoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultaContactCorreoOperationCompleted);
            }
            this.InvokeAsync("ConsultaContactCorreo", new object[] {
                        Correo,
                        dummy1,
                        dummy2}, this.ConsultaContactCorreoOperationCompleted, userState);
        }
        
        private void OnConsultaContactCorreoOperationCompleted(object arg) {
            if ((this.ConsultaContactCorreoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultaContactCorreoCompleted(this, new ConsultaContactCorreoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Recuperacontact {
        
        private string udem_folioudemField;
        
        private string owneridField;
        
        private string fullnameField;
        
        private string firstnameField;
        
        private string middlenameField;
        
        private string new_apellidopaternoField;
        
        private string new_apellidomaternoField;
        
        private string new_fechacompletanacimientoField;
        
        private string recr_diadenacimientoField;
        
        private string new_mesdenacimientoField;
        
        private string recr_udem_anodenacimientoField;
        
        private string address1_line1Field;
        
        private string address1_line2Field;
        
        private string recr_codigopostalField;
        
        private string address1_line3Field;
        
        private string new_estadodecontactoField;
        
        private string new_municipiodecontactoField;
        
        private string new_paisdecontactoField;
        
        private string mobilephoneField;
        
        private string telephone2Field;
        
        private string udem_telefonodecasaField;
        
        private string telephone1Field;
        
        private string emailaddress1Field;
        
        private string new_facebookField;
        
        private string new_twitterField;
        
        private string new_instagramField;
        
        private string new_linkedinField;
        
        private string new_otraredsocialField;
        
        private string contactidField;
        
        private string new_exalumnoField;
        
        private string new_padredefamiliaalumnoField;
        
        private string new_padredefamiliaegresadoField;
        
        private string new_colaboradorField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string udem_folioudem {
            get {
                return this.udem_folioudemField;
            }
            set {
                this.udem_folioudemField = value;
            }
        }
        
        /// <remarks/>
        public string ownerid {
            get {
                return this.owneridField;
            }
            set {
                this.owneridField = value;
            }
        }
        
        /// <remarks/>
        public string fullname {
            get {
                return this.fullnameField;
            }
            set {
                this.fullnameField = value;
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
        public string new_apellidopaterno {
            get {
                return this.new_apellidopaternoField;
            }
            set {
                this.new_apellidopaternoField = value;
            }
        }
        
        /// <remarks/>
        public string new_apellidomaterno {
            get {
                return this.new_apellidomaternoField;
            }
            set {
                this.new_apellidomaternoField = value;
            }
        }
        
        /// <remarks/>
        public string new_fechacompletanacimiento {
            get {
                return this.new_fechacompletanacimientoField;
            }
            set {
                this.new_fechacompletanacimientoField = value;
            }
        }
        
        /// <remarks/>
        public string recr_diadenacimiento {
            get {
                return this.recr_diadenacimientoField;
            }
            set {
                this.recr_diadenacimientoField = value;
            }
        }
        
        /// <remarks/>
        public string new_mesdenacimiento {
            get {
                return this.new_mesdenacimientoField;
            }
            set {
                this.new_mesdenacimientoField = value;
            }
        }
        
        /// <remarks/>
        public string recr_udem_anodenacimiento {
            get {
                return this.recr_udem_anodenacimientoField;
            }
            set {
                this.recr_udem_anodenacimientoField = value;
            }
        }
        
        /// <remarks/>
        public string address1_line1 {
            get {
                return this.address1_line1Field;
            }
            set {
                this.address1_line1Field = value;
            }
        }
        
        /// <remarks/>
        public string address1_line2 {
            get {
                return this.address1_line2Field;
            }
            set {
                this.address1_line2Field = value;
            }
        }
        
        /// <remarks/>
        public string recr_codigopostal {
            get {
                return this.recr_codigopostalField;
            }
            set {
                this.recr_codigopostalField = value;
            }
        }
        
        /// <remarks/>
        public string address1_line3 {
            get {
                return this.address1_line3Field;
            }
            set {
                this.address1_line3Field = value;
            }
        }
        
        /// <remarks/>
        public string new_estadodecontacto {
            get {
                return this.new_estadodecontactoField;
            }
            set {
                this.new_estadodecontactoField = value;
            }
        }
        
        /// <remarks/>
        public string new_municipiodecontacto {
            get {
                return this.new_municipiodecontactoField;
            }
            set {
                this.new_municipiodecontactoField = value;
            }
        }
        
        /// <remarks/>
        public string new_paisdecontacto {
            get {
                return this.new_paisdecontactoField;
            }
            set {
                this.new_paisdecontactoField = value;
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
        public string udem_telefonodecasa {
            get {
                return this.udem_telefonodecasaField;
            }
            set {
                this.udem_telefonodecasaField = value;
            }
        }
        
        /// <remarks/>
        public string telephone1 {
            get {
                return this.telephone1Field;
            }
            set {
                this.telephone1Field = value;
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
        public string new_facebook {
            get {
                return this.new_facebookField;
            }
            set {
                this.new_facebookField = value;
            }
        }
        
        /// <remarks/>
        public string new_twitter {
            get {
                return this.new_twitterField;
            }
            set {
                this.new_twitterField = value;
            }
        }
        
        /// <remarks/>
        public string new_instagram {
            get {
                return this.new_instagramField;
            }
            set {
                this.new_instagramField = value;
            }
        }
        
        /// <remarks/>
        public string new_linkedin {
            get {
                return this.new_linkedinField;
            }
            set {
                this.new_linkedinField = value;
            }
        }
        
        /// <remarks/>
        public string new_otraredsocial {
            get {
                return this.new_otraredsocialField;
            }
            set {
                this.new_otraredsocialField = value;
            }
        }
        
        /// <remarks/>
        public string contactid {
            get {
                return this.contactidField;
            }
            set {
                this.contactidField = value;
            }
        }
        
        /// <remarks/>
        public string new_exalumno {
            get {
                return this.new_exalumnoField;
            }
            set {
                this.new_exalumnoField = value;
            }
        }
        
        /// <remarks/>
        public string new_padredefamiliaalumno {
            get {
                return this.new_padredefamiliaalumnoField;
            }
            set {
                this.new_padredefamiliaalumnoField = value;
            }
        }
        
        /// <remarks/>
        public string new_padredefamiliaegresado {
            get {
                return this.new_padredefamiliaegresadoField;
            }
            set {
                this.new_padredefamiliaegresadoField = value;
            }
        }
        
        /// <remarks/>
        public string new_colaborador {
            get {
                return this.new_colaboradorField;
            }
            set {
                this.new_colaboradorField = value;
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
    public delegate void ConsultaContactCompletedEventHandler(object sender, ConsultaContactCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultaContactCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultaContactCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Recuperacontact[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Recuperacontact[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ConsultaContactMatriculaCompletedEventHandler(object sender, ConsultaContactMatriculaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultaContactMatriculaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultaContactMatriculaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Recuperacontact[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Recuperacontact[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ConsultaContactCorreoCompletedEventHandler(object sender, ConsultaContactCorreoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultaContactCorreoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultaContactCorreoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Recuperacontact[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Recuperacontact[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591