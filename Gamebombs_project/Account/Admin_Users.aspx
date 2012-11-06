<%@ Page Title="" Language="C#" MasterPageFile="~/sample1.master" AutoEventWireup="true" CodeFile="Admin_Users.aspx.cs" Inherits="Account_Admin_Games" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;</p>
    <h2>
        User Management</h2>
    <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onrowdatabound="GridView1_RowDataBound" 
            onrowediting="GridView1_RowEditing" DataKeyNames="UserName" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowupdating="GridView1_RowUpdating" BorderColor="Black" ForeColor="Black" 
                onrowdeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="UserName" HeaderText="User Name" ReadOnly="True" 
                    SortExpression="UserName" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" 
                    SortExpression="Email" />
                <asp:TemplateField HeaderText="Is Admin?">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>

                <HeaderStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </p>
    <p>
        <asp:HyperLink ID="lnkGames" runat="server" Font-Size="X-Large" 
            NavigateUrl="~/Account/Admin_Management.aspx">Back</asp:HyperLink>

    </p>
</asp:Content>

