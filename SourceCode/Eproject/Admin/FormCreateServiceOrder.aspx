<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormCreateServiceOrder.aspx.cs" Inherits="Admin_FormCreateServiceOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">Add new Service order</td>
        </tr>
        <tr>
            <td>Id</td>
            <td style="width: 327px"><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Employee</td>
            <td style="width: 327px">
                <asp:DropDownList ID="ddlEmployee" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>Name</td>
            <td><input name="txtName" id="txtName" type="text" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtName" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is null"></asp:RequiredFieldValidator>
                <asp:Label ID="lbMessage" runat="server" Font-Bold="True" Font-Size="Smaller" 
                    ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Customer</td>
            <td style="width: 327px">
                <asp:DropDownList ID="ddlCustomer" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Service type</td>
            <td style="width: 327px">
                <asp:DropDownList ID="ddlServiceType" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Begin date</td>
            <td style="width: 327px">
                <asp:Calendar ID="cBeginDate" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Begin date</td>
            <td style="width: 327px">
                <asp:Calendar ID="cEndDate" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Complete</td>
            <td style="width: 327px">
                <input name="txtComplete" id="txtComplete" type="text" runat="server" /></td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Description</td>
            <td style="width: 327px">
      <textarea name="txtDescription" id="txtDescription" cols="45" rows="5"></textarea></td>
            <td>
                <asp:RequiredFieldValidator ControlToValidate="txtDescription" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Description is null"></asp:RequiredFieldValidator>
            </td>
        </tr>
		
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnCreate" runat="server" Text="Create" 
                    onclick="btnCreate_Click" />
            </td>
            
        </tr>
    </table>


</asp:Content>

