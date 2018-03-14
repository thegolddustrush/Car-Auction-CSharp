<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="SellCar.aspx.cs" Inherits="CarAuction.SellCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadLoginContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentRegistration" runat="server">
    <form id="FormSellingCar" runat="server">
    <fieldset>
        <legend><b>Sell Your Car</b></legend>
        <table style="width: 640px;">
            <tr>
                <td class="style7">
                    &nbsp;Brand: 
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxBrand" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtBoxBrand" CssClass="style6" ErrorMessage="Enter a Brand" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label runat="server" ID="lblError" style=" color: Red; " 
                        CssClass="style6" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Model:
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxModel" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtBoxModel" ErrorMessage="Enter Model" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Year:
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxYear" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtBoxYear" ErrorMessage="Enter Year" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Kilometers:
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxKilometer" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtBoxKilometer" ErrorMessage="Enter your Km" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Description:
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxDesc" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtBoxDesc" ErrorMessage="Enter a Description" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Value:
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxValue" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtBoxValue" ErrorMessage="Enter a value" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Starting Bid: 
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxStartBid" runat="server"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtBoxStartBid" ErrorMessage="Enter a Starting bid" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Closing Date: 
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:TextBox ID="txtBoxClosingDate" 
                        runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp; Image: 
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:FileUpload ID="fileUploadImage" runat="server" />
                </td>
                <td class="style6">
                    &nbsp; *NB a picture of your vehicle will improve the chances of being sold
                    </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;
                </td>
                <td>
                    <span class="style6">&nbsp;</span><asp:Button ID="btnUpload" CssClass="pure-button pure-button-primary" runat="server" 
                        Text="Upload" onclick="btnUpload_Click" />
                </td>
                <td class="style6">
                    &nbsp;
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="HeadImage">
    <style type="text/css">
        .style6
        {
            font-size: x-small;
        }
        .style7
        {
            text-align: right;
            width: 118px;
            font-size: small;
        }
    </style>
</asp:Content>

