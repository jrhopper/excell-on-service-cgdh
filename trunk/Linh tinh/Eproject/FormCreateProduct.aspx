<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateProduct.aspx.cs" Inherits="Admin_FormCreateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table cellpadding="5" cellspacing="0" border="0px" style="margin:10px auto; width: 500px; border: #CCCCCC 2px solid;">
        <tr>
            <td colspan="2" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Add new Product</td>
        </tr>
        <tr>
            <td>Name</td>
            <td><input name="txtName" id="txtName" type="text" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>            </td>
        </tr>
		<tr>
            <td>Company</td>
            <td><input name="txtCompany" id="txtCompany" type="text" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtCompany" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Company is null"></asp:RequiredFieldValidator>            </td>
        </tr>
		<tr>
            <td>Price</td>
            <td><input name="txtPrice" id="txtPrice" type="text" runat="server" />
                <asp:RequiredFieldValidator ControlToValidate="txtPrice" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Price is null"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
                    runat="server" ErrorMessage="Price is Invalid" 
                    ValidationExpression="\d+" 
                    ControlToValidate="txtPrice"></asp:RegularExpressionValidator>            </td>
        </tr>
		<tr>
            <td>CustomerID</td>
            <td><asp:DropDownList ID="ddlCustomer" runat="server" DataValueField="ddlCustomer">
                                </asp:DropDownList>
                <asp:RequiredFieldValidator ControlToValidate="ddlCustomer" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="ddlCustomer is null"></asp:RequiredFieldValidator>            </td>
        </tr>
		<tr>
            <td>Description</td>
            <td><textarea rows="5" name="txtDescription" id="txtDescription" type="text" runat="server"></textarea>            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button OnClick="btnUpdate_Click" ID="btnUpdate" runat="server" Text="Update" />
            </td>
            
        </tr>
    </table>


</asp:Content>


