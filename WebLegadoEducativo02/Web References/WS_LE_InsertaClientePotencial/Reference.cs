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

namespace WebLegadoEducativo02.WS_LE_InsertaClientePotencial {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_InsertaClientePotencialSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_InsertaClientePotencial : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsClientPotencialOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalificaLeadOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_InsertaClientePotencial() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_InsertaClientePotencial_WS_LE_InsertaClientePotencial;
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
        public event InsClientPotencialCompletedEventHandler InsClientPotencialCompleted;
        
        /// <remarks/>
        public event CalificaLeadCompletedEventHandler CalificaLeadCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsClientPotencial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta InsClientPotencial(
                    string udem_asunto, 
                    string firstname, 
                    string middlename, 
                    string udem_apellidopaterno, 
                    string udem_apellidomaterno, 
                    string udem_fechadenacimiento, 
                    string udem_contactoprincipal_diceserexalumno, 
                    string udem_informacionadicional, 
                    string udem_informacion_pareja, 
                    string udem_pareja_diceserexalumno, 
                    string udem_informacion_hijos, 
                    string mobilephone, 
                    string telephone2, 
                    string telephone1, 
                    string emailaddress1, 
                    string preferredcontactmethodcode, 
                    string udem_niveldelegado, 
                    string leadqualitycode, 
                    string udem_le_fuentedelead, 
                    string udem_le_fuentedelead_subcategoria, 
                    string udem_le_empresaocolegiodelafuente, 
                    string udem_le_otrafuentedelead, 
                    string udem_le_referido, 
                    string udem_le_evento, 
                    string udem_le_eventocatalogo, 
                    string udem_le_otroevento, 
                    string udem_le_fechaevento, 
                    string udem_matricula, 
                    string udem_area) {
            object[] results = this.Invoke("InsClientPotencial", new object[] {
                        udem_asunto,
                        firstname,
                        middlename,
                        udem_apellidopaterno,
                        udem_apellidomaterno,
                        udem_fechadenacimiento,
                        udem_contactoprincipal_diceserexalumno,
                        udem_informacionadicional,
                        udem_informacion_pareja,
                        udem_pareja_diceserexalumno,
                        udem_informacion_hijos,
                        mobilephone,
                        telephone2,
                        telephone1,
                        emailaddress1,
                        preferredcontactmethodcode,
                        udem_niveldelegado,
                        leadqualitycode,
                        udem_le_fuentedelead,
                        udem_le_fuentedelead_subcategoria,
                        udem_le_empresaocolegiodelafuente,
                        udem_le_otrafuentedelead,
                        udem_le_referido,
                        udem_le_evento,
                        udem_le_eventocatalogo,
                        udem_le_otroevento,
                        udem_le_fechaevento,
                        udem_matricula,
                        udem_area});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void InsClientPotencialAsync(
                    string udem_asunto, 
                    string firstname, 
                    string middlename, 
                    string udem_apellidopaterno, 
                    string udem_apellidomaterno, 
                    string udem_fechadenacimiento, 
                    string udem_contactoprincipal_diceserexalumno, 
                    string udem_informacionadicional, 
                    string udem_informacion_pareja, 
                    string udem_pareja_diceserexalumno, 
                    string udem_informacion_hijos, 
                    string mobilephone, 
                    string telephone2, 
                    string telephone1, 
                    string emailaddress1, 
                    string preferredcontactmethodcode, 
                    string udem_niveldelegado, 
                    string leadqualitycode, 
                    string udem_le_fuentedelead, 
                    string udem_le_fuentedelead_subcategoria, 
                    string udem_le_empresaocolegiodelafuente, 
                    string udem_le_otrafuentedelead, 
                    string udem_le_referido, 
                    string udem_le_evento, 
                    string udem_le_eventocatalogo, 
                    string udem_le_otroevento, 
                    string udem_le_fechaevento, 
                    string udem_matricula, 
                    string udem_area) {
            this.InsClientPotencialAsync(udem_asunto, firstname, middlename, udem_apellidopaterno, udem_apellidomaterno, udem_fechadenacimiento, udem_contactoprincipal_diceserexalumno, udem_informacionadicional, udem_informacion_pareja, udem_pareja_diceserexalumno, udem_informacion_hijos, mobilephone, telephone2, telephone1, emailaddress1, preferredcontactmethodcode, udem_niveldelegado, leadqualitycode, udem_le_fuentedelead, udem_le_fuentedelead_subcategoria, udem_le_empresaocolegiodelafuente, udem_le_otrafuentedelead, udem_le_referido, udem_le_evento, udem_le_eventocatalogo, udem_le_otroevento, udem_le_fechaevento, udem_matricula, udem_area, null);
        }
        
        /// <remarks/>
        public void InsClientPotencialAsync(
                    string udem_asunto, 
                    string firstname, 
                    string middlename, 
                    string udem_apellidopaterno, 
                    string udem_apellidomaterno, 
                    string udem_fechadenacimiento, 
                    string udem_contactoprincipal_diceserexalumno, 
                    string udem_informacionadicional, 
                    string udem_informacion_pareja, 
                    string udem_pareja_diceserexalumno, 
                    string udem_informacion_hijos, 
                    string mobilephone, 
                    string telephone2, 
                    string telephone1, 
                    string emailaddress1, 
                    string preferredcontactmethodcode, 
                    string udem_niveldelegado, 
                    string leadqualitycode, 
                    string udem_le_fuentedelead, 
                    string udem_le_fuentedelead_subcategoria, 
                    string udem_le_empresaocolegiodelafuente, 
                    string udem_le_otrafuentedelead, 
                    string udem_le_referido, 
                    string udem_le_evento, 
                    string udem_le_eventocatalogo, 
                    string udem_le_otroevento, 
                    string udem_le_fechaevento, 
                    string udem_matricula, 
                    string udem_area, 
                    object userState) {
            if ((this.InsClientPotencialOperationCompleted == null)) {
                this.InsClientPotencialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsClientPotencialOperationCompleted);
            }
            this.InvokeAsync("InsClientPotencial", new object[] {
                        udem_asunto,
                        firstname,
                        middlename,
                        udem_apellidopaterno,
                        udem_apellidomaterno,
                        udem_fechadenacimiento,
                        udem_contactoprincipal_diceserexalumno,
                        udem_informacionadicional,
                        udem_informacion_pareja,
                        udem_pareja_diceserexalumno,
                        udem_informacion_hijos,
                        mobilephone,
                        telephone2,
                        telephone1,
                        emailaddress1,
                        preferredcontactmethodcode,
                        udem_niveldelegado,
                        leadqualitycode,
                        udem_le_fuentedelead,
                        udem_le_fuentedelead_subcategoria,
                        udem_le_empresaocolegiodelafuente,
                        udem_le_otrafuentedelead,
                        udem_le_referido,
                        udem_le_evento,
                        udem_le_eventocatalogo,
                        udem_le_otroevento,
                        udem_le_fechaevento,
                        udem_matricula,
                        udem_area}, this.InsClientPotencialOperationCompleted, userState);
        }
        
        private void OnInsClientPotencialOperationCompleted(object arg) {
            if ((this.InsClientPotencialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsClientPotencialCompleted(this, new InsClientPotencialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalificaLead", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta CalificaLead(string Lead) {
            object[] results = this.Invoke("CalificaLead", new object[] {
                        Lead});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void CalificaLeadAsync(string Lead) {
            this.CalificaLeadAsync(Lead, null);
        }
        
        /// <remarks/>
        public void CalificaLeadAsync(string Lead, object userState) {
            if ((this.CalificaLeadOperationCompleted == null)) {
                this.CalificaLeadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalificaLeadOperationCompleted);
            }
            this.InvokeAsync("CalificaLead", new object[] {
                        Lead}, this.CalificaLeadOperationCompleted, userState);
        }
        
        private void OnCalificaLeadOperationCompleted(object arg) {
            if ((this.CalificaLeadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalificaLeadCompleted(this, new CalificaLeadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void InsClientPotencialCompletedEventHandler(object sender, InsClientPotencialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsClientPotencialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsClientPotencialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void CalificaLeadCompletedEventHandler(object sender, CalificaLeadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalificaLeadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalificaLeadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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