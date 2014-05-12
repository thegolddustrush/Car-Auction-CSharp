<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registeration.aspx.cs" Inherits="Registeration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="../Styles/PureFile.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script src="../Scripts/jquery-ui-1.10.3.custom.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#datepicker").datepicker();
        });
    </script>
    <style type="text/css">
        .style1
        {
            text-align: right;
            width: 118px;
        }
        .style3
        {
            width: 271px;
        }
        .style5
        {
            width: 170px;
        }
        #AgeRegistration
        {
            width: 211px;
            height: 34px;
        }
        .style6
        {
            width: 205px;
        }
    </style>
    <link href="../Styles/jquery-ui-1.10.3.custom.min.css" rel="stylesheet" type="text/css" />
    <link href="../Styles/Design.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="pure-menu-horizontal pure-menu-open pure-menu">
        <ul>
            <li><a href="#">Home</a></li>
            <li class="pure-menu-selected"><a href="#">Auction</a></li>
            <li><a href="#">Sell your car</a></li>
            <li class="pure-menu-selected"><a href="#">About Us</a></li>
            <li><a href="#">Cars Available</a></li>
        </ul>
        <br />
    </div>
    <div id="NewUser">
        <form id="RegistraionForm" runat="server" style="height: 211px; width: 1000px; margin-left: 0px;
        margin-bottom: 1px">
        <fieldset style="width: 883px; height: 280px; margin-right: 0px;">
            <legend>New User Registration</legend>
            <table style="width: 876px; margin-right: 0px;">
                <tr>
                    <td class="style1">
                        Name:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxName" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldName" runat="server" ControlToValidate="txtBoxName"
                            ErrorMessage="Please enter a Name!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Surname:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxSurname" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldSurname" runat="server" ControlToValidate="txtBoxSurname"
                            ErrorMessage="Please enter a Surname!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
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
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Date of Birth:
                    </td>
                    <td class="style6">
                        <input type="text" id="datepicker" />
                        <%--<div id="AgeRegistration">
                    &nbsp;<asp:DropDownList ID="DrpDwnLstDay" runat="server" Height="24px" Width="41px">
                        </asp:DropDownList>
                        &nbsp;&nbsp;
                    <asp:DropDownList ID="DrpDwnLstMonth" runat="server" Height="24px" Width="41px" 
                            onselectedindexchanged="DrpDwnLstMonth_SelectedIndexChanged">
                        </asp:DropDownList>
                    &nbsp;
                        <asp:DropDownList ID="DrpDwnLstYear" runat="server">
                        </asp:DropDownList>
                    </div>--%>
                    </td>
                    <td class="style5">
                        &nbsp;
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Password:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ControlToValidate="txtBoxPass"
                            ErrorMessage="Please enter a password!" Style="font-size: small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style3">
                        <asp:RangeValidator ID="RangeValidatorPassword" runat="server" ControlToValidate="txtBoxPass"
                            ErrorMessage="Password must atleast be 10 characters long" MaximumValue="20"
                            MinimumValue="10" Style="font-size: small" ForeColor="Red"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
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
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Question:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxQuestion" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="ValidatorQuestion" runat="server" ControlToValidate="txtBoxQuestion"
                            ErrorMessage="Please enter a question" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        Answer:
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="txtBoxAnswer" runat="server"></asp:TextBox>
                    </td>
                    <td class="style5">
                        <asp:RequiredFieldValidator ID="ValidatorAnswer" runat="server" ControlToValidate="txtBoxAnswer"
                            ErrorMessage="Please enter an Answer" ForeColor="Red" Style="font-size: small"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        &nbsp;
                    </td>
                    <td class="style6">
                        <%--<asp:button ID="btnRegister" type="submit" class="pure button pure-button-primary" 
                        runat="server" OnClick="btnRegister_Click" Text="Register" />--%>
                        <asp:Button runat="server" type="submit" Text="Register" class="pure-button pure-button-primary"
                            Width="100px" height="40px" margin="0px" OnClick="btnRegister_Click" ID="btnRegister" />
                    </td>
                    <td class="style5">
                        &nbsp;
                    </td>
                    <td class="style3">
                        &nbsp;
                    </td>
                </tr>
            </table>
        </fieldset>
        </form>
    </div>
</body>
</html>
