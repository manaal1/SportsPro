<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="SportsPro.Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Customers - Search and view your customer contact information</h2>
    <hr style="border: 1px outset red" />
    <br />
    <br />
    <div style="text-align: center">
        <table style="text-align:left; display: inline-block">
            <tr>
                <td>
                    <b>Select a customer:</b><br /><br />
                </td>
                <td>
                    <asp:DropDownList ID="ddlCustomerList" runat="server" Width="200px" AutoPostBack="true" OnSelectedIndexChanged="ddlCustomerList_SelectedIndexChanged"></asp:DropDownList>
                    <br /><br />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Address:</b>
                </td>
                <td>
                    <asp:Label ID="lblAddress1" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblAddress2" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><b>Phone:</b></td>
                <td>
                    <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td><b>Email:</b></td>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <br />
                    <asp:Button ID="btnAddCList" runat="server" Text="Add to Contact List" Height="35px" Width="200px" OnClick="btnAddCList_Click" /></td>
                <td>
                    <br />
                    <asp:Button ID="btnDisplayCList" runat="server" Text="Display Contact List" Height="35px" Width="200px" OnClick="btnDisplayCList_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
