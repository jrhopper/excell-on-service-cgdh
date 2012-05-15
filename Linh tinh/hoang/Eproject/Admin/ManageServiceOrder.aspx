<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageServiceOrder.aspx.cs" Inherits="Admin_ManageServiceOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<p>
        <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Small" 
            ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Management Service Order"></asp:Label>
    </p>
    <br />
    <p>
    <asp:GridView ID="gvServiceOrder" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" 
        onselectedindexchanged="gvServiceOrder_SelectedIndexChanged" 
    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
    CellPadding="4" CellSpacing="2" ForeColor="Black" 
        onrowdeleting="gvServiceOrder_RowDeleting" OnRowCommand="gvServiceOrder_RowCommand">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID"></asp:BoundField>
            <asp:BoundField DataField="serviceorder" HeaderText="Name">
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="employee" HeaderText="Employee">
            <ItemStyle Width="80px" />
            </asp:BoundField>
            <asp:BoundField DataField="customer" HeaderText="Customer">
            <ItemStyle Width="150px" />
            </asp:BoundField>
            <asp:BoundField DataField="servicetype" HeaderText="Service type">
            <ItemStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="begindate" HeaderText="Begindate"></asp:BoundField>
            <asp:BoundField DataField="enddate" HeaderText="Enddate"></asp:BoundField>
            <asp:BoundField DataField="complete" HeaderText="Complete"></asp:BoundField>
            <asp:BoundField DataField="description" HeaderText="Description">
            </asp:BoundField>
            <asp:ButtonField CommandName="updateServiceOrder" ButtonType="Image" 
                    ImageUrl="~/images/edit_icon.png" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField CommandName="deleteServiceOrder" ButtonType="Image" 
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
    <asp:Button ID="btnCreate" OnClick="btnCreateNew_Click" runat="server" Text="Create New Service Order" />
    </center>
</asp:Content>

