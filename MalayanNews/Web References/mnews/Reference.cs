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

namespace MalayanNews.mnews {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MalayanNewsServiceBinding", Namespace="http://192.168.1.16/mnews/MNews-server/server.php")]
    public partial class MalayanNewsService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AnnouncementsOperationCompleted;
        
        private System.Threading.SendOrPostCallback AnnouncementOperationCompleted;
        
        private System.Threading.SendOrPostCallback PostAnnouncementOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditAnnouncementOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteAnnouncementOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MalayanNewsService() {
            this.Url = "http://192.168.1.16/mnews/MNews-server/server.php";
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
        public event AnnouncementsCompletedEventHandler AnnouncementsCompleted;
        
        /// <remarks/>
        public event AnnouncementCompletedEventHandler AnnouncementCompleted;
        
        /// <remarks/>
        public event PostAnnouncementCompletedEventHandler PostAnnouncementCompleted;
        
        /// <remarks/>
        public event EditAnnouncementCompletedEventHandler EditAnnouncementCompleted;
        
        /// <remarks/>
        public event DeleteAnnouncementCompletedEventHandler DeleteAnnouncementCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.16/mnews/MNews-server/server.php/Announcements", RequestNamespace="http://192.168.1.16/mnews/MNews-server/server.php", ResponseNamespace="http://192.168.1.16/mnews/MNews-server/server.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public AnnouncementObject[] Announcements() {
            object[] results = this.Invoke("Announcements", new object[0]);
            return ((AnnouncementObject[])(results[0]));
        }
        
        /// <remarks/>
        public void AnnouncementsAsync() {
            this.AnnouncementsAsync(null);
        }
        
        /// <remarks/>
        public void AnnouncementsAsync(object userState) {
            if ((this.AnnouncementsOperationCompleted == null)) {
                this.AnnouncementsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAnnouncementsOperationCompleted);
            }
            this.InvokeAsync("Announcements", new object[0], this.AnnouncementsOperationCompleted, userState);
        }
        
        private void OnAnnouncementsOperationCompleted(object arg) {
            if ((this.AnnouncementsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AnnouncementsCompleted(this, new AnnouncementsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.16/mnews/MNews-server/server.php/Announcement", RequestNamespace="http://192.168.1.16/mnews/MNews-server/server.php", ResponseNamespace="http://192.168.1.16/mnews/MNews-server/server.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public AnnouncementObject Announcement(int idx) {
            object[] results = this.Invoke("Announcement", new object[] {
                        idx});
            return ((AnnouncementObject)(results[0]));
        }
        
        /// <remarks/>
        public void AnnouncementAsync(int idx) {
            this.AnnouncementAsync(idx, null);
        }
        
        /// <remarks/>
        public void AnnouncementAsync(int idx, object userState) {
            if ((this.AnnouncementOperationCompleted == null)) {
                this.AnnouncementOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAnnouncementOperationCompleted);
            }
            this.InvokeAsync("Announcement", new object[] {
                        idx}, this.AnnouncementOperationCompleted, userState);
        }
        
        private void OnAnnouncementOperationCompleted(object arg) {
            if ((this.AnnouncementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AnnouncementCompleted(this, new AnnouncementCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.16/mnews/MNews-server/server.php/PostAnnouncement", RequestNamespace="http://192.168.1.16/mnews/MNews-server/server.php", ResponseNamespace="http://192.168.1.16/mnews/MNews-server/server.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string PostAnnouncement(AnnouncementObject announcement) {
            object[] results = this.Invoke("PostAnnouncement", new object[] {
                        announcement});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PostAnnouncementAsync(AnnouncementObject announcement) {
            this.PostAnnouncementAsync(announcement, null);
        }
        
        /// <remarks/>
        public void PostAnnouncementAsync(AnnouncementObject announcement, object userState) {
            if ((this.PostAnnouncementOperationCompleted == null)) {
                this.PostAnnouncementOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPostAnnouncementOperationCompleted);
            }
            this.InvokeAsync("PostAnnouncement", new object[] {
                        announcement}, this.PostAnnouncementOperationCompleted, userState);
        }
        
        private void OnPostAnnouncementOperationCompleted(object arg) {
            if ((this.PostAnnouncementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PostAnnouncementCompleted(this, new PostAnnouncementCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.16/mnews/MNews-server/server.php/EditAnnouncement", RequestNamespace="http://192.168.1.16/mnews/MNews-server/server.php", ResponseNamespace="http://192.168.1.16/mnews/MNews-server/server.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string EditAnnouncement(AnnouncementObject announcement) {
            object[] results = this.Invoke("EditAnnouncement", new object[] {
                        announcement});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EditAnnouncementAsync(AnnouncementObject announcement) {
            this.EditAnnouncementAsync(announcement, null);
        }
        
        /// <remarks/>
        public void EditAnnouncementAsync(AnnouncementObject announcement, object userState) {
            if ((this.EditAnnouncementOperationCompleted == null)) {
                this.EditAnnouncementOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditAnnouncementOperationCompleted);
            }
            this.InvokeAsync("EditAnnouncement", new object[] {
                        announcement}, this.EditAnnouncementOperationCompleted, userState);
        }
        
        private void OnEditAnnouncementOperationCompleted(object arg) {
            if ((this.EditAnnouncementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditAnnouncementCompleted(this, new EditAnnouncementCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.16/mnews/MNews-server/server.php/DeleteAnnouncement", RequestNamespace="http://192.168.1.16/mnews/MNews-server/server.php", ResponseNamespace="http://192.168.1.16/mnews/MNews-server/server.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string DeleteAnnouncement(int idx) {
            object[] results = this.Invoke("DeleteAnnouncement", new object[] {
                        idx});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteAnnouncementAsync(int idx) {
            this.DeleteAnnouncementAsync(idx, null);
        }
        
        /// <remarks/>
        public void DeleteAnnouncementAsync(int idx, object userState) {
            if ((this.DeleteAnnouncementOperationCompleted == null)) {
                this.DeleteAnnouncementOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteAnnouncementOperationCompleted);
            }
            this.InvokeAsync("DeleteAnnouncement", new object[] {
                        idx}, this.DeleteAnnouncementOperationCompleted, userState);
        }
        
        private void OnDeleteAnnouncementOperationCompleted(object arg) {
            if ((this.DeleteAnnouncementCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteAnnouncementCompleted(this, new DeleteAnnouncementCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://192.168.1.16/mnews/MNews-server/server.php")]
    public partial class AnnouncementObject {
        
        private int idField;
        
        private string subjectField;
        
        private string uploadDateField;
        
        private string contentField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        public string uploadDate {
            get {
                return this.uploadDateField;
            }
            set {
                this.uploadDateField = value;
            }
        }
        
        /// <remarks/>
        public string content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AnnouncementsCompletedEventHandler(object sender, AnnouncementsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AnnouncementsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AnnouncementsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AnnouncementObject[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AnnouncementObject[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AnnouncementCompletedEventHandler(object sender, AnnouncementCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AnnouncementCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AnnouncementCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AnnouncementObject Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AnnouncementObject)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void PostAnnouncementCompletedEventHandler(object sender, PostAnnouncementCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PostAnnouncementCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PostAnnouncementCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EditAnnouncementCompletedEventHandler(object sender, EditAnnouncementCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditAnnouncementCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditAnnouncementCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteAnnouncementCompletedEventHandler(object sender, DeleteAnnouncementCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteAnnouncementCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteAnnouncementCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591