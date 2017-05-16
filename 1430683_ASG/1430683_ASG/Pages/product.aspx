<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="_1430683_ASG.Pages.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Reference code retrieved from https://www.youtube.com/watch?v=SFDQ6Lkp8Ec -->
    <link href="../CSS/product.css" rel="stylesheet" />

    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailImage" /></td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                    
                </h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" Text="detailsPrice"></asp:Label></td>
            <td>Quantity : 
            <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><p>
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add Product" />
                </p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
</td>
        </tr>
        <tr>
            <td>Product Number:<asp:Label ID="lblItemNumber" runat="server" Text="Label"></asp:Label></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="In stock" CssClass="productPrice"></asp:Label></td>
            
        </tr>


    </table>
</asp:Content>
