<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="FormUpdateStatusPayment.aspx.cs" Inherits="Admin_FormUpdateStatusPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table cellpadding="5" cellspacing="0" border="1px" style="margin:10px auto; width: 500px;">
        <tr>
            <td colspan="3" style="background: #CCC; text-align:center; font-size: 15pt; font-weight: bold;">
                Update Status payment</td>
        </tr>
        <tr>
            <td>Id</td>
            <td style="width: 327px"><input name="txtId" id="txtId" readonly="readonly" type="text" runat="server" /></td>
            <td></td>
        </tr>
        <tr>
            <td>Service order</td>
            <td>
                <asp:DropDownList ID="ddlServiceOrder" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
		<tr>
            <td>Status</td>
            <td style="width: 327px">
                <input name="txtStatus" id="txtStatus" type="text" 
                    runat="server" /></td>
            <td>
                
            </td>
        </tr>
		<tr>
            <td>Date</td>
            <td style="width: 327px">
                <asp:Calendar ID="cDate" runat="server" BackColor="White" 
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
            <td>Description</td>
            <td style="width: 327px">
      <textarea name="txtDescription" id="txtDescription" cols="45" rows="5"></textarea></td>
            <td>
                &nbsp;</td>
        </tr>
		
        <tr>
            <td colspan="3" align="center">
            
                 
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" />
            </td>
            
        </tr>
    </table>


</asp:Content>

