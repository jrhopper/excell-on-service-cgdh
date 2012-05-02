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
        if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        ProductBLL product = new ProductBLL();
        gvProduct.DataSource = product.getAllProduct();
        gvProduct.DataBind();
    }

    protected void gvProduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "updateProduct")
        {
            Response.Redirect("FormUpdateProduct.aspx?id=" + int.Parse(gvProduct.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text));
        }
        if (e.CommandName == "deleteProduct")
        {
            ProductBLL ProductBLL = new ProductBLL();
            if (ProductBLL.deleteProduct(int.Parse(gvProduct.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This product is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateProduct.aspx");
    }
}