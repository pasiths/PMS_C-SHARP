using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.BLL
{
    internal class transactionDetailsBLL
    {
        public int id { get; set; }
        public int p_id { get; set; }
        public decimal price { get; set; }
        public int qty {  get; set; }
        public decimal total {  get; set; }
        public int c_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
