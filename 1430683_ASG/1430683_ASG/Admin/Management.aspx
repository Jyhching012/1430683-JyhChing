<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="_1430683_ASG.Admin.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Reference code was retrieved from http://tutorials.tinyappco.com/ASPNET/Gridviews and http://tutorials.tinyappco.com/ASPNET/GridviewEditDelete and https://www.youtube.com/watch?v=hkiYuPBwnkQ -->
    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/Admin/ManageProducts.aspx">Add new Product</asp:LinkButton>
    
    
    
    
    
    <asp:GridView ID="grdProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsProducts" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="GpuId" HeaderText="GpuId" SortExpression="GpuId" />
            <asp:BoundField DataField="GpuName" HeaderText="GpuName" SortExpression="GpuName" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Descriptionofgpu" HeaderText="Descriptionofgpu" SortExpression="Descriptionofgpu" />
            <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:db_1430683_co5027_productConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Product] ([Id], [GpuId], [GpuName], [Price], [Descriptionofgpu], [Image]) VALUES (@Id, @GpuId, @GpuName, @Price, @Descriptionofgpu, @Image)" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [GpuId] = @GpuId, [GpuName] = @GpuName, [Price] = @Price, [Descriptionofgpu] = @Descriptionofgpu, [Image] = @Image WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Id" Type="Int32" />
            <asp:Parameter Name="GpuId" Type="Int32" />
            <asp:Parameter Name="GpuName" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Descriptionofgpu" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="GpuId" Type="Int32" />
            <asp:Parameter Name="GpuName" Type="String" />
            <asp:Parameter Name="Price" Type="Int32" />
            <asp:Parameter Name="Descriptionofgpu" Type="String" />
            <asp:Parameter Name="Image" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    
<br />

    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/Admin/ManageProductSpec.aspx">Add new Spec</asp:LinkButton>
    
    
    
    
    
    <br />
    
    
    
    
    
    <asp:GridView ID="grdProductsSpec" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsGpuSpec" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" InsertVisible="False" />
            <asp:BoundField DataField="GpuName" HeaderText="GpuName" SortExpression="GpuName" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sdsGpuSpec" runat="server" ConnectionString="<%$ ConnectionStrings:db_1430683_co5027_productConnectionString %>" DeleteCommand="DELETE FROM [ProductSpecs] WHERE [Id] = @Id" InsertCommand="INSERT INTO [ProductSpecs] ([GpuName]) VALUES (@GpuName)" SelectCommand="SELECT * FROM [ProductSpecs]" UpdateCommand="UPDATE [ProductSpecs] SET [GpuName] = @GpuName WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="GpuName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="GpuName" Type="String" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
</asp:SqlDataSource>
    
</asp:Content>
