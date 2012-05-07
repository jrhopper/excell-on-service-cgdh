using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class Admin_Report : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        for (int i = 1; i < 13; i++)
            dropdownlistMonth.Items.Add(new ListItem(i.ToString(),i.ToString()));
        EmployeeBLL empBLL = new EmployeeBLL();
        foreach(DataRow dr in empBLL.getAllEmployee().Tables[0].Rows)
            dropdownlistEmployeeName.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
        CustomerBLL custBLL = new CustomerBLL();
        foreach (DataRow dr in custBLL.getAllCustomer().Tables[0].Rows)
            dropdownlistCustomerName.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
        ServiceOrderBLL serviceOrderBLL = new ServiceOrderBLL();
        foreach (DataRow dr in serviceOrderBLL.getAllServiceOrder().Tables[0].Rows)
            dropdownlistServiceOrder.Items.Add(new ListItem(dr["serviceorder"].ToString(), dr["id"].ToString()));
    }

    public void btnViewReport_Click(object sender, EventArgs e)
    {
        //Response.Write("<script>alert('"+dropdownlistMonth.SelectedValue+","+dropdownlistEmployeeName.SelectedValue+","+dropdownlistCustomerName.SelectedValue+","+dropdownlistServiceOrder.SelectedValue+"');</script>");
        ReportBLL reportBLL = new ReportBLL();
        if (reportBLL.reportCount(dropdownlistServiceOrder.SelectedValue.ToString(), dropdownlistMonth.SelectedValue.ToString(), dropdownlistEmployeeName.SelectedValue.ToString(), dropdownlistCustomerName.SelectedValue.ToString()) != 0)
        {
            ReportDocument report = new ReportDocument();
            report.Load(Server.MapPath("CrystalReport1.rpt"));
            report.FileName = Server.MapPath("CrystalReport1.rpt");
            report.SetDataSource(reportBLL.report(dropdownlistServiceOrder.SelectedValue.ToString(), dropdownlistMonth.SelectedValue.ToString(), dropdownlistEmployeeName.SelectedValue.ToString(), dropdownlistCustomerName.SelectedValue.ToString()));
            report.SetDatabaseLogon("sa", "123", "QCHUONG", "ExcellOnServices");
            report.SetParameterValue("@serviceorderid", dropdownlistServiceOrder.SelectedValue.ToString());
            report.SetParameterValue("@month", dropdownlistMonth.SelectedValue.ToString());
            report.SetParameterValue("@empid", dropdownlistEmployeeName.SelectedValue.ToString());
            report.SetParameterValue("@custid", dropdownlistCustomerName.SelectedValue.ToString());
            CrystalReportViewer1.ReportSource = report;
            //CrystalReportViewer1.DataBind();
            lbMessage.Text = "";
        }
        else
            lbMessage.Text = "No Result!";

    }

    public void btnExport_Click(object sender, EventArgs e)
    {
        ReportBLL reportBLL = new ReportBLL();
        if (reportBLL.reportCount(dropdownlistServiceOrder.SelectedValue.ToString(), dropdownlistMonth.SelectedValue.ToString(), dropdownlistEmployeeName.SelectedValue.ToString(), dropdownlistCustomerName.SelectedValue.ToString()) != 0)
        {
            string repFilePath = Server.MapPath("CrystalReport1.rpt");
            ReportDocument repDoc = new ReportDocument();
            repDoc.Load(repFilePath);
            repDoc.SetDataSource(reportBLL.report(dropdownlistServiceOrder.SelectedValue.ToString(), dropdownlistMonth.SelectedValue.ToString(), dropdownlistEmployeeName.SelectedValue.ToString(), dropdownlistCustomerName.SelectedValue.ToString()));
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            String export = dropdownlistExport.SelectedValue.ToString();
            if (export == "-1")
                Response.Write("<script>alert('Choose export format please!');</script>");
            else if (export == "pdf")
            {
                try
                {
                    repDoc.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "Report");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ex = null;
                }
            }
            else if (export == "excel")
            {
                try
                {
                    repDoc.ExportToHttpResponse(ExportFormatType.ExcelRecord, Response, true, "Report");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ex = null;
                }
            }
            lbMessage.Text = "";
        }        
        else
            lbMessage.Text = "No Result!";
    }

    public void btnReset_Click(object sender, EventArgs e)
    {
        dropdownlistMonth.SelectedIndex = 0;
        dropdownlistEmployeeName.SelectedIndex = 0;
        dropdownlistCustomerName.SelectedIndex = 0;
        dropdownlistServiceOrder.SelectedIndex = 0;
    }
}