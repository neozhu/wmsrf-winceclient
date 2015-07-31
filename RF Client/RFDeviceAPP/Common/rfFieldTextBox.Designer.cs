namespace RFDeviceAPP.Common
{
    partial class rfFieldTextBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fieldLabel = new System.Windows.Forms.Label();
            this.FieldTextBox = new RFDeviceAPP.Common.rfTextBox();
            this.SuspendLayout();
            // 
            // fieldLabel
            // 
            this.fieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.fieldLabel.Location = new System.Drawing.Point(3, 0);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(92, 18);
            this.fieldLabel.Text = "label1";
            // 
            // FieldTextBox
            // 
            this.FieldTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.FieldTextBox.Location = new System.Drawing.Point(4, 18);
            this.FieldTextBox.Name = "FieldTextBox";
            this.FieldTextBox.Size = new System.Drawing.Size(231, 21);
            this.FieldTextBox.TabIndex = 1;
            // 
            // rfFieldTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FieldTextBox);
            this.Controls.Add(this.fieldLabel);
            this.Name = "rfFieldTextBox";
            this.Size = new System.Drawing.Size(240, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fieldLabel;
        public RFDeviceAPP.Common.rfTextBox FieldTextBox;
    }
}
