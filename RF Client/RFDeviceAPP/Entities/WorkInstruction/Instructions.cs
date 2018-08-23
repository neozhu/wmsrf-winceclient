using System;

using System.Collections.Generic;
using System.Text;

namespace RFDeviceAPP.Entities.WorkInstruction
{
    public partial class Instructions
    {

        public static Instructions CreateINS(string ordertype, string orderkey)
        {
            Instructions instruction = new Instructions();
            instruction.InstructionsHeader.OrderType = ordertype;
            instruction.InstructionsHeader.OrderKey = orderkey;
            return instruction;
        }
        private InstructionsHeader instructionsHeaderField;

        public Instructions()
        {
            this.instructionsHeaderField = new InstructionsHeader();
        }

        public InstructionsHeader InstructionsHeader
        {
            get
            {
                return this.instructionsHeaderField;
            }
            set
            {
                this.instructionsHeaderField = value;
            }
        }
    }

    public partial class InstructionsHeader
    {
        private string orderKeyField;

        private string orderTypeField;

        private string sourceLineNoField;

        private string serviceNameField;

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

        public string OrderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        public string SourceLineNo
        {
            get
            {
                return this.sourceLineNoField;
            }
            set
            {
                this.sourceLineNoField = value;
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
