// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>InfoWms.API</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFPA01.Request
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

        public static Utility CreateById(string Id)
        {
            Utility data = new Utility();
            data.UtilityHeader.id = Id;
            return data;
        }

        private UtilityHeader utilityHeaderField;

        public UtilityHeader UtilityHeader
        {
            get
            {
                if ((this.utilityHeaderField == null))
                {
                    this.utilityHeaderField = new UtilityHeader();
                }
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

        private string procNameField;

        private string sendDelimiterField;

        private string ptcidField;

        private string useridField;

        private string taskIdField;

        private string databasenameField;

        private string appflagField;

        private string recordTypeField;

        private string serverField;

        private string storerkeyField;

        private string lotField;

        private string skuField;

        private string idField;

        private string fromlocField;

        private string qtyField;

        private string uomField;

        private string packkeyField;

        private string refnumField;

        private string transactionkeyField;

        public UtilityHeader()
        {
            this.procNameField = "NSPRFPA01";
            this.sendDelimiterField = "`";
            this.taskIdField = "0";
            this.storerkeyField = "";
            this.lotField = "";
            this.skuField = "";
            this.fromlocField = "";
            this.qtyField = "0";
            this.uomField = "EA";
            this.packkeyField = "STD";
            this.refnumField = "";
            this.transactionkeyField = "";
        }

        public string ProcName
        {
            get
            {
                return this.procNameField;
            }
            set
            {
                this.procNameField = value;
            }
        }

        public string sendDelimiter
        {
            get
            {
                return this.sendDelimiterField;
            }
            set
            {
                this.sendDelimiterField = value;
            }
        }

        public string ptcid
        {
            get
            {
                return this.ptcidField;
            }
            set
            {
                this.ptcidField = value;
            }
        }

        public string userid
        {
            get
            {
                return this.useridField;
            }
            set
            {
                this.useridField = value;
            }
        }

        public string taskId
        {
            get
            {
                return this.taskIdField;
            }
            set
            {
                this.taskIdField = value;
            }
        }

        public string databasename
        {
            get
            {
                return this.databasenameField;
            }
            set
            {
                this.databasenameField = value;
            }
        }

        public string appflag
        {
            get
            {
                return this.appflagField;
            }
            set
            {
                this.appflagField = value;
            }
        }

        public string recordType
        {
            get
            {
                return this.recordTypeField;
            }
            set
            {
                this.recordTypeField = value;
            }
        }

        public string server
        {
            get
            {
                return this.serverField;
            }
            set
            {
                this.serverField = value;
            }
        }

        public string storerkey
        {
            get
            {
                return this.storerkeyField;
            }
            set
            {
                this.storerkeyField = value;
            }
        }

        public string lot
        {
            get
            {
                return this.lotField;
            }
            set
            {
                this.lotField = value;
            }
        }

        public string sku
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

        public string id
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

        public string fromloc
        {
            get
            {
                return this.fromlocField;
            }
            set
            {
                this.fromlocField = value;
            }
        }

        public string qty
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

        public string uom
        {
            get
            {
                return this.uomField;
            }
            set
            {
                this.uomField = value;
            }
        }

        public string packkey
        {
            get
            {
                return this.packkeyField;
            }
            set
            {
                this.packkeyField = value;
            }
        }

        public string refnum
        {
            get
            {
                return this.refnumField;
            }
            set
            {
                this.refnumField = value;
            }
        }

        public string transactionkey
        {
            get
            {
                return this.transactionkeyField;
            }
            set
            {
                this.transactionkeyField = value;
            }
        }
    }
}
