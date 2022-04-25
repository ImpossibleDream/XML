using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JOB;
using System.Xml;

namespace XML
{
    class manually
    {
        static void Main(string[] args)
        {
            Job config = new Job();

            XmlDocument doc = new XmlDocument();
            doc.Load("c:/Users/admin/Desktop/test/JobConfig.xml");

            //root node
            //XmlNode node = doc.SelectSingleNode("Job");
            //XmlNodeList list = node.ChildNodes;

            XmlNode node1 = doc.SelectSingleNode("Job/Configuration");
            XmlNodeList list1 = node1.ChildNodes;
            //int len1 = list1.Count;
            config.Config.USeShell = (list1[0].InnerText == "true");
            config.Config.Size = int.Parse(list1[1].InnerText);
            config.Config.EncodingString = (list1[2].InnerText);

            XmlNode node2 = doc.SelectSingleNode("Job/DataPath");
            XmlNodeList list2 = node2.ChildNodes;
            //int len2 = list2.Count;
            config.Data.InPut = (list2[0].InnerText);
            config.Data.OutPut = (list2[1].InnerText);

            Console.WriteLine("Configuration Config:");
            Console.WriteLine("UseShell: "+config.Config.USeShell);
            Console.WriteLine("Size: "+config.Config.Size);
            Console.WriteLine("EncodingString: "+config.Config.EncodingString);
            Console.WriteLine("\nDataPath Data:");
            Console.WriteLine("Input: "+config.Data.InPut);
            Console.WriteLine("OutPut: "+config.Data.OutPut+"\n");
        }
    }
}