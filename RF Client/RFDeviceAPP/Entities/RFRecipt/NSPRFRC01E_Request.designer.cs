// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>RFDeviceAPP.Common.NSPRFRC01E.Response</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>True</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace RFDeviceAPP.Common.NSPRFRC01E.Request
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
        public static Utility CreateBy(string drid, string storerkey,string sku, string username)
        {
            Utility item = new Utility();
            item.UtilityHeader.drid = drid;
            item.UtilityHeader.id = drid;
            item.UtilityHeader.storerkey = storerkey;
            item.UtilityHeader.userid = username;
            item.UtilityHeader.sku = sku;
            return item;
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

        private string receiptkeyField;

        private string storerkeyField;

        private string lotField;

        private string prokeyField;

        private string skuField;

        private string pokeyField;

        private string qtyField;

        private string uomField;

        private string packkeyField;

        private string locField;

        private string idField;

        private string holdField;

        private string isrpField;

        private string dridField;

        private string lottable01Field;

        private string lottable02Field;

        private string lottable03Field;

        private string lottable04Field;

        private string lottable05Field;

        private string lottable06Field;

        private string lottable07Field;

        private string lottable08Field;

        private string lottable09Field;

        private string lottable10Field;

        private string other1Field;

        private string other2Field;

        private string other3Field;

        private string printerIDField;

        private string counterField;

        private string wgtField;

        private string reasoncodeField;

        private string rejectQtyField;

        private string packingSlipQtyField;

        private string lottable11Field;

        private string lottable12Field;

        private string transactionkeyField;

        private string lottable13Field;

        private string lottable14Field;

        private string lottable15Field;

        private string lottable16Field;

        private string lottable17Field;

        private string lottable18Field;

        private string lottable19Field;

        private string lottable20Field;

        private string lottable21Field;

        private string lottable22Field;

        private string lottable23Field;

        private string lottable24Field;

        private string lottable25Field;

        private string lottable26Field;

        private string lottable27Field;

        private string lottable28Field;

        private string lottable29Field;

        private string lottable30Field;

        private string lottable31Field;

        private string lottable32Field;

        private string lottable33Field;

        private string lottable34Field;

        private string lottable35Field;

        private string lottable36Field;

        private string lottable37Field;

        private string lottable38Field;

        private string lottable39Field;

        private string lottable40Field;

        private string lottable41Field;

        private string lottable42Field;

        private string lottable43Field;

        private string lottable44Field;

        private string lottable45Field;

        private string lottable46Field;

        private string lottable47Field;

        public UtilityHeader()
        {
            this.procNameField = "NSPRFRC01E";
            this.sendDelimiterField = "`";
            this.ptcidField = "";
            this.useridField = "";
            this.taskIdField = "";
            this.databasenameField = "";
            this.appflagField = "";
            this.recordTypeField = "";
            this.serverField = "";
            this.receiptkeyField = "";
            this.storerkeyField = "";
            this.lotField = "";
            this.prokeyField = "PALBLDDONE";
            this.skuField = "";
            this.pokeyField = "NOPO";
            this.qtyField = "0";
            this.uomField = "EA";
            this.packkeyField = "STD";
            this.locField = "STAGE";
            this.idField = "";
            this.holdField = "";
            this.isrpField = "N";
            this.dridField = "";
            this.lottable01Field = "";
            this.lottable02Field = "";
            this.lottable03Field = "";
            this.lottable04Field = "";
            this.lottable05Field = "";
            this.lottable06Field = "";
            this.lottable07Field = "";
            this.lottable08Field = "";
            this.lottable09Field = "";
            this.lottable10Field = "";
            this.other1Field = "";
            this.other2Field = "";
            this.other3Field = "";
            this.printerIDField = "";
            this.counterField = "";
            this.wgtField = "";
            this.reasoncodeField = "";
            this.rejectQtyField = "";
            this.packingSlipQtyField = "";
            this.lottable11Field = "";
            this.lottable12Field = "";
            this.transactionkeyField = "";
            this.lottable13Field = "";
            this.lottable14Field = "";
            this.lottable15Field = "";
            this.lottable16Field = "";
            this.lottable17Field = "";
            this.lottable18Field = "";
            this.lottable19Field = "";
            this.lottable20Field = "";
            this.lottable21Field = "";
            this.lottable22Field = "";
            this.lottable23Field = "";
            this.lottable24Field = "";
            this.lottable25Field = "";
            this.lottable26Field = "";
            this.lottable27Field = "";
            this.lottable28Field = "";
            this.lottable29Field = "";
            this.lottable30Field = "";
            this.lottable31Field = "";
            this.lottable32Field = "";
            this.lottable33Field = "";
            this.lottable34Field = "";
            this.lottable35Field = "";
            this.lottable36Field = "";
            this.lottable37Field = "";
            this.lottable38Field = "";
            this.lottable39Field = "";
            this.lottable40Field = "";
            this.lottable41Field = "";
            this.lottable42Field = "";
            this.lottable43Field = "";
            this.lottable44Field = "";
            this.lottable45Field = "";
            this.lottable46Field = "";
            this.lottable47Field = "";
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

        public string receiptkey
        {
            get
            {
                return this.receiptkeyField;
            }
            set
            {
                this.receiptkeyField = value;
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

        public string prokey
        {
            get
            {
                return this.prokeyField;
            }
            set
            {
                this.prokeyField = value;
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

        public string pokey
        {
            get
            {
                return this.pokeyField;
            }
            set
            {
                this.pokeyField = value;
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

        public string loc
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

        public string hold
        {
            get
            {
                return this.holdField;
            }
            set
            {
                this.holdField = value;
            }
        }

        public string isrp
        {
            get
            {
                return this.isrpField;
            }
            set
            {
                this.isrpField = value;
            }
        }

        public string drid
        {
            get
            {
                return this.dridField;
            }
            set
            {
                this.dridField = value;
            }
        }

        public string lottable01
        {
            get
            {
                return this.lottable01Field;
            }
            set
            {
                this.lottable01Field = value;
            }
        }

        public string lottable02
        {
            get
            {
                return this.lottable02Field;
            }
            set
            {
                this.lottable02Field = value;
            }
        }

        public string lottable03
        {
            get
            {
                return this.lottable03Field;
            }
            set
            {
                this.lottable03Field = value;
            }
        }

        public string lottable04
        {
            get
            {
                return this.lottable04Field;
            }
            set
            {
                this.lottable04Field = value;
            }
        }

        public string lottable05
        {
            get
            {
                return this.lottable05Field;
            }
            set
            {
                this.lottable05Field = value;
            }
        }

        public string lottable06
        {
            get
            {
                return this.lottable06Field;
            }
            set
            {
                this.lottable06Field = value;
            }
        }

        public string lottable07
        {
            get
            {
                return this.lottable07Field;
            }
            set
            {
                this.lottable07Field = value;
            }
        }

        public string lottable08
        {
            get
            {
                return this.lottable08Field;
            }
            set
            {
                this.lottable08Field = value;
            }
        }

        public string lottable09
        {
            get
            {
                return this.lottable09Field;
            }
            set
            {
                this.lottable09Field = value;
            }
        }

        public string lottable10
        {
            get
            {
                return this.lottable10Field;
            }
            set
            {
                this.lottable10Field = value;
            }
        }

        public string other1
        {
            get
            {
                return this.other1Field;
            }
            set
            {
                this.other1Field = value;
            }
        }

        public string other2
        {
            get
            {
                return this.other2Field;
            }
            set
            {
                this.other2Field = value;
            }
        }

        public string other3
        {
            get
            {
                return this.other3Field;
            }
            set
            {
                this.other3Field = value;
            }
        }

        public string printerID
        {
            get
            {
                return this.printerIDField;
            }
            set
            {
                this.printerIDField = value;
            }
        }

        public string counter
        {
            get
            {
                return this.counterField;
            }
            set
            {
                this.counterField = value;
            }
        }

        public string wgt
        {
            get
            {
                return this.wgtField;
            }
            set
            {
                this.wgtField = value;
            }
        }

        public string reasoncode
        {
            get
            {
                return this.reasoncodeField;
            }
            set
            {
                this.reasoncodeField = value;
            }
        }

        public string RejectQty
        {
            get
            {
                return this.rejectQtyField;
            }
            set
            {
                this.rejectQtyField = value;
            }
        }

        public string PackingSlipQty
        {
            get
            {
                return this.packingSlipQtyField;
            }
            set
            {
                this.packingSlipQtyField = value;
            }
        }

        public string lottable11
        {
            get
            {
                return this.lottable11Field;
            }
            set
            {
                this.lottable11Field = value;
            }
        }

        public string lottable12
        {
            get
            {
                return this.lottable12Field;
            }
            set
            {
                this.lottable12Field = value;
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

        public string lottable13
        {
            get
            {
                return this.lottable13Field;
            }
            set
            {
                this.lottable13Field = value;
            }
        }

        public string lottable14
        {
            get
            {
                return this.lottable14Field;
            }
            set
            {
                this.lottable14Field = value;
            }
        }

        public string lottable15
        {
            get
            {
                return this.lottable15Field;
            }
            set
            {
                this.lottable15Field = value;
            }
        }

        public string lottable16
        {
            get
            {
                return this.lottable16Field;
            }
            set
            {
                this.lottable16Field = value;
            }
        }

        public string lottable17
        {
            get
            {
                return this.lottable17Field;
            }
            set
            {
                this.lottable17Field = value;
            }
        }

        public string lottable18
        {
            get
            {
                return this.lottable18Field;
            }
            set
            {
                this.lottable18Field = value;
            }
        }

        public string lottable19
        {
            get
            {
                return this.lottable19Field;
            }
            set
            {
                this.lottable19Field = value;
            }
        }

        public string lottable20
        {
            get
            {
                return this.lottable20Field;
            }
            set
            {
                this.lottable20Field = value;
            }
        }

        public string lottable21
        {
            get
            {
                return this.lottable21Field;
            }
            set
            {
                this.lottable21Field = value;
            }
        }

        public string lottable22
        {
            get
            {
                return this.lottable22Field;
            }
            set
            {
                this.lottable22Field = value;
            }
        }

        public string lottable23
        {
            get
            {
                return this.lottable23Field;
            }
            set
            {
                this.lottable23Field = value;
            }
        }

        public string lottable24
        {
            get
            {
                return this.lottable24Field;
            }
            set
            {
                this.lottable24Field = value;
            }
        }

        public string lottable25
        {
            get
            {
                return this.lottable25Field;
            }
            set
            {
                this.lottable25Field = value;
            }
        }

        public string lottable26
        {
            get
            {
                return this.lottable26Field;
            }
            set
            {
                this.lottable26Field = value;
            }
        }

        public string lottable27
        {
            get
            {
                return this.lottable27Field;
            }
            set
            {
                this.lottable27Field = value;
            }
        }

        public string lottable28
        {
            get
            {
                return this.lottable28Field;
            }
            set
            {
                this.lottable28Field = value;
            }
        }

        public string lottable29
        {
            get
            {
                return this.lottable29Field;
            }
            set
            {
                this.lottable29Field = value;
            }
        }

        public string lottable30
        {
            get
            {
                return this.lottable30Field;
            }
            set
            {
                this.lottable30Field = value;
            }
        }

        public string lottable31
        {
            get
            {
                return this.lottable31Field;
            }
            set
            {
                this.lottable31Field = value;
            }
        }

        public string lottable32
        {
            get
            {
                return this.lottable32Field;
            }
            set
            {
                this.lottable32Field = value;
            }
        }

        public string lottable33
        {
            get
            {
                return this.lottable33Field;
            }
            set
            {
                this.lottable33Field = value;
            }
        }

        public string lottable34
        {
            get
            {
                return this.lottable34Field;
            }
            set
            {
                this.lottable34Field = value;
            }
        }

        public string lottable35
        {
            get
            {
                return this.lottable35Field;
            }
            set
            {
                this.lottable35Field = value;
            }
        }

        public string lottable36
        {
            get
            {
                return this.lottable36Field;
            }
            set
            {
                this.lottable36Field = value;
            }
        }

        public string lottable37
        {
            get
            {
                return this.lottable37Field;
            }
            set
            {
                this.lottable37Field = value;
            }
        }

        public string lottable38
        {
            get
            {
                return this.lottable38Field;
            }
            set
            {
                this.lottable38Field = value;
            }
        }

        public string lottable39
        {
            get
            {
                return this.lottable39Field;
            }
            set
            {
                this.lottable39Field = value;
            }
        }

        public string lottable40
        {
            get
            {
                return this.lottable40Field;
            }
            set
            {
                this.lottable40Field = value;
            }
        }

        public string lottable41
        {
            get
            {
                return this.lottable41Field;
            }
            set
            {
                this.lottable41Field = value;
            }
        }

        public string lottable42
        {
            get
            {
                return this.lottable42Field;
            }
            set
            {
                this.lottable42Field = value;
            }
        }

        public string lottable43
        {
            get
            {
                return this.lottable43Field;
            }
            set
            {
                this.lottable43Field = value;
            }
        }

        public string lottable44
        {
            get
            {
                return this.lottable44Field;
            }
            set
            {
                this.lottable44Field = value;
            }
        }

        public string lottable45
        {
            get
            {
                return this.lottable45Field;
            }
            set
            {
                this.lottable45Field = value;
            }
        }

        public string lottable46
        {
            get
            {
                return this.lottable46Field;
            }
            set
            {
                this.lottable46Field = value;
            }
        }

        public string lottable47
        {
            get
            {
                return this.lottable47Field;
            }
            set
            {
                this.lottable47Field = value;
            }
        }
    }
}
