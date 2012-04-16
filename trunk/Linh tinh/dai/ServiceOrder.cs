using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class ServiceOrder
    {
        String id;
        String name;
        String customer;
        String servicetype;
        String begindate;
        String enddate;
        String complete;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Complete
        {
            get { return complete; }
            set { complete = value; }
        }

        public String Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public String Begindate
        {
            get { return begindate; }
            set { begindate = value; }
        }

        public String Servicetype
        {
            get { return servicetype; }
            set { servicetype = value; }
        }

        public String Customer
        {
            get { return customer; }
            set { customer = value; }
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