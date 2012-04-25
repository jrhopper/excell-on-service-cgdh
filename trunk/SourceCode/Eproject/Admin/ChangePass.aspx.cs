using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ChangePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChange_Click(object sender, EventArgs e)
    {
        //Response.Write();
        String newPass = txtNewPassword.Text;
        EmployeeBLL emp = new EmployeeBLL();
        emp.changePass(newPass, Session["user"].ToString());
        Response.Write("<script>alert('Require logout to change your profile!');window.location='../Logout.aspx'</script>");
        
    }
}