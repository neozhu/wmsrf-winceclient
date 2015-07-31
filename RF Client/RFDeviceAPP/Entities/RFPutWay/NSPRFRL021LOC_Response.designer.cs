// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>InfoWms.API</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFRL021LOC.Response
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

        private string DropIDField;

        private string DEFAULTTOLOCField;

       
        private string errmsgField;


        private string rectypeField;

        private string rectotalField;

        private string dateFormateField;
        

        public string DropID
        {
            get
            {
                return this.DropIDField;
            }
            set
            {
                this.DropIDField = value;
            }
        }

        public string DEFAULTTOLOC
        {
            get
            {
                return this.DEFAULTTOLOCField;
            }
            set
            {
                this.DEFAULTTOLOCField = value;
            }
        }

        
        public string errmsg
        {
            get { return errmsgField; }
            set { errmsgField = value; }
        }
        public string rectype
        {
            get { return rectypeField; }
            set { rectypeField = value; }
        }
        public string rectotal
        {
            get { return rectotalField; }
            set { rectotalField = value; }
        }
        public string dateFormate
        {
            get { return dateFormateField; }
            set { dateFormateField = value; }
        }
    }
}
