using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["user"] != null)
        {
            topnav.InnerHtml = "";
            MenuBLL menu = new MenuBLL();
            EmployeeBLL empBll = new EmployeeBLL();
            DataSet ds = empBll.getRoleIdOfEmployeeByUserName(Session["user"].ToString());
            List<WebApplication1.Entities.Menu> listMenu = menu.getAllMenuByRoleId((int)ds.Tables[0].Rows[0]["roleid"]);
            foreach (WebApplication1.Entities.Menu m in listMenu)
            {
                topnav.InnerHtml += "<li><a href='" + m.Link + "'>" + m.Name + "</a><ul class='subnav'>";
                List<WebApplication1.Entities.Menu> listSubMenu = menu.getSubMenuByMenuIdAndRoleId((int)ds.Tables[0].Rows[0]["roleid"], int.Parse(m.Id));
                foreach (WebApplication1.Entities.Menu m2 in listSubMenu)
                {
                    topnav.InnerHtml += "<li><a href='" + m2.Link + "'>" + m2.Name + "</a>";
                }
                topnav.InnerHtml += "</li></ul>";
            }
        }
        else
        {            
            Response.Write("<script>alert('Permission is not allowed ');</script>");
            Response.Redirect("..");
        }
    }
}
