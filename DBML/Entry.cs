using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBML
{
    class Entry
    {
        public Entry(string friendlyName, string mountPath, string commandsToExecute, List<string> DBconfiguration)
        {
            FriendlyName = friendlyName;
            Path = mountPath;
            Launch = commandsToExecute;
            Config = DBconfiguration;
        }

        //public override string ToString()
        //{
            //return FriendlyName;
        //}

        public string Path { get; set; }
        public string Launch { get; set; }
        public string FriendlyName { get; set; }
        public List<string> Config { get; set; }
    }
}
