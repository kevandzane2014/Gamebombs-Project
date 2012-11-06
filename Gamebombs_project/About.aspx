<%@ Page Title="About Us" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:SqlDataSource ID="datAbout" runat="server" 
        ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
        SelectCommand="SELECT [aboutUs] FROM [aboutUs]"></asp:SqlDataSource>
    
    <h2>About Us</h2>

    <asp:ListView ID="lstAbout" runat="server" DataSourceID="datAbout">
        <EmptyDataTemplate>
            <span>Welcome to the exclusive world of Games.</span>
        </EmptyDataTemplate>

        <ItemTemplate>
            <span>
                <asp:Label ID="aboutUsLabel" runat="server" Text='<%# Eval("aboutUs") %>' />
                <br />
                <br />
            </span>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
