using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }

    private void loadData()
    {
        ActionBLL actionBLL = new ActionBLL();
        gvAction.DataSource = actionBLL.getAllAction();
        gvAction.DataBind();
    }

    protected void gvAction_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int actionId = int.Parse(gvAction.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        if (e.CommandName == "update_Action")
        {
            Response.Redirect("UpdateAction.aspx?id=" + actionId);
        }
        if (e.CommandName == "delete_Action")
        {
            //Response.Write("<b style='color:white'>asdasdasd</b>");
            ActionBLL actionBLL = new ActionBLL();
            if (actionBLL.deleteAction(actionId) == 0)
            {
                Response.Write("<script>alert('Delete successful');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This action is contraint to another table.');</script>");
            }
        }
    }
}