// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFFLOP01.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFFLOP01.Response
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

        private string tot_linesField;

        private string snumsperscanField;

        private string oPRTYPEField;

        private string skuField;

        private string visWgtField;

        private string pickDetailKeyField;

        private string fromIdField;

        private string orderLineNumberField;

        private string l_totPKlinesField;

        private string curPKLineField;

        private string rmainPKLineField;

        private string recNumField;

        private string processtypeField;

        private string tranTypeField;

        private string itrnKeyField;

        private string lotField;

        private string actionField;

        private string proField;

        private string prolinenumberField;

        private string locField;

        private string errmsgField;

        private string rectypeField;

        private string rectotalField;

        private string dateFormateField;

        public string Tot_lines
        {
            get
            {
                return this.tot_linesField;
            }
            set
            {
                this.tot_linesField = value;
            }
        }

        public string snumsperscan
        {
            get
            {
                return this.snumsperscanField;
            }
            set
            {
                this.snumsperscanField = value;
            }
        }

        public string OPRTYPE
        {
            get
            {
                return this.oPRTYPEField;
            }
            set
            {
                this.oPRTYPEField = value;
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

        public string VisWgt
        {
            get
            {
                return this.visWgtField;
            }
            set
            {
                this.visWgtField = value;
            }
        }

        public string PickDetailKey
        {
            get
            {
                return this.pickDetailKeyField;
            }
            set
            {
                this.pickDetailKeyField = value;
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

        public string OrderLineNumber
        {
            get
            {
                return this.orderLineNumberField;
            }
            set
            {
                this.orderLineNumberField = value;
            }
        }

        public string l_totPKlines
        {
            get
            {
                return this.l_totPKlinesField;
            }
            set
            {
                this.l_totPKlinesField = value;
            }
        }

        public string curPKLine
        {
            get
            {
                return this.curPKLineField;
            }
            set
            {
                this.curPKLineField = value;
            }
        }

        public string RmainPKLine
        {
            get
            {
                return this.rmainPKLineField;
            }
            set
            {
                this.rmainPKLineField = value;
            }
        }

        public string RecNum
        {
            get
            {
                return this.recNumField;
            }
            set
            {
                this.recNumField = value;
            }
        }

        public string processtype
        {
            get
            {
                return this.processtypeField;
            }
            set
            {
                this.processtypeField = value;
            }
        }

        public string TranType
        {
            get
            {
                return this.tranTypeField;
            }
            set
            {
                this.tranTypeField = value;
            }
        }

        public string ItrnKey
        {
            get
            {
                return this.itrnKeyField;
            }
            set
            {
                this.itrnKeyField = value;
            }
        }

        public string Lot
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

        public string action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        public string pro
        {
            get
            {
                return this.proField;
            }
            set
            {
                this.proField = value;
            }
        }

        public string prolinenumber
        {
            get
            {
                return this.prolinenumberField;
            }
            set
            {
                this.prolinenumberField = value;
            }
        }

        public string Loc
        {
            get
            {
                return this.locField;
            }
            set
            {
                this.locField = value;
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