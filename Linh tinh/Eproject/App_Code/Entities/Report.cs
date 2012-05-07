using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Report
/// </summary>
public class Report
{
	public Report()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    String serviceOrderId;
    String serviceOrderName;
    String employeeId;
    String employeeName;
    String custId;
    String custName;
    String charges;
    String beginDate;
    String endDate;

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


    public String Charges
    {
        get { return charges; }
        set { charges = value; }
    }

    public String CustName
    {
        get { return custName; }
        set { custName = value; }
    }

    public String CustId
    {
        get { return custId; }
        set { custId = value; }
    }

    public String EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    public String EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public String ServiceOrderName
    {
        get { return serviceOrderName; }
        set { serviceOrderName = value; }
    }

    public String ServiceOrderId
    {
        get { return serviceOrderId; }
        set { serviceOrderId = value; }
    }
}