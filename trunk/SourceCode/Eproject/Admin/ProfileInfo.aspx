<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ProfileInfo.aspx.cs" Inherits="ProfileInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
        <tr>
            <td style="width:130px; background-color:red">User name</td>
            <td style="width:300px; background-color:blue"><asp:TextBox ReadOnly=true ID="TextBox1" runat="server" TextMode=SingleLine></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtUserName" runat="server" TextMode=Password></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Change" /></td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode=Password></asp:TextBox>
                        </td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="TextBox4" runat="server" TextMode=Password></asp:TextBox>
                        </td>
        </tr>

    </table>
</asp:Content>

