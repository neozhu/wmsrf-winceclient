// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFTM01.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFINSTRUCTION01X.Response
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

        private List<UtilityHeader> utilityHeaderFields;
        public Utility()
        {
            utilityHeaderFields = new List<UtilityHeader>();
        }
        [System.Xml.Serialization.XmlElement("UtilityHeader")]
        public List<UtilityHeader> UtilityHeaders
        {
            get
            {

                return this.utilityHeaderFields;
            }
            set
            {
                this.utilityHeaderFields = value;
            }
        }
    }

    public partial class UtilityHeader
    {

        private string sourcetypeField;

        private string sourcekeyField;

        private string lable1Field;

        private string lable2Field;

        private string lable3Field;

        private string lable4Field;

        private string lable5Field;

        private string isShow1Field;

        private string isShow2Field;

        private string isShow3Field;

        private string isShow4Field;

        private string isShow5Field;

        private string sourceLineNo1Field;

        private string sourceLineNo2Field;

        private string sourceLineNo3Field;

        private string sourceLineNo4Field;

        private string sourceLineNo5Field;

        private string statusField;

        private string errmsgField;

        private string rectypeField;

        private string rectotalField;

        private string isendField;

        public string sourcekey
        {
            get
            {
                return this.sourcetypeField;
            }
            set
            {
                this.sourcetypeField = value;
            }
        }

        public string type
        {
            get
            {
                return this.sourcetypeField;
            }
            set
            {
                this.sourcetypeField = value;
            }
        }

        public string LABLE1
        {
            get
            {
                return this.lable1Field;
            }
            set
            {
                this.lable1Field = value;
            }
        }

        public string LABLE2
        {
            get
            {
                return this.lable2Field;
            }
            set
            {
                this.lable2Field = value;
            }
        }

        public string LABLE3
        {
            get
            {
                return this.lable3Field;
            }
            set
            {
                this.lable3Field = value;
            }
        }

        public string LABLE4
        {
            get
            {
                return this.lable4Field;
            }
            set
            {
                this.lable4Field = value;
            }
        }

        public string LABLE5
        {
            get
            {
                return this.lable5Field;
            }
            set
            {
                this.lable5Field = value;
            }
        }

        public string ISSHOW1
        {
            get
            {
                return this.isShow1Field;
            }
            set
            {
                this.isShow1Field = value;
            }
        }

        public string ISSHOW2
        {
            get
            {
                return this.isShow2Field;
            }
            set
            {
                this.isShow2Field = value;
            }
        }

        public string ISSHOW3
        {
            get
            {
                return this.isShow3Field;
            }
            set
            {
                this.isShow3Field = value;
            }
        }

        public string ISSHOW4
        {
            get
            {
                return this.isShow4Field;
            }
            set
            {
                this.isShow4Field = value;
            }
        }

        public string ISSHOW5
        {
            get
            {
                return this.isShow5Field;
            }
            set
            {
                this.isShow5Field = value;
            }
        }
        
        public string SOURCELINENO1
        {
            get
            {
                return this.sourceLineNo1Field;
            }
            set
            {
                this.sourceLineNo1Field = value;
            }
        }

        public string SOURCELINENO2
        {
            get
            {
                return this.sourceLineNo2Field;
            }
            set
            {
                this.sourceLineNo2Field = value;
            }
        }

        public string SOURCELINENO3
        {
            get
            {
                return this.sourceLineNo3Field;
            }
            set
            {
                this.sourceLineNo3Field = value;
            }
        }

        public string SOURCELINENO4
        {
            get
            {
                return this.sourceLineNo4Field;
            }
            set
            {
                this.sourceLineNo4Field = value;
            }
        }

        public string SOURCELINENO5
        {
            get
            {
                return this.sourceLineNo5Field;
            }
            set
            {
                this.sourceLineNo5Field = value;
            }
        }

        public string Status
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

        public string isend {
            get
            {
                return this.isendField;
            }
            set
            {
                this.isendField = value;
            }
        }
    }

}
