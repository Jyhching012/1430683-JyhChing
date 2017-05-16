<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="_1430683_ASG.Pages.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- reference code was retrieved from https://www.youtube.com/watch?v=67fW_kNLghc -->
    <link href="../CSS/shopping.css" rel="stylesheet" />
    <asp:Panel ID="pnlShopCart" runat="server" CssClass="cartleft" >
    </asp:Panel>
    

    <table>
        <tr>
            <td><b>Total:</b></td>

            <td><asp:Literal  ID="litTotal" runat="server" Text=""/></td>
        </tr>

        <tr>
            <td><b>Vat:</b></td>

            <td><asp:Literal  ID="litVat" runat="server" Text=""/></td>
        </tr>

        <tr>
            <td><b>Shipping:</b></td>

            <td>$10</td>
        </tr>

        <tr>
            <td><b>Total:</b></td>

            <td><asp:Literal  ID="litTotalAmount" runat="server" Text=""/></td>
        </tr>
        <tr>
        <td>
            <asp:LinkButton ID="linkContinue" runat="server" PostBackUrl="~/default.aspx"
                Text="Continue Shopping" />
            Or
            <asp:Button ID="btnCheckOut"  runat="server" PostBackUrl="~/Pages/Success.aspx"
                CssClass="button" Width="250px" Text="Continue CheckOut" />
        </td>
</tr>

    </table>
</asp:Content>
