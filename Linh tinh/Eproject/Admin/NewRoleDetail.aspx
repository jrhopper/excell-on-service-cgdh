<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewRoleDetail.aspx.cs" Inherits="Admin_NewRoleDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p style="margin-left:300px">
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="New Role Detail"></asp:Label>
    </p><br />

    <asp:Table style="margin-left:300px" runat=server Width="204px">
        <asp:TableRow ID="role" runat=server>
            <asp:TableCell runat=server>Role</asp:TableCell>
            <asp:TableCell runat=server>
                <asp:DropDownList Width=150 ID="roleList" runat="server">                    
                    
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>   
        <asp:TableRow runat=server ID="menu">
            <asp:TableCell runat=server>Menu</asp:TableCell>
            <asp:TableCell runat=server>
                <asp:DropDownList Width=150 ID="menuList" 
                 runat="server">                    
                    
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="action" runat=server>
            <asp:TableCell runat=server>Action</asp:TableCell>
            <asp:TableCell runat=server>
                <asp:DropDownList Width=150 ID="actionList" 
                 runat="server">           
                    
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat=server ID="TableRow1">
            <asp:TableCell runat=server ColumnSpan=2>
                <asp:Button style="margin-left:50px" OnClick="btnAdd_Click" Width=80 ID="btnAdd" runat="server" Text="Add" />
            </asp:TableCell>
        </asp:TableRow>      
    </asp:Table>   
    <br />
    <center>
    <asp:Button ID="btnNewRole" style="margin-left:2px" PostBackUrl="NewRole.aspx" runat="server" Text="New Role" />
    <asp:Button ID="btnNewMenu" style="margin-left:2px" runat="server" Text="New Menu" PostBackUrl="~/Admin/NewMenu.aspx" />    
    <asp:Button ID="btnNewAction" style="margin-left:2px" runat="server" Text="New Action" PostBackUrl="~/Admin/NewAction.aspx" />    
    <asp:Button ID="btnNewRoleDetail" style="margin-left:2px" runat="server" Text="New Role Detail"  PostBackUrl="~/Admin/NewRoleDetail.aspx"/>
    <asp:Button ID="btnViewRoleDetail" style="margin-left:2px" runat="server" Text="Role Detail List" PostBackUrl="~/Admin/RoleDetail.aspx" />
    <asp:Button ID="btnViewAction" style="margin-left:2px" runat="server" Text="Action List" PostBackUrl="~/Admin/Action.aspx" />
    <asp:Button ID="btnViewMenu" style="margin-left:2px" runat="server" Text="Menu List" PostBackUrl="~/Admin/Menu.aspx" />
    </center>
</asp:Content>

