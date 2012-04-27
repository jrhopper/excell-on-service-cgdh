using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
            loadData();
    }

    private void loadData()
    {
        MenuBLL menuBLL = new MenuBLL();
        gvMenu.DataSource = menuBLL.getAllMenu();
        gvMenu.DataBind();
    }

    protected void gvMenu_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int menuId = int.Parse(gvMenu.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        if (e.CommandName == "update_menu")
        {
            Response.Redirect("UpdateMenu.aspx?id=" + menuId);
        }
        if (e.CommandName == "delete_menu")
        {
            //Response.Write("<b style='color:white'>asdasdasd</b>");
            MenuBLL menuBLL = new MenuBLL();
            if (menuBLL.deleteMenu(menuId) == 0)
            {
                Response.Write("<script>alert('Delete successful');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This menu is contraint to another table.');</script>");
            }
        }
    }
}