using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Menu
    {
        String id;
        String name;
		String link;
        String description;
        String menuId;

        public String MenuId
        {
            get { return menuId; }
            set { menuId = value; }
        }
        String roleId;

        public String RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        String actionId;

        public String ActionId
        {
            get { return actionId; }
            set { actionId = value; }
        }
        
       
		public String Link
        {
            get { return link; }
            set { link = value; }
        }            

        public String Id
        {
            get { return id; }
            set { id = value; }
        }        

        public String Name
        {
            get { return name; }
            set { name = value; }
        }        

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}