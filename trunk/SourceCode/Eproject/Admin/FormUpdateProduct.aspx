<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateProduct.aspx.cs" Inherits="Admin_FormUpdateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Update Product</td>
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
            <td>Company</td>
            <td><input name="txtCompany" id="txtCompany" type="text" runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Price</td>
            <td><input name="txtPrice" id="txtPrice" type="text" runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Customer</td>
            <td>
                <asp:DropDownList ID="ddlCustomer" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Description</td>
            <td>
      <textarea name="txtDescription" id="txtDescription" cols="45" rows="5"></textarea></td>
            <td>
                &nbsp;</td>
        </tr>
		
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" />
            </td>
            
        </tr>
    </table>


</asp:Content>

