using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB
{
    public class Job
    {
        public Configuration Config=new Configuration();
        public DataPath Data=new DataPath();
    }

    public class Configuration
    {
        public bool USeShell;
        public int Size;
        public string EncodingString;
    }
    public class DataPath
    {
        public string InPut;
        public string OutPut;
    }
}
