<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateProduct.aspx.cs" Inherits="Admin_FormUpdateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Update Product</td>
        </tr>
        <tr>
            <td style="width: 71px">Id</td>
            <td style="width: 150px"><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td style="width: 241px"></td>
        </tr>
        <tr>
            <td style="width: 71px">Name</td>
            <td style="width: 150px"><input name="txtName" id="txtName" type="text" runat="server" /></td>
            <td style="width: 241px">
                <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
		<tr>
            <td style="width: 71px">Company</td>
            <td style="width: 150px"><input name="txtCompany" id="txtCompany" type="text" runat="server" /></td>
            <td style="width: 241px">
                <asp:RequiredFieldValidator ControlToValidate="txtCompany" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Company is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
		<tr>
            <td style="width: 71px">Price</td>
            <td style="width: 150px"><input name="txtPrice" id="txtPrice" type="text" runat="server" /></td>
            <td style="width: 241px">
                <asp:RequiredFieldValidator ControlToValidate="txtPrice" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Price is null"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
                    runat="server" ErrorMessage="Price is Invalid" 
                    ValidationExpression="\d+" 
                    ControlToValidate="txtPrice"></asp:RegularExpressionValidator>
            </td>
        </tr>
		<tr>
            <td style="width: 71px">Customer</td>
            <td style="width: 150px">
             <asp:DropDownList ID="ddlCustomer" runat="server" DataValueField="ddlCustomer">
                                </asp:DropDownList>                
            </td>
            <td style="width: 241px">
                <asp:RequiredFieldValidator ControlToValidate="ddlCustomer" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Customer is null"></asp:RequiredFieldValidator>
          
            </td>
        </tr>
		<tr>
            <td style="width: 71px">Description</td>
            <td style="width: 150px"><input name="txtDescription" id="txtDescription" type="text" runat="server" /></td>
            <td style="width: 241px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:Button OnClick="btnUpdate_Click" ID="btnUpdate" runat="server" Text="Update" />
            </td>
            
        </tr>
    </table>


</asp:Content>

