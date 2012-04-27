<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateRole.aspx.cs" Inherits="Admin_FormCreateRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
     <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Form Create Role"></asp:Label>
    </p>
</center>
    <br />
    <table style="margin-left:280px">
        
        <tr>
            <td>Name</td>
            <td><input name=txtName id=txtName type=text runat=server /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate=txtName Display=Dynamic ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
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
            
                 
                <asp:Button ID="btnCreate" runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
            </td>
            
        </tr>
    </table>

</asp:Content>

