﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewAction.aspx.cs" Inherits="Admin_NewAction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="New Action"></asp:Label>
    </p><br />
    
        
    <table width=500 style="margin-left:180px">
        <tr>
            <td style="width:90px">Name</td>
            <td style="width:350px">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                
                <asp:Label ID="lbMessage"   Font-Size=Smaller Font-Bold=true  ForeColor=Red                
                 runat="server" Text=""></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td>Link</td>
            <td>
                <asp:TextBox ID="txtLink" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td>Description</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" TextMode=MultiLine></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td colspan=2>
                <asp:Button style="margin-left:30px" OnClick="btnCreate_Click" ID="btnCreate" runat="server" Text="Create" />
                <asp:Button ID="Button2" runat="server" Text="Action List" PostBackUrl="~/Admin/Action.aspx" CausesValidation=false />
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/Admin/ManageRole.aspx" Text="Role Management" CausesValidation=false />
            </td>
        </tr>
    </table>
</center>
</asp:Content>

