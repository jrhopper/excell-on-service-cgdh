<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Add-Emp.aspx.cs" Inherits="Admin_Add_Emp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 style="text-align:center;">Add new Employee</h1>

<table style="margin:0 auto; text-align:left" width="371" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="row">Username</th>
    <td><form id="form2" name="form2" method="post" action="">
      <label for="textfield"></label>
      <input type="text" name="textfield" id="textfield" />
    </form></td>
  </tr>
  <tr>
    <th scope="row">Password</th>
    <td><input type="text" name="textfield2" id="textfield2" /></td>
  </tr>
  <tr>
    <th scope="row"> Department</th>
    <td><form name="form3" id="form3">
      <select name="jumpMenu2" id="jumpMenu2" onchange="MM_jumpMenu('parent',this,0)">
        <option>HR Management</option>
        <option>Administration</option>
        <option>Service</option>
        <option>Training</option>
        <option>Internet sercurity</option>
        <option>Auditors</option>
      </select>
    </form></td>
  </tr>
  <tr>
    <th scope="row">Role</th>
    <td><form name="form" id="form">
      <select name="jumpMenu" id="jumpMenu" onchange="MM_jumpMenu('parent',this,0)">
        <option>Admin</option>
        <option>HR Management</option>
        <option>Service Management</option>
        <option>Employee</option>
      </select>
    </form></td>
  </tr>
  <tr>
    <th scope="row">Fullname</th>
    <td><input type="text" name="textfield5" id="textfield5" /></td>
  </tr>
  <tr>
    <th scope="row">Birthday</th>
    <td><input type="text" name="textfield3" id="textfield3" /></td>
  </tr>
  <tr>
    <th scope="row">Sex</th>
    <td><form id="form4" name="form4" method="post" action="">
      <input type="radio" name="radio" id="Male" value="Male" />
      <label for="Male"></label>
<label for="Male"></label>
    Male 
    <input type="radio" name="radio" id="Female" value="Female" />
    <label for="Female"></label>
    Female
    </form></td>
  </tr>
  <tr>
    <th scope="row">Address</th>
    <td><input type="text" name="textfield8" id="textfield8" /></td>
  </tr>
  <tr>
    <th scope="row">Fone</th>
    <td><input type="text" name="textfield9" id="textfield9" /></td>
  </tr>
  <tr>
    <th scope="row">Email</th>
    <td><input type="text" name="textfield10" id="textfield10" /></td>
  </tr>
  <tr>
    <th colspan="2" scope="row" style="text-align:center"><form id="form1" name="form1" method="post" action="">
      <input type="submit" name="submit" id="submit" value="Add" />
      &nbsp;&nbsp;<input type="submit" name="submit2" id="submit2" value="Reset" />
    </form></th>
  </tr>
</table>
</asp:Content>