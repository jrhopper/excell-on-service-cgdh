using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        ConfigurationDAL con = new ConfigurationDAL();
        con.connectDB();
        con.openConnect();
        DepartmentBLL depBLL = new DepartmentBLL();
        gvDepartment.DataSource = depBLL.getAllDepartment();
        gvDepartment.DataBind();
        con.closeConnect();
    }
    protected void gvDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        Session["ctrl"] = gvDepartment;
        ClientScript.RegisterStartupScript(this.GetType(), "onclick", "<script language=javascript>window.open('Print.aspx','PrintMe','height=768px,width=1366px,scrollbars=1');</script>");
    }
}