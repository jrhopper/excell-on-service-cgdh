using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_RoleDetailList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
            loadData();
    }

    private void loadData()
    {
        int id = int.Parse( Request.Params["id"].ToString());
        RoleBLL roleBLL = new RoleBLL();
        gvRoleDetail.DataSource = roleBLL.getAllRoleDetailByRoleId(id);
        gvRoleDetail.DataBind();            
    }
}