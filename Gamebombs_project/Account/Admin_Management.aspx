<%@ Page Title="Admin Management" Language="C#" MasterPageFile="~/sample1.master"
    AutoEventWireup="true" CodeFile="Admin_Management.aspx.cs" Inherits="Account_Admin_Management" %>

<script runat="server">


</script>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Admin Management</h2>

    <asp:SqlDataSource ID="datAbout" runat="server" 
        ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
        SelectCommand="SELECT [ID], [aboutUs] FROM [aboutUs]" 
        DeleteCommand="DELETE FROM [aboutUs] WHERE [ID] = @ID" 
        
        UpdateCommand="UPDATE [aboutUs] SET [aboutUs] = @aboutUs WHERE [ID] = @ID" 
        
        InsertCommand="INSERT INTO [aboutUs] ([ID], [aboutUs]) VALUES (@ID, @aboutUs)">

        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="aboutUs" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="aboutUs" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="datContactInfo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
        SelectCommand="SELECT * FROM [contactUs]" 
        UpdateCommand="UPDATE [contactUs] SET [ID] = @ID, [Name] = @Name, [Email] = @Email, [Phone] = @Phone, [Address] = @Address, [City] = @City, [State] = @State, [ZIP] = @ZIP WHERE (([Message] = @Message) OR ([Message] IS NULL AND @Message IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="Message" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="ZIP" Type="String" />
            <asp:Parameter Name="Message" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ID" Type="Int32" />
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="State" Type="String" />
            <asp:Parameter Name="ZIP" Type="String" />
            <asp:Parameter Name="Message" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <h3>About Us:</h3>
    <p>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" DataSourceID="datAbout" Width="100%">
            <EditItemTemplate>
                <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                <asp:TextBox ID="aboutUsTextBox" runat="server" Text='<%# Bind("aboutUs") %>' Width="100%" />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            
            <ItemTemplate>
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                <asp:Label ID="aboutUsLabel" runat="server" Text='<%# Bind("aboutUs") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                    CommandName="Edit" Text="Edit" />
            </ItemTemplate>
        </asp:FormView>
    </p>

    <h3>Contact Us:</h3>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataKeyNames="ID" DataSourceID="datContactInfo" Height="50px" 
            Width="100%">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ReadOnly="True" Visible="false" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="ZIP" HeaderText="ZIP" SortExpression="ZIP" />
                <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
                <asp:CommandField ShowEditButton="True" />
            </Fields>
        </asp:DetailsView>
    </p>


    <table>
        <tr>
            <td>
                &nbsp;
            <asp:HyperLink ID="lnkGames" runat="server" Font-Size="X-Large" 
            NavigateUrl="~/Account/Admin_Games.aspx">Edit Games</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            <asp:HyperLink ID="lnkGames0" runat="server" Font-Size="X-Large" 
            NavigateUrl="~/Account/Admin_Users.aspx">Edit Users</asp:HyperLink>
            </td>
        </tr>
        </table>


    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

    </asp:Content>