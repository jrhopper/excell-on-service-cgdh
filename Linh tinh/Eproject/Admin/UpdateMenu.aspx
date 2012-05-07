<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="UpdateMenu.aspx.cs" Inherits="Admin_UpdateMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Update Menu"></asp:Label>
    </p><br />
</center>
<table style="margin-left:330px">
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
            <td>Link</td>
            <td><asp:TextBox ID="txtLink" runat="server" TextMode=SingleLine></asp:TextBox></td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>Description</td>
            <td><asp:TextBox ID="txtDescription" runat="server" TextMode=MultiLine></asp:TextBox></td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td colspan=2>
            
                 
                <asp:Button style="margin-left:20px" OnClick="btnUpdate_Click" ID="btnUpdate" runat="server" Text="Update" />
                <asp:Button ID="Button1" runat="server" CausesValidation=false Text="Menu List" PostBackUrl="~/Admin/Menu.aspx" />
                <asp:Button ID="Button2" runat="server" CausesValidation=false Text="Role Management" PostBackUrl="~/Admin/ManageRole.aspx" />
            </td>
            
        </tr>
    </table>

</asp:Content>

