<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateServiceOrder.aspx.cs" Inherits="Admin_FormCreateServiceOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="0" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Add new Service Order </td>
        </tr>
        <tr>
            <td>Id</td>
            <td><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
		<tr>
            <td>Employee</td>
            <td>
                <asp:DropDownList ID="ddlEmployee" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
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
            <td>Customer</td>
            <td>
                <asp:DropDownList ID="ddlCustomer" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Service type</td>
            <td>
                <asp:DropDownList ID="ddlServiceType" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Begin date</td>
            <td>
                <input name="txtBeginDate" id="txtBeginDate" type="text" runat="server" readonly="readonly"/>
                
                <asp:Calendar ID="Calendar1" runat="server" PopupPosition=Right Format="dd/MM/yyyy" PopupButtonID=txtBeginDate TargetControlID=txtBeginDate ></asp:Calendar>
                
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>End date</td>
            <td>
                <input name="txtEndDate" id="txtEndDate" type="text" runat="server" readonly="readonly"/>
                <asp:Calendar ID="Calendar2" runat="server" PopupPosition=Right Format="dd/MM/yyyy" PopupButtonID=txtEndDate TargetControlID=txtEndDate></asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Complete</td>
            <td>
                <asp:DropDownList ID="ddlComplete" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
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
                <asp:Button ID="btn" PostBackUrl="~/Admin/ManageServiceOrder.aspx" CausesValidation=false runat="server" Text="Service Order Management" />
            </td>
            
        </tr>
    </table>


</asp:Content>

