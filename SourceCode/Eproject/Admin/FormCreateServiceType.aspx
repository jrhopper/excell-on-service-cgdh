<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateServiceType.aspx.cs" Inherits="Admin_FormCreateServiceType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Add new Service type</td>
        </tr>
        <tr>
            <td>Id</td>
            <td style="width: 327px"><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
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
            <td>Image</td>
            <td style="width: 327px">
                <asp:FileUpload ID="fuImage" runat="server" />
            </td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Charges</td>
            <td style="width: 327px">
                <input name="txtCharges" id="txtCharges" type="text" 
                    runat="server" /></td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Description</td>
            <td style="width: 327px">
      <textarea name="txtDescription" id="txtDescription" cols="45" rows="5"></textarea></td>
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

