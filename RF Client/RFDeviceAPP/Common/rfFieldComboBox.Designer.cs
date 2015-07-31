namespace RFDeviceAPP.Common
{
    partial class rfFieldComboBox
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
            this.FieldComboBox = new RFDeviceAPP.Common.rfComboBox();
            this.SuspendLayout();
            // 
            // fieldLabel
            // 
            this.fieldLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.fieldLabel.Location = new System.Drawing.Point(0, 0);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(369, 18);
            this.fieldLabel.Text = "label1";
            // 
            // FieldComboBox
            // 
            this.FieldComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FieldComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.FieldComboBox.Location = new System.Drawing.Point(0, 18);
            this.FieldComboBox.Name = "FieldComboBox";
            this.FieldComboBox.Size = new System.Drawing.Size(369, 21);
            this.FieldComboBox.TabIndex = 3;
            // 
            // rfFieldComboBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.FieldComboBox);
            this.Controls.Add(this.fieldLabel);
            this.Name = "rfFieldComboBox";
            this.Size = new System.Drawing.Size(369, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fieldLabel;
        public rfComboBox FieldComboBox;
    }
}
