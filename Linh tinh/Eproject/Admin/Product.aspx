<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Admin_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1 style="text-align:center;">Product</h1>

<table style="margin: 0 auto;" width="500" border="1" cellspacing="0" cellpadding="5">
  <tr>
    <th scope="col">&nbsp;</th>
    <th scope="col">Id</th>
    <th scope="col">Name</th>
    <th scope="col">Company</th>
    <th scope="col">Price</th>
    <th scope="col">Customer Name</th>
    <th scope="col">Description</th>
  </tr>
  <tr>
    <td><a href="Edit-Pro.aspx?Name=Exciter GP 2011">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">1</th>
    <td>Exciter GP 2011</td>
    <td>Yamaha</td>
    <td>2.307,69 $</td>
    <td>Mr A
</td>
    <td>best</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">2</th>
    <td>Jupiter RC 2011</td>
    <td>Yamaha</td>
    <td>1.807,69 $</td>
    <td>Mr B</td>
    <td>good</td>
  </tr>
  <tr>
    <td><a href="#">Edit</a>&nbsp;|&nbsp;<a href="#">Delete</a></td>  
    <th scope="row">3</th>
    <td>Mio Classico</td>
    <td>Yamaha</td>
    <td>2.007,69 $</td>
    <td>Mr. C
</td>
    <td>best</td>
  </tr>
</table>

</asp:Content>

