using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Entities;

public partial class ProfileInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        loadData();
    }

    public void loadData()
    {
        EmployeeBLL empBLL = new EmployeeBLL();
        Employee emp = empBLL.getEmployeeByUser(Session["user"].ToString());
        txtUserName.Text = emp.Username;
        txtPassword.Text = emp.Password;
        txtName.Text = emp.Name;
        txtBirthday.Text = emp.Birthday;
        if (emp.Sex.Equals("0"))
            rdSex.Items[1].Selected = true;
        else
            rdSex.Items[0].Selected = true;
        txtAddress.Text = emp.Address;
        txtPhone.Text = emp.Phone;
        txtEmail.Text = emp.Email;
        lbProfile.Text = emp.Username;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        String username = txtUserName.Text;
        String name = txtName.Text;
        String[] arr = txtBirthday.Text.Split('/');
        String birthday = arr.GetValue(2).ToString() + "/" + arr.GetValue(1).ToString() + "/" + arr.GetValue(0).ToString();
        int sex = int.Parse(rdSex.SelectedValue);
        String address = txtAddress.Text;
        String phone = txtPhone.Text;
        String email = txtEmail.Text;
        EmployeeBLL empBLL = new EmployeeBLL();
        //Response.Write("<b style='color:white'>"+empBLL.updateEmployee(username, name, birthday, sex, address, phone, email)+"</b>");
        if (empBLL.updateEmployee(username, name, birthday, sex, address, phone, email) != -1)
        {
            lbMessage.Text = "Update Successful!";
            //lbMessage.Text = username + "-" + name + "-" + birthday + "-" + sex + "-" + address + "-" + phone + "-" + email;
            loadData();
        }
        else
        {
            lbMessage.Text = "Update Fail!";
        }
    }

}