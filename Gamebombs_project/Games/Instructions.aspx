<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Instructions.aspx.cs" Inherits="Games_GameImages_Instructions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="datInstructions" runat="server" 
            ConnectionString="<%$ ConnectionStrings:siteInfoString %>" 
            SelectCommand="SELECT [Instructions] FROM [gameInfo] WHERE ([gameName] = @gameName)">
            <SelectParameters>
                <asp:QueryStringParameter Name="gameName" QueryStringField="name" 
                    Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <asp:FormView ID="FormView1" runat="server" DataSourceID="datInstructions">

            <ItemTemplate>
                <h3>Instructions:</h3><br />
                <asp:Label ID="InstructionsLabel" runat="server" 
                    Text='<%# Bind("Instructions") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>

    </div>
    </form>
</body>
</html>
