<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangeDetails.aspx.cs" Inherits="CarAuction.ChangeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadLoginContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadImage" runat="server">
    <style type="text/css">
        .style5
        {
            width: 291px;
        }
        .style6
        {
            text-align: center;
            width: 122px;
        }
        .style7
        {
            text-align: right;
            width: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BodyContentRegistration" runat="server">
    <form id="RegistraionForm" runat="server" style="height: 211px; width: 1000px; margin-left: 0px;
        margin-bottom: 1px">
        <fieldset style="width: 683px; height: 280px; margin-right: 0px;">
            <legend><b>Change Details</b></legend>
            <table style="width: 671px; margin-right: 0px;">
                <tr>
                    <td class="style7">
                        Name:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxName" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldName" runat="server" ControlToValidate="txtBoxName"
                            ErrorMessage="Please enter a Name!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Surname:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxSurname" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldSurname" runat="server" ControlToValidate="txtBoxSurname"
                            ErrorMessage="Please enter a Surname!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Date of Birth:
                    </td>
                    <td class="style6">
                        <input type="text" id="datepicker" name="txtBoxDate" />
                    </td>
                    <td class="style5">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Email Address:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RegularExpressionValidator ID="RegularExpressionEmail" runat="server" ControlToValidate="txtBoxEmail"
                            ErrorMessage="Enter a correct Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            Style="font-size: small" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Password:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ControlToValidate="txtBoxPass"
                            ErrorMessage="Please enter a password!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Confirm Password:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxConPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtBoxConPass"
                            ControlToValidate="txtBoxPass" ErrorMessage="Password does not match" Style="font-size: small"
                            ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Question:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxQuestion" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="ValidatorQuestion" runat="server" ControlToValidate="txtBoxQuestion"
                            ErrorMessage="Please enter a question" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Answer:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxAnswer" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="ValidatorAnswer" runat="server" ControlToValidate="txtBoxAnswer"
                            ErrorMessage="Please enter an Answer" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        &nbsp;
                    </td>
                    <td class="style6">
                        <asp:Button runat="server" type="submit" Text="Update" class="pure-button pure-button-primary"
                            Width="100px" height="40px" margin="0px" ID="btnRegister" 
                            onclick="btnUpdate_Click" />
                    </td>
                    <td class="style5">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </fieldset>
        </form>
</asp:Content>