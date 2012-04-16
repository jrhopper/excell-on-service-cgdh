using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Role
    {
        String id;
        String name;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}