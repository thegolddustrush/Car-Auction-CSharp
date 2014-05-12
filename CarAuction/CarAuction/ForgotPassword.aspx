<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    CodeBehind="ForgotPassword.aspx.cs" Inherits="CarAuction.ForgotPassword" %>

<asp:Content ID="BodyContentforgotPass" runat="server" ContentPlaceHolderID="BodyContentRegistration">
    <form id="FormForgotPass" runat="server" style="height: 211px; width: 910px; margin-left: 0px;
    margin-bottom: 1px">
    <fieldset style="width: 500px; height: 203px; margin-right: 0px;">
        <legend>Renew your password</legend>
        <table style="width: 484px; margin-right: 0px;">
            <tr>
                <td class="style1">
                    Email Address:
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtBxRegisterEmail" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RegularExpressionValidator ID="RegularExpressionEmail" runat="server" ControlToValidate="txtBxRegisterEmail"
                        ErrorMessage="Enter a correct Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        Style="font-size: small" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Question:
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtBoxRegisterQuestion" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="ValidatorQuestion" runat="server" ControlToValidate="txtBoxRegisterQuestion"
                        ErrorMessage="Please enter a question" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Answer:
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtBoxRegisterAnswer" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="ValidatorAnswer" runat="server" ControlToValidate="txtBoxRegisterAnswer"
                        ErrorMessage="Please enter an Answer" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    New Password:
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtBoxRegisterNewPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ControlToValidate="txtBoxRegisterNewPass"
                        ErrorMessage="Please enter a password!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Confirm Password:
                </td>
                <td class="style6">
                    <asp:TextBox ID="txtBoxRegisterConNewPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtBoxRegisterNewPass"
                        ControlToValidate="txtBoxRegisterConNewPass" ErrorMessage="Password does not match"
                        Style="font-size: small" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                </td>
                <td class="style6">
                    <asp:Button runat="server" type="submit" Text="Renew Password" class="pure-button pure-button-primary"
                        Width="152px" Height="40px" margin="0px" OnClick="btnRegister_Click" ID="btnRenewPass"
                        Font-Size="Small" />
                </td>
                <td class="style5">
                    &nbsp;
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</asp:Content> 