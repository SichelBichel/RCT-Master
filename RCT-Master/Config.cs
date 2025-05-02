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
        //


        [XmlElement("EventButton1Name")]
        public string EventButton1Name { get; set; }

        [XmlElement("EventButton1Content")]
        public string EventButton1Content { get; set; }
        //


        [XmlElement("EventButton2Name")]
        public string EventButton2Name { get; set; }

        [XmlElement("EventButton2Content")]
        public string EventButton2Content { get; set; }
        //


        [XmlElement("EventButton3Name")]
        public string EventButton3Name { get; set; }

        [XmlElement("EventButton3Content")]
        public string EventButton3Content { get; set; }
        //


        [XmlElement("EventButton4Name")]
        public string EventButton4Name { get; set; }

        [XmlElement("EventButton4Content")]
        public string EventButton4Content { get; set; }

        [XmlElement("EventButton5Name")]
        public string EventButton5Name { get; set; }

        [XmlElement("EventButton5Content")]
        public string EventButton5Content { get; set; }

        [XmlElement("EventButton6Name")]
        public string EventButton6Name { get; set; }

        [XmlElement("EventButton6Content")]
        public string EventButton6Content { get; set; }

        [XmlElement("EventButton7Name")]
        public string EventButton7Name { get; set; }

        [XmlElement("EventButton7Content")]
        public string EventButton7Content { get; set; }

        [XmlElement("EventButton8Name")]
        public string EventButton8Name { get; set; }

        [XmlElement("EventButton8Content")]
        public string EventButton8Content { get; set; }

        [XmlElement("EventButton9Name")]
        public string EventButton9Name { get; set; }

        [XmlElement("EventButton9Content")]
        public string EventButton9Content { get; set; }

        [XmlElement("EventButton10Name")]
        public string EventButton10Name { get; set; }

        [XmlElement("EventButton10Content")]
        public string EventButton10Content { get; set; }

        [XmlElement("EventButton11Name")]
        public string EventButton11Name { get; set; }

        [XmlElement("EventButton11Content")]
        public string EventButton11Content { get; set; }

        [XmlElement("EventButton12Name")]
        public string EventButton12Name { get; set; }

        [XmlElement("EventButton12Content")]
        public string EventButton12Content { get; set; }

        [XmlElement("EventButton13Name")]
        public string EventButton13Name { get; set; }

        [XmlElement("EventButton13Content")]
        public string EventButton13Content { get; set; }

        [XmlElement("EventButton14Name")]
        public string EventButton14Name { get; set; }

        [XmlElement("EventButton14Content")]
        public string EventButton14Content { get; set; }
    }
}