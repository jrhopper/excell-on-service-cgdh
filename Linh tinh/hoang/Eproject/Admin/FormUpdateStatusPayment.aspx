<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateStatusPayment.aspx.cs" Inherits="Admin_FormUpdateStatusPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="0" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Update Status payment</td>
        </tr>
        <tr>
            <td>Id</td>
            <td><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Service Order</td>
            <td>
                <asp:DropDownList ID="ddlServiceOrder" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                    <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
		<tr>
            <td>Status</td>
            <td>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>Date</td>
            <td>
                <input name="txtDate" id="txtDate" type="text" runat="server" readonly="readonly"/>
                
                <asp:Calendar ID="Calendar1" runat="server" PopupPosition=Right Format="dd/MM/yyyy" PopupButtonID=txtDate TargetControlID=txtDate ></asp:Calendar></td>
            <td>
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
                <asp:Button ID="btn" PostBackUrl="~/Admin/ManageStatusPayment.aspx" CausesValidation=false runat="server" Text="Status Payment Management" />
            </td>
            
        </tr>
    </table>


</asp:Content>

