using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormUpdateServiceType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            ServiceTypeBLL stBLL = new ServiceTypeBLL();
            DataSet ds = stBLL.getServiceTypeById(id);
            txtId.Value = id.ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            fuImage.Value = ds.Tables[0].Rows[0]["image"].ToString();
            txtCharges.Value = ds.Tables[0].Rows[0]["charges"].ToString();
            txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        stBLL.updateServiceType(int.Parse(txtId.Value), txtName.Value, fuImage.Value, txtCharges.Value, txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageServiceType.aspx';</script>");
    }
}