<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Eproject.Admin.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style6
        {
            height: 22px;
            width: 260px;
        }
        .style7
        {
            height: 21px;
            width: 260px;
        }
        .style8
        {
            width: 260px;
        }
        .style9
        {
            height: 22px;
            width: 130px;
        }
        .style10
        {
            height: 21px;
            width: 130px;
        }
        .style11
        {
            width: 130px;
        }
        .style12
        {
            height: 22px;
            width: 355px;
        }
        .style13
        {
            height: 21px;
            width: 355px;
        }
        .style14
        {
            width: 355px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style9">
                <asp:Label ID="lbName" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="tbName" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style9">
                <asp:Label ID="lbEmail" runat="server" Text="Email" ></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="tbEmail" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Label ID="lbAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="style7">
                <asp:TextBox ID="tbAddress" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style10">
                <asp:Label ID="lbContact" runat="server" Text="Contact"></asp:Label>
            </td>
            <td class="style13">
                <asp:TextBox ID="tbContact" runat="server" Width="180px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style11">
                <asp:Label ID="lbPhone" runat="server" Text="Phone"></asp:Label>
            </td>
            <td class="style8">
                <asp:TextBox ID="tbPhone" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style11">
                <asp:Label ID="lbCompany" runat="server" Text="Company"></asp:Label>
            </td>
            <td class="style14">
                <asp:TextBox ID="tbCompany" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td align="right" class="style8">
                <asp:Button ID="btAdd" runat="server" style="margin-left: 0px" Text="Add" Width="100px"/>
            </td>
            <td class="style11">
                <asp:Button ID="btCancel" runat="server" Text="Cancel" Width="100px"/>
            </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
