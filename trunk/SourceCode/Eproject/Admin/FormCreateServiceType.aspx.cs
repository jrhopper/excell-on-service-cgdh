using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateServiceType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        if (stBLL.checkServiceTypeNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (stBLL.checkServiceTypeNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (stBLL.insert(txtName.Value,txtImage.Value, txtCharges.Value,txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Service Type Successful.');window.location='ManageServiceType.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Service Type Fail.');window.location='ManageServiceType.aspx';</script>");
            }
        }
    }
}