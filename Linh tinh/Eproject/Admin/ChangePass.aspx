<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ChangePass.aspx.cs" Inherits="Admin_ChangePass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table BorderWidth=0 ID="Table1" runat="server" Width=500 style="margin-left:200px">
        <asp:TableRow>
            <asp:TableCell ColumnSpan=3><h3 style="color:Blue; margin-left:100px; font-size:medium">Change Password</h3></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width=120 Height=30>New Password</asp:TableCell>
            <asp:TableCell Width=300>
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode=Password></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                 ErrorMessage="New password is null" ControlToValidate="txtNewPassword" 
                 Display=Dynamic Font-Size="Smaller" Font-Bold="True">
                </asp:RequiredFieldValidator>
            </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width=120 Height=30>Cofirm New Password</asp:TableCell>
            <asp:TableCell  Width=300>
                <asp:TextBox ID="txtConfirmNewPassword" runat="server" TextMode=Password></asp:TextBox>        
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                 ErrorMessage="Confirm new password is null" Display=Dynamic
                  ControlToValidate="txtConfirmNewPassword" Font-Size="Smaller" Font-Bold="True">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" Display=Dynamic runat="server"
                 ErrorMessage="Confirm new password is not valid" ControlToCompare="txtNewPassword"
                  ControlToValidate="txtConfirmNewPassword" Font-Size="Smaller"
                   Font-Bold="True"></asp:CompareValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Height=30 ColumnSpan=2>
                <asp:Button style="margin-left:180px" OnClick="btnChange_Click" ID="btnChange" runat="server"
                 Text="Change" UseSubmitBehavior=false
                 CausesValidation=true />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

