<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CarsBidded.aspx.cs" Inherits="CarAuction.CarsAvailable" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="HeaderLoginContent" runat="server" ContentPlaceHolderID="HeadLoginContent">
</asp:Content>
<asp:Content ID="HeaderImage" runat="server" ContentPlaceHolderID="HeadImage">
</asp:Content>
<asp:Content ID="CarContent" runat="server" ContentPlaceHolderID="BodyContentRegistration">
    <form id="DisplayAvailableCars" runat="server">
    <asp:DataList ID="DataListDisplayCar" runat="server" CellPadding="25" DataSourceID="AccessDataSourceCarPics"
        RepeatColumns="2" RepeatDirection="Horizontal" DataKeyField="carID">
        <HeaderTemplate>
            <b>Cars Bidded Against<b>
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
            <i>
                <b>
                    Highest Bid: R
                </b>
            </i>
            <b>
                <asp:Label ID="HighestBidLabel" runat="server" Text='<%# Eval("Expr1") %>' />
            </b>
            <br />
            <br />
            <asp:HyperLink ID="hyperlinkAuction" runat="server" CssClass="pure-button pure-button-secondary"
                NavigateUrl='<%# string.Format("~/Auction.aspx?CarID={0}", HttpUtility.UrlEncode(Eval("carID").ToString())) %>'>Bid for this Vehicle</asp:HyperLink>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="AccessDataSourceCarPics" runat="server" 
                  DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:ApplicationServices%>"
        SelectCommand="SELECT CarInformation.carID, CarInformation.brand, CarInformation.model, CarInformation.[year], CarInformation.Kilometers, CarInformation.startingBid, CarInformation.description, CarInformation.photo, CarInformation.closingDate, CarInformation.estValue, MAX(BidInformation.bid) AS Expr1 FROM (CarInformation INNER JOIN BidInformation ON CarInformation.carID = BidInformation.carID) GROUP BY CarInformation.carID, CarInformation.brand, CarInformation.model, CarInformation.[year], CarInformation.Kilometers, CarInformation.startingBid, CarInformation.description, CarInformation.photo, CarInformation.closingDate, CarInformation.estValue">
    </asp:SqlDataSource>
    <br />
    <br />
    </form>
</asp:Content>
