using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapBgService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISoapBgService
    {
        //[OperationContract]
        //layer getLayers(long userId, string username);

        [OperationContract]
        Layer getLayers(long userId, string username);
        //[OperationContract]
        //string getData(string inp);

        // TODO: Add your service operations here
    }



}
