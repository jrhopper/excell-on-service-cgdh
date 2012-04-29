<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="RoleDetail.aspx.cs" Inherits="Admin_RoleDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Role Detail List"></asp:Label>
    </p><br />
    <p>
        <asp:GridView ID="gvAction" AutoGenerateColumns=False runat="server" 
            EnableModelValidation="True" onrowcommand="gvAction_RowCommand" PageSize="5">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" 
                    Height="30px" />
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="Name">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="link" HeaderText="Link">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="220px" />
                </asp:BoundField>
                <asp:BoundField DataField="description" HeaderText="Description">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="180px" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Image" CommandName="update_Action" 
                    ImageUrl="~/images/edit_icon.png">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" CommandName="delete_Action" 
                    ImageUrl="~/images/delete_icon.png">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
    
    </p>
    
    <asp:Button ID="btnNewRole" style="margin-left:2px" PostBackUrl="NewRole.aspx" runat="server" Text="New Role" />
    <asp:Button ID="btnNewMenu" style="margin-left:2px" runat="server" Text="New Menu" PostBackUrl="~/Admin/NewMenu.aspx" />    
    <asp:Button ID="btnNewAction" style="margin-left:2px" runat="server" Text="New Action" PostBackUrl="~/Admin/NewAction.aspx" />    
    <asp:Button ID="btnNewRoleDetail" style="margin-left:2px" runat="server" Text="New Role Detail"  PostBackUrl="~/Admin/NewRoleDetail.aspx"/>
    <asp:Button ID="btnViewRoleDetail" style="margin-left:2px" runat="server" Text="Role Detail List" PostBackUrl="~/Admin/RoleDetail.aspx" />
    <asp:Button ID="btnViewAction" style="margin-left:2px" runat="server" Text="Action List" PostBackUrl="~/Admin/Action.aspx" />
    <asp:Button ID="btnViewMenu" style="margin-left:2px" runat="server" Text="Menu List" PostBackUrl="~/Admin/Menu.aspx" />
    
</center>
</asp:Content>

