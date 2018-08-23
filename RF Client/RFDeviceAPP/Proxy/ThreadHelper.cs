using System;

using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using RFDeviceAPP.Common;
using RFDeviceAPP.Entities;
namespace RFDeviceAPP.Proxy
{
    public class RequestGenerator<T>
    {
        private T _object;
        private string _messagetype;
        private string _user;
        private string _password;
        private string _sendsysid;
        private string _recipientsysid;

        public RequestGenerator(string messagetype, string user, string password, string sendsysid, string recipientsysid, T obj)
        {
            this._messagetype = messagetype;
            this._object = obj;
            this._password = password;
            this._recipientsysid = recipientsysid;
            this._sendsysid = sendsysid;
            this._user = user;
        }

        private XmlDocument createHeader()
        {
            string xmlstring = string.Format(
            "<Message><Head><MessageType>{0}</MessageType><Sender><SystemID>{1}</SystemID><User>{2}</User><Password>{3}</Password></Sender><Recipient><SystemID>{4}</SystemID></Recipient></Head><Body /></Message>",
            _messagetype, _sendsysid, _user, _password, _recipientsysid);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlstring);
            return doc;
        }
        public XmlDocument CreateMessage()
        {
            XmlDocument bodydoc = new XmlDocument();
            bodydoc.LoadXml(this.serialize());
            XmlDocument headdoc = this.createHeader();
            XmlNode bodycopy = headdoc.ImportNode(bodydoc.DocumentElement, true);
            XmlNode bodynode = headdoc.SelectSingleNode("/Message/Body");
            bodynode.AppendChild(bodycopy);

            return headdoc;
        }
        public string CreateNativeMessage()
        {

            return CreateMessage().OuterXml;
           
        }
        private string serialize()
        {
            XmlSerializerNamespaces xmlnsEmpty = new XmlSerializerNamespaces();
            xmlnsEmpty.Add("", "");

            System.Xml.Serialization.XmlSerializer xmlser = new System.Xml.Serialization.XmlSerializer(typeof(T));
            StringBuilder sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                xmlser.Serialize(writer, _object, xmlnsEmpty);
            }
            return sb.ToString();
        }
    }
    public enum enumRequestType{MessageProcessor=0}
    public enum enumMessageType { AdvancedShipNotice = 0, ShipmentOrder, Inventory, Utility, DoorsManagement, Task, TaskReason }
    public enum enumRequestMethod { list = 0, store, search, functionOperation,listHead }
    public enum enumSendSysId { EXceed = 0, External }
    public class RequestMessage
    {
        private object _entity;
        private UserInfo loginUser;

        public UserInfo LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }
        public RequestMessage(enumRequestType requesttype,enumMessageType requestcategory,enumRequestMethod requestmethod, Common.UserInfo userinfo, enumSendSysId sendsysid, object entity)
        {
            this.requestType = requesttype;
            this.messageType = requestcategory;
            this.requestMethod = requestmethod;
            this.sendSysId = sendsysid;
            this._entity = entity;
            this.loginUser = userinfo;
            this.document=this.createXmlDocument();
            
        }
        private XmlDocument document;

        public XmlDocument Document
        {
            get { return document; }
            //set { document = value; }
        }
        private enumSendSysId sendSysId;

        public enumSendSysId SendSysId
        {
            get { return sendSysId; }
            set { sendSysId = value; }
        }

        private enumRequestType requestType;

        public enumRequestType RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }
        private enumRequestMethod requestMethod;

        public enumRequestMethod RequestMethod
        {
            get { return requestMethod; }
            set { requestMethod = value; }
        }
        private enumMessageType messageType;

        public enumMessageType MessageType
        {
            get { return messageType; }
            set { messageType = value; }
        }
        private string xmlString;

        public string XmlString
        {
            get { return this.document.OuterXml; }
            //set { xmlString = value; }
        }

        private XmlDocument createXmlDocument()
        {
            XmlDocument bodydoc = new XmlDocument();
            bodydoc.LoadXml(this.serialize());
            XmlDocument headdoc = this.createHeader();
            XmlNode bodycopy = headdoc.ImportNode(bodydoc.DocumentElement, true);
            XmlNode bodynode = headdoc.SelectSingleNode("/Message/Body");
            bodynode.AppendChild(bodycopy);

            return headdoc;
        }
        private XmlDocument createHeader()
        {
            string xmlstring = string.Format(
            "<Message><Head><MessageType>{0}</MessageType><Sender><SystemID>{1}</SystemID><User>{2}</User><Password>{3}</Password></Sender><Recipient><SystemID>{4}</SystemID></Recipient></Head><Body /></Message>",
            this.messageType.ToString(), this.sendSysId.ToString(), this.loginUser.UserName, this.loginUser.Password, this.loginUser.Whcode);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlstring);
            return doc;
        }

        private string serialize()
        {
            XmlSerializerNamespaces xmlnsEmpty = new XmlSerializerNamespaces();
            xmlnsEmpty.Add("", "");

            System.Xml.Serialization.XmlSerializer xmlser = new System.Xml.Serialization.XmlSerializer(this._entity.GetType());
            StringBuilder sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb, new XmlWriterSettings { OmitXmlDeclaration = true }))
            {
                xmlser.Serialize(writer, _entity, xmlnsEmpty);
            }
            return sb.ToString();
        }
        public T Deserialize<T>()
        {
            string xmlpath = "/Message/Body";
            string xmlstr = "";
            XmlNode node = document.SelectSingleNode(xmlpath);
            if (node.ChildNodes.Count > 1)
            {
                xmlstr = node.LastChild.OuterXml;
            }
            else
            {
                xmlstr = node.InnerXml;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (XmlReader reader = new XmlTextReader(new StringReader(xmlstr)))
            {
                return (T)xmlSerializer.Deserialize(reader);
                //return (T)XmlSerializer.d
            }
        }

    }
    public class ResponseMessage
    {
        public ResponseMessage(string xmlstring)
        {
            this.xmlString = xmlstring;
            this.xmldoc = new XmlDocument();

            xmldoc.LoadXml(this.xmlString);

        }
        private XmlDocument xmldoc;
        private string xmlString;

        public string XmlString
        {
            get { return xmlString; }
            set { xmlString = value; }
        }

        public string  GetErrorMessage()
        {
            string xmlpath = "/Message/Body/Error";
            XmlNode node = xmldoc.SelectSingleNode(xmlpath);
            if (node == null)
                return string.Empty;
            else
                return node.InnerText;
        }
        public T Deserialize<T>()
        {
            string xmlpath = "/Message/Body";
            string xmlstr = "";
            XmlNode node = xmldoc.SelectSingleNode(xmlpath);
            if (node.ChildNodes.Count > 1)
            {
                xmlstr = node.LastChild.OuterXml;
            }
            else
            {
                xmlstr = node.InnerXml;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (XmlReader reader = new XmlTextReader(new StringReader(xmlstr)))
            {
                return (T)xmlSerializer.Deserialize(reader);
                //return (T)XmlSerializer.d
            }
        }
    }

  
    public class WorkItemEventArgs : EventArgs
    {
        public WorkItemEventArgs()
        {

        }
        public WorkItemEventArgs(WorkItem workitem)
        {
            this.workItem = workitem;
        }
        private WorkItem workItem;

        public WorkItem WorkItem
        {
            get { return workItem; }
            set { workItem = value; }
        }
        
    }
   
    public enum WorkItemState
	{
      /// <summary>
      ///   Not assigned to a <see cref="WorkQueue"/>.
      /// </summary>
      Created = 0,

      /// <summary>
      ///   Waiting for a <see cref="Thread"/> to execute on.
      /// </summary>
      Scheduled,

      /// <summary>
      ///   Waiting for another <see cref="WorkItem"/> to complete, so it can run concurrently.
      /// </summary>
      Queued,

      /// <summary>
      ///   Executing on a <see cref="Thread"/>.
      /// </summary>
      Running,

      /// <summary>
      ///   Recovering from a thrown <see cref="Exception"/>.
      /// </summary>
      Failing,

      /// <summary>
      ///   Finished executing.
      /// </summary>
      Completed
	}
    public interface IWorkItem
    {
        void Perform( );
    }
    public abstract class WorkItem : IWorkItem
    {
        private RequestMessage request;

        public RequestMessage Request
        {
            get { return request; }
            set { request = value; }
        }
        private ResponseMessage response;

        public ResponseMessage Response
        {
            get { return response; }
            set { response = value; }
        }
        private int tag;

        public int Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        private WorkItemState state;
        private Exception ex;

        public Exception Ex
        {
            get { return ex; }
            set { ex = value; }
        }
        public WorkItemState State
        {
            get { return state; }
            set { state = value; }
        }
        #region IWorkItem Members

        public abstract void Perform( );


        #endregion


    }
    public class ThreadHelper
    {
        public ThreadHelper()
        {
            worklist = new List<WorkItem>();
        }
        private List<WorkItem> worklist;
        //public event EventHandler<ProcessEventArgs> InvokingService;
        //public event EventHandler<ResponseEventArgs> InvokeCompleted;
        //public event EventHandler<ResponseErrorEventArgs> ExecuteFailure;

        public event EventHandler<WorkItemEventArgs> WorkItemCompleted;
        public event EventHandler<WorkItemEventArgs> WorkItemFailed;
        public event EventHandler AllWorkItemCompleted;
      
        private bool runing;

        public bool Runing
        {
            get { return runing; }
            set { runing = value; }
        }
        private bool isCancel;

        public bool IsCancel
        {
            get { return isCancel; }
            set { isCancel = value; }
        }
        private bool isCompleted;


        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }
        
        public void AddWorkItem(WorkItem workitem)
        {
            lock (worklist)
            {
                worklist.Add(workitem);
            }
            workitem.State = WorkItemState.Running;
            
            ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork),workitem);
        }
        public void DoWork(object workitem)
        {
            WorkItem work = workitem as WorkItem;
            try
            {
                work.Perform();
                work.State = WorkItemState.Completed;
                if (this.WorkItemCompleted != null)
                {
                    this.WorkItemCompleted(this, new WorkItemEventArgs(work));
                }
            }
            catch (Exception ex)
            {
                work.State = WorkItemState.Failing;
                work.Ex = ex;
                if (this.WorkItemFailed != null)
                {
                    this.WorkItemFailed(this, new WorkItemEventArgs(work));
                }
            }
            finally
            {
                lock (worklist)
                {
                    worklist.Remove(workitem as WorkItem);
                }
                if (worklist.Count == 0)
                {
                    if (this.AllWorkItemCompleted != null)
                    {
                        this.AllWorkItemCompleted(this, new EventArgs());
                    }
                }

            }
        }

        public static ResponseMessage Execute(RequestMessage requestMessage)
        {
            try
            {
                string resstring = ServiceFactory.Create().callBackEnd(requestMessage.RequestType.ToString(), requestMessage.MessageType.ToString(), requestMessage.RequestMethod.ToString(), requestMessage.XmlString);
                return new ResponseMessage(resstring);
            }
            catch (Exception e)
            {
                string errorstring=e.Message;
                return new ResponseMessage(string.Format("<Message><Body><Error>{0}</Error></Body></Message>",errorstring));
            }
        }
        //public void DoAction()
        //{
         
        //    Thread doThread = new Thread(new ThreadStart(request));
        //    doThread.Start();
        //}
       
        //private void request()
        //{
        //    //invoke wms web service;
        //    Thread.Sleep(5000);
        //    this.isCompleted = true;
        //    this.IsCancel = true;
        //    if (this.InvokeCompleted != null)
        //    {
        //        ResponseEventArgs args=new ResponseEventArgs();
        //        InvokeCompleted(this, args);
        //    }

        //}
       
    }

    public class ServiceFactory
    {
        private static InfoWms.Api.WmsWebService _service = null;
        public static InfoWms.Api.WmsWebService Create()
        {
            if (_service == null)
            {
                if (Global.Parameters.ContainsKey("url"))
                {
                    string url = (string)Global.Parameters["url"];
                    _service = new RFDeviceAPP.InfoWms.Api.WmsWebService(url);
                }
                else
                    _service = new RFDeviceAPP.InfoWms.Api.WmsWebService();
                _service.Timeout = 900000;
            }
            return _service;
        }
    }
    public class RequestWorkItem : WorkItem
    {
        InfoWms.Api.WmsWebService _service = null;
        public RequestWorkItem(RequestMessage requestmessage,int tag):this()
        {
            this.Request=requestmessage;
            this.Tag = tag;
            
        }
        public RequestWorkItem()
        {
            _service = ServiceFactory.Create();
            _service.Timeout = 900000;
        }
        public override void Perform()
        {
           string response= _service.callBackEnd(this.Request.RequestType.ToString(), this.Request.MessageType.ToString(), this.Request.RequestMethod.ToString(), this.Request.XmlString);
           this.Response = new ResponseMessage(response);
        }
    }

    public class MyWorkItem : WorkItem
    {
        public MyWorkItem(int tag)
        {
            this.Tag = tag;

        }
        public override void Perform()
        {
            for (int i = 0; i <= 10; i++)
            {
                System.Diagnostics.Debug.WriteLine(Thread.CurrentThread.Name + " ==== " + i);
                
            }
            Thread.Sleep(2000);
        }
    }
}
