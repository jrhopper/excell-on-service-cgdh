using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_UpdateMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Request.Params["id"] == null || Request.Params["id"].ToString() == "")
                Response.Redirect("ManageRole.aspx");
            else
            {
                int id = int.Parse(Request.Params["id"].ToString());
                MenuBLL menuBLL = new MenuBLL();
                txtId.Value = id.ToString();
                txtName.Value = menuBLL.getMenuById(id).Tables[0].Rows[0]["name"].ToString();
                txtLink.Text = menuBLL.getMenuById(id).Tables[0].Rows[0]["link"].ToString();
                txtDescription.Text = menuBLL.getMenuById(id).Tables[0].Rows[0]["description"].ToString();
            }
        }
    }
    
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        MenuBLL menuBLL = new MenuBLL();
        int id = int.Parse(Request.Params["id"].ToString());
        DataSet ds = menuBLL.getMenuById(id);
        String name = ds.Tables[0].Rows[0]["name"].ToString();
        if (menuBLL.checkMenuName(txtName.Value) == true)
        {
            menuBLL.update(int.Parse(txtId.Value), txtName.Value, txtLink.Text, txtDescription.Text);
            Response.Write("<script>alert('Update Successful!');window.location='Menu.aspx';</script>");
        }
        else if (menuBLL.checkMenuName(txtName.Value) == false)
        {
            if (txtName.Value == name)
            {
                menuBLL.update(int.Parse(txtId.Value),txtName.Value,txtLink.Text,txtDescription.Text);
                Response.Write("<script>alert('Update Successful!');window.location='Menu.aspx';</script>");
            }
            else if (txtName.Value != name)
            {
                Response.Write("<script>alert('This menu name is existed!');</script>");
            }
        }
    }
}