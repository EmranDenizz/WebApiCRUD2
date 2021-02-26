using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCRUD.Business.Request
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Country { get; set; }
    }
}
