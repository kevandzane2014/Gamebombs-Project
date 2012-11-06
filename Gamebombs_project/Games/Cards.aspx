<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cards.aspx.cs" Inherits="Cards" %>

<%@ Register Src="OneOf25.ascx" TagName="OneOf25" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Card Game</title>
    <link id="Link1" href="~/Styles/StyleSheet.css" media="all" rel="stylesheet"
        rev="stylesheet" type="text/css" runat="server" />
</head>
<body>
    <h1>
       Click on the card to play</h1>
        <p>
            The robot plays it here</p>
&nbsp;<form id="form1" runat="server">
        <asp:Image ID="DealCard" runat="server" />
        <asp:Label ID="Total" runat="server" Text=".."></asp:Label>
        <asp:Button ID="NewDeal" runat="server" Text="New deal" Visible="False" OnClick="NewDeal_Click" />
        <div>
            <table  border="1" >
                <tr class="row_class">
                    <td>
                        <uc1:OneOf25 ID="OneOf25_1" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_2" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_3" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_4" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_5" runat="server" />
                    </td>
                    <td style="width:20px;" >
                        <asp:Label ID="Row1" runat="server" Text="..."></asp:Label></td>
                </tr>
                <tr class="row_class">
                    <td>
                        <uc1:OneOf25 ID="OneOf25_6" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_7" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_8" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_9" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_10" runat="server" />
                    </td>
                    <td style="width:20px;">
                        <asp:Label ID="Row2" runat="server" Text="..."></asp:Label></td>
                </tr>
                <tr class="row_class">
                    <td>
                        <uc1:OneOf25 ID="OneOf25_11" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_12" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_13" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_14" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_15" runat="server" />
                    </td>
                    <td style="width:20px;">
                        <asp:Label ID="Row3" runat="server" Text="..."></asp:Label></td>
                </tr>
                <tr class="row_class">
                    <td>
                        <uc1:OneOf25 ID="OneOf25_16" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_17" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_18" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_19" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_20" runat="server" />
                    </td>
                    <td style="width:20px;">
                        <asp:Label ID="Row4" runat="server" Text="..."></asp:Label></td>
                </tr>
                <tr class="row_class">
                    <td>
                        <uc1:OneOf25 ID="OneOf25_21" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_22" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_23" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_24" runat="server" />
                    </td>
                    <td>
                        <uc1:OneOf25 ID="OneOf25_25" runat="server" />
                    </td>
                    <td style="width:20px;">
                        <asp:Label ID="Row5" runat="server" Text="..."></asp:Label></td>
                </tr>
                <tr >
                    <td>
                        <asp:Label ID="Col1" runat="server" Text="..."></asp:Label></td>
                    <td>
                        <asp:Label ID="Col2" runat="server" Text="..."></asp:Label></td>
                    <td>
                        <asp:Label ID="Col3" runat="server" Text="..."></asp:Label></td>
                    <td>
                        <asp:Label ID="Col4" runat="server" Text="..."></asp:Label></td>
                    <td>
                        <asp:Label ID="Col5" runat="server" Text="..."></asp:Label></td>
                    <td style="width:20px;">
                        <asp:Label ID="Dia1" runat="server" Text="..."></asp:Label>/<asp:Label ID="Dia2"
                            runat="server" Text="..."></asp:Label></td>
                </tr>
            </table>
            
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Back" 
            onclick="Button1_Click" />
    </form>
</body>
</html>
