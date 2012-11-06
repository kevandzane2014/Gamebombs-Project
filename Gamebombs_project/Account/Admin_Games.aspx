<%@ Page Title="" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true"
    CodeFile="Admin_Games.aspx.cs" Inherits="Account_Admin_Games" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <p>
        <asp:SqlDataSource ID="sqlGameData" runat="server" ConnectionString="<%$ ConnectionStrings:siteInfoString %>"
            DeleteCommand="DELETE FROM [gameInfo] WHERE [ID] = @ID" InsertCommand="INSERT INTO [gameInfo] ([ID], [gameName], [Instructions]) VALUES (@ID, @gameName, @Instructions)"
            SelectCommand="SELECT * FROM [gameInfo]" UpdateCommand="UPDATE [gameInfo] SET [gameName] = @gameName, [Instructions] = @Instructions WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="gameName" Type="String" />
                <asp:Parameter Name="Instructions" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="gameName" Type="String" />
                <asp:Parameter Name="Instructions" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <h2>
        Game Management</h2>
    <p>
        <br />
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" DataSourceID="sqlGameData"
            Width="100%" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid"
            BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <EditItemTemplate>
                <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                <asp:Label ID="lblgameName" runat="server" Text='<%# Bind("gameName") %>' />
                <br />
                <br />
                Instructions:
                <asp:TextBox ID="InstructionsTextBox" runat="server" Text='<%# Bind("Instructions") %>'
                    Width="100%" />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                    Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False"
                    CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                <asp:Label ID="gameNameLabel" runat="server" Text='<%# Bind("gameName") %>' />
                <br />
                <br />
                Instructions:
                <br />
                <asp:Label ID="InstructionsLabel" runat="server" Text='<%# Bind("Instructions") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
                    Text="Edit" />
            </ItemTemplate>
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        </asp:FormView>
    </p>
    <p>
        <asp:HyperLink ID="lnkGames" runat="server" Font-Size="X-Large" NavigateUrl="~/Account/Admin_Management.aspx">Back</asp:HyperLink>
    </p>
</asp:Content>
