<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateOrderDetail.aspx.cs" Inherits="Admin_FormCreateOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Add new Service order detail</td>
        </tr>
        <tr>
            <td>Id</td>
            <td style="width: 327px"><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Service order </td>
            <td style="width: 327px">
                <asp:DropDownList ID="ddlServiceOrder" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Employee</td>
            <td style="width: 327px">
                <asp:DropDownList ID="ddlEmployee" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Task name</td>
            <td style="width: 327px"><input name="txtTaskname" id="txtTaskname" type="text" 
                    runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtTaskname" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Taskname is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
		<tr>
            <td>Description</td>
            <td style="width: 327px">
      <textarea name="txtDescription" id="txtDescription" cols="45" rows="5"></textarea></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtDescription" Display="Dynamic" ID="RequiredFieldValidator" runat="server" ErrorMessage="Description is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
		
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnCreate" runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
            </td>
            
        </tr>
    </table>


</asp:Content>

