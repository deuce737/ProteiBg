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
        public Layer getLayers(long userId, string username)
        {
            var glr = new Layer();
            glr.id = 111;
            glr.name = "dfs";
            return glr;
        }
        //public string getData(string inp)
        //{
        //    return "Get Dataaa" + inp;
        //}

    }
}



