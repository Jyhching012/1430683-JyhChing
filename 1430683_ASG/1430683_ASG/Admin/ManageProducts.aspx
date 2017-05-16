<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="_1430683_ASG.Admin.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- reference code was retrieved from https://www.youtube.com/watch?v=hkiYuPBwnkQ and http://tutorials.tinyappco.com/ASPNET/EntityFrameworkAddRecords -->
    <p>
    Name:</p>
<p>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</p>
<p>
    Type:</p>
<p>
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="GpuName" DataValueField="Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:db_1430683_co5027_productConnectionString %>" SelectCommand="SELECT * FROM [ProductSpecs] ORDER BY [GpuName]"></asp:SqlDataSource>
</p>
<p>
    Price:</p>
<p>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
</p>
<p>
    Image:</p>
<p>
    <asp:DropDownList ID="ddlImage" runat="server">
    </asp:DropDownList>
</p>
<p>
    Description:</p>
<p>
    <asp:TextBox ID="txtDescription" runat="server" Height="71px" TextMode="MultiLine" Width="286px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</p>
<p>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</p>
</asp:Content>
