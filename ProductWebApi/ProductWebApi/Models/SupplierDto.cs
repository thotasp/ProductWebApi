﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApi.Models
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}