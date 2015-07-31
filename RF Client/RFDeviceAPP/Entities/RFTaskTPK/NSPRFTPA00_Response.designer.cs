// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFTPA00.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFTPA00.Response
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    

    public partial class Utility
    {

         private List<UtilityHeader> utilityHeaderField;

         public Utility()
        {
            this.utilityHeaderField = new List<UtilityHeader>();
        }

        //[System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        //[System.Xml.Serialization.XmlArrayItemAttribute("AdvancedShipNoticeHeader", IsNullable = false)]
         [System.Xml.Serialization.XmlElement("UtilityHeader")]
         public List<UtilityHeader> UtilityHeaders
        {
            get
            {
                return this.utilityHeaderField;
            }
            set
            {
                this.utilityHeaderField = value;
            }
        }
    }

    public partial class UtilityHeader
    {

        private string taskDetailKeyField;

        private string storerKeyField;

        private string skuField;

        private string fromLocField;

        private string fromIdField;

        private string message01Field;

        private string message02Field;

        private string message03Field;

        private string eDITFROMLOCField;

        private string eDITFROMIDField;

        private string descrField;

        private string qtyField;

        private string priorityField;

        private string errmsgField;

        private string rectypeField;

        private string rectotalField;

        private string dateFormateField;

        public string TaskDetailKey
        {
            get
            {
                return this.taskDetailKeyField;
            }
            set
            {
                this.taskDetailKeyField = value;
            }
        }

        public string StorerKey
        {
            get
            {
                return this.storerKeyField;
            }
            set
            {
                this.storerKeyField = value;
            }
        }

        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        public string FromLoc
        {
            get
            {
                return this.fromLocField;
            }
            set
            {
                this.fromLocField = value;
            }
        }

        public string FromId
        {
            get
            {
                return this.fromIdField;
            }
            set
            {
                this.fromIdField = value;
            }
        }

        public string Message01
        {
            get
            {
                return this.message01Field;
            }
            set
            {
                this.message01Field = value;
            }
        }

        public string Message02
        {
            get
            {
                return this.message02Field;
            }
            set
            {
                this.message02Field = value;
            }
        }

        public string Message03
        {
            get
            {
                return this.message03Field;
            }
            set
            {
                this.message03Field = value;
            }
        }

        public string EDITFROMLOC
        {
            get
            {
                return this.eDITFROMLOCField;
            }
            set
            {
                this.eDITFROMLOCField = value;
            }
        }

        public string EDITFROMID
        {
            get
            {
                return this.eDITFROMIDField;
            }
            set
            {
                this.eDITFROMIDField = value;
            }
        }

        public string Descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }

        public string Qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }

        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        public string errmsg
        {
            get
            {
                return this.errmsgField;
            }
            set
            {
                this.errmsgField = value;
            }
        }

        public string rectype
        {
            get
            {
                return this.rectypeField;
            }
            set
            {
                this.rectypeField = value;
            }
        }

        public string rectotal
        {
            get
            {
                return this.rectotalField;
            }
            set
            {
                this.rectotalField = value;
            }
        }

        public string dateFormate
        {
            get
            {
                return this.dateFormateField;
            }
            set
            {
                this.dateFormateField = value;
            }
        }
    }
}