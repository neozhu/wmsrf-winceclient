using System;

using System.Collections.Generic;
using System.Text;

namespace RFDeviceAPP.Entities.RTRSKU
{
    public partial class RTRSku
    {

        public static RTRSku CreateINS(string receiptkey, string sku)
        {
            RTRSku rtrsku = new RTRSku();
            rtrsku.RTRSkuHeader.ReceiptKey = receiptkey;
            rtrsku.RTRSkuHeader.Sku = sku;
            return rtrsku;
        }
        private RTRSkuHeader RTRSkuHeaderField;

        public RTRSku()
        {
            this.RTRSkuHeaderField = new RTRSkuHeader();
        }

        public RTRSkuHeader RTRSkuHeader
        {
            get
            {
                return this.RTRSkuHeaderField;
            }
            set
            {
                this.RTRSkuHeaderField = value;
            }
        }
    }

    public partial class RTRSkuHeader
    {
        private string receiptKeyField;

        private string skuTypeField;

        private string inqcqtyField;

        private string serviceNameField;

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

        public string Sku
        {
            get
            {
                return this.skuTypeField;
            }
            set
            {
                this.skuTypeField = value;
            }
        }

        public string InQCQty
        {
            get
            {
                return this.inqcqtyField;
            }
            set
            {
                this.inqcqtyField = value;
            }
        }

        public string ServiceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }
    }
}
