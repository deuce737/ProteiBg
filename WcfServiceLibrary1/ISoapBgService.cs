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
        [OperationContract]
        List<Layer> getLayers(long userId, string username);

        [OperationContract]
        List<GeoObject> getGeoObjects(long userId, string username, int layerId,
                            double bottomLeftLat, double bottomLeftLon, double topRightLat, double topRightLon,
                            List<Filter> filters);

        //[OperationContract]

        //[OperationContract]
        //string getData(string inp);

        // TODO: Add your service operations here
    }



}
