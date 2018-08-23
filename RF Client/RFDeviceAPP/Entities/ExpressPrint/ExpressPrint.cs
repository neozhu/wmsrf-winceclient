using System;

using System.Collections.Generic;
using System.Text;

namespace RFDeviceAPP.Entities.ExpressPrint
{
    public partial class ExpressPrint
    {

        private ExpressPrintHeader ExpressPrintHeaderField;

        public ExpressPrint()
        {
            this.ExpressPrintHeaderField = new ExpressPrintHeader();
        }

        public ExpressPrintHeader ExpressPrintHeader
        {
            get
            {
                return this.ExpressPrintHeaderField;
            }
            set
            {
                this.ExpressPrintHeaderField = value;
            }
        }
    }

    public partial class ExpressPrintHeader
    {
        private string orderKeyField;

        private string typeField;

        private string qtyField;

        public string OrderKey
        {
            get
            {
                return this.orderKeyField;
            }
            set
            {
                this.orderKeyField = value;
            }
        }

        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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
    }
}
