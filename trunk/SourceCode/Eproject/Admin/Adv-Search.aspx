<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Adv-Search.aspx.cs" Inherits="Admin_Adv_Search" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 style="text-align:center;">Advanced Search</h1>

<!--
<form action="" method="post">
<input name="" type="checkbox" value="Customer" checked /> 
Customer <input name="" type="checkbox" value="Service type" /> 
Service type <input name="" type="checkbox" value="Service order" /> 
Service order <input style="height: 25px; margin: 0 auto; border: #CCC 1px solid; padding: 2px 2px 2px 5px; width: 200px; color: #6E6E6E" type="text" value="Advanced Search" onblur="javascript:if(this.value==''){this.value=this.defaultValue;}" onfocus="javascript:if(this.value==this.defaultValue){this.value='';}">
            <input type="submit" value="Go" style="cursor: pointer;">
</form>

-->

<form id="form1" name="form1" method="post" action="">	
	<table width="939" border="1" cellpadding="3" cellspacing="0">
	  <tr>
	    <td width="132">Customer name</td>
	    <td width="172"><label for="textfield"></label>
        <input type="text" name="textfield" id="textfield" /></td>
	    <td width="140">Email</td>
	    <td width="169"><input type="text" name="textfield3" id="textfield3" /></td>
	    <td width="142">Phone
        <input type="text" name="textfield4" id="textfield4" /></td>
	    <td width="144">&nbsp;</td>
      </tr>
	  <tr>
	    <td>Service order name</td>
	    <td><select name="select2" id="select2">
	      <option>service 1</option>
	      <option>service 2</option>
        </select></td>
	    <td>Status payment</td>
	    <td><input type="radio" name="radio" id="radio" value="radio" />
        <label for="radio">Paid</label>
        <input type="radio" name="radio" id="radio2" value="radio" />
        <label for="radio2">Unpaid</label></td>
	    <td>Begin Date
        <input type="text" name="textfield5" id="textfield5" /></td>
	    <td>End Date
          <input type="text" name="textfield6" id="textfield6" /></td>
      </tr>
	  <tr>
	    <td>Product name</td>
	    <td><input type="text" name="textfield2" id="textfield2" /></td>
	    <td><input type="submit" name="button" id="button" value="Search" /></td>
	    <td><label for="select"></label>
	      <label for="select"></label></td>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
      </tr>
	  <tr>
	    <td colspan="6">&nbsp;</td>
      </tr>
	  <tr>
	    <td>Employee name</td>
	    <td><label for="textfield2"></label>
	      <input type="text" name="textfield7" id="textfield2" /></td>
	    <td>Email</td>
	    <td><input type="text" name="textfield7" id="textfield7" /></td>
	    <td>Phone
	      <input type="text" name="textfield7" id="textfield8" /></td>
	    <td>Birthday
        <input type="text" name="textfield8" id="textfield9" /></td>
      </tr>
	  <tr>
	    <td>Role </td>
	    <td><select name="select" id="select">
	      <option>Admin</option>
	      <option>HR Manager</option>
	      <option>Service Manager</option>
	      <option>Service Order Manager</option>
        </select></td>
	    <td>sex</td>
	    <td><select name="select3" id="select3">
	      <option>Male</option>
	      <option>Female</option>
        </select></td>
	    <td>Department 
	      <select name="select4" id="select4">
	        <option>HR Management</option>
	        <option>Administration</option>
	        <option>Service</option>
	        <option>Training</option>
	        <option>Internet security</option>
	        <option>Auditor</option>
        </select></td>
	    <td><input type="submit" name="button2" id="button2" value="Search" /></td>
      </tr>
	  <tr>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
	    <td>&nbsp;</td>
      </tr>
  </table>
</form>



</asp:Content>