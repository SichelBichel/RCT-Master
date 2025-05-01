using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RCT_Master
{
    [XmlRoot("Config")] 
    public class Config
    {
        [XmlElement("HostName")] 
        public string HostName { get; set; }

        [XmlElement("SlaveIP")]
        public string SlaveIP { get; set; }

        [XmlElement("SlavePort")]
        public int SlavePort { get; set; }

        [XmlElement("Token")]
        public string Token { get; set; }
    }
}