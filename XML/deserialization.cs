using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JJOB;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XML
{
    class deserialization
    {
        static void Main(string[] args)
        {
            /*Job config = new Job();

             XmlDocument doc = new XmlDocument();
             doc.Load("c:/Users/admin/Desktop/test/JobConfig.xml");*/

            //string path = @"c:\Users\admin\Desktop\test\JobConfig.xml";

            try
            {
                XmlSerializer des = new XmlSerializer(typeof(Job));
                using (FileStream file = File.OpenRead(@"c:\Users\admin\Desktop\test\JobConfig.xml"))
                {
                    Job job = (Job)des.Deserialize(file);
                    foreach (Configuration con in job.config)
                    {
                        Console.WriteLine("UseShell: " + con.useShell);
                        Console.WriteLine("Size: " + con.size);
                        Console.WriteLine("EncodingString: " + con.encodingString);
                    }
                    foreach (DataPath dat in job.data)
                    {
                        Console.WriteLine("InPut: " + dat.input);
                        Console.WriteLine("OutPut: " + dat.output);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            //xmlDes(path);

        }

        /*public static void xmlDes(string path)
        {
            XmlSerializer des = new XmlSerializer(typeof(Job));
            using (FileStream file = File.OpenRead(path))
            {
                Job job = (Job)des.Deserialize(file);
                foreach (Configuration con in job.config)
                {
                    Console.WriteLine("UseShell: " + con.useShell);
                    Console.WriteLine("Size: " + con.size);
                    Console.WriteLine("EncodingString: " + con.encodingString);
                }
                foreach (DataPath data in job.data)
                {
                    Console.WriteLine("InPut: " + data.input);
                    Console.WriteLine("OutPut: " + data.output);
                }
            }
        }*/
    }
} 
