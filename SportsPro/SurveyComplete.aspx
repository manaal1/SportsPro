<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SurveyComplete.aspx.cs" Inherits="SportsPro.SurveyComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Survey Complete - Confirmation of Survey</h2>
    <hr style="border: 1px outset red" />
    <br />
    <br />
    <div style="text-align:center">
        <table style="text-align:left; display:inline-block">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Thank you for your feedback!" Font-Bold="True" Font-Size="11pt" ForeColor="Green"></asp:Label>
            </td>
        </tr>
            <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="True" Font-Size="11pt" ForeColor="Green"></asp:Label>
                <br /><br />
            </td>
        </tr>
            <tr>
                <td>
                    <asp:Button ID="btnReturnServey" runat="server" Text="Return to Survey" Height="35px" OnClick="btnReturnServey_Click" />
                </td>
            </tr>
    </table>
    </div>
</asp:Content>
