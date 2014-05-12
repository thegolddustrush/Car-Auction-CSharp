<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="loginPg2.aspx.cs" Inherits="CarAuction.loginPg2" %>



<html>
<head runat="server">
    <title></title>
</head>
<body>
    

<asp:Content ID="LogoImage" runat="server" ContentPlaceHolderID="LogoContent">
    <img style="width:20%; height: 20% " alt="Logo" src="online-auction.jpg" />
</asp:Content>

<asp:Content ID="SignInContent" runat="server" ContentPlaceHolderID="LoginContent">
   <form id="Form1" runat="server" class="pure-form-login" style="padding-left: 50px; font-size:X-Small;">
        <fieldset style="width: auto">
            <legend>Login</legend>
            <asp:TextBox  ID="txtBoxLoginEmail" runat="server" type="text" 
                placeholder="Email" Font-Size="X-Small" />
            <asp:TextBox  ID="txtBoxLoginPassword" runat="server" type="password" 
                placeholder="Password"  style="Font-Size:X-Small; height:auto;" 
                ontextchanged="TextBoxLoginPassword_TextChanged"/>
            <label for="remember" style="Font-Size:X-Small">
                <input id="chkboxRememberMe" type="checkbox"/>
                Remember me
            </label>
            <asp:button runat="server" type="submit"  text="Sign in" 
                class="pure-button pure-button-primary" style=" Width:auto" margin="0px" 
                onclick="btnSignIn_Click" ID="btnSignIn" Font-Size="X-Small"/>
        </fieldset>
    </form>
</asp:Content>
</body>
</html>
