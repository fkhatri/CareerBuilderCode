﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Question1.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DOB { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}