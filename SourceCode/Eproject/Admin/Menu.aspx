<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Admin_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Menu List"></asp:Label>
    </p><br />
    <p>
        <asp:GridView ID="gvMenu" AutoGenerateColumns=False runat="server" 
            EnableModelValidation="True" onrowcommand="gvMenu_RowCommand" PageSize="5">
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
                <asp:ButtonField ButtonType="Image" CommandName="update_menu" 
                    ImageUrl="~/images/edit_icon.png">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Image" CommandName="delete_menu" 
                    ImageUrl="~/images/delete_icon.png">
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="30px" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
    
    </p>
</center>
</asp:Content>

