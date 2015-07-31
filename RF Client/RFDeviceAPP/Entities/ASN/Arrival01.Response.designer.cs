// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.Arrival01.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.Arrival01.Response
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


   

    public partial class AdvancedShipNotice
    {

        private AdvancedShipNoticeHeader advancedShipNoticeHeaderField;

        public AdvancedShipNotice()
        {
            this.advancedShipNoticeHeaderField = new AdvancedShipNoticeHeader();
        }

        public AdvancedShipNoticeHeader AdvancedShipNoticeHeader
        {
            get
            {
                return this.advancedShipNoticeHeaderField;
            }
            set
            {
                this.advancedShipNoticeHeaderField = value;
            }
        }
    }

    public partial class AdvancedShipNoticeHeader
    {

        private string serialKeyField;

        private string receiptKeyField;

        private string externReceiptKeyField;

        private string storerKeyField;

        private string receiptDateField;

        private string openQtyField;

        private string expectedReceiptDateField;

        private string closedDateField;

        private string rEFERENCEACCOUNTINGENTITYField;

        public string SerialKey
        {
            get
            {
                return this.serialKeyField;
            }
            set
            {
                this.serialKeyField = value;
            }
        }

        public string ReceiptKey
        {
            get
            {
                return this.receiptKeyField;
            }
            set
            {
                this.receiptKeyField = value;
            }
        }

        public string ExternReceiptKey
        {
            get
            {
                return this.externReceiptKeyField;
            }
            set
            {
                this.externReceiptKeyField = value;
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

        public string ReceiptDate
        {
            get
            {
                return this.receiptDateField;
            }
            set
            {
                this.receiptDateField = value;
            }
        }

        public string OpenQty
        {
            get
            {
                return this.openQtyField;
            }
            set
            {
                this.openQtyField = value;
            }
        }

        public string ExpectedReceiptDate
        {
            get
            {
                return this.expectedReceiptDateField;
            }
            set
            {
                this.expectedReceiptDateField = value;
            }
        }

        public string ClosedDate
        {
            get
            {
                return this.closedDateField;
            }
            set
            {
                this.closedDateField = value;
            }
        }

        public string REFERENCEACCOUNTINGENTITY
        {
            get
            {
                return this.rEFERENCEACCOUNTINGENTITYField;
            }
            set
            {
                this.rEFERENCEACCOUNTINGENTITYField = value;
            }
        }
    }
}
