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
        string path  = "notinitialized";
  

        public string saveAndFormatData(string data)
        {
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\testfile.txt", data);
            return verifyParamOrAlarm(data);
        }

        public string showTest()
        {
            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\testfile.txt"))
            {

                String line = sr.ReadToEnd();
                return line;
            }
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

            return path;
        
        }



    }



}

