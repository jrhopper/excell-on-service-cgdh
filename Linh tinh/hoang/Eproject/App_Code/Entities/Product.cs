using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Product
    {
        String id;
		String name;
        String company;
        String price;
        String customerId;
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


        public String CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
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