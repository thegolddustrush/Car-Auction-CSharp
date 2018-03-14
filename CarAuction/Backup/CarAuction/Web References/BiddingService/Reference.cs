﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1008.
// 
#pragma warning disable 1591

namespace CarAuction.BiddingService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BiddingDataServiceSoap", Namespace="http://tempuri.org/")]
    public partial class BiddingDataService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback SellCarOperationCompleted;
        
        private System.Threading.SendOrPostCallback ForgottenPasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback ChangePasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback ChangeDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback BidCarOperationCompleted;
        
        private System.Threading.SendOrPostCallback UserNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BiddingDataService() {
            this.Url = global::CarAuction.Properties.Settings.Default.CarAuction_BiddingService_BiddingDataService;
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
        public event AddUserCompletedEventHandler AddUserCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event SellCarCompletedEventHandler SellCarCompleted;
        
        /// <remarks/>
        public event ForgottenPasswordCompletedEventHandler ForgottenPasswordCompleted;
        
        /// <remarks/>
        public event ChangePasswordCompletedEventHandler ChangePasswordCompleted;
        
        /// <remarks/>
        public event ChangeDetailsCompletedEventHandler ChangeDetailsCompleted;
        
        /// <remarks/>
        public event GetUserIDCompletedEventHandler GetUserIDCompleted;
        
        /// <remarks/>
        public event BidCarCompletedEventHandler BidCarCompleted;
        
        /// <remarks/>
        public event UserNameCompletedEventHandler UserNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddUser(string name, string surname, string email, string password, string question, string DOB, string answer) {
            object[] results = this.Invoke("AddUser", new object[] {
                        name,
                        surname,
                        email,
                        password,
                        question,
                        DOB,
                        answer});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddUserAsync(string name, string surname, string email, string password, string question, string DOB, string answer) {
            this.AddUserAsync(name, surname, email, password, question, DOB, answer, null);
        }
        
        /// <remarks/>
        public void AddUserAsync(string name, string surname, string email, string password, string question, string DOB, string answer, object userState) {
            if ((this.AddUserOperationCompleted == null)) {
                this.AddUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddUserOperationCompleted);
            }
            this.InvokeAsync("AddUser", new object[] {
                        name,
                        surname,
                        email,
                        password,
                        question,
                        DOB,
                        answer}, this.AddUserOperationCompleted, userState);
        }
        
        private void OnAddUserOperationCompleted(object arg) {
            if ((this.AddUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddUserCompleted(this, new AddUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Login(string email, string password) {
            object[] results = this.Invoke("Login", new object[] {
                        email,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string email, string password) {
            this.LoginAsync(email, password, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string email, string password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        email,
                        password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SellCar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SellCar(string description, string brand, string model, string year, int startBid, int kilometer, string closeDate, int value, string image) {
            object[] results = this.Invoke("SellCar", new object[] {
                        description,
                        brand,
                        model,
                        year,
                        startBid,
                        kilometer,
                        closeDate,
                        value,
                        image});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SellCarAsync(string description, string brand, string model, string year, int startBid, int kilometer, string closeDate, int value, string image) {
            this.SellCarAsync(description, brand, model, year, startBid, kilometer, closeDate, value, image, null);
        }
        
        /// <remarks/>
        public void SellCarAsync(string description, string brand, string model, string year, int startBid, int kilometer, string closeDate, int value, string image, object userState) {
            if ((this.SellCarOperationCompleted == null)) {
                this.SellCarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSellCarOperationCompleted);
            }
            this.InvokeAsync("SellCar", new object[] {
                        description,
                        brand,
                        model,
                        year,
                        startBid,
                        kilometer,
                        closeDate,
                        value,
                        image}, this.SellCarOperationCompleted, userState);
        }
        
        private void OnSellCarOperationCompleted(object arg) {
            if ((this.SellCarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SellCarCompleted(this, new SellCarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ForgottenPassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ForgottenPassword(string password, string question, string answer, string email) {
            object[] results = this.Invoke("ForgottenPassword", new object[] {
                        password,
                        question,
                        answer,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ForgottenPasswordAsync(string password, string question, string answer, string email) {
            this.ForgottenPasswordAsync(password, question, answer, email, null);
        }
        
        /// <remarks/>
        public void ForgottenPasswordAsync(string password, string question, string answer, string email, object userState) {
            if ((this.ForgottenPasswordOperationCompleted == null)) {
                this.ForgottenPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnForgottenPasswordOperationCompleted);
            }
            this.InvokeAsync("ForgottenPassword", new object[] {
                        password,
                        question,
                        answer,
                        email}, this.ForgottenPasswordOperationCompleted, userState);
        }
        
        private void OnForgottenPasswordOperationCompleted(object arg) {
            if ((this.ForgottenPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ForgottenPasswordCompleted(this, new ForgottenPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ChangePassword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ChangePassword(string password, string email, string question, string answer) {
            object[] results = this.Invoke("ChangePassword", new object[] {
                        password,
                        email,
                        question,
                        answer});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ChangePasswordAsync(string password, string email, string question, string answer) {
            this.ChangePasswordAsync(password, email, question, answer, null);
        }
        
        /// <remarks/>
        public void ChangePasswordAsync(string password, string email, string question, string answer, object userState) {
            if ((this.ChangePasswordOperationCompleted == null)) {
                this.ChangePasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangePasswordOperationCompleted);
            }
            this.InvokeAsync("ChangePassword", new object[] {
                        password,
                        email,
                        question,
                        answer}, this.ChangePasswordOperationCompleted, userState);
        }
        
        private void OnChangePasswordOperationCompleted(object arg) {
            if ((this.ChangePasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangePasswordCompleted(this, new ChangePasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ChangeDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ChangeDetails(string name, string surname, string email, string question, string answer, string password) {
            object[] results = this.Invoke("ChangeDetails", new object[] {
                        name,
                        surname,
                        email,
                        question,
                        answer,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ChangeDetailsAsync(string name, string surname, string email, string question, string answer, string password) {
            this.ChangeDetailsAsync(name, surname, email, question, answer, password, null);
        }
        
        /// <remarks/>
        public void ChangeDetailsAsync(string name, string surname, string email, string question, string answer, string password, object userState) {
            if ((this.ChangeDetailsOperationCompleted == null)) {
                this.ChangeDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeDetailsOperationCompleted);
            }
            this.InvokeAsync("ChangeDetails", new object[] {
                        name,
                        surname,
                        email,
                        question,
                        answer,
                        password}, this.ChangeDetailsOperationCompleted, userState);
        }
        
        private void OnChangeDetailsOperationCompleted(object arg) {
            if ((this.ChangeDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeDetailsCompleted(this, new ChangeDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetUserID(string email, string password) {
            object[] results = this.Invoke("GetUserID", new object[] {
                        email,
                        password});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserIDAsync(string email, string password) {
            this.GetUserIDAsync(email, password, null);
        }
        
        /// <remarks/>
        public void GetUserIDAsync(string email, string password, object userState) {
            if ((this.GetUserIDOperationCompleted == null)) {
                this.GetUserIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserIDOperationCompleted);
            }
            this.InvokeAsync("GetUserID", new object[] {
                        email,
                        password}, this.GetUserIDOperationCompleted, userState);
        }
        
        private void OnGetUserIDOperationCompleted(object arg) {
            if ((this.GetUserIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserIDCompleted(this, new GetUserIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BidCar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int BidCar(int useID, int carID, int BidValue) {
            object[] results = this.Invoke("BidCar", new object[] {
                        useID,
                        carID,
                        BidValue});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void BidCarAsync(int useID, int carID, int BidValue) {
            this.BidCarAsync(useID, carID, BidValue, null);
        }
        
        /// <remarks/>
        public void BidCarAsync(int useID, int carID, int BidValue, object userState) {
            if ((this.BidCarOperationCompleted == null)) {
                this.BidCarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBidCarOperationCompleted);
            }
            this.InvokeAsync("BidCar", new object[] {
                        useID,
                        carID,
                        BidValue}, this.BidCarOperationCompleted, userState);
        }
        
        private void OnBidCarOperationCompleted(object arg) {
            if ((this.BidCarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BidCarCompleted(this, new BidCarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserName", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UserName(string email, string password) {
            object[] results = this.Invoke("UserName", new object[] {
                        email,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UserNameAsync(string email, string password) {
            this.UserNameAsync(email, password, null);
        }
        
        /// <remarks/>
        public void UserNameAsync(string email, string password, object userState) {
            if ((this.UserNameOperationCompleted == null)) {
                this.UserNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserNameOperationCompleted);
            }
            this.InvokeAsync("UserName", new object[] {
                        email,
                        password}, this.UserNameOperationCompleted, userState);
        }
        
        private void OnUserNameOperationCompleted(object arg) {
            if ((this.UserNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UserNameCompleted(this, new UserNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddUserCompletedEventHandler(object sender, AddUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void SellCarCompletedEventHandler(object sender, SellCarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SellCarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SellCarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ForgottenPasswordCompletedEventHandler(object sender, ForgottenPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ForgottenPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ForgottenPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ChangePasswordCompletedEventHandler(object sender, ChangePasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ChangePasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ChangePasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ChangeDetailsCompletedEventHandler(object sender, ChangeDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ChangeDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ChangeDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetUserIDCompletedEventHandler(object sender, GetUserIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void BidCarCompletedEventHandler(object sender, BidCarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BidCarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BidCarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void UserNameCompletedEventHandler(object sender, UserNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UserNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UserNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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