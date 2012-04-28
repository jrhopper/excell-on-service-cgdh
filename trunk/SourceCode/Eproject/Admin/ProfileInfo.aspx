<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ProfileInfo.aspx.cs" Inherits="ProfileInfo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="../css/Profile.css" rel="stylesheet" type="text/css" />

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    

    <asp:Label ID="lbMessage" style="margin-left:300px" CssClass="lbMessage"
     runat="server" Text="123123123" ForeColor="Red" Font-Size="Medium" Font-Bold=true></asp:Label>
    <br />
    <br />

    <asp:Label ID="lbProfile" style="margin-left:280px;" ForeColor=Blue Font-Size=20 Font-Bold=true runat="server" Text="My Profile"></asp:Label>


<br />
     <table cellpadding=1 cellspacing=1 border=0 style="margin-left:200px; width:500px">     
        <tr>
            <td style="width:80px; height:35px ">User name</td>
            <td style="width:300px; height:35px ">
                <asp:TextBox ReadOnly=true ID="txtUserName" runat="server" TextMode=SingleLine>
                </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Password</td>               
            <td style="width:300px; height:35px ">   
                <asp:LinkButton ID="btnChangePassword" PostBackUrl="~/Admin/ChangePass.aspx" runat="server">Change password</asp:LinkButton>                                                                        
            </td>               
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Name</td>
            <td style="width:300px; height:35px ">
                <asp:TextBox ID="txtName" runat="server" TextMode=SingleLine></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate=txtName 
                runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Birthday</td>
            <td style="width:300px; height:35px ">            
                <asp:TextBox ID="txtBirthday" ReadOnly=true runat="server" TextMode=SingleLine></asp:TextBox>                
                <asp:CalendarExtender PopupPosition=Right Format="dd/mm/yyyy" ID="CalendarExtender1" runat="server" PopupButtonID="txtBirthday" TargetControlID="txtBirthday">
                </asp:CalendarExtender>                
            </td>
            
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Gender</td>
            <td style="width:300px; height:35px ">
                <asp:RadioButtonList ID="rdSex" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="0"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Address</td>
            <td style="width:300px; height:35px ">
                <asp:TextBox ID="txtAddress" runat="server" TextMode=MultiLine Height="34px" 
                    Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Phone</td>
            <td style="width:300px; height:35px ">                
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>    
                <asp:FilteredTextBoxExtender ID="fltxtPhone" Enabled=true  
                 FilterType="Numbers" TargetControlID="txtPhone"  
                 runat="server">
                </asp:FilteredTextBoxExtender>               
            </td>
        </tr>
        <tr>
            <td style="width:50px; height:35px ">Email</td>
            <td style="width:300px; height:35px ">
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
            <td colspan=2  style="height:35px ">
                <asp:Button style="margin-left:100px" ID="btnUpdate" UseSubmitBehavior=False runat="server" Text="Update" 
                    onclick="btnUpdate_Click" Enabled="true" />
            </td>
        </tr>
    </table>
</asp:Content>

