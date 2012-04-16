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