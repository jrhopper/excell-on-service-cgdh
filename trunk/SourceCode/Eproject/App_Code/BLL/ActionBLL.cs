using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for ActionBLL
/// </summary>
public class ActionBLL
{
    ActionDAL actionDAL = new ActionDAL();

	public ActionBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
    *Author:La Quoc Chuong 
    *Purpose:get all action in db
    *Date:2012/04/17
    */
    public DataSet getAllAction()
    {
        return actionDAL.getAllAction();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:checkActionName
     *Date:2012/04/17
     */
    public bool checkActionName(String name)
    {
        return actionDAL.checkActionName(name);
    }

    /*
     *Author:La Quoc Chuong
     *Purpose:insert
     *Date:2012/04/17
     */
    public void insert(String name, String link, String description)
    {
        actionDAL.insert(name, link, description);
    }
}