// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFP1A01.Request</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFRL01B1FL.Request
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
        public static Utility Create(string sku, string fromloc, string fromid, string toid, string qty, string actloc)
        {
            Utility data = new Utility();
            data.UtilityHeader.toid = toid;
            data.UtilityHeader.sku = sku;
            data.UtilityHeader.fromloc = fromloc;
            data.UtilityHeader.fromid = fromid;
            data.UtilityHeader.qty = qty;
            data.UtilityHeader.actloc = actloc;
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

        private string fromlocField;

        private string fromidField;

        private string tolocField;

        private string toidField;

        private string qtyField;

        private string uomField;

        private string packkeyField;

        private string refnumField;

        private string var1Field;

        private string var2Field;

        private string var3Field;

        private string actlocField;

        public UtilityHeader()
        {
            this.procNameField = "NSPRFRL01B1FL";
            this.sendDelimiterField = "`";
            this.ptcidField = "";
            this.useridField = "";
            this.taskIdField = "";
            this.databasenameField = "";
            this.appflagField = "";
            this.recordTypeField = "";
            this.serverField = "";
            this.storerkeyField = "";
            this.lotField = "";
            this.skuField = "";
            this.uomField = "EA";
            this.packkeyField = "STD";
            this.refnumField = "";
            this.var1Field = "";
            this.var2Field = "var2";
            this.var3Field = "var3";
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

        public string fromid
        {
            get
            {
                return this.fromidField;
            }
            set
            {
                this.fromidField = value;
            }
        }

        public string toloc
        {
            get
            {
                return this.tolocField;
            }
            set
            {
                this.tolocField = value;
            }
        }

        public string toid
        {
            get
            {
                return this.toidField;
            }
            set
            {
                this.toidField = value;
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

        public string var1
        {
            get
            {
                return this.var1Field;
            }
            set
            {
                this.var1Field = value;
            }
        }

        public string var2
        {
            get
            {
                return this.var2Field;
            }
            set
            {
                this.var2Field = value;
            }
        }

        public string var3
        {
            get
            {
                return this.var3Field;
            }
            set
            {
                this.var3Field = value;
            }
        }

        public string actloc
        {
            get
            {
                return this.actlocField;
            }
            set
            {
                this.actlocField = value;
            }
        }
    }
}