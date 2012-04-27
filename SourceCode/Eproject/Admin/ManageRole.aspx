<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageRole.aspx.cs" Inherits="Admin_ManageRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<center>
    <p>
        <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Small" 
            ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Role Management"></asp:Label>
    </p>
    <br />
    <p>
        <asp:GridView  ID="gvRole" runat="server" 
            AutoGenerateColumns="False" EnableModelValidation="True" 
            onrowcommand="gvRole_RowCommand">
            <Columns>
                   
                <asp:BoundField DataField="id" HeaderText="ID" Visible=true >
                <HeaderStyle Font-Bold="True" Height="25px" HorizontalAlign="Center" 
                    VerticalAlign="Top" />
                <ItemStyle Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="Name"  >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="description" HeaderText="Description" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                </asp:BoundField>
                <asp:ButtonField CommandName="updateRole" ButtonType="Image" 
                    ImageUrl="~/images/edit_icon.png" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField CommandName="deleteRole" ButtonType="Image" 
                    ImageUrl="~/images/delete_icon.png" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                
                <asp:ButtonField CommandName="detail_" Text="Detail_" Visible=false />
            </Columns>
        </asp:GridView>
        <br />
    </p>
    <asp:Button ID="btnNewRole" style="margin-left:2px" OnClick="btnNewRole_Click" runat="server" Text="New Role" />
    <asp:Button ID="btnNewMenu" style="margin-left:2px" runat="server" Text="New Menu" PostBackUrl="~/Admin/NewMenu.aspx" />    
    <asp:Button ID="btnNewAction" style="margin-left:2px" runat="server" Text="New Action" PostBackUrl="~/Admin/NewAction.aspx" />    
    <asp:Button ID="btnNewRoleDetail" style="margin-left:2px" runat="server" Text="New Role Detail"  PostBackUrl="~/Admin/NewRoleDetail.aspx"/>
    <asp:Button ID="btnViewRoleDetail" style="margin-left:2px" runat="server" Text="Role Detail List" PostBackUrl="~/Admin/RoleDetail.aspx" />
    <asp:Button ID="btnViewAction" style="margin-left:2px" runat="server" Text="Action List" PostBackUrl="~/Admin/Action.aspx" />
    <asp:Button ID="btnViewMenu" style="margin-left:2px" runat="server" Text="Menu List" PostBackUrl="~/Admin/Menu.aspx" />
    
</center>
</asp:Content>

