using System;

using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace RFDeviceAPP.Entities
{
    public class WhCode
    {
        public WhCode()
        {

        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static List<WhCode> Reader(string xmlstring)
        {
            List<WhCode> list = new List<WhCode>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlstring);
            XmlNode node = doc.SelectSingleNode("/Message/Body/Utility/UtilityHeader[1]");
         
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {

                XmlNode item = node.ChildNodes[i];
                int m = (i % 3);
                if (m == 2 && item.Name.IndexOf("Value") >= 0)
                {
                    WhCode wh = new WhCode();
                    wh.Code = item.InnerText;
                    XmlNode item1 = node.ChildNodes[i + 1];
                    wh.Name = item1.InnerText;
                    list.Add(wh);
                }
            }
            return list;

        }

    }

}
