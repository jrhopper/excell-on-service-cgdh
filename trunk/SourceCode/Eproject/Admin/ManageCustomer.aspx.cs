using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        CustomerBLL customer = new CustomerBLL();
        gvCustomer.DataSource = customer.getAllCustomer();
        gvCustomer.DataBind();
    }

    protected void gvCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateCustomer")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateCustomer.aspx?id=" + int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteCustomer")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            CustomerBLL CustomerBLL = new CustomerBLL();
            //Response.Write("<b style='color:white'>"+CustomerBLL.deletecustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (CustomerBLL.deleteCustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This customer is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateCustomer.aspx");
    }
}