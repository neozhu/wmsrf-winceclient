// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFTM01.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFTM01.Response
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

        private string taskDetailKeyField;

        private string storerKeyField;

        private string skuField;

        private string fromLocField;

        private string fromIdField;

        private string toLocField;

        private string toIdField;

        private string lotField;

        private string qtyField;

        private string caseIDField;

        private string packKeyField;

        private string uOMField;

        private string message01Field;

        private string message02Field;

        private string message03Field;

        private string descField;

        private string fromchkdigitField;

        private string tochkdigitField;

        private string posverMethod1Field;

        private string posverMethod2Field;

        private string taskkeyField;

        private string taskTypeField;

        private string subtaskField;

        private string assignmentkeyField;

        private string laborflagField;

        private string printflagField;

        private string cartonGroupField;

        private string cartonTypeField;

        private string doReplenishField;

        private string qtyflagField;
        //idqty��locqty,theoryidqty, theorylocqty
        private string idqtyField;
        private string locqtyField;
        private string theoryidqtyField;
        private string theorylocqtyField;

        private string msg01Field;
        private string msg02Field;
        private string msg03Field;

        private string ExternOrderKeyField;
        private string ExternalOrderKey2Field;
        private string ODSUSR3Field;
        private string LOTTABLE26Field;

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

        public string ToLoc
        {
            get
            {
                return this.toLocField;
            }
            set
            {
                this.toLocField = value;
            }
        }

        public string ToId
        {
            get
            {
                return this.toIdField;
            }
            set
            {
                this.toIdField = value;
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

        public string CaseID
        {
            get
            {
                return this.caseIDField;
            }
            set
            {
                this.caseIDField = value;
            }
        }

        public string PackKey
        {
            get
            {
                return this.packKeyField;
            }
            set
            {
                this.packKeyField = value;
            }
        }

        public string UOM
        {
            get
            {
                return this.uOMField;
            }
            set
            {
                this.uOMField = value;
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

        public string fromchkdigit
        {
            get
            {
                return this.fromchkdigitField;
            }
            set
            {
                this.fromchkdigitField = value;
            }
        }

        public string tochkdigit
        {
            get
            {
                return this.tochkdigitField;
            }
            set
            {
                this.tochkdigitField = value;
            }
        }

        public string posverMethod1
        {
            get
            {
                return this.posverMethod1Field;
            }
            set
            {
                this.posverMethod1Field = value;
            }
        }

        public string posverMethod2
        {
            get
            {
                return this.posverMethod2Field;
            }
            set
            {
                this.posverMethod2Field = value;
            }
        }

        public string taskkey
        {
            get
            {
                return this.taskkeyField;
            }
            set
            {
                this.taskkeyField = value;
            }
        }

        public string TaskType
        {
            get
            {
                return this.taskTypeField;
            }
            set
            {
                this.taskTypeField = value;
            }
        }

        public string subtask
        {
            get
            {
                return this.subtaskField;
            }
            set
            {
                this.subtaskField = value;
            }
        }

        public string assignmentkey
        {
            get
            {
                return this.assignmentkeyField;
            }
            set
            {
                this.assignmentkeyField = value;
            }
        }

        public string laborflag
        {
            get
            {
                return this.laborflagField;
            }
            set
            {
                this.laborflagField = value;
            }
        }

        public string printflag
        {
            get
            {
                return this.printflagField;
            }
            set
            {
                this.printflagField = value;
            }
        }

        public string CartonGroup
        {
            get
            {
                return this.cartonGroupField;
            }
            set
            {
                this.cartonGroupField = value;
            }
        }

        public string CartonType
        {
            get
            {
                return this.cartonTypeField;
            }
            set
            {
                this.cartonTypeField = value;
            }
        }

        public string doReplenish
        {
            get
            {
                return this.doReplenishField;
            }
            set
            {
                this.doReplenishField = value;
            }
        }

        public string qtyflag
        {
            get
            {
                return this.qtyflagField;
            }
            set
            {
                this.qtyflagField = value;
            }
        }
        //idqty��locqty,theoryidqty, theorylocqty
        public string idqty
        {
            get
            {
                return this.idqtyField;
            }
            set
            {
                this.idqtyField = value;
            }
        }
        public string locqty
        {
            get
            {
                return this.locqtyField;
            }
            set
            {
                this.locqtyField = value;
            }
        }
        public string theoryidqty
        {
            get
            {
                return this.theoryidqtyField;
            }
            set
            {
                this.theoryidqtyField = value;
            }
        }
        public string theorylocqty
        {
            get
            {
                return this.theorylocqtyField;
            }
            set
            {
                this.theorylocqtyField = value;
            }
        }
        public string msg01
        {
            get
            {
                return this.msg01Field;
            }
            set
            {
                this.msg01Field = value;
            }
        }
        public string msg02
        {
            get
            {
                return this.msg02Field;
            }
            set
            {
                this.msg02Field = value;
            }
        }
        public string msg03
        {
            get
            {
                return this.msg03Field;
            }
            set
            {
                this.msg03Field = value;
            }
        }

        public string ExternOrderKey
        {
            get
            {
                return this.ExternOrderKeyField;
            }
            set
            {
                this.ExternOrderKeyField = value;
            }
        }


        public string ExternalOrderKey2
        {
            get
            {
                return this.ExternalOrderKey2Field;
            }
            set
            {
                this.ExternalOrderKey2Field = value;
            }
        }

        public string ODSUSR3
        {
            get
            {
                return this.ODSUSR3Field;
            }
            set
            {
                this.ODSUSR3Field = value;
            }
        }
        public string LOTTABLE26
        {
            get
            {
                return this.LOTTABLE26Field;
            }
            set
            {
                this.LOTTABLE26Field = value;
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
