<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/sample1.master" CodeFile="Thanks.aspx.cs" Inherits="Thanks" %>




<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>

    <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Your message has been sent. We will shortly contact you.</h2>

<br />
<br />
        <asp:Button ID="Button1" runat="server" Text="Back to Home" onclick="Button1_Click" />


    </asp:Content>
