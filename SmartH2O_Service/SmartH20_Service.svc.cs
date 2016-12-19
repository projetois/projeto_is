﻿using System;
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
        private string path;

        public void saveAndFormatData(string data)
        {

          verifyParamOrAlarm(data);
        }

       

        private void verifyParamOrAlarm(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList message = doc.GetElementsByTagName("message");
            string path = "";
            if (message.Count == 0)
             {
                path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, @"App_Data\params-data.xml");
                
             }
             else
             {
                path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, @"App_Data\alarms-data.xml");
                
             }
            
        }

        public string showTest()
        {

            return path;
        }
    }



}

