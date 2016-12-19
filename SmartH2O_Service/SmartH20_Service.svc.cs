using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SmartH2O_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SmartH2O_Service : DLogger
    {

        private XmlNode alarmXml;
        private XmlNode paramXml;
        private string path ="notinitialized";

        public string saveAndFormatData(string data)
        {
            return verifyParamOrAlarm(data);
        }

       

        public string verifyParamOrAlarm(string xml)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument docXml = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList message = doc.GetElementsByTagName("message");
            if (message.Count == 0)
            {
                //Se não tiver element "message" então é param-data
                path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, @"App_Data\params-data.xml");
                if (!File.Exists(path))
                {
                    //paramXml = docXml.CreateElement("sensors");
                    // param
                    path = "test5";

                } else
                {
                    path = "test6";
                }

            }
            else
            {
                path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, @"App_Data\alarms-data.xml");
                if (!File.Exists(path))
                {
                    //paramXml = docXml.CreateElement("sensors");
                    // param
                    path = "testmessage=1 path !=";

                }
                else
                {
                    path = "testmessage=1 path ==";
                }
            }
            return path;
        }

        public string showTest()
        {
            return path;
        }


    }



}

