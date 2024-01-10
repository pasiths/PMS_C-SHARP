using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamicySysytem.BLL
{
    internal class userBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string user_type { get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }        
        public DateTime updated_date { get; set; }
        public int updated_by { get; set;}
        public int status { get; set; }
        public string sDOB { get; set; }
    }
}
