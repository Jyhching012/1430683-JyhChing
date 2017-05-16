<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_1430683_ASG.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Reference code was retrieved from https://www.youtube.com/watch?v=mBrxQQJdoHM and http://tutorials.tinyappco.com/ASPNET/Authorisation  and http://tutorials.tinyappco.com/ASPNET/AccessibleLogin -->
    <p>
        <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    </p>
    <p>
        UserName:</p>
    <p>
        <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        Password:</p>
    <p>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="buttonLogin" runat="server" CssClass="button" OnClick="buttonLogin_Click" Text="Log In" />
    </p>
</asp:Content>
