<%@ Page Title="User Management" Language="C#" MasterPageFile="~/sample1.master"
    AutoEventWireup="true" CodeFile="User_Management.aspx.cs" Inherits="Account_User_Management" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 127px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        User Management</h2>
    <br />
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp; 
                User Name:
             </td>
            <td>
                &nbsp;
                <asp:LoginName ID="LoginName1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp; Game Most Played:
            </td>
            <td>
                &nbsp;
                <asp:Label ID="lblPlayedMost" runat="server" EnableViewState="False" 
                    ViewStateMode="Disabled"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp; Last Game Played:
            </td>
            <td>
                &nbsp;
                <asp:Label ID="lblLastPlayed" runat="server" EnableViewState="False" 
                    ViewStateMode="Disabled"></asp:Label>
            </td>
        </tr>
    </table>
    </asp:Content>
