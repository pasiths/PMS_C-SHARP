using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.BLL
{
    internal class stockBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }
        public int man_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
        public DateTime updated_date { get; set; }
        public int updated_by { get; set; }
        public int status { get; set; }
    }
}
