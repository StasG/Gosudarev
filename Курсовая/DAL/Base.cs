using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class Base
    {
        public string file = "Chosen.xml";
        public List<Comics> Sub;
        public Int32 num;
        public Base()
        {
            num = 0;
            Sub = new List<Comics>();
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node["name"].InnerText;
                string page = node["page"].InnerText;
                Sub.Add(new Comics(name, page));
                num++;
            }
        }
        public Int32 numbers()
        {
            return num;
        }
        public string BName(Int32 n)
        {
            return Sub[n].name;
        }
        public Int32 BPage(Int32 n)
        {
            return Sub[n].LastPage;
        }
        public void Adding(string n, string p)
        {
            bool b = true;
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node["name"].InnerText == n)
                {
                    b = false;
                }
            }
            if (b)
            {
                XmlNode node = doc.CreateNode(XmlNodeType.Element, "comics", null);
                XmlNode nodename = doc.CreateElement("name");
                nodename.InnerText = n;
                XmlNode nodepage = doc.CreateElement("page");
                nodepage.InnerText = p;
                node.AppendChild(nodename);
                node.AppendChild(nodepage);
                doc.DocumentElement.AppendChild(node);
                doc.Save(file);
            }
        }
        public void Change(string n, string p)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node["name"].InnerText == n) {
                    node["page"].InnerText = p;
                }
            }
            doc.Save(file);
        }
    }
}
