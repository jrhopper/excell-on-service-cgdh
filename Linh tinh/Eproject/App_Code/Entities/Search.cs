using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Search
/// </summary>
public class Search
{
	public Search()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    String serviceorderid;
    String serviceordername;
    String employeeid;
    String employeename;
    String customerId;
    String customerName;
    String serviceTypeId;
    String serviceTypeName;
    String status;
    String beginDate;
    String endDate;
    String complete;
    String serviceOrderDescription;
    String customerPhone;
    String customerEmail;
    String customerAddress;

    public String CustomerAddress
    {
        get { return customerAddress; }
        set { customerAddress = value; }
    }

    public String CustomerEmail
    {
        get { return customerEmail; }
        set { customerEmail = value; }
    }

    public String CustomerPhone
    {
        get { return customerPhone; }
        set { customerPhone = value; }
    }
    

    public String ServiceOrderDescription
    {
        get { return serviceOrderDescription; }
        set { serviceOrderDescription = value; }
    }


    public String Complete
    {
        get { return complete; }
        set { complete = value; }
    }

    public String EndDate
    {
        get { return endDate; }
        set { endDate = value; }
    }

    public String BeginDate
    {
        get { return beginDate; }
        set { beginDate = value; }
    }

    public String Status
    {
        get { return status; }
        set { status = value; }
    }

    public String ServiceTypeName
    {
        get { return serviceTypeName; }
        set { serviceTypeName = value; }
    }

    public String ServiceTypeId
    {
        get { return serviceTypeId; }
        set { serviceTypeId = value; }
    }

    public String CustomerName
    {
        get { return customerName; }
        set { customerName = value; }
    }

    public String CustomerId
    {
        get { return customerId; }
        set { customerId = value; }
    }

    public String Employeename
    {
        get { return employeename; }
        set { employeename = value; }
    }

    public String Employeeid
    {
        get { return employeeid; }
        set { employeeid = value; }
    }

    public String Serviceordername
    {
        get { return serviceordername; }
        set { serviceordername = value; }
    }
    

    public String Serviceorderid
    {
        get { return serviceorderid; }
        set { serviceorderid = value; }
    }

}