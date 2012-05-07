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
        if (!this.IsPostBack)
        loadData();
    }
    public void loadData()
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

    protected void gvStatusPayment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateStatusPayment")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateStatusPayment.aspx?id=" + int.Parse(gvStatusPayment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteStatusPayment")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            StatusPaymentBLL statusPaymentBLL = new StatusPaymentBLL();
            //Response.Write("<b style='color:white'>"+CustomerBLL.deletecustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (statusPaymentBLL.deleteStatusPayment(int.Parse(gvStatusPayment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This status payment is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateStatusPayment.aspx");
    }

    protected void gvStatusPayment_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
}