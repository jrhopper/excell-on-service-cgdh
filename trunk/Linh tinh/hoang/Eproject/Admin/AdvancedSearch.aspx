<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdvancedSearch.aspx.cs" Inherits="Admin_AdvancedSearch" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
.left{padding-left:20px;}
</style>
    
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>

    <br />
<%--    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>--%>

    <asp:Panel ID="panelSearch" runat="server">
        <asp:Table ID="tbSearch" runat="server" CellSpacing=15 >
            <asp:TableRow>
                <asp:TableCell>
                    Service Order Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtServiceOrderName" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    Employee Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    Customer Name
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Service Type
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList Width=100 ID="dropdownlistServiceType" runat="server">
                        <asp:ListItem Text="Choose..." Value="-1"></asp:ListItem>
                    </asp:DropDownList> 
                </asp:TableCell>
                <asp:TableCell>
                    Begin Date
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ReadOnly=true Width=100 ID="txtBeginDate" runat="server"></asp:TextBox>
                    <asp:CalendarExtender PopupPosition=Right Format="dd/MM/yyyy" PopupButtonID=txtBeginDate ID="CalendarExtender1" TargetControlID=txtBeginDate runat="server">
                    </asp:CalendarExtender>
                </asp:TableCell>
                <asp:TableCell>
                    End Date
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ReadOnly=true Width=100 ID="txtEndDate" runat="server"></asp:TextBox>
                    <asp:CalendarExtender PopupPosition=Right Format="dd/MM/yyyy" PopupButtonID=txtEndDate ID="CalendarExtender2" TargetControlID=txtEndDate runat="server">
                    </asp:CalendarExtender>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Status
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList Width=100 ID="dropdownlistStatus" runat="server">
                        <asp:ListItem Text="Choose..." Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Unfinish" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Finish" Value="1"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                    Customer Address
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    Customer Phone
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCustomerPhone" runat="server"></asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="fltxtPhone" Enabled=true  
                             FilterType="Numbers" TargetControlID="txtCustomerPhone"  
                             runat="server">
                    </asp:FilteredTextBoxExtender>  
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Customer Email
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>                       
                    <asp:Button ID="btnSearch" UseSubmitBehavior=false OnClick="btnSearch_Click" runat="server" Text="Search" />
                    <asp:Button ID="btnReset" UseSubmitBehavior=false OnClick="btnReset_Click" runat="server" Text="Reset" style="margin-left:10px" />
                    
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
    <br />

    <center>
        <asp:Label ID="lbTitle" runat="server" Font-Bold=true Font-Size=XX-Large ForeColor=Blue Text=""></asp:Label>
    <br />
    <br />
        <asp:Label ID="lbMessage" Font-Bold=true Font-Size=Small ForeColor=red runat="server" Text=""></asp:Label>
    <br />
    <br />
        <asp:GridView ID="gvSearch" runat="server" AutoGenerateColumns="False" 
            EnableModelValidation="True" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
            GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="serviceorderid" HeaderText="serviceorderid" 
                    Visible="False" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                
                <asp:HyperLinkField DataNavigateUrlFields="serviceorderid" 
                    DataNavigateUrlFormatString="ServiceOrderDetail.aspx?id={0}" DataTextField="serviceordername" 
                    HeaderText="Service Order" >
                
                <HeaderStyle Height="40px" />
                
                <ItemStyle Width="200px" Height="30px" />
                </asp:HyperLinkField>
                <asp:BoundField DataField="employeeid" HeaderText="employeeid" 
                    Visible="False" />
                <asp:HyperLinkField DataNavigateUrlFields="employeeid" 
                    DataNavigateUrlFormatString="EmployeeDetail.aspx?id={0}" 
                    DataTextField="employeename" HeaderText="Responsibility">
                <ItemStyle Width="200px" />
                </asp:HyperLinkField>
                <asp:BoundField DataField="customerid" HeaderText="customerid" 
                    Visible="False" />
                <asp:BoundField DataField="customername" HeaderText="Customer Name" >
                <ItemStyle Width="220px" CssClass=left />
                </asp:BoundField>
                <asp:BoundField DataField="servicetypeid" HeaderText="servicetypeid" 
                    Visible="False" />
                <asp:BoundField DataField="servicetypename" HeaderText="Service Type" >
                <ItemStyle Width="220px" CssClass=left />
                </asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="Status">
                <ItemStyle Width="150px" CssClass=left />
                </asp:BoundField>
                <asp:BoundField DataField="begindate" HeaderText="Begin Date" >
                <ItemStyle Width="150px" CssClass=left />
                </asp:BoundField>
                <asp:BoundField DataField="enddate" HeaderText="End Date" >
                <ItemStyle Width="150px" CssClass=left />
                </asp:BoundField>
                
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:GridView>
    </center>
<%--    </ContentTemplate>
    </asp:UpdatePanel>--%>

</asp:Content>

