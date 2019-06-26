namespace CarHireCompany
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerLstBox = new System.Windows.Forms.ListBox();
            this.vehicleLstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerLstBox
            // 
            this.customerLstBox.FormattingEnabled = true;
            this.customerLstBox.Location = new System.Drawing.Point(32, 24);
            this.customerLstBox.Name = "customerLstBox";
            this.customerLstBox.Size = new System.Drawing.Size(497, 134);
            this.customerLstBox.TabIndex = 0;
            // 
            // vehicleLstBox
            // 
            this.vehicleLstBox.FormattingEnabled = true;
            this.vehicleLstBox.Location = new System.Drawing.Point(32, 181);
            this.vehicleLstBox.Name = "vehicleLstBox";
            this.vehicleLstBox.Size = new System.Drawing.Size(497, 134);
            this.vehicleLstBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicleLstBox);
            this.Controls.Add(this.customerLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customerLstBox;
        private System.Windows.Forms.ListBox vehicleLstBox;
    }
}

