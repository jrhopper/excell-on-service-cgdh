<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Department.aspx.cs" Inherits="Admin_Department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 style="text-align:center;">Department</h1>
<table style="margin: 0 auto;" width="500" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="col">&nbsp;</th>
    <th scope="col">Id</th>
    <th scope="col">Name</th>
    <th scope="col">Description</th>
  </tr>
  <tr>
    <td><a href="Edit-Dep.aspx?Name=HR Management">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">1</th>
    <td>HR Management</td>
    <td>HR Management</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">2</th>
    <td>Administration</td>
    <td>Administration</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">3</th>
    <td>Service</td>
    <td>Service</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>
    <th scope="row">4</th>
    <td>Training</td>
    <td>Training</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>
    <th scope="row">5</th>
    <td>Internet Security</td>
    <td>(It will take care of any technical related issues and problems like PC of an employee is hanged, PC of an employee is not getting started, One of the software application is not running properly, installing and uninstalling software, etc.)</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>
    <th scope="row">6</th>
    <td>Auditors</td>
    <td>Auditors</td>
  </tr>
</table>

</asp:Content>

