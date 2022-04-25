using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XmlConfiguration;

namespace JJOB
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface|AttributeTargets.All)]
    public class Job:Attribute
    {
        //public Configuration Config = new Configuration();
        //public DataPath Data = new DataPath();

        public List<Configuration> Config = new List<Configuration>();
        //[XmlElement(ElementName="Configuration")]

        public List<DataPath> Data = new List<DataPath>();
        //[XmlElement(ElementName = "DataPath")]

        public List<Configuration> config
        {
            get { return Config; }
            set { Config =value; }
        }
        public List<DataPath> data
        {
            get { return Data; }
            set { Data = value; }
        }
    }

    public class Configuration
    {
        public bool UseShell;
        public bool useShell
        {
            get { return UseShell; }
            set { UseShell = value; }
        }
        //public bool USeShell;
        public int Size;
        public int size
        {
            get { return Size; }
            set { Size = value; }
        }
        //public int Size;
        public string EncodingString;
        public string encodingString
        {
            get { return EncodingString; }
            set { EncodingString = value; }
        }
        //public string EncodingString;

        public Configuration() { }
        public Configuration(bool _UseShell, int _Size,string _EncodingString)
        {
            UseShell = _UseShell;
            Size = _Size;
            EncodingString = _EncodingString;
        }
    }
    public class DataPath
    {
        public string InPut;
        public string input
        {
            get { return InPut; }
            set { InPut = value; }
        }
        //public string InPut;
        public string OutPut;
        public string output
        {
            get { return OutPut; }
            set { OutPut = value; }
        }
        //public string OutPut;

        public DataPath() { }
        public DataPath (string _input,string _output)
        {
            InPut = _input;
            OutPut = _output;
        }
    }
}
