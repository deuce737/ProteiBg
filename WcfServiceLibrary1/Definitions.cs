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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    [DataContract]
    //[KnownType(typeof(CompositeType))]
    public class Layer
    {
        [DataMember]
        public string description;
        [DataMember]
        public Filter[] filters;
        [DataMember]
        public GeoObject[] geoObjects;
        [DataMember]
        public int id;
        [DataMember]
        public LayerDescriptor layerDescriptor;
        [DataMember]
        public Layer[] layers;
        [DataMember]
        public string name;
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    [DataContract]
    public class GeoObject
    {
        [DataMember]
        public Action[] actions;
        [DataMember]
        public GeoObjectEntry attributes;
        [DataMember]
        public string description;
        [DataMember]
        public string iconUrl;
        [DataMember]
        public int id;
        [DataMember]
        public int layerId;
        [DataMember]
        public GeoJson location;
        [DataMember]
        public string name;
    }

    [DataContract]
    public class Filter
    {
        [DataMember]
        public string nameField;
    }

    [DataContract]
    public class LayerDescriptor
    {
        [DataMember]
        public DisplayType[] displayTypes;
    }

    [DataContract]
    public class GeoJson
    {
        [DataMember]
        public string geometry;
    }

    [DataContract]
    public class GeoObjectEntry
    {
        [DataMember]
        public string key;
        [DataMember]
        public string value;
    }

    [DataContract]
    public class Action
    {
        [DataMember]
        public FilterConstraint[] actionConstraints;
        [DataMember]
        public string description;
        [DataMember]
        public Dictionary dictionary;
        [DataMember]
        public long id;
        [DataMember]
        public bool idSpecified;
        [DataMember]
        public string link;
        [DataMember]
        public string name;
        [DataMember]
        public string showType;
        [DataMember]
        public string title;
        [DataMember]
        public string typeToInput;
    }

    [DataContract]
    public class Dictionary
    {
        [DataMember]
        public string description;
        [DataMember]
        public long id;
        [DataMember]
        public bool isSpecified;
        [DataMember]
        public string name;
        [DataMember]
        public DictionaryValue[] values;
    }

    [DataContract]
    public class DictionaryValue
    {
        [DataMember]
        public long id;
        [DataMember]
        public bool isSpecified;
        [DataMember]
        public string value;
    }

    [DataContract]
    public class FilterConstraint
    {
        [DataMember]
        public FilterConstraintType type;
        [DataMember]
        public bool typeSpecified;
        public object value;
    }

    [DataContract]
    public class StatusResponse
    {
        [DataMember]
        public string message;
        [DataMember]
        public string notificationType;
        [DataMember]
        public int status;
    }

    public enum RequestType
    {
        REFRESH,
        UPDATE,
        ADD,
        DELETE
    }

    public enum FilterConstraintType
    {
        /// <remarks/>
        MAX_VALUE,
        /// <remarks/>
        MIN_VALUE,
        /// <remarks/>
        MAX_SELECT,
        /// <remarks/>
        MIN_LENGTH,
        /// <remarks/>
        MAX_LENGTH,
    }

    public enum DisplayType
    {
        /// <remarks/>
        WIND,
        /// <remarks/>
        INTENSITY_MAP,
        /// <remarks/>
        HEAT_MAP,
    }
}
