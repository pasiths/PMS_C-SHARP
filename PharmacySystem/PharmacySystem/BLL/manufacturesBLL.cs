using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamicySysytem.BLL
{
    internal class manufacturesBLL
    {
        public int manufacturerID { get; set; }
        public string manufacturerName { get; set;}
        public string manufacturerAddress { get; set; }
        public string manufacturerEmail { get; set; }
        public string manufacturerMobile { get; set;}
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public DateTime updated_date { get; set; }
        public int updated_by { get; set; }
        public int status { get; set; }
    }
}
