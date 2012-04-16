using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Product
    {
        String id;
        String company;
        String price;
        String customerid;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }

        public String Price
        {
            get { return price; }
            set { price = value; }
        }

        public String Company
        {
            get { return company; }
            set { company = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}