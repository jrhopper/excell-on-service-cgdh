﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateRole.aspx.cs" Inherits="Admin_FormUpdateRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
     <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Form Update Role"></asp:Label>
    </p>
</center>
    <br />
    <table style="margin-left:300px">
        <tr>
            <td>Id</td>
            <td><input name=txtId id=txtId readonly=readonly type=text runat=server /></td>
            <td></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><input name=txtName id=txtName type=text runat=server /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate=txtName Display=Dynamic ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Description</td>
            <td><asp:TextBox ID="txtDescription" runat="server" TextMode=MultiLine></asp:TextBox></td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td colspan=2 align=center>
            
                 <asp:ImageButton ImageUrl="~/images/update_icon.png" OnClick="btnUpdate_Click" Width=32 Height=32 ID="imgBtnUpdate" runat="server"  />
                <asp:Button OnClick="btnUpdate_Click" ID="btnUpdate" runat="server" Text="Update" />
            </td>
            
        </tr>
    </table>

</asp:Content>

