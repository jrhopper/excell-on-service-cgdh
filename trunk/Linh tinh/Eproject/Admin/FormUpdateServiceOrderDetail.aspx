<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateServiceOrderDetail.aspx.cs" Inherits="Admin_FormUpdateServiceOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="0" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Update Order detail</td>
        </tr>
        <tr>
            <td>Id</td>
            <td><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Service order</td>
            <td>
                <asp:DropDownList ID="ddlServiceOrder" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Employee</td>
            <td>
                <asp:DropDownList ID="ddlEmployee" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Service type</td>
            <td>
                <asp:DropDownList ID="ddlServiceType" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Task name</td>
            <td><input name="txtTaskName" id="txtTaskName" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtTaskName" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Task Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
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
            
                 
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" />
                <asp:Button ID="btn" PostBackUrl="~/Admin/ManageOrderDetail.aspx" CausesValidation=false runat="server" Text="Order Detail Management" />
            </td>
            
        </tr>
    </table>


</asp:Content>

