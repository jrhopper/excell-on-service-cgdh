using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ProductBLL proBLL = new ProductBLL();
        gvProduct.DataSource = proBLL.getAllProduct();
        gvProduct.DataBind();
        c.closeConnect();
    }

    protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}