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
        
    }

    public void btnCreate_Click(object sender, EventArgs e)
    {

    }

    protected void gvAction_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int actionId = int.Parse(gvAction.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        if (e.CommandName == "update_Action")
        {
            Response.Redirect("UpdateMenu.aspx?id=" + actionId);
        }
        if (e.CommandName == "delete_Action")
        {
            //Response.Write("<b style='color:white'>asdasdasd</b>");
            
        }
    }
}