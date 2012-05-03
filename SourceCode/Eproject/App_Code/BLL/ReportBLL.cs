using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ReportBLL
/// </summary>
public class ReportBLL
{
    ReportDAL reportDAL = new ReportDAL();
	public ReportBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /*
     Author:La Quoc Chuong
     * Purpose: report
     */
    public List<Report> report(String serviceorderid, String month, String empid, String custid)
    {
        return reportDAL.report(serviceorderid,month,empid,custid);
    }

    /*
    *Author:La Quoc Chuong
    *Purpose: report count
    *Date: 2012/04/17
    */
    public int reportCount(String serviceorderid, String month, String empid, String custid)
    {
        return reportDAL.reportCount(serviceorderid,month,empid,custid);
    }
}