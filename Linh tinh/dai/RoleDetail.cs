using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class RoleDetail
    {
        String id;
        String menuld;
        String Roleld;
        String actionld;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Actionld
        {
            get { return actionld; }
            set { actionld = value; }
        }

public String Roleld1
{
  get { return Roleld; }
  set { Roleld = value; }
}
        

        

        public String Menuld
        {
            get { return menuld; }
            set { menuld = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}