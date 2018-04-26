using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyQuanCafe.Entity
{
    public class Staff
    {
        public int id { get; set; }
        public DateTime birthday { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
    }
}