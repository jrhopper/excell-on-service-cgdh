﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageServiceOrderDetail.aspx.cs" Inherits="Admin_ManageServiceOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="gvServiceOrderDetail" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" AutoGenerateDeleteButton="True" 
        AutoGenerateEditButton="True" AutoGenerateSelectButton="True" 
        onselectedindexchanged="gvServiceOrderDetail_SelectedIndexChanged" 
    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
    CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:BoundField DataField="serviceorder" HeaderText="Service order">
            </asp:BoundField>
            <asp:BoundField DataField="employee" HeaderText="Employee">
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField DataField="taskname" HeaderText="Task name">
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="description" HeaderText="Description">
            </asp:BoundField>
        </Columns>
        <EditRowStyle Width="300px" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        

        
    </asp:GridView>

</asp:Content>

