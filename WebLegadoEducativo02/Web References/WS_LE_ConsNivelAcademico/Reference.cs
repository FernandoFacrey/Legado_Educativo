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

namespace WebLegadoEducativo02.WS_LE_ConsNivelAcademico {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsNivelAcademicoSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsNivelAcademico : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConNivelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsNivelAcademico() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsNivelAcademico_WS_LE_ConsNivelAcademico;
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
        public event ConNivelCompletedEventHandler ConNivelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConNivel", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsNivelAcademico[] ConNivel(string niv) {
            object[] results = this.Invoke("ConNivel", new object[] {
                        niv});
            return ((CsNivelAcademico[])(results[0]));
        }
        
        /// <remarks/>
        public void ConNivelAsync(string niv) {
            this.ConNivelAsync(niv, null);
        }
        
        /// <remarks/>
        public void ConNivelAsync(string niv, object userState) {
            if ((this.ConNivelOperationCompleted == null)) {
                this.ConNivelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConNivelOperationCompleted);
            }
            this.InvokeAsync("ConNivel", new object[] {
                        niv}, this.ConNivelOperationCompleted, userState);
        }
        
        private void OnConNivelOperationCompleted(object arg) {
            if ((this.ConNivelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConNivelCompleted(this, new ConNivelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class CsNivelAcademico {
        
        private string new_siglasField;
        
        private string new_nivelacademicoidField;
        
        private string new_nivelField;
        
        private string new_nivelacademicoField;
        
        private string new_verenwebField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string new_siglas {
            get {
                return this.new_siglasField;
            }
            set {
                this.new_siglasField = value;
            }
        }
        
        /// <remarks/>
        public string new_nivelacademicoid {
            get {
                return this.new_nivelacademicoidField;
            }
            set {
                this.new_nivelacademicoidField = value;
            }
        }
        
        /// <remarks/>
        public string new_nivel {
            get {
                return this.new_nivelField;
            }
            set {
                this.new_nivelField = value;
            }
        }
        
        /// <remarks/>
        public string new_nivelacademico {
            get {
                return this.new_nivelacademicoField;
            }
            set {
                this.new_nivelacademicoField = value;
            }
        }
        
        /// <remarks/>
        public string new_verenweb {
            get {
                return this.new_verenwebField;
            }
            set {
                this.new_verenwebField = value;
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
    public delegate void ConNivelCompletedEventHandler(object sender, ConNivelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConNivelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConNivelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsNivelAcademico[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsNivelAcademico[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591