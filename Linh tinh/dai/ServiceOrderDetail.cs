using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class ServiceOrderDetail
    {
        String id;
        String serviceorderld;
        String empld;
        String taskname;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Taskname
        {
            get { return taskname; }
            set { taskname = value; }
        }

        public String Empld
        {
            get { return empld; }
            set { empld = value; }
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