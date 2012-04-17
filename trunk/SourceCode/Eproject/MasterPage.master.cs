using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Div2.InnerHtml = "Welcome, "+Session["user"]+" - <a href='Logout.aspx'>Logout</a>";
            MultiView1.ActiveViewIndex = 0;

        }
    }


    protected void LoginTop_Authenticate(object sender, AuthenticateEventArgs e)
    {
        EmployeeBLL empBll = new EmployeeBLL();
        if (empBll.checkExistsEmployeeByUserNameAndPassword(LoginTop.UserName, LoginTop.Password) == 1)
        {
            Session["user"] = LoginTop.UserName;
            e.Authenticated = true;
        }
        else
            Response.Write("<b style='color:white'>sjahsdjkahjsdhk</b>");
    }
}
