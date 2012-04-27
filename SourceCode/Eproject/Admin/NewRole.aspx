<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewRole.aspx.cs" Inherits="Admin_FormCreateRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <p style="margin-left:350px">
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="New Role"></asp:Label>
    </p>

    <br />
        
    <table style="margin-left:300px" width=400>
        
        <tr>
            <td>Name</td>
            <td style="width:300px"><input name=txtName id=txtName type=text runat=server />
            
                <asp:RequiredFieldValidator ControlToValidate=txtName  Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red" Display=Dynamic ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Description</td>
            <td><asp:TextBox ID="txtDescription" runat="server" TextMode=MultiLine></asp:TextBox></td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td colspan=2>
            
                 
                <asp:Button style="margin-left:80px" ID="btnCreate" UseSubmitBehavior=false  runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
            <asp:Button ID="btn" PostBackUrl="~/Admin/ManageRole.aspx" CausesValidation=false runat="server" Text="Role Management" 
                     />
            </td>
            
        </tr>
    </table>
        

</asp:Content>

