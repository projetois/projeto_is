﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SmartH2O_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface DLogger
    {

        [OperationContract]
        string saveAndFormatData(string data);

        [OperationContract]
        string verifyParamOrAlarm(string xml);

        [OperationContract]
        string showTest();
       
        // TODO: Add your service operations here
    }


}
