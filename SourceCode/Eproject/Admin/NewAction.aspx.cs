using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_NewAction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnCreate_Click(object sender, EventArgs e)
    {
        //MenuBLL menuBLL = new MenuBLL();
        //if (txtName.Text != "")
        //{
        //    if (menuBLL.checkMenuName(txtName.Text) == false)
        //        lbMessage.Text = "This menu name is existed!";
        //    if (menuBLL.checkMenuName(txtName.Text) == true)
        //    {
        //        lbMessage.Text = "create menu successful!";
        //        menuBLL.insert(txtName.Text, txtLink.Text, txtDescription.Text);
        //        Response.Redirect("Menu.aspx");

        //    }
        //}
        //else if (txtName.Text == "")
        //    lbMessage.Text = "Menu name is null";
    }
}