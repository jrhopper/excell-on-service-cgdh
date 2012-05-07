<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Admin_Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
.left{padding-left:20px;}
</style>
    
<asp:Panel ID="panelReport" runat="server">
        <asp:Table ID="tbReport" runat="server" CellSpacing=15 >
            <asp:TableRow>
                <asp:TableCell Width=250>
                    Month
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="dropdownlistMonth" Width=80 runat="server">
                        <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell Width=250>
                    Employee Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="dropdownlistEmployeeName" Width=150 runat="server">
                        <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell Width=250>
                    Customer Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="dropdownlistCustomerName" Width=150 runat="server">
                        <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width=180>
                        Service Order
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="dropdownlistServiceOrder" Width=150 runat="server">
                        <asp:ListItem Text="Choose..." Value="null"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell ColumnSpan=4>
                    <asp:Button ID="btnViewReport" OnClick="btnViewReport_Click" runat="server" Text="View Report" />
                    <asp:Button ID="btnReset" style="margin-left:10px;" OnClick="btnReset_Click" runat="server" Text="Reset" />
                    <asp:DropDownList ID="dropdownlistExport" runat="server" Width=100>
                        <asp:ListItem Text="Choose..." Value="-1" Selected=True></asp:ListItem>
                        <asp:ListItem Text="PDF" Value="pdf"></asp:ListItem>
                        <asp:ListItem Text="Excel" Value="excel"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnExport" UseSubmitBehavior=false runat="server" OnClick="btnExport_Click" Text="Export" />
                </asp:TableCell>
                <asp:TableCell>
                   
                </asp:TableCell>
                <asp:TableCell>
                    
                </asp:TableCell>
                <asp:TableCell>
                    
                </asp:TableCell>
            </asp:TableRow>
            
        </asp:Table>
    </asp:Panel>


    <br />
    <asp:Label ID="lbMessage" runat="server" Text="" ForeColor=Red Font-Size=Small Font-Bold=true></asp:Label>
    <br />

    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server"  
    AutoDataBind="true" ToolPanelView="None" 
    HasExportButton=False HasPrintButton=False HasSearchButton=False HasZoomFactorList=False
     HasCrystalLogo=False HasGotoPageButton=False HasToggleGroupTreeButton=false 
     HasPageNavigationButtons=False />  
</asp:Content>

