<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true"
    CodeFile="Contact.aspx.cs" Inherits="contact" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Contact&nbsp; us</h2>


        <asp:SqlDataSource ID="datContactInfo" runat="server" 
            ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
            SelectCommand="SELECT [Name], [Email], [Phone], [Address], [City], [State], [Zip] FROM [contactUs]">
        </asp:SqlDataSource>


    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" BorderStyle="None" 
            DataSourceID="datContactInfo" GridLines="None" Height="50px" Width="125px">
        </asp:DetailsView>
    </p>
    <p>
        <asp:SqlDataSource ID="datContactMessage" runat="server" 
            ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
            SelectCommand="SELECT [Message] FROM [contactUs]"></asp:SqlDataSource>
    </p>
    
    
    
    
    <p>
        <asp:ListView ID="lstAbout" runat="server" DataSourceID="datContactMessage">
            <EmptyDataTemplate>
                <span>Please enter a short message below:</span>
            </EmptyDataTemplate>
            <ItemTemplate>
                <span>
                <asp:Label ID="aboutUsLabel" runat="server" Text='<%# Eval("Message") %>' />
                <br />
                <br />
                </span>
            </ItemTemplate>
        </asp:ListView>
    </p>


    <asp:Label ID="Label1" runat="server" Text="Your message has been sent" 
        Visible="False"></asp:Label>
    <br />
    <br />
    <br />


    <br />


    <table>
        <tr>
            <td>
                <b>Name:</b>
            </td>
            
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="280px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a valid name" Text="Please enter a valid name" ControlToValidate = "txtName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Email:</b>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="280px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter a valid E-Mail" Text="Please enter a valid E-Mail" ControlToValidate = "txtEmail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ErrorMessage="Invalid Email Format" ></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <b>Subject:</b>
            </td>
            <td>
                <asp:TextBox ID="txtSubject" runat="server" Width="280px"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>
                <b>Enquiry Detail:</b>
            </td>
            <td>
                <asp:TextBox ID="txtEnquiry" runat="server" Height="149px" TextMode="MultiLine" Width="408px"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter your text here" Text="Please enter your text here" ControlToValidate = "txtEnquiry"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit Enquiry" OnClick="btnSubmit_Click" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
