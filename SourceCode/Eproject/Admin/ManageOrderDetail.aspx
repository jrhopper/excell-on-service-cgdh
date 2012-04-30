<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageOrderDetail.aspx.cs" Inherits="Admin_ManageOrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <p>
        <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Small" 
            ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Management Order Detail"></asp:Label>
    </p>
    <br />
    <p>
    <asp:GridView ID="gvServiceOrderDetail" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" 
        onselectedindexchanged="gvServiceOrderDetail_SelectedIndexChanged" 
    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
    CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            
            <asp:BoundField DataField="id" HeaderText="ID"></asp:BoundField>
            
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
            <asp:ButtonField CommandName="updateDepartment" ButtonType="Image" 
                    ImageUrl="~/images/edit_icon.png" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField CommandName="deleteDepartment" ButtonType="Image" 
                    ImageUrl="~/images/delete_icon.png" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
        </Columns>
        <EditRowStyle Width="300px" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        

        
    </asp:GridView>
    <br />
    </p>
    <asp:Button ID="btnCreate" OnClick="btnCreateNew_Click" runat="server" Text="Create New Order Detail" />
</center>
</asp:Content>

