using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageServiceType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        gvServiceType.DataSource = stBLL.getAllServiceType();
        gvServiceType.DataBind();
        c.closeConnect();
    }

    protected void gvServiceType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}