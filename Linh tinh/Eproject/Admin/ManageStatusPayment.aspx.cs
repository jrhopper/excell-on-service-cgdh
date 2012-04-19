using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageStatusPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        StatusPaymentBLL spBLL = new StatusPaymentBLL();
        gvStatusPayment.DataSource = spBLL.getAllStatusPayment();
        gvStatusPayment.DataBind();
        c.closeConnect();
    }

    protected void gvStatusPayment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}