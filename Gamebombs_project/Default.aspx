<%@ Page Title="Home" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Welcome to our Game Zone:</h2>
    <br />
    <br />
    <asp:SqlDataSource ID="datGames" runat="server" 
        ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
        SelectCommand="SELECT [ID], [gameName] FROM [gameInfo]">
    </asp:SqlDataSource>
    <asp:ListView ID="lstGames" runat="server" DataKeyNames="ID" DataSourceID="datGames" GroupItemCount="2" onitemcreated="lstGames_ItemCreated">

        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        No games found.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>

        <GroupTemplate>
            <tr ID="itemPlaceholderContainer" runat="server">
                <td ID="itemPlaceholder" runat="server">
                </td>
            </tr>
        </GroupTemplate>

        <ItemTemplate>
            <td runat="server" style="">
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                <center><asp:Label ID="gameNameLabel" runat="server" Text='<%# Eval("gameName") %>' /></center>
                <br /> 
                <asp:ImageButton ID="imgGame" runat="server" ImageUrl='<%# String.Format("~/images/{0}.jpg", Eval("gameName"))%>' 
                   Height="83px" Width="118px" />
                <br />
            </td>
        </ItemTemplate>

        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table ID="groupPlaceholderContainer" runat="server" border="0" style="" cellpadding="20">
                            <tr ID="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:ListView>
   
    <span>
    <iframe src="https://www.youtube.com/embed/PfiqJ9sZ64E" frameborder="0" align = "right" style="height: 153px; width: 329px; margin-left: 0px; margin-top: 0px;" id="I1" name="I1"></iframe></span>
    <br />
    
    <br />
</asp:Content>
