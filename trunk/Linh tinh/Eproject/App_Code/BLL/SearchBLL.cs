using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SearchBLL
/// </summary>
public class SearchBLL
{
	public SearchBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    SearchDAL searchDAL = new SearchDAL();
    /*
     Author:La Quoc Chuong
     Purpose: Search function
     */
    public List<Search> search(String serviceordername,String employeename,String customername,String servicetype,String begindate,String enddate,String status,String customeraddress,String customerphone,String customeremail)
    {
        return searchDAL.search(serviceordername,employeename,customername,servicetype,begindate,enddate,status,customeraddress,customerphone,customeremail);
    }
}