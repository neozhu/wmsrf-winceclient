// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFRL02.Request</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFRL02.Request
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

        private string movableUnitField;

        private string caseidField;

        private string storerField;

        private string lotnumField;

        private string skuField;

        private string descField;

        private string fromtagField;

        private string fromlocField;

        private string totagField;

        private string tolocField;

        private string toqtyField;

        private string uomField;

        private string packkeyField;

        private string refnumField;

        private string lasttoidField;

        public UtilityHeader()
        {
            this.procNameField = "NSPRFRL02";
            this.sendDelimiterField = "`";
            this.ptcidField = "";
            this.useridField = "";
            this.taskIdField = "";
            this.databasenameField = "";
            this.appflagField = "";
            this.recordTypeField = "";
            this.serverField = "";
            this.movableUnitField = "";
            this.caseidField = "";
            this.storerField = "";
            this.lotnumField = "";
            this.skuField = "";
            this.descField = "";
            this.fromtagField = "";
            this.fromlocField = "";
            this.totagField = "";
            this.tolocField = "";
            this.toqtyField = "";
            this.uomField = "";
            this.packkeyField = "";
            this.refnumField = "";
            this.lasttoidField = "";
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

        public string MovableUnit
        {
            get
            {
                return this.movableUnitField;
            }
            set
            {
                this.movableUnitField = value;
            }
        }

        public string caseid
        {
            get
            {
                return this.caseidField;
            }
            set
            {
                this.caseidField = value;
            }
        }

        public string storer
        {
            get
            {
                return this.storerField;
            }
            set
            {
                this.storerField = value;
            }
        }

        public string lotnum
        {
            get
            {
                return this.lotnumField;
            }
            set
            {
                this.lotnumField = value;
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

        public string desc
        {
            get
            {
                return this.descField;
            }
            set
            {
                this.descField = value;
            }
        }

        public string fromtag
        {
            get
            {
                return this.fromtagField;
            }
            set
            {
                this.fromtagField = value;
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

        public string totag
        {
            get
            {
                return this.totagField;
            }
            set
            {
                this.totagField = value;
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

        public string toqty
        {
            get
            {
                return this.toqtyField;
            }
            set
            {
                this.toqtyField = value;
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


        public string lasttoid
        {
            get 
            { 
                return lasttoidField; 
            }
            set 
            { 
                lasttoidField = value; 
            }
        }

    }
}
