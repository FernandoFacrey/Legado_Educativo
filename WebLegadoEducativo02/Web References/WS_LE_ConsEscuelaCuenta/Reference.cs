﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebLegadoEducativo02.WS_LE_ConsEscuelaCuenta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsEscuelaCuentaSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsEscuelaCuenta : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsEscuelaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsEscuelaCuenta() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsEscuelaCuenta_WS_LE_ConsEscuelaCuenta;
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
        public event ConsEscuelaCompletedEventHandler ConsEscuelaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsEscuela", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsEscuelaCuenta[] ConsEscuela(string Nivel) {
            object[] results = this.Invoke("ConsEscuela", new object[] {
                        Nivel});
            return ((CsEscuelaCuenta[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsEscuelaAsync(string Nivel) {
            this.ConsEscuelaAsync(Nivel, null);
        }
        
        /// <remarks/>
        public void ConsEscuelaAsync(string Nivel, object userState) {
            if ((this.ConsEscuelaOperationCompleted == null)) {
                this.ConsEscuelaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsEscuelaOperationCompleted);
            }
            this.InvokeAsync("ConsEscuela", new object[] {
                        Nivel}, this.ConsEscuelaOperationCompleted, userState);
        }
        
        private void OnConsEscuelaOperationCompleted(object arg) {
            if ((this.ConsEscuelaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsEscuelaCompleted(this, new ConsEscuelaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CsEscuelaCuenta {
        
        private string accountidField;
        
        private string recr_nivelidField;
        
        private string nameField;
        
        private string recr_codigopostalField;
        
        private string address1_cityField;
        
        private string address1_line3_colField;
        
        private string recr_clavedelainstitucionField;
        
        private string recr_tipodeorganizacionField;
        
        private string address1_stateorprovinceField;
        
        private string new_municipioField;
        
        private string new_paisField;
        
        private string recr_publicaoprivadaField;
        
        private string recr_religiosanoreligiosaField;
        
        private string recr_eficienciaterminalField;
        
        private string recr_segmentoField;
        
        private string recr_niveldecolegiaturaField;
        
        private string owneridField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string accountid {
            get {
                return this.accountidField;
            }
            set {
                this.accountidField = value;
            }
        }
        
        /// <remarks/>
        public string recr_nivelid {
            get {
                return this.recr_nivelidField;
            }
            set {
                this.recr_nivelidField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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
        public string address1_city {
            get {
                return this.address1_cityField;
            }
            set {
                this.address1_cityField = value;
            }
        }
        
        /// <remarks/>
        public string address1_line3_col {
            get {
                return this.address1_line3_colField;
            }
            set {
                this.address1_line3_colField = value;
            }
        }
        
        /// <remarks/>
        public string recr_clavedelainstitucion {
            get {
                return this.recr_clavedelainstitucionField;
            }
            set {
                this.recr_clavedelainstitucionField = value;
            }
        }
        
        /// <remarks/>
        public string recr_tipodeorganizacion {
            get {
                return this.recr_tipodeorganizacionField;
            }
            set {
                this.recr_tipodeorganizacionField = value;
            }
        }
        
        /// <remarks/>
        public string address1_stateorprovince {
            get {
                return this.address1_stateorprovinceField;
            }
            set {
                this.address1_stateorprovinceField = value;
            }
        }
        
        /// <remarks/>
        public string new_municipio {
            get {
                return this.new_municipioField;
            }
            set {
                this.new_municipioField = value;
            }
        }
        
        /// <remarks/>
        public string new_pais {
            get {
                return this.new_paisField;
            }
            set {
                this.new_paisField = value;
            }
        }
        
        /// <remarks/>
        public string recr_publicaoprivada {
            get {
                return this.recr_publicaoprivadaField;
            }
            set {
                this.recr_publicaoprivadaField = value;
            }
        }
        
        /// <remarks/>
        public string recr_religiosanoreligiosa {
            get {
                return this.recr_religiosanoreligiosaField;
            }
            set {
                this.recr_religiosanoreligiosaField = value;
            }
        }
        
        /// <remarks/>
        public string recr_eficienciaterminal {
            get {
                return this.recr_eficienciaterminalField;
            }
            set {
                this.recr_eficienciaterminalField = value;
            }
        }
        
        /// <remarks/>
        public string recr_segmento {
            get {
                return this.recr_segmentoField;
            }
            set {
                this.recr_segmentoField = value;
            }
        }
        
        /// <remarks/>
        public string recr_niveldecolegiatura {
            get {
                return this.recr_niveldecolegiaturaField;
            }
            set {
                this.recr_niveldecolegiaturaField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ConsEscuelaCompletedEventHandler(object sender, ConsEscuelaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsEscuelaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsEscuelaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsEscuelaCuenta[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsEscuelaCuenta[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591