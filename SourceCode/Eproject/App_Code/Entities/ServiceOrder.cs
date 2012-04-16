using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entities
{
    public class ServiceOrder
    {
        String id;
		String empId;
        String name;
        String customer;
        String serviceType;
        String beginDate;
        String endDate;
        String complete;
        String description;

		public String EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
		
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

        public String EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public String BeginDate
        {
            get { return beginDate; }
            set { beginDate = value; }
        }

        public String ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
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