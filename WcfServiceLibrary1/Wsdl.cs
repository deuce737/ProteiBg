

    using System;
    using System.ComponentModel;
    using System.Diagnostics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Services;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;




/// <remarks/>


namespace SoapBgService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Web.Services.WebServiceBindingAttribute(Name = "LayerWebServiceImplSoapBinding", Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(layerUpdWrapper))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(performActionResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(performAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(registerForUpdateResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(registerForUpdate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getLayersResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getLayers))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getGeoObjectsResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getGeoObjects))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(action[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(geoObject[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(filter[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(displayType[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(layer[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(filterValue[]))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(filterConstraint[]))]
    public partial class LayerWebServiceImpl : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback getGeoObjectsOperationCompleted;

        private System.Threading.SendOrPostCallback getLayersOperationCompleted;

        private System.Threading.SendOrPostCallback registerForUpdateOperationCompleted;

        private System.Threading.SendOrPostCallback performActionOperationCompleted;

        /// <remarks/>
        public LayerWebServiceImpl()
        {
            this.Url = "http://localhost:8081/SoapBgService/";
        }

        /// <remarks/>
        public event getGeoObjectsCompletedEventHandler getGeoObjectsCompleted;

        /// <remarks/>
        public event getLayersCompletedEventHandler getLayersCompleted;

        /// <remarks/>
        public event registerForUpdateCompletedEventHandler registerForUpdateCompleted;

        /// <remarks/>
        public event performActionCompletedEventHandler performActionCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://ws.integratedService.geoserver.protei.ru/", ResponseNamespace = "http://ws.integratedService.geoserver.protei.ru/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public geoObject[] getGeoObjects(long userId, string username, int layerId, double bottomLeftLat, [System.Xml.Serialization.XmlIgnoreAttribute()] bool bottomLeftLatSpecified, double bottomLeftLon, [System.Xml.Serialization.XmlIgnoreAttribute()] bool bottomLeftLonSpecified, double topRightLat, [System.Xml.Serialization.XmlIgnoreAttribute()] bool topRightLatSpecified, double topRightLon, [System.Xml.Serialization.XmlIgnoreAttribute()] bool topRightLonSpecified, [System.Xml.Serialization.XmlElementAttribute("filter")] filter[] filter)
        {
            object[] results = this.Invoke("getGeoObjects", new object[] {
                    userId,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter});
            return ((geoObject[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetGeoObjects(long userId, string username, int layerId, double bottomLeftLat, bool bottomLeftLatSpecified, double bottomLeftLon, bool bottomLeftLonSpecified, double topRightLat, bool topRightLatSpecified, double topRightLon, bool topRightLonSpecified, filter[] filter, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("getGeoObjects", new object[] {
                    userId,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter}, callback, asyncState);
        }

        /// <remarks/>
        public geoObject[] EndgetGeoObjects(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((geoObject[])(results[0]));
        }

        /// <remarks/>
        public void getGeoObjectsAsync(long userId, string username, int layerId, double bottomLeftLat, bool bottomLeftLatSpecified, double bottomLeftLon, bool bottomLeftLonSpecified, double topRightLat, bool topRightLatSpecified, double topRightLon, bool topRightLonSpecified, filter[] filter)
        {
            this.getGeoObjectsAsync(userId, username, layerId, bottomLeftLat, bottomLeftLatSpecified, bottomLeftLon, bottomLeftLonSpecified, topRightLat, topRightLatSpecified, topRightLon, topRightLonSpecified, filter, null);
        }

        /// <remarks/>
        public void getGeoObjectsAsync(long userId, string username, int layerId, double bottomLeftLat, bool bottomLeftLatSpecified, double bottomLeftLon, bool bottomLeftLonSpecified, double topRightLat, bool topRightLatSpecified, double topRightLon, bool topRightLonSpecified, filter[] filter, object userState)
        {
            if ((this.getGeoObjectsOperationCompleted == null))
            {
                this.getGeoObjectsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetGeoObjectsOperationCompleted);
            }
            this.InvokeAsync("getGeoObjects", new object[] {
                    userId,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter}, this.getGeoObjectsOperationCompleted, userState);
        }

        private void OngetGeoObjectsOperationCompleted(object arg)
        {
            if ((this.getGeoObjectsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getGeoObjectsCompleted(this, new getGeoObjectsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://ws.integratedService.geoserver.protei.ru/", ResponseNamespace = "http://ws.integratedService.geoserver.protei.ru/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public layer[] getLayers(long userId, string username)
        {
            object[] results = this.Invoke("getLayers", new object[] {
                    userId,
                    username});
            return ((layer[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetLayers(long userId, string username, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("getLayers", new object[] {
                    userId,
                    username}, callback, asyncState);
        }

        /// <remarks/>
        public layer[] EndgetLayers(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((layer[])(results[0]));
        }

        /// <remarks/>
        public void getLayersAsync(long userId, string username)
        {
            this.getLayersAsync(userId, username, null);
        }

        /// <remarks/>
        public void getLayersAsync(long userId, string username, object userState)
        {
            if ((this.getLayersOperationCompleted == null))
            {
                this.getLayersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLayersOperationCompleted);
            }
            this.InvokeAsync("getLayers", new object[] {
                    userId,
                    username}, this.getLayersOperationCompleted, userState);
        }

        private void OngetLayersOperationCompleted(object arg)
        {
            if ((this.getLayersCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLayersCompleted(this, new getLayersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://ws.integratedService.geoserver.protei.ru/", ResponseNamespace = "http://ws.integratedService.geoserver.protei.ru/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public bool registerForUpdate(long systemId, long userId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool userIdSpecified, string username, int layerId, double bottomLeftLat, [System.Xml.Serialization.XmlIgnoreAttribute()] bool bottomLeftLatSpecified, double bottomLeftLon, [System.Xml.Serialization.XmlIgnoreAttribute()] bool bottomLeftLonSpecified, double topRightLat, [System.Xml.Serialization.XmlIgnoreAttribute()] bool topRightLatSpecified, double topRightLon, [System.Xml.Serialization.XmlIgnoreAttribute()] bool topRightLonSpecified, [System.Xml.Serialization.XmlElementAttribute("filter")] filter[] filter)
        {
            object[] results = this.Invoke("registerForUpdate", new object[] {
                    systemId,
                    userId,
                    userIdSpecified,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginregisterForUpdate(
                    long systemId,
                    long userId,
                    bool userIdSpecified,
                    string username,
                    int layerId,
                    double bottomLeftLat,
                    bool bottomLeftLatSpecified,
                    double bottomLeftLon,
                    bool bottomLeftLonSpecified,
                    double topRightLat,
                    bool topRightLatSpecified,
                    double topRightLon,
                    bool topRightLonSpecified,
                    filter[] filter,
                    System.AsyncCallback callback,
                    object asyncState)
        {
            return this.BeginInvoke("registerForUpdate", new object[] {
                    systemId,
                    userId,
                    userIdSpecified,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndregisterForUpdate(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void registerForUpdateAsync(long systemId, long userId, bool userIdSpecified, string username, int layerId, double bottomLeftLat, bool bottomLeftLatSpecified, double bottomLeftLon, bool bottomLeftLonSpecified, double topRightLat, bool topRightLatSpecified, double topRightLon, bool topRightLonSpecified, filter[] filter)
        {
            this.registerForUpdateAsync(systemId, userId, userIdSpecified, username, layerId, bottomLeftLat, bottomLeftLatSpecified, bottomLeftLon, bottomLeftLonSpecified, topRightLat, topRightLatSpecified, topRightLon, topRightLonSpecified, filter, null);
        }

        /// <remarks/>
        public void registerForUpdateAsync(long systemId, long userId, bool userIdSpecified, string username, int layerId, double bottomLeftLat, bool bottomLeftLatSpecified, double bottomLeftLon, bool bottomLeftLonSpecified, double topRightLat, bool topRightLatSpecified, double topRightLon, bool topRightLonSpecified, filter[] filter, object userState)
        {
            if ((this.registerForUpdateOperationCompleted == null))
            {
                this.registerForUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnregisterForUpdateOperationCompleted);
            }
            this.InvokeAsync("registerForUpdate", new object[] {
                    systemId,
                    userId,
                    userIdSpecified,
                    username,
                    layerId,
                    bottomLeftLat,
                    bottomLeftLatSpecified,
                    bottomLeftLon,
                    bottomLeftLonSpecified,
                    topRightLat,
                    topRightLatSpecified,
                    topRightLon,
                    topRightLonSpecified,
                    filter}, this.registerForUpdateOperationCompleted, userState);
        }

        private void OnregisterForUpdateOperationCompleted(object arg)
        {
            if ((this.registerForUpdateCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.registerForUpdateCompleted(this, new registerForUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://ws.integratedService.geoserver.protei.ru/", ResponseNamespace = "http://ws.integratedService.geoserver.protei.ru/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public statusResponse performAction(long userId, string username, int layerId, int geoObjectId, customAction customAction)
        {
            object[] results = this.Invoke("performAction", new object[] {
                    userId,
                    username,
                    layerId,
                    geoObjectId,
                    customAction});
            return ((statusResponse)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginperformAction(long userId, string username, int layerId, int geoObjectId, customAction customAction, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("performAction", new object[] {
                    userId,
                    username,
                    layerId,
                    geoObjectId,
                    customAction}, callback, asyncState);
        }

        /// <remarks/>
        public statusResponse EndperformAction(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((statusResponse)(results[0]));
        }

        /// <remarks/>
        public void performActionAsync(long userId, string username, int layerId, int geoObjectId, customAction customAction)
        {
            this.performActionAsync(userId, username, layerId, geoObjectId, customAction, null);
        }

        /// <remarks/>
        public void performActionAsync(long userId, string username, int layerId, int geoObjectId, customAction customAction, object userState)
        {
            if ((this.performActionOperationCompleted == null))
            {
                this.performActionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnperformActionOperationCompleted);
            }
            this.InvokeAsync("performAction", new object[] {
                    userId,
                    username,
                    layerId,
                    geoObjectId,
                    customAction}, this.performActionOperationCompleted, userState);
        }

        private void OnperformActionOperationCompleted(object arg)
        {
            if ((this.performActionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.performActionCompleted(this, new performActionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public partial class filter
    {

        private customFilter customFilterField;

        private dictionary dictionaryField;

        private filterConstraint[] filterConstraintsField;

        private long idField;

        private bool idFieldSpecified;

        private string nameField;

        private filteringOperation[] supportedOperationsField;

        private string titleField;

        private filterValueType typeField;

        private bool typeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public customFilter customFilter
        {
            get
            {
                return this.customFilterField;
            }
            set
            {
                this.customFilterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public dictionary dictionary
        {
            get
            {
                return this.dictionaryField;
            }
            set
            {
                this.dictionaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public filterConstraint[] filterConstraints
        {
            get
            {
                return this.filterConstraintsField;
            }
            set
            {
                this.filterConstraintsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("supportedOperation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public filteringOperation[] supportedOperations
        {
            get
            {
                return this.supportedOperationsField;
            }
            set
            {
                this.supportedOperationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public filterValueType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public partial class customFilter
    {

        private filterValue[] filterValuesField;

        private filteringOperation operationField;

        private bool operationFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public filterValue[] filterValues
        {
            get
            {
                return this.filterValuesField;
            }
            set
            {
                this.filterValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public filteringOperation operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationSpecified
        {
            get
            {
                return this.operationFieldSpecified;
            }
            set
            {
                this.operationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public partial class filterValue
    {

        private object valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class layerUpdWrapper
    {

        private string complexIdField;

        private geoObject[] geoObjectsField;

        private string requestTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string complexId
        {
            get
            {
                return this.complexIdField;
            }
            set
            {
                this.complexIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("geoObjects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public geoObject[] geoObjects
        {
            get
            {
                return this.geoObjectsField;
            }
            set
            {
                this.geoObjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string requestType
        {
            get
            {
                return this.requestTypeField;
            }
            set
            {
                this.requestTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class geoObject
    {

        private action[] actionsField;

        private geoObjectEntry[] attributesField;

        private string descriptionField;

        private string iconUrlField;

        private int idField;

        private int layerIdField;

        private geoJson locationField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public action[] actions
        {
            get
            {
                return this.actionsField;
            }
            set
            {
                this.actionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public geoObjectEntry[] attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string iconUrl
        {
            get
            {
                return this.iconUrlField;
            }
            set
            {
                this.iconUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int layerId
        {
            get
            {
                return this.layerIdField;
            }
            set
            {
                this.layerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public geoJson location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class action
    {

        private filterConstraint[] actionConstraintsField;

        private string descriptionField;

        private dictionary dictionaryField;

        private long idField;

        private bool idFieldSpecified;

        private string linkField;

        private string nameField;

        private string showTypeField;

        private string titleField;

        private string typeToInputField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("actionConstraint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public filterConstraint[] actionConstraints
        {
            get
            {
                return this.actionConstraintsField;
            }
            set
            {
                this.actionConstraintsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public dictionary dictionary
        {
            get
            {
                return this.dictionaryField;
            }
            set
            {
                this.dictionaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI")]
        public string link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string showType
        {
            get
            {
                return this.showTypeField;
            }
            set
            {
                this.showTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string typeToInput
        {
            get
            {
                return this.typeToInputField;
            }
            set
            {
                this.typeToInputField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public partial class filterConstraint
    {

        private filterConstraintType typeField;

        private bool typeFieldSpecified;

        private object valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public filterConstraintType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public enum filterConstraintType
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class dictionary
    {

        private string descriptionField;

        private long idField;

        private bool idFieldSpecified;

        private string nameField;

        private dictionaryValue[] valuesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public dictionaryValue[] values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class dictionaryValue
    {

        private long idField;

        private bool idFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://geoserver.protei.ru/models")]
    public partial class geoObjectEntry
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class geoJson
    {

        private string geometryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string geometry
        {
            get
            {
                return this.geometryField;
            }
            set
            {
                this.geometryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class statusResponse
    {

        private string messageField;

        private string notificationTypeField;

        private int statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string notificationType
        {
            get
            {
                return this.notificationTypeField;
            }
            set
            {
                this.notificationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class performActionResponse
    {

        private statusResponse returnField;

        /// <remarks/>
        public statusResponse @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class customAction
    {

        private object[] actionDataField;

        private int actionIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public object[] actionData
        {
            get
            {
                return this.actionDataField;
            }
            set
            {
                this.actionDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int actionId
        {
            get
            {
                return this.actionIdField;
            }
            set
            {
                this.actionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class performAction
    {

        private long userIdField;

        private string usernameField;

        private int layerIdField;

        private int geoObjectIdField;

        private customAction customActionField;

        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public int layerId
        {
            get
            {
                return this.layerIdField;
            }
            set
            {
                this.layerIdField = value;
            }
        }

        /// <remarks/>
        public int geoObjectId
        {
            get
            {
                return this.geoObjectIdField;
            }
            set
            {
                this.geoObjectIdField = value;
            }
        }

        /// <remarks/>
        public customAction customAction
        {
            get
            {
                return this.customActionField;
            }
            set
            {
                this.customActionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class registerForUpdateResponse
    {

        private bool returnField;

        /// <remarks/>
        public bool @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class registerForUpdate
    {

        private long systemIdField;

        private long userIdField;

        private bool userIdFieldSpecified;

        private string usernameField;

        private int layerIdField;

        private double bottomLeftLatField;

        private bool bottomLeftLatFieldSpecified;

        private double bottomLeftLonField;

        private bool bottomLeftLonFieldSpecified;

        private double topRightLatField;

        private bool topRightLatFieldSpecified;

        private double topRightLonField;

        private bool topRightLonFieldSpecified;

        private filter[] filterField;

        /// <remarks/>
        public long systemId
        {
            get
            {
                return this.systemIdField;
            }
            set
            {
                this.systemIdField = value;
            }
        }

        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool userIdSpecified
        {
            get
            {
                return this.userIdFieldSpecified;
            }
            set
            {
                this.userIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public int layerId
        {
            get
            {
                return this.layerIdField;
            }
            set
            {
                this.layerIdField = value;
            }
        }

        /// <remarks/>
        public double bottomLeftLat
        {
            get
            {
                return this.bottomLeftLatField;
            }
            set
            {
                this.bottomLeftLatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bottomLeftLatSpecified
        {
            get
            {
                return this.bottomLeftLatFieldSpecified;
            }
            set
            {
                this.bottomLeftLatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double bottomLeftLon
        {
            get
            {
                return this.bottomLeftLonField;
            }
            set
            {
                this.bottomLeftLonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bottomLeftLonSpecified
        {
            get
            {
                return this.bottomLeftLonFieldSpecified;
            }
            set
            {
                this.bottomLeftLonFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double topRightLat
        {
            get
            {
                return this.topRightLatField;
            }
            set
            {
                this.topRightLatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topRightLatSpecified
        {
            get
            {
                return this.topRightLatFieldSpecified;
            }
            set
            {
                this.topRightLatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double topRightLon
        {
            get
            {
                return this.topRightLonField;
            }
            set
            {
                this.topRightLonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topRightLonSpecified
        {
            get
            {
                return this.topRightLonFieldSpecified;
            }
            set
            {
                this.topRightLonFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public filter[] filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public partial class layerDescriptor
    {

        private displayType[] displayTypesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public displayType[] displayTypes
        {
            get
            {
                return this.displayTypesField;
            }
            set
            {
                this.displayTypesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    public enum displayType
    {

        /// <remarks/>
        WIND,

        /// <remarks/>
        INTENSITY_MAP,

        /// <remarks/>
        HEAT_MAP,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models")]
    //[DataContract]
    public partial class layer
    {

        private string descriptionField;

        private filter[] filtersField;

        private geoObject[] geoObjectsField;

        private int idField;

        private layerDescriptor layerDescriptorField;

        private layer[] layersField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public filter[] filters
        {
            get
            {
                return this.filtersField;
            }
            set
            {
                this.filtersField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public geoObject[] geoObjects
        {
            get
            {
                return this.geoObjectsField;
            }
            set
            {
                this.geoObjectsField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public layerDescriptor layerDescriptor
        {
            get
            {
                return this.layerDescriptorField;
            }
            set
            {
                this.layerDescriptorField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public layer[] layers
        {
            get
            {
                return this.layersField;
            }
            set
            {
                this.layersField = value;
            }
        }
        //[DataMember]
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]

    public partial class getLayersResponse
    {

        private layer[] returnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public layer[] @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class getLayers
    {

        private long userIdField;

        private string usernameField;

        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class getGeoObjectsResponse
    {

        private geoObject[] returnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public geoObject[] @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ws.integratedService.geoserver.protei.ru/")]
    public partial class getGeoObjects
    {

        private long userIdField;

        private string usernameField;

        private int layerIdField;

        private double bottomLeftLatField;

        private bool bottomLeftLatFieldSpecified;

        private double bottomLeftLonField;

        private bool bottomLeftLonFieldSpecified;

        private double topRightLatField;

        private bool topRightLatFieldSpecified;

        private double topRightLonField;

        private bool topRightLonFieldSpecified;

        private filter[] filterField;

        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public int layerId
        {
            get
            {
                return this.layerIdField;
            }
            set
            {
                this.layerIdField = value;
            }
        }

        /// <remarks/>
        public double bottomLeftLat
        {
            get
            {
                return this.bottomLeftLatField;
            }
            set
            {
                this.bottomLeftLatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bottomLeftLatSpecified
        {
            get
            {
                return this.bottomLeftLatFieldSpecified;
            }
            set
            {
                this.bottomLeftLatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double bottomLeftLon
        {
            get
            {
                return this.bottomLeftLonField;
            }
            set
            {
                this.bottomLeftLonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bottomLeftLonSpecified
        {
            get
            {
                return this.bottomLeftLonFieldSpecified;
            }
            set
            {
                this.bottomLeftLonFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double topRightLat
        {
            get
            {
                return this.topRightLatField;
            }
            set
            {
                this.topRightLatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topRightLatSpecified
        {
            get
            {
                return this.topRightLatFieldSpecified;
            }
            set
            {
                this.topRightLatFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double topRightLon
        {
            get
            {
                return this.topRightLonField;
            }
            set
            {
                this.topRightLonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool topRightLonSpecified
        {
            get
            {
                return this.topRightLonFieldSpecified;
            }
            set
            {
                this.topRightLonFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public filter[] filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public enum filteringOperation
    {

        /// <remarks/>
        LESS,

        /// <remarks/>
        EQUAL,

        /// <remarks/>
        STRING_CONTAINS,

        /// <remarks/>
        RANGE,

        /// <remarks/>
        GREATER,

        /// <remarks/>
        MULTISELECT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://geoserver.protei.ru/models/filtering")]
    public enum filterValueType
    {

        /// <remarks/>
        DOUBLE,

        /// <remarks/>
        DICTIONARY,

        /// <remarks/>
        DATE_TIME_ISO8601,

        /// <remarks/>
        INTEGER,

        /// <remarks/>
        STRING,

        /// <remarks/>
        BOOLEAN,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void getGeoObjectsCompletedEventHandler(object sender, getGeoObjectsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getGeoObjectsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getGeoObjectsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public geoObject[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((geoObject[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void getLayersCompletedEventHandler(object sender, getLayersCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLayersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal getLayersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public layer[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((layer[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void registerForUpdateCompletedEventHandler(object sender, registerForUpdateCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class registerForUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal registerForUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void performActionCompletedEventHandler(object sender, performActionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class performActionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal performActionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public statusResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((statusResponse)(this.results[0]));
            }
        }
    }
}

