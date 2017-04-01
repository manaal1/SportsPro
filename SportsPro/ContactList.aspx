<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="SportsPro.ContactList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Contact List - Manage your contact list</h2>
    <hr style="border: 1px outset red" />
    <br />
    <br />
    <div style="text-align:center">
        <table style="text-align:left; display:inline-block">
            <tr>
                <td colspan="2"><b>Contact List:</b></td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="lstBxContact" runat="server" Height="200px" Width="500px"></asp:ListBox>
                </td>
                <td style="text-align:right">
                    <asp:Button ID="btnSelectAddCust" runat="server" Height="100px" Width="150px" OnClick="btnSelectAddCust_Click" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Button ID="btnRemoveContact" runat="server" Text="Remove Contact" Width="190px" Height="35px" OnClick="btnRemoveContact_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEmptyList" runat="server" Text="Empty List" Width="190px" Height="35px" OnClick="btnEmptyList_Click" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>
