﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapBgService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]//(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public interface ISoapBgService
    {
        [OperationContract]
        List<Layer> getLayers(long userId, string username);

        [OperationContract]
        List<GeoObject> getGeoObjects(long userId, string username, int layerId,
                            double bottomLeftLat, double bottomLeftLon, double topRightLat, double topRightLon,
                            List<Filter> filters);

        [OperationContract]
        StatusResponse updateLayer(long systemId, long userId, string username, long layerId,
                            RequestType requestType, List<GeoObject> geoObjects);

        [OperationContract]
        bool registerForUpdate(long systemId, long userId, string username, int layerId,
                            double bottomLeftLat, double bottomLeftLon, double topRightLat, double topRightLon,
                            List<Filter> filters);
    }

}
