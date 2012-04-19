using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageServiceOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
        gvServiceOrderDetail.DataSource = sodBLL.getAllServiceOrderDetail();
        gvServiceOrderDetail.DataBind();
        c.closeConnect();
    }

    protected void gvServiceOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}