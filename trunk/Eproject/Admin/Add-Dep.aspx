<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Add-Dep.aspx.cs" Inherits="Admin_Add_Dep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 style="text-align:center">Add new Department</h1>
<table style="margin:0 auto; text-align:left" width="371" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="row">Name</th>
    <td><form id="form2" name="form2" method="post" action="">
      <label for="textfield"></label>
      <input type="text" name="textfield" id="textfield" />
    </form></td>
  </tr>
  <tr>
    <th scope="row">Description</th>
    <td><textarea name="Description" id="Description" cols="45" rows="5"></textarea></td>
  </tr>
  <tr>
    <th colspan="2" scope="row" style="text-align:center"><form id="form1" name="form1" method="post" action="">
      <input type="submit" name="submit" id="submit" value="Add" />
      &nbsp;&nbsp;<input type="submit" name="submit2" id="submit2" value="Reset" />
    </form></th>
  </tr>
</table>

</asp:Content>

