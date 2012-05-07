<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateServiceType.aspx.cs" Inherits="Admin_FormCreateServiceType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="0" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Add new Service type</td>
        </tr>
        <tr>
            <td>Id</td>
            <td><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Name</td>
            <td><input name="txtName" id="txtName" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
		<tr>
            <td>Image</td>
            <td>
                
                <input name="txtImage" id="txtImage" type="text" runat="server" /></td>
                
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtImage" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Image is null"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Charges</td>
            <td>
                <input name="txtCharges" id="txtCharges" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtCharges" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Charges is null"></asp:RequiredFieldValidator></td>
        </tr>
		<tr>
            <td>Description</td>
            <td><asp:TextBox ID="txtDescription" runat="server" TextMode=MultiLine></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtDescription" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Description is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnCreate" runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
                <asp:Button ID="btn" PostBackUrl="~/Admin/ManageServiceType.aspx" CausesValidation=false runat="server" Text="Service Type Management" />
            </td>
            
        </tr>
    </table>


</asp:Content>

