using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            DepartmentBLL departmentBLL = new DepartmentBLL();
            DataSet ds = departmentBLL.getDepartmentById(id);
            txtId.Value = id.ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        departmentBLL.updateDepartment(int.Parse(txtId.Value), txtName.Value, txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageDepartment.aspx';</script>");
    }
}