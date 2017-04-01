<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Surveys.aspx.cs" Inherits="SportsPro.Surveys" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h2>Surveys - Collect feedback from customers</h2>
    <hr style="border: 1px outset red" />
    <br />
    <br />
    <div style="text-align:center">
        <table style="text-align:left; display:inline-block">
            <tr>
                <td><asp:Label runat="server" ID="lblEntCID" Font-Bold="True">Enter your customer ID:</asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtCustomerId" runat="server" Font-Bold="True" Font-Size="14pt" Height="28px" Width="100px"></asp:TextBox>
                    &nbsp;
                    <asp:Button ID="btnGetIncidents" runat="server" Text="Get Incidents" Height="35px" Width="100px" OnClick="btnGetIncidents_Click" ValidationGroup="vgCustId"/>
                    <asp:RequiredFieldValidator ID="rfvCustId" runat="server" ErrorMessage="Customer ID could not be empty." 
                        Display="Dynamic" ValidationGroup="vgCustId" ControlToValidate="txtCustomerId" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvCustId" runat="server" ErrorMessage="Customer ID should be an Integer" 
                        Operator="DataTypeCheck" Type="Integer" Display="Dynamic" ValidationGroup="vgCustId" 
                        ControlToValidate="txtCustomerId" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <asp:Label ID="lblMessage" runat="server" Font-Bold="False" Font-Italic="True" Font-Size="10pt" ForeColor="Red"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:ListBox ID="lstBxIncidents" runat="server" Height="100px" Width="100%"></asp:ListBox>
                     <asp:RequiredFieldValidator ID="rfvIncident" runat="server" ErrorMessage="Please select an incident to submit." 
                        Display="Dynamic" ValidationGroup="vgIncident" ControlToValidate="lstBxIncidents" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br /><br />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label runat="server" ID="lblRateIncident" Font-Bold="True" Font-Size="11pt">
                        Please rate this incident by the following categories:</asp:Label>
                </td>
            </tr>
            <tr>
                <td><asp:Label runat="server" ID="lblResTime" Font-Bold="True">Response time:</asp:Label></td>
                <td colspan="2">
                    <asp:RadioButtonList ID="rblResponseTime" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label runat="server" ID="lblTechEff" Font-Bold="True">Technician efficiency:</asp:Label></td>
                <td colspan="2">
                    <asp:RadioButtonList ID="rblTechEff" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td><asp:Label runat="server" ID="lblProbRes" Font-Bold="True">Problem resolution:</asp:Label></td>
                <td colspan="2">
                    <asp:RadioButtonList ID="rblProbRes" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Not satisfied</asp:ListItem>
                        <asp:ListItem Value="2">Somewhat satisfied</asp:ListItem>
                        <asp:ListItem Value="3">Satisfied</asp:ListItem>
                        <asp:ListItem Value="4">Completely satisfied</asp:ListItem>
                    </asp:RadioButtonList>                    
                </td>
            </tr>
            <tr>
                <td style="vertical-align:top">
                    <br />
                    <asp:Label runat="server" ID="lblAddinfo" Font-Bold="true" Enabled="false">Additional comments:</asp:Label></td>
                <td colspan="2">
                    <br />
                    <asp:TextBox ID="txtAdditionalInfo" runat="server" TextMode="MultiLine" Height="60px" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <asp:CheckBox ID="chBxHasContacted" runat="server" Text="Please contact me to discuss this incident" 
                        Font-Bold="True" Font-Size="11pt" OnCheckedChanged="chBxHasContacted_CheckedChanged" AutoPostBack="true"/>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:RadioButtonList ID="rblContactby" runat="server" RepeatDirection="Horizontal" Font-Bold="True" Font-Size="11pt">
                        <asp:ListItem>Contact by email</asp:ListItem>
                        <asp:ListItem>Contact by phone</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="35px" Width="100px" OnClick="btnSubmit_Click" ValidationGroup="vgIncident"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
