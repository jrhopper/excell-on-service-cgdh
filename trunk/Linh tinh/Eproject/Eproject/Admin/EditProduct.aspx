<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Eproject.Admin.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style6
        {
            height: 22px;
            width: 260px;
        }
        .style7
        {
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
                <asp:Label ID="lbPrcie" runat="server" Text="Price" ></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="tbPrice" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10" align="left" rowspan="2" valign="top">
                <asp:Label ID="lbDescription" runat="server" Text="Description"></asp:Label>
            </td>
            <td class="style7" rowspan="2" valign="top">
                <textarea name="taDescription" id="taDescription"  Width="180px" Height = "40px"></textarea></td>
            <td class="style10">
                <asp:Label ID="lbCustomer" runat="server" Text="Customer"></asp:Label>
            </td>
            <td class="style13">
                <asp:DropDownList ID="ddlCustomer" runat="server" Width="180px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
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
