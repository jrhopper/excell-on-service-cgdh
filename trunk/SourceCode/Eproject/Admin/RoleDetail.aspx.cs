using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_RoleDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            loadData();
            loadRoleList();
        }
    }

    public void loadData()
    {
        RoleBLL roleBLL = new RoleBLL();
        gvRoleDetail.DataSource = roleBLL.getAllRoleDetail();
        gvRoleDetail.DataBind();
    }

    public void loadRoleList()
    {
        RoleBLL roleBLL = new RoleBLL();
        foreach (DataRow dr in roleBLL.getAllRole().Tables[0].Rows)
            roleList.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
    }

    public void gvRoleDetail_RowCommand(object sender,EventArgs e)
    {

    }

    protected void roleList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (int.Parse(roleList.SelectedValue) == -1)
        {
            loadData();
        }
        else
        {
            int roleId = int.Parse(roleList.SelectedValue);
            RoleBLL roleBLL = new RoleBLL();
            gvRoleDetail.DataSource = roleBLL.getAllRoleDetailByRoleId(roleId);
            gvRoleDetail.DataBind();
            
        }
    }
}