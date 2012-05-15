using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataSet ds = employeeBLL.getEmployeeById(id);
            txtId.Value = id.ToString();
            txtUserName.Value = ds.Tables[0].Rows[0]["username"].ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            txtBirthday.Value = ds.Tables[0].Rows[0]["birthday"].ToString();
            txtAddress.Value = ds.Tables[0].Rows[0]["address"].ToString();
            txtPhone.Value = ds.Tables[0].Rows[0]["phone"].ToString();
            txtEmail.Value = ds.Tables[0].Rows[0]["email"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        employeeBLL.updateEmployee(int.Parse(txtId.Value), txtUserName.Value, txtName.Value, txtBirthday.Value, txtAddress.Value, txtPhone.Value, txtEmail.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageEmployee.aspx';</script>");
    }
}