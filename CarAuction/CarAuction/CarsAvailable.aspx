<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarsAvailable.aspx.cs" Inherits="CarAuction.CarsAvailable" %>
<asp:Content ID="CarContent" runat="server" ContentPlaceHolderID="BodyContentRegistration">
    <form id="DisplayAllAvailableCars" runat="server">
    <asp:DataList ID="DataListDisplayAllCar" runat="server" CellPadding="25" DataSourceID="AccessDataSourceAllCarPictures"
        RepeatColumns="2" RepeatDirection="Horizontal" DataKeyField="carID">
        <HeaderTemplate>
            <b>Cars Available<b>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="pure-button pure-button-success">
                <b>
                    <asp:Label ID="brandLabel" runat="server" Text='<%# Eval("brand") %>' />
                    <asp:Label ID="modelLabel" runat="server" Text='<%# Eval("model") %>' />
                    <asp:Label ID="yearLabel" runat="server" Text='<%# Eval("year") %>' />
                </b>
            </div>
            <br />
            <img alt="" src="/CarImages/<%# Eval("photo") %>" style="width: 300px; height: 200px" />
            <br />
            <i>
                <b>
                    Car ID :
                </b>
            </i>
            <b>
                <asp:Label ID="carIDLabel" runat="server" Text='<%# Eval("carID") %>' />
            </b>
            <br />
            <i>
                <b>
                    Estimated Value:
                </b>
            </i>
            <b>
                R <asp:Label ID="estValueLabel" runat="server" Text='<%# Eval("estValue") %>' />
            </b>
            <br />
            <i>
                <b>
                    Kilometers:
                </b>
            </i>
            <b>
                <asp:Label ID="KilometersLabel" runat="server" Text='<%# Eval("Kilometers") %>' /> Km
            </b>
            <br />
            <i>
                <b>
                    Starting Bid:
                </b>
            </i>
            <b>
               R <asp:Label ID="startingBidLabel" runat="server" Text='<%# Eval("startingBid") %>' />
            </b>
            <br />
            <i>
                <b>
                    Description:
                </b>
            </i>
            <b>
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
            </b>
            <br />
            <br />
            <i>
                <b>
                    Closing Date:
                <b>
            <i>
            <b>
                <asp:Label ID="closingDateLabel" runat="server" Text='<%# Eval("closingDate") %>' />
            </b>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkAuction" runat="server" CssClass="pure-button pure-button-secondary"
                NavigateUrl='<%# string.Format("~/Auction.aspx?CarID={0}", HttpUtility.UrlEncode(Eval("carID").ToString())) %>'>Bid for this Vehicle</asp:HyperLink>
        </ItemTemplate>
    </asp:DataList>

       <asp:SqlDataSource
          id="AccessDataSourceAllCarPictures"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:ApplicationServices%>"
          SelectCommand="SELECT * FROM [CarInformation]">
      </asp:SqlDataSource>
 
    <br />
    <br />
    </form>
</asp:Content>
