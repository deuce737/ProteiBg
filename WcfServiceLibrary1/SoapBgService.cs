using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;


namespace SoapBgService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

    public class SoapBgService : ISoapBgService
    {
        //public layer getLayers(long userId, string username)
        //{
        //    var glr = new layer();
        //    glr.id = 1;
        //    glr.description = "fff";
        //    return glr;
        //}
        public List<Layer> getLayers(long userId, string username)
        {
            var lrList = new List<Layer>();
            lrList.Add(new Layer { id = 1, name = "test1", description = "layerTest1" });
            lrList.Add(new Layer { id = 2, name = "test2", description = "layerTest2" });

            //glr.id = 111;
            //glr.name = "test";
            //glr.description = "testGlr";
            return lrList;
        }

        public List<GeoObject> getGeoObjects(long userId, string username, int layerId,
                        double bottomLeftLat, double bottomLeftLon, double topRightLat, double topRightLon,
                        List<Filter> filters)
        {
            var go = new List<GeoObject>();
            go.Add(new GeoObject { id = 1, name = "test1", description = "geoTest1" });
            go.Add(new GeoObject { id = 2, name = "test2", description = "geoTest2" });           

            return go;
        }

    }
}



