<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="RoleDetailList.aspx.cs" Inherits="Admin_RoleDetailList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
     <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Role Detail List"></asp:Label>
    </p>

    <br />
    <p>
    <asp:GridView ID="gvRoleDetail" runat="server" AutoGenerateColumns="False" 
         EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="RoleDetailId" HeaderText="Id">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="130px" 
                Height="30px" />
            </asp:BoundField>
            <asp:BoundField DataField="menuid" HeaderText="Menu Id" Visible="False">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="roleid" HeaderText="Role Id" Visible="False">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="actionid" HeaderText="Action Id" Visible="False">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="actionname" HeaderText="Action Name">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="400px" />
            </asp:BoundField>
            <asp:BoundField DataField="menuname" HeaderText="Menu Name">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="300px" />
            </asp:BoundField>
            <asp:BoundField DataField="rolename" HeaderText="Role Name">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="300px" />
            </asp:BoundField>
            <asp:BoundField DataField="RoleDetailDescription" HeaderText="Description">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="350px" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
    </p>
</center>
</asp:Content>

