<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_1430683_ASG.Pages.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Reference code was retrieved from https://www.youtube.com/watch?v=mBrxQQJdoHM and http://tutorials.tinyappco.com/ASPNET/Authorisation  -->
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
        Confirm Password:</p>
    <p>
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        First Name:</p>
    <p>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    </p>
    <p>
        Last Name:</p>
    <p>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </p>
    <p>
        Address:</p>
    <p>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    </p>
    <p>
        Postal Code:</p>
    <p>
        <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Register" />
    </p>
</asp:Content>
