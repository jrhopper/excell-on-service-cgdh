using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_NewRoleDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        RoleBLL roleBLL = new RoleBLL();
        foreach (DataRow dr in roleBLL.getAllRole().Tables[0].Rows)
            roleList.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
        MenuBLL menuBLL = new MenuBLL();
        foreach (DataRow dr in menuBLL.getAllMenu().Tables[0].Rows)
            menuList.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
        ActionBLL actionBLL = new ActionBLL();
        foreach (DataRow dr in actionBLL.getAllAction().Tables[0].Rows)
            actionList.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
        
    }

    public void btnAdd_Click(object sender, EventArgs e)
    {
        RoleBLL roleBLL = new RoleBLL();
        int rs = roleBLL.checkRoleDetail(int.Parse(roleList.SelectedValue), int.Parse(menuList.SelectedValue), int.Parse(actionList.SelectedValue));
        if (rs == 1)
        {
            Response.Write("<script>alert('Role detail is existed, can not add into table.');</script>");
        }
        else
        {
            roleBLL.insertRoleDetail(int.Parse(roleList.SelectedValue), int.Parse(menuList.SelectedValue), int.Parse(actionList.SelectedValue));
            Response.Write("<script>alert('Add role detail successful!');window.location='RoleDetail.aspx';</script>");
            
        }
    }
        
}