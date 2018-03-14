<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Auction.aspx.cs" Inherits="CarAuction.Auction" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="HeaderLoginContent" runat="server" ContentPlaceHolderID="HeadLoginContent">
</asp:Content>
<asp:Content ID="HeaderImage" runat="server" ContentPlaceHolderID="BodyContentRegistration">
    <form id="form1" runat="server">
    <fieldset style="width: 165%;">
        <legend><b>Bid on a vehicle</b></legend>
        <table style="width: 160%;">
            <tr>
                <td class="style6">
                    Your ID: 
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtBoxUserID" type="text" placeholder="User ID" runat="server"></asp:TextBox>
                </td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    <asp:Label runat="server" ID="lblError" Style="color: Red; font-size: x-small"></asp:Label>
                </td>
            </tr>
            <tr>
            <td class="style6">
                    Car ID:
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtBoxCarID" type="text" placeholder="Car ID" runat="server"></asp:TextBox>
                </td>
                <td class="style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Please enter a number" style="font-size: x-small" 
                        ControlToValidate="txtBoxCarID" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtBoxBid" type="text" placeholder="Bid value" runat="server"></asp:TextBox>
                </td>
                <td class="style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Please enter your price number only" 
                        style="font-size: x-small" ControlToValidate="txtBoxBid" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                </td>
                <td class="style5">
                    <asp:Button ID="btnBid" class="pure-button pure-button-primary" runat="server" Text="Bid"
                        OnClick="btnBid_Click" />
                </td>
                <td class="style7">
                    &nbsp;</td>
            </tr>
        </table>
    </fieldset>
    </form>
</asp:Content>
<asp:Content ID="StyleContent" runat="server" ContentPlaceHolderID="HeadImage">
    <style type="text/css">
        .style5
        {
            width: 137px;
        }
        .style6
        {
            text-align: right;
            width: 57px;
        }
        .style7
        {
            font-size: medium;
            width: 176px;
        }
    </style>
</asp:Content>
