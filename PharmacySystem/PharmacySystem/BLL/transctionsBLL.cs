using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.BLL
{
    internal class transctionsBLL
    {
        public string c_name { get; set; }
        public decimal total { get; set; }
        public DataTable transactionDetails { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
