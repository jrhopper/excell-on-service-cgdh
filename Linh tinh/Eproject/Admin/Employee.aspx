<%@ Page Title="" Language="C#" MasterPageFile="AdminMasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Admin_Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<h1 style="text-align:center;">Employee</h1>

<table style="margin: 0 auto;" width="500" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="col">&nbsp;</th>
    <th scope="col">Id</th>
    <th scope="col">Username</th>
    <th scope="col">Password</th>
    <th scope="col">Department</th>
    <th scope="col">RoleId</th>
    <th scope="col">Name</th>
    <th scope="col">Birthday</th>
    <th scope="col">Sex</th>
    <th scope="col">Address</th>
    <th scope="col">Fone</th>
    <th scope="col">Email</th>    

  </tr>
  <tr>
    <td><a href="Edit-Emp.aspx?Username=Gia">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">1</th>
    <td>Gia</td>
    <td>123</td>
    <td>Administration</td>
    <td>Admin
</td>
    <td>Huynh Trong Gia</td>
    <td>09/09/1989</td>
    <td>Male</td>
    <td>147 Tan Son st</td>
    <td>0934813161</td>
    <td>tronggia@gmail.com</td>

  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">2</th>
    <td>Chuong</td>
    <td>456</td>
    <td>Traning</td>
    <td>HR Management
</td>
    <td>La Quoc Chuong</td>
    <td>01/01/2001</td>
    <td>Female</td>
    <td>123 Nam Ky Khoi Nghia</td>
    <td>0909198999</td>
    <td>chuong@gmail.com</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">3</th>
    <td>Dai</td>
    <td>789</td>
    <td>Service</td>
    <td>Employee
</td>
    <td>Anh Dai</td>
    <td>02/02/2002</td>
    <td>Male</td>
    <td>789 Au Co</td>
    <td>0123456789</td>
    <td>Dai@gmail.com</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">4</th>
    <td>Hoang</td>
    <td>234</td>
    <td>Auditors</td>
    <td>Service Management
</td>
    <td>Le Hoang</td>
    <td>03/03/2003</td>
    <td>Male</td>
    <td>456 Cach mang Thang 8</td>
    <td>0934343434</td>
    <td>Hoang@gmail.com</td>
  </tr>
</table>

<p style="float:right; padding-right:20px"><a href=#>Print report</a></p>
</asp:Content>