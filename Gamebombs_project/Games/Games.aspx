<%@ Page Title="Game Page" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true" CodeFile="Games.aspx.cs" Inherits="Games_GameTest" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>

    


   
    <div id="wrapper" style="width: 700px; margin: 0 auto;">
    
    
        <div id="generated" style="width: 300px; height:400px; float: left; ">
            <asp:Label ID="getHtml" runat="server" Text="" />
        </div>
        
        
        <div id="buttons" style="width: 200px; height: 200px; margin-left: 50px; float: right;">
            <br />
            <br />
            <asp:Button ID="Instructions" runat="server" Text="Instructions" Width="100px" onclick="Instructions_Click" />
            <br />
            <br />
            <asp:Button ID="Start" runat="server" Text="Start Game" Visible="false" onclick="Start_Click"/>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        
        
    </div>
   
    </asp:Content>

