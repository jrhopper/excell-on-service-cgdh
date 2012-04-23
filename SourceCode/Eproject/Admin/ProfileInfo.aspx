<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ProfileInfo.aspx.cs" Inherits="ProfileInfo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lbMessage" runat="server" Text="" ForeColor="Red" Font-Size="Large"></asp:Label>
<br />
     <table style="margin-left:100px; width:500px">
        <tr>            
            <td colspan=2>
                <asp:Label ID="lbProfile" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width:70px;">User name</td>
            <td style="width:200px;">
                <asp:TextBox ReadOnly=false ID="txtUserName" runat="server" TextMode=SingleLine>
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password</td>               
            <td>               
                <asp:TextBox ID="txtPassword" ReadOnly=true runat="server" TextMode=SingleLine></asp:TextBox>                                        

            </td>               
        </tr>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="txtName" runat="server" TextMode=SingleLine></asp:TextBox></td>
        </tr>
        <tr>
            <td>Birthday</td>
            <td>            
                <asp:TextBox ID="txtBirthday" ReadOnly=true runat="server" TextMode=SingleLine></asp:TextBox>                
                <asp:CalendarExtender Format="dd/mm/yyyy" ID="CalendarExtender1" runat="server" PopupButtonID="txtBirthday" TargetControlID="txtBirthday">
                </asp:CalendarExtender>                
            </td>
            
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButtonList ID="rdSex" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="0"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" TextMode=MultiLine Height="34px" 
                    Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone</td>
            <td>                
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>    
                <asp:FilteredTextBoxExtender ID="fltxtPhone" Enabled=true  
                 FilterType="Numbers" TargetControlID="txtPhone"  
                 runat="server">
                </asp:FilteredTextBoxExtender>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" TextMode=SingleLine></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                 ControlToValidate="txtEmail" 
                 runat="server" Display=Dynamic ErrorMessage="Please Enter Email" >
                 </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator Display=Dynamic ID="RegularExpressionValidator1"
                 ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                  ControlToValidate="txtEmail" 
                 runat="server" ErrorMessage="Invalid Email">
                 </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan=2 align=center>
                <asp:Button ID="btnUpdate" UseSubmitBehavior=true runat="server" Text="Update" 
                    onclick="btnUpdate_Click" />
            </td>
        </tr>
    </table>   
 
    <asp:MaskedEditExtender ID="MaskedEditExtender1"  runat="server" 
        MaskType="Number" Mask="999999999999" PromptCharacter="" 
        TargetControlID="txtPhone">
    </asp:MaskedEditExtender>
</asp:Content>

