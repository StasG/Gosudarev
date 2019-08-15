using Internet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Site
    {
        public List<Comics> Lenta { get; set; }
        public bool GetLenta()
        {
            if (Connection.ConnectionAvailable())
            {
                WebClient client = new WebClient() { Encoding = Encoding.GetEncoding(1251) };
                string url = "https://acomics.ru/profile/featured";
                string text = client.DownloadString(url);
                List<Comics> a = new List<Comics>();
                for (int i = 0; i < Amounts.AmountLenta(); i++)
                {
                    text = text.Remove(0, text.IndexOf("agrBody"));
                    text = text.Remove(0, text.IndexOf("~"));
                    String f1 = text.Substring(0, text.IndexOf("\""));
                    text = text.Remove(0, text.IndexOf("numbers"));
                    text = text.Remove(0, text.IndexOf("#") + 1);
                    String f2 = text.Substring(0, text.IndexOf("<"));
                    a.Add(new Comics(f1, f2));
                }
                Lenta = a;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Getname(Int32 n)
        {
            //REVIEW: А если он null или нет элементов
            return Lenta[n].name;
        }
        public Int32 GetLastPage(Int32 n)
        {
            //REVIEW: А если он null или нет элементов
            return Lenta[n].LastPage;
        }
        public Site()
        {
            Lenta = new List<Comics>();
        }
    }
}
