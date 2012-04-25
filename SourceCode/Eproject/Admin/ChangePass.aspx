<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ChangePass.aspx.cs" Inherits="Admin_ChangePass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table ID="Table1" runat="server">
    <asp:TableRow>
        <asp:TableCell ColumnSpan=3><h3>Change Password</h3></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>New Password</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtNewPassword" runat="server" TextMode=Password></asp:TextBox>
        </asp:TableCell>
        <asp:TableCell>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
             ErrorMessage="New password is null" ControlToValidate="txtNewPassword" 
             Display=Dynamic Font-Size="Smaller" Font-Bold="True">
            </asp:RequiredFieldValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>Cofirm New Password</asp:TableCell>
        <asp:TableCell>
            <asp:TextBox ID="txtConfirmNewPassword" runat="server" TextMode=Password></asp:TextBox>        
        </asp:TableCell>
        <asp:TableCell>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
             ErrorMessage="Confirm new password is null" Display=Dynamic
              ControlToValidate="txtConfirmNewPassword" Font-Size="Smaller" Font-Bold="True">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server"
             ErrorMessage="Confirm new password is not valid" ControlToCompare="txtNewPassword"
              ControlToValidate="txtConfirmNewPassword" Font-Size="Smaller" Font-Bold="True"></asp:CompareValidator>
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell ColumnSpan=3>
            <asp:Button OnClick="btnChange_Click" ID="btnChange" runat="server" Text="Change" UseSubmitBehavior=false
             CausesValidation=true />
        </asp:TableCell>
    </asp:TableRow>
    </asp:Table>
</asp:Content>

