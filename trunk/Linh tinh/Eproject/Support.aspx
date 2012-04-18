<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Support.aspx.cs" Inherits="Support" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8" />
<script type="text/javascript" src="javascript/jquery.js"></script>

<script type="text/javascript">
    function initSpoilers(context) {
        var context = context || 'body';
        $('div.spoiler-head', $(context))
        .click(function () {
            $(this).toggleClass('unfolded');
            $(this).next('div.spoiler-body').slideToggle('fast');
        })
    ;
    }

    $(document).ready(function () {
        initSpoilers('body');
    });
</script>	
	<div id="header">
    <div class="spoiler-wrap">
    <div class="spoiler-head folded clickable">Login / Logout</div>
    <div class="spoiler-body" style="display: none; ">
    <form action="" method="post">
    <table border="0" cellpadding="3px" cellspacing="0px">
    <tr><td style="padding-top: 5px;">Username: </td>    <td><input type="text" value="Username" class="htg-field" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}" /></td></tr>
    <tr><td style="padding-top: 5px;">Password: </td>    <td><input type="password" value="" class="htg-field" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}" /></td></tr>
    <tr><td colspan="2" align="center"><input type="submit" value="Login" title="Login"></td></tr>
    </table>
    </form>
    </div>
    </div>
		<a href="Default.aspx" id="logo"><img src="images/logoEOS.png" alt="LOGO" /></a>
		<div id="navigation">
			<ul>
				<li><a href="Default.aspx">Home</a></li>
				<li><a href="About.aspx">About us</a></li>
				<li><a href="Services.aspx">Services</a></li>
				<li><a href="Solutions.aspx">Solutions</a></li>
				<li class="first selected"><a href="Support.aspx">Support</a></li>
				<li><a href="Feedback.aspx">Feedback</a></li>
				<li><a href="Contact.aspx">Contact</a></li>
			</ul>
		</div>
		<div id="search">
			<form action="" method="">
				<input type="text" value="Search" class="txtfield" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}" />
				<input type="submit" value="Search" class="button" />
			</form>
		</div>
	</div> <!-- /#header -->
	<div id="contents">
		<div class="background">
<br />Updating...<br />
		</div>
	</div> <!-- /#contents -->
	<div id="footer">
		<ul class="contacts">
			<h3>Contact Us</h3>
			<li><span>Email</span><p>: tronggia@gmail.com</p></li>
			<li><span>Address</span><p>: Nguyen Chi Thanh st, Ho Chi Minh City</p></li>
			<li><span>Phone</span><p>: 0934 81 31 61</p></li>
		</ul>		
		<div id="newsletter" class="htg">
			<p><b>Login</b>
			if you do not have account, please contact <a href="mailto:tronggia@gmail.com" border="0" target=_blank title="send an email to Administrator">Administrator</a>
			</p>
			<form action="" method="">
				<input type="text" value="Username" class="txtfield" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}" />
				<input type="password" value="" class="txtfield" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}" />
				<input type="submit" value="" title="Login" class="button" />
			</form>
		</div>
		<span class="footnote">Copyright &copy; 2012 Excell-On Service. All rights reserved - <a href="Admin/Default.aspx" title="Admin Control Panel">Admin Control Panel</a></span>
	</div> <!-- /#footer -->

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
