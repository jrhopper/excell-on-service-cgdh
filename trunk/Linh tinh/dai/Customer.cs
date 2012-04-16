using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Customer
    {
        String id;
        String name;
        String address;
        String phone;
        String email;
        String contact;
        String company;

        public String Company
        {
            get { return company; }
            set { company = value; }
        }

        public String Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
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