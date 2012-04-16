using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class RoleDetail
    {
        String id;
        String menuId;
        String roleId;
        String actionId;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String ActionId
        {
            get { return actionId; }
            set { actionId = value; }
        }

		public String RoleId
		{
		  get { return roleId; }
		  set { roleId = value; }
		}       

        public String MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}