﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }

    public class TestController : Controller
    {
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address 1";

            return c;
        }
    }
}