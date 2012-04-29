<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="RoleDetail.aspx.cs" Inherits="Admin_RoleDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style>
.left
{
    padding-left:20px;
}
</style>
    
<center>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Role Detail List"></asp:Label>
    </p><br />
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
    
    Role: <asp:DropDownList ID="roleList" runat="server" AutoPostBack=true  Width=150 
        onselectedindexchanged="roleList_SelectedIndexChanged">
        <asp:ListItem Value="-1" Selected=True Text="All"></asp:ListItem>
    </asp:DropDownList>
    <p>
        <asp:GridView ID="gvRoleDetail" AutoGenerateColumns=False runat="server"  
            EnableModelValidation="True" onrowcommand="gvRoleDetail_RowCommand" PageSize="5">
            <Columns>
                <asp:BoundField DataField="roledetailid" HeaderText="ID">
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" CssClass=left Width="50px" 
                    Height="30px" />
                </asp:BoundField>
                <asp:BoundField DataField="rolename" HeaderText="Role">
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" CssClass=left Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="menuname" HeaderText="Menu">
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" CssClass=left Width="220px" />
                </asp:BoundField>
                <asp:BoundField DataField="actionname" HeaderText="Action">
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" CssClass=left Width="250px" />
                </asp:BoundField>
                <asp:ButtonField ButtonType="Image" CommandName="update_RoleDetail" 
                    ImageUrl="~/images/edit_icon.png">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" CommandName="delete_RoleDetail" 
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
    
    </ContentTemplate>
    </asp:UpdatePanel>

</center>
</asp:Content>

