<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Edit-Pro.aspx.cs" Inherits="Admin_Edit_Pro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1 style="text-align:center;">Edit Product</h1>

<table style="margin:0 auto; text-align:left" width="371" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="row">Name</th>
    <td><form id="form2" name="form2" method="post" action="">
      <label for="textfield"></label>
      <input type="text" name="textfield" id="textfield" />
    </form></td>
  </tr>
  <tr>
    <th scope="row">Company</th>
    <td><input type="text" name="textfield2" id="textfield2" /></td>
  </tr>
  <tr>
    <th scope="row"> Price</th>
    <td><form name="form3" id="form3">
      <input type="text" name="textfield4" id="textfield4" /> 
      $
    </form></td>
  </tr>
  <tr>
    <th scope="row">Customer Name</th>
    <td><form name="form" id="form">
      <input type="text" name="textfield3" id="textfield3" />
    </form></td>
  </tr>
  <tr>
    <th scope="row">Description</th>
    <td><form id="form4" name="form4" method="post" action="">
      <label for="textarea"></label>
      <textarea name="textarea" id="textarea" cols="45" rows="5"></textarea>
    </form></td>
  </tr>
  <tr>
    <th colspan="2" scope="row" style="text-align:center"><form id="form1" name="form1" method="post" action="">
      <input type="submit" name="submit" id="submit" value="Add" />
      &nbsp;&nbsp;<input type="submit" name="submit2" id="submit2" value="Reset" />
    </form></th>
  </tr>
</table>

</asp:Content>

