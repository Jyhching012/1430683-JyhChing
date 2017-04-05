<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="_1430683_CO5027.Pages.ContactUs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/contactus.css" rel="stylesheet" />
    <div id="wrapper">
        <br />
    <h1>Contact Us</h1>
        
        <!-- Code retrieved from https://www.youtube.com/watch?v=ngldKCSXA6U vid 1 and https://www.youtube.com/watch?v=Fw1X7HLZfos vid 2 to make a contact us table align and error code will appear when an input is not valid -->
        <table>
            <tr>
                <td class="font" >
                    <b>Name:</b>
                </td>

                <td>
                    <asp:TextBox ID="Name" Width="200px" runat="server"></asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        runat="server" ErrorMessage="Enter Name that is Validated" 
                        ControlToValidate="Name"
                        Text="*"
                        ForeColor="Red"
                        ></asp:RequiredFieldValidator>

                </td>
            </tr>

            <tr>
                <td class="font">
                    <b>Email:</b>
                </td>

                <td>
                    <asp:TextBox ID="Email" Width="200px" runat="server"></asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                        runat="server" ErrorMessage="Enter Email that is Validated" 
                        ControlToValidate="Email"
                        Display="Dynamic"
                        Text="*"
                        ForeColor="Red"
                        ></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                        runat="server" ErrorMessage="Enter Email that is Validated" ControlToValidate="Email" Text="*"
                        Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                </td>
            </tr>

            <tr>
                <td class="font">
                    <b>Subject:</b>
                </td>

                <td>
                    <asp:TextBox ID="Subject" Width="200px" runat="server"></asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                        runat="server" ErrorMessage="Enter a Subject" 
                        ControlToValidate="Subject"
                        Text="*"
                        ForeColor="Red"
                        ></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td style="vertical-align:top" class="font">
                    <b>Message:</b>
                </td>

                <td style="vertical-align:top">
                    <asp:TextBox ID="Message" Width="200px" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
                </td>

                <td style="vertical-align:top">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                        runat="server" ErrorMessage="Enter messages" 
                        ControlToValidate="Message"
                        Text="*"
                        ForeColor="Red"
                        ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ValidationSummary HeaderText="Please change the error showing" ForeColor="Red" ID="ValidationSummary1" runat="server" />

                </td>

            </tr>

            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="true" ></asp:Label>
                </td>
            </tr>

            <tr>
                <td colspan="3" class="button">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
            </tr>

        </table>

        <hr />
        <h1>Address</h1>

        <p>
            Unit 11, 1st Floor, Mabohai Shopping Complex Spg 99, JalanKebangsaan Lama,
            (MABOHAI) Bandar Seri Begawan BA1111, Negara Brunei Darussalam, Bandar Seri Begawan
</p>

        <hr />
        <p><!-- Retrieved from GoogleMaps-->
        <iframe src="https://www.google.com/maps/embed?pb=!1m23!1m12!1m3!1d3975.186283817327!2d114.94050271476306!3d4.908471496436228!2m3!1f0!2f0!3f0!3m2!1i1024!
            2i768!4f13.1!4m8!3e6!4m0!4m5!1s0x3222f52379b208ab%3A0xbeddb8e9db66f5ee!2sMabohai+Shopping+Complex%2C+Jalan+Kebangsaan%2C+Bandar+Seri+Begawan+BA1111!3m2!
            1d4.9084715!2d114.9426914!5e0!3m2!1sen!2sbn!4v1491114619016" ></iframe>
</p>
                


      

            
        


      </div>
    

</asp:Content>


