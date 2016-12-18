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
        public string saveAndFormatData(string data)
        {
           
            return "test";
            //Verificar se XML recebido tem elemento "message" para distinguir ficheiro datauploader ou ficheiro alarme

            

           
        }

        private void verifyParamOrAlarm(XmlDocument xml)
        {
            XmlNodeList message = xml.GetElementsByTagName("message");
           // File.AppendAllText(Directory.GetCurrentDirectory() + "\\" + filename, data);
            /* if (message.Count == 0)
             {
                 return "param";
             }
             else
             {
                 return "alarm";
             }*/
        } 
    }



}

