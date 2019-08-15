using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Comics
    {
        public String name { get; set; }
        public Int32 LastPage { get; set; }

        public Comics(string a, string b)
        {
            name = a;
            LastPage = Convert.ToInt32(b);
        }
    }
}
