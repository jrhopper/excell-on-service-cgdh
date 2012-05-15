<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ManageDepartment.aspx.cs" Inherits="Admin_ManageDepartment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<center>
    <p>
        <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Small" 
            ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Size="25pt" 
            ForeColor="#0066FF" Text="Management Department"></asp:Label>
    </p>
    <br />
    <p>
        <asp:GridView  ID="gvDepartment" runat="server" 
            AutoGenerateColumns="False" EnableModelValidation="True" 
            onrowcommand="gvDepartment_RowCommand">
            <Columns>
                   
                <asp:BoundField DataField="id" HeaderText="ID" Visible="true" >
                <HeaderStyle Font-Bold="True" Height="25px" HorizontalAlign="Center" 
                    VerticalAlign="Top" />
                <ItemStyle Height="25px" HorizontalAlign="Center" VerticalAlign="Middle" 
                    Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="Name"  >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                </asp:BoundField>
				<asp:BoundField DataField="description" HeaderText="Description"  >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
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
        </asp:GridView>
        <br />
    </p>
    <asp:Button ID="btnCreate" OnClick="btnCreateNew_Click" runat="server" Text="Create New Department" />
</center>
</asp:Content>

