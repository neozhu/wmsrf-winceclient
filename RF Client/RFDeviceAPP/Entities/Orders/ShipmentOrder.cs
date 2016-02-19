using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;

namespace RFDeviceAPP.Common.Orders
{
    




    public partial class ShipmentOrder
    {
        public static ShipmentOrder CreateQCPOD(string orderkey, string pcuser)
        {
            ShipmentOrder order = new ShipmentOrder();
            order.ShipmentOrderHeader.OrderKey = orderkey;
            order.shipmentOrderHeaderField.PerformanceData03 = pcuser;
            return order;
        }
        public static ShipmentOrder CreateCheckPOD(string orderkey, string checkuser)
        {
            ShipmentOrder order = new ShipmentOrder();
            order.ShipmentOrderHeader.OrderKey = orderkey;
            order.shipmentOrderHeaderField.PerformanceData04 = checkuser;
            return order;
        }
        public static ShipmentOrder CreatePickPOD(string orderkey, string pickuser,string qty)
        {
            ShipmentOrder order = new ShipmentOrder();
            order.ShipmentOrderHeader.OrderKey = orderkey;
            order.shipmentOrderHeaderField.PerformanceData01 = pickuser;
            order.shipmentOrderHeaderField.PerformanceData17 = qty;
            return order;
        }

        public static ShipmentOrder CreateLabelkPOD(string orderkey, string labeluser, string qty1,string qty2)
        {
            ShipmentOrder order = new ShipmentOrder();
            order.ShipmentOrderHeader.OrderKey = orderkey;
            order.shipmentOrderHeaderField.PerformanceData02 = labeluser;
            order.shipmentOrderHeaderField.PerformanceData14 = qty1;

            order.shipmentOrderHeaderField.PerformanceData15 = qty2;
            return order;
        }

        public static ShipmentOrder CreateLoadPOD(string orderkey, string loaduser, string qty1, string qty2,string qty3)
        {
            ShipmentOrder order = new ShipmentOrder();
            order.ShipmentOrderHeader.OrderKey = orderkey;
            order.shipmentOrderHeaderField.PerformanceData05 = loaduser;
            order.shipmentOrderHeaderField.PerformanceData11 = qty1;
            order.shipmentOrderHeaderField.PerformanceData12 = qty2;
            order.shipmentOrderHeaderField.PerformanceData13 = qty3;
            return order;
        }

        public static ShipmentOrder CreatePOD(string orderkey)
        {
            ShipmentOrder order = new ShipmentOrder();
            ShipmentOrderHeader soh = new ShipmentOrderHeader();
            soh.OrderKey = orderkey;
            order.ShipmentOrderHeader = soh;
            return order;
        }


        private ShipmentOrderHeader shipmentOrderHeaderField;

        public ShipmentOrder()
        {
            this.shipmentOrderHeaderField = new ShipmentOrderHeader();
        }

        public ShipmentOrderHeader ShipmentOrderHeader
        {
            get
            {
                return this.shipmentOrderHeaderField;
            }
            set
            {
                this.shipmentOrderHeaderField = value;
            }
        }
    }

    public partial class ShipmentOrderHeader
    {

        private string orderKeyField;

        private string performanceData01Field;

        private string performanceData02Field;

        private string performanceData03Field;

        private string performanceData04Field;

        private string performanceData05Field;

        private string performanceData06Field;

        private string performanceData07Field;

        private string performanceData08Field;

        private string performanceData09Field;

        private string performanceData10Field;

        private string performanceData11Field;

        private string performanceData12Field;

        private string performanceData13Field;

        private string performanceData14Field;

        private string performanceData15Field;

        private string performanceData16Field;

        private string performanceData17Field;

        private string performanceData18Field;

        private string performanceData19Field;

        private string performanceData20Field;

        private string susr15Field;

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

        public string PerformanceData01
        {
            get
            {
                return this.performanceData01Field;
            }
            set
            {
                this.performanceData01Field = value;
            }
        }

        public string PerformanceData02
        {
            get
            {
                return this.performanceData02Field;
            }
            set
            {
                this.performanceData02Field = value;
            }
        }

        public string PerformanceData03
        {
            get
            {
                return this.performanceData03Field;
            }
            set
            {
                this.performanceData03Field = value;
            }
        }

        public string PerformanceData04
        {
            get
            {
                return this.performanceData04Field;
            }
            set
            {
                this.performanceData04Field = value;
            }
        }

        public string PerformanceData05
        {
            get
            {
                return this.performanceData05Field;
            }
            set
            {
                this.performanceData05Field = value;
            }
        }

        public string PerformanceData06
        {
            get
            {
                return this.performanceData06Field;
            }
            set
            {
                this.performanceData06Field = value;
            }
        }

        public string PerformanceData07
        {
            get
            {
                return this.performanceData07Field;
            }
            set
            {
                this.performanceData07Field = value;
            }
        }

        public string PerformanceData08
        {
            get
            {
                return this.performanceData08Field;
            }
            set
            {
                this.performanceData08Field = value;
            }
        }

        public string PerformanceData09
        {
            get
            {
                return this.performanceData09Field;
            }
            set
            {
                this.performanceData09Field = value;
            }
        }

        public string PerformanceData10
        {
            get
            {
                return this.performanceData10Field;
            }
            set
            {
                this.performanceData10Field = value;
            }
        }

        public string PerformanceData11
        {
            get
            {
                return this.performanceData11Field;
            }
            set
            {
                this.performanceData11Field = value;
            }
        }

        public string PerformanceData12
        {
            get
            {
                return this.performanceData12Field;
            }
            set
            {
                this.performanceData12Field = value;
            }
        }

        public string PerformanceData13
        {
            get
            {
                return this.performanceData13Field;
            }
            set
            {
                this.performanceData13Field = value;
            }
        }

        public string PerformanceData14
        {
            get
            {
                return this.performanceData14Field;
            }
            set
            {
                this.performanceData14Field = value;
            }
        }

        public string PerformanceData15
        {
            get
            {
                return this.performanceData15Field;
            }
            set
            {
                this.performanceData15Field = value;
            }
        }

        public string PerformanceData16
        {
            get
            {
                return this.performanceData16Field;
            }
            set
            {
                this.performanceData16Field = value;
            }
        }

        public string PerformanceData17
        {
            get
            {
                return this.performanceData17Field;
            }
            set
            {
                this.performanceData17Field = value;
            }
        }

        public string PerformanceData18
        {
            get
            {
                return this.performanceData18Field;
            }
            set
            {
                this.performanceData18Field = value;
            }
        }

        public string PerformanceData19
        {
            get
            {
                return this.performanceData19Field;
            }
            set
            {
                this.performanceData19Field = value;
            }
        }

        public string PerformanceData20
        {
            get
            {
                return this.performanceData20Field;
            }
            set
            {
                this.performanceData20Field = value;
            }
        }

        public string SUSR15
        {
            get
            {
                return this.susr15Field;
            }
            set
            {
                this.susr15Field = value;
            }
        }
    }
}
