using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        EmployeeBLL empBLL = new EmployeeBLL();
        gvEmployee.DataSource = empBLL.getAllEmployee();
        gvEmployee.DataBind();
        c.closeConnect();
    }

    protected void gvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}