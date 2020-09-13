using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SoapBgService
{
    [DataContract]
    //[KnownType(typeof(CompositeType))]
    public class Layer
    {
        [DataMember]
        public string description;
        //[DataMember]
        //public filter[] filters;
        [DataMember]
        // public geoObject[] geoObjects;
        //[DataMember]
        public int id;
        [DataMember]
        public layerDescriptor layerDescriptor;
        //[DataMember]
        //public layer[] layers;
        [DataMember]
        public string name;
    }

    [DataContract]
    public class GeoObject
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;
        [DataMember]
        public string description;
    }

    [DataContract]
    public class Filter
    {
        [DataMember]
        public string nameField;
    }
}
