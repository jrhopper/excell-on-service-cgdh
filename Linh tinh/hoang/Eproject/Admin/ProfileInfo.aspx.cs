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
        if(!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        EmployeeBLL empBLL = new EmployeeBLL();
        Employee emp = empBLL.getEmployeeByUser(Session["user"].ToString());
        txtUserName.Text = emp.Username;
        txtName.Text = emp.Name;
        txtBirthday.Text = emp.Birthday;
        if (emp.Sex.Equals("0"))
            rdSex.Items[1].Selected = true;
        else
            rdSex.Items[0].Selected = true;
        txtAddress.Text = emp.Address;
        txtPhone.Text = emp.Phone;
        txtEmail.Text = emp.Email;
        //lbProfile.Text = emp.Username;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //Response.Write("<b color=white>"+txtPhone.Text+"</b>");
        String username = txtUserName.Text;
        String name = txtName.Text;
        String[] arr = Request.Form[txtBirthday.UniqueID].Split('/');
        String birthday = arr.GetValue(2).ToString() + "/" + arr.GetValue(1).ToString() + "/" + arr.GetValue(0).ToString();
        int sex = int.Parse(rdSex.SelectedValue);
        String address = txtAddress.Text;
        String phone = txtPhone.Text;
        String email = txtEmail.Text;

        //Response.Write("<b style='color:white'>" + txtUserName.Text + "," 
        //    + txtName.Text + "," + Request.Form[txtBirthday.UniqueID] + "," 
        //    + txtAddress.Text + "," + txtPhone.Text + "," + txtEmail.Text + "</b>");

        EmployeeBLL empBLL = new EmployeeBLL();
        //Response.Write("<b style='color:white'>"+empBLL.updateEmployee(username, name, birthday, sex, address, phone, email)+"</b>");
        if (empBLL.updateEmployee(username, name,birthday, sex, address,phone, email) != -1)
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