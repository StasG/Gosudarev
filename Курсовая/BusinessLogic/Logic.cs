using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Internet;
using System.Net;

namespace BusinessLogic
{
    public class Logic
    {
        public bool Completed { get; set; }
        public bool ConnectionAvailable { get; private set; }

        public Site Len;
        public Base Pod;
        public Logic()
        {
            Pod = new Base();
            Len = new Site();
            Completed = false;
        }
        public bool CreateLenta()
        {
             return Len.GetLenta();
        }
        public string name(Int32 n)
        {
            return Len.Getname(n);
        }
        public Int32 LastPage(Int32 n)
        {
            return Len.GetLastPage(n);
        }
        public void AddToBase(string n,string p)
        {
            Pod.Adding(n, p);
            Pod = new Base();
        }
        public string ReadBasename(Int32 n)
        {
            return Pod.BName(n);
        }
        public Int32 ReadBasepage(Int32 n)
        {
            return Pod.BPage(n);
        }
        public void SaveChanges(string n,string p)
        {
            Pod.Change(n, p);
            Pod = new Base();
        }
        public Int32 ReturnNum()
        {
            return Pod.num;
        }
        public void Print()
        {
            ExcelStatisticProvider.CopySub();
        }
        public bool Compare(Int32 i)
        {
            if (Connection.ConnectionAvailable())
            {
                WebClient client = new WebClient() { Encoding = Encoding.GetEncoding(1251) };
                string url = "https://acomics.ru/" + Pod.BName(i)+"/1";
                string text = client.DownloadString(url);//< span class="issueNumber">1/1079</span>
                text = text.Remove(0, text.IndexOf("issueNumber"));
                text = text.Remove(0, text.IndexOf("/")+1);
                Int32 newp = Convert.ToInt32(text.Substring(0, text.IndexOf("<")));
                if (newp > Pod.BPage(i))
                {
                    SaveChanges(Pod.BName(i), newp.ToString());
                    return true;
                }
            }
            return false;     
        }
    }
}
