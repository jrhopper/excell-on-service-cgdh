using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class ServiceOrderDetail
    {
        String id;
        String serviceOrderId;
        String empId;
        String taskName;
        String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }

        public String EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public String ServiceOrderId
        {
            get { return serviceOrderId; }
            set { serviceOrderId = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}