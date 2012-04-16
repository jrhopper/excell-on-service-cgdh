<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

	<div id="contents">
		<div class="background">

        <h1 style="text-align:center">Feedback</h1>
<form action="URL to form script" method="POST">

Your name: <br>
<input type="text" name="realname"><br>
<br>

Your email: <br>
<input type="text" name="email"><br>
<br>

Your comments: <br>
<textarea name="comments" rows="15" cols="50"></textarea><br><br>

<input type="button" value="Submit" onclick="window.alert ('Sorry! This is an example form only.');"> 
</form>

		</div>
	</div>

</asp:Content>
