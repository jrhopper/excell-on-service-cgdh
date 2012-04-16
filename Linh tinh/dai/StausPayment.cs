using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class StausPayment
    {
        String id;
        String serviceorderld;
        String status;
        String date;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Serviceorderld
        {
            get { return serviceorderld; }
            set { serviceorderld = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}