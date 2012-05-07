<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateCustomer.aspx.cs" Inherits="Admin_FormCreateCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Add new Customer</td>
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
                <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
		<tr>
            <td>Address</td>
            <td><input name="txtAddress" id="txtAddress" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtAddress" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Address is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
		<tr>
            <td>Phone</td>
            <td><input name="txtPhone" id="txtPhone" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtPhone" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Phone is null"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
                    runat="server" ErrorMessage="Phone is Invalid" 
                    ValidationExpression="\d{10,11}" 
                    ControlToValidate="txtPhone"></asp:RegularExpressionValidator>
            </td>
        </tr>
		<tr>
            <td>Email</td>
            <td><input name="txtEmail" id="txtEmail" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtEmail" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email is null"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" 
                    runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Invalid" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
		<tr>
            <td>Contact</td>
            <td><input name="txtContact" id="txtContact" type="text" runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Company</td>
            <td><input name="txtCompany" id="txtCompany" type="text" runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnCreate" runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
            </td>
            
        </tr>
    </table>


</asp:Content>

