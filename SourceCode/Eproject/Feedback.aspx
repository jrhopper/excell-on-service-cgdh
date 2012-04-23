<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="contents">
<div class="background">
<div style="margin: 0 auto; width: 540px;">
    <h1 style="text-align:center">Feedback</h1>
    <asp:TextBox  Visible="false" ID="txtTo" runat="server" Width="300px">tronggia@gmail.com,qchuong100@gmail.com</asp:TextBox>
    <br /><br />
    Your email:&nbsp;&nbsp;&nbsp;
    
    <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox> &nbsp; <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txtEmail" ErrorMessage="Email is invalid" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Bold="True" Font-Size="Small"></asp:RegularExpressionValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Email is Required" ControlToValidate="txtEmail" Font-Size="Small" Font-Bold="True"></asp:RequiredFieldValidator>
    <br /><br />
    Subject:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSubject" runat="server" Width="300px"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="Subject is Required" ControlToValidate="txtSubject" Font-Size="Small" Font-Bold="True"></asp:RequiredFieldValidator>
    <br /><br />
    Body:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtBody" runat="server" Rows="6" TextMode="MultiLine" 
        Width="300px"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="Body is Required" ControlToValidate="txtBody" Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
    <br /><p style="text-align: center">        
    <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" 
        Text="Send Feedback" ToolTip="Send Feedback" /></p>
</div>
</div></div>
</asp:Content>