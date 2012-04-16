using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class ServiceType
    {
        String id;
        String name;
        String charges;
        String description;

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
        String image;

        public String Image
        {
            get { return image; }
            set { image = value; }
        }
        

        public String Charges
        {
            get { return charges; }
            set { charges = value; }
        }
        

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}