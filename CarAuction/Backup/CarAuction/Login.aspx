<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarAuction.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Auction</title>
    <link href="~/Styles/PureFile.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 109px;
        }
    </style>
</head>
<body>
    <div class="pure-g">
        <div class="pure-u-1 header">
            <div class="pure-g">
                <div class="pure-u-2-3">
                </div>
                <div class="pure-u-1-3" style="padding-top: 50px;">
                </div>
            </div>
        </div>
        <div class="pure-u-1">
            <div class="pure-menu-horizontal pure-menu-open pure-menu">
            </div>
        </div>
        <div class="pure-g" style="padding-top: 20px; height: 300px">
            <div class="pure-u-1">
                <div class="pure-g" style="height: auto">
                    <div class="pure-u-1-6">
                    </div>
                    <div class="pure-u-1-3">
                        <form id="Login" runat="server">
                        <fieldset style="width: 410px">
                            <legend><b>Login</b></legend>
                            <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtBoxLoginEmail" runat="server" type="text" placeholder="Email"
                                            Style="font-size: Small" />
                                    </td>
                                    <td class="style1">
                                        <asp:Label runat="server" ID="lblError" style=" color: Red; font-size: x-small" ></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtBoxLoginPassword" runat="server" type="password" placeholder="Password"
                                            Style="font-size: Small; height: auto;" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="ButtonLgin" runat="server" type="submit" CssClass="pure-button pure-button-primary"
                                            Style="width: auto; font-size: Small; margin: 0px;" Text="Sign In" OnClick="btnSignIn_Click" />
                                    </td>
                                    <td class="style1">
                                        <asp:HyperLink ID="HperLinkForgotPassword" runat="server" CssClass="pure-button pure-button-secondary"
                                            Style="font-size: small" NavigateUrl="~/ForgotPassword.aspx">Forgot password</asp:HyperLink>
                                    </td>
                                    <td style="padding: 5;">
                                        <asp:HyperLink ID="HyperLinkNewUser" CssClass="pure-button pure-button-tertiary"
                                            NavigateUrl="~/Registration.aspx" runat="server" Style="font-size: small">New User?</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                        </form>
                    </div>
                    <div class="pure-u-1-6">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
