using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageServiceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        gvServiceOrder.DataSource = soBLL.getAllServiceOrder();
        gvServiceOrder.DataBind();
        c.closeConnect();
    }

    protected void gvServiceOrder_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}