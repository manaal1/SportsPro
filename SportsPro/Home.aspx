<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SportsPro.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .pnlHome1{
            display:inline-block;
            border-right: 1px groove red;
            padding-right:20px;
        }
        .pnlHome2{
            display:inline-block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Welcome to SportsPro support portal</h2>
    <hr style="border: 1px outset red" />
    <br />
    <br />
    <div style="text-align:center">
        <asp:Panel ID="Panel1" runat="server" Width="300px" CssClass="pnlHome1" Height="150px">
            <asp:Label ID="Label1" runat="server" Text="1. Getting Started" Font-Bold="True" Font-Size="10pt"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Go to 'Customer' section to search for your customer information."></asp:Label>
            <br /><br />
            <asp:LinkButton ID="lnkCustomer" PostBackUrl="~/Customers.aspx" runat="server" Font-Bold="True" Font-Size="10pt">Go to Customer</asp:LinkButton>
        </asp:Panel>
        &nbsp;
        <asp:Panel ID="Panel2" runat="server" Width="300px" CssClass="pnlHome2" Height="150px">
            <asp:Label ID="Label3" runat="server" Text="2. What do you think about our service?" Font-Bold="True" Font-Size="10pt"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="'Submit a Survey' to provide your feedback for any support we have provided to you recently."></asp:Label>
            <br /><br />
            <asp:LinkButton ID="lnkSurvey" PostBackUrl="~/Surveys.aspx" runat="server" Font-Bold="True" Font-Size="10pt">Submit a Survey</asp:LinkButton>
        </asp:Panel>
    </div>
</asp:Content>
