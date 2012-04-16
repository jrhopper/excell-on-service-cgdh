using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class Employee
    {
        String id;
        String username;
        String password;
        String department;
        String roleld;
        String name;
        String birthday;
        String sex;
        String address;
        String phone;
        String email;

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

        public String Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public String Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Roleld
        {
            get { return roleld; }
            set { roleld = value; }
        }

        public String Department
        {
            get { return department; }
            set { department = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}