using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_AdvancedSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            loadData();
        }     
    }


    public void loadData()
    {
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        foreach (DataRow dr in stBLL.getAllServiceType().Tables[0].Rows)
            dropdownlistServiceType.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
        
    }

    public void btnReset_Click(object sender, EventArgs e)
    {
        txtServiceOrderName.Text = "";
        txtEmployeeName.Text = "";
        txtCustomerName.Text = "";
        dropdownlistServiceType.SelectedIndex = 0;
        txtBeginDate.Text = "";
        txtEndDate.Text = "";
        dropdownlistStatus.SelectedIndex = 0;
        txtCustomerAddress.Text = "";
        txtCustomerPhone.Text = "";
        txtCustomerEmail.Text = "";
    }

    public void btnSearch_Click(object sender, EventArgs e)
    {
        //Response.Write("<b style='color:white'>begin date: " + Request.Form[txtBeginDate.UniqueID] + "</b>");
        SearchBLL searchBLL = new SearchBLL();
        String serviceOrderName = "";
        String employeeName = "";
        String customerName = "";
        String serviceType = "";
        String beginDate = "";
        String endDate = "";
        String status = "";
        String customerAddress = "";
        String customerPhone = "";
        String customerEmail = "";

        if (txtServiceOrderName.Text.Trim() == "")
            serviceOrderName = "null";
        else
            serviceOrderName = txtServiceOrderName.Text.Trim();

        if (txtEmployeeName.Text.Trim() == "")
            employeeName = "null";
        else
            employeeName = txtEmployeeName.Text.Trim();

        if (txtCustomerName.Text.Trim() == "")
            customerName = "null";
        else
            customerName = txtEmployeeName.Text.Trim();

        if (dropdownlistServiceType.SelectedValue == "-1")
            serviceType = "null";
        else
            serviceType = dropdownlistServiceType.SelectedValue;

        if (Request.Form[txtBeginDate.UniqueID].Trim().ToString() == "")
            beginDate = "null";
        else
        {
            String[] arrBeginDate = Request.Form[txtBeginDate.UniqueID].Split('/');
            beginDate = arrBeginDate.GetValue(2).ToString() + "/" + arrBeginDate.GetValue(1).ToString() + "/" + arrBeginDate.GetValue(0).ToString();
            //Response.Write("<b style='color:white'>begin date: " + beginDate + "</b>");
            txtBeginDate.Text = Request.Form[txtBeginDate.UniqueID];
        }

        if (Request.Form[txtEndDate.UniqueID].Trim().ToString() == "")
            endDate = "null";
        else
        {
            String[] arrEndDate = Request.Form[txtEndDate.UniqueID].Split('/');
            endDate = arrEndDate.GetValue(2).ToString() + "/" + arrEndDate.GetValue(1).ToString() + "/" + arrEndDate.GetValue(0).ToString();
            txtEndDate.Text = Request.Form[txtEndDate.UniqueID];
        }

        if (dropdownlistStatus.SelectedValue == "-1")
            status = "null";
        else
            status = dropdownlistStatus.SelectedValue;

        if (txtCustomerAddress.Text.Trim() == "")
            customerAddress = "null";
        else
            customerAddress = txtCustomerAddress.Text.Trim();

        if (txtCustomerPhone.Text.Trim() == "")
            customerPhone = "null";
        else
            customerPhone = txtCustomerPhone.Text.Trim();

        if (txtCustomerEmail.Text.Trim() == "")
            customerEmail = "null";
        else
            customerEmail = txtCustomerEmail.Text.Trim();


        List<Search> list = searchBLL.search(serviceOrderName, employeeName, customerName, serviceType,
                                beginDate, endDate, status, customerAddress, customerPhone, customerEmail);
        if (list.Count != 0)
        {
            lbTitle.Text = "Search Result";
            gvSearch.DataSource = list;
            gvSearch.DataBind();
            lbMessage.Text = "";
            gvSearch.Visible = true;
        }
        else
        {
            lbTitle.Text = "Search Result";
            lbMessage.Text = "No result is found.";
            gvSearch.Visible = false;
        }
    }
}