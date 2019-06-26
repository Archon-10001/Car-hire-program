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
            this.Firstnametxt = new System.Windows.Forms.TextBox();
            this.SecondNametxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Createvehiclebtn = new System.Windows.Forms.Button();
            this.Vehicletxt = new System.Windows.Forms.TextBox();
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
            // Firstnametxt
            // 
            this.Firstnametxt.Location = new System.Drawing.Point(615, 24);
            this.Firstnametxt.Name = "Firstnametxt";
            this.Firstnametxt.Size = new System.Drawing.Size(100, 20);
            this.Firstnametxt.TabIndex = 2;
            // 
            // SecondNametxt
            // 
            this.SecondNametxt.Location = new System.Drawing.Point(615, 79);
            this.SecondNametxt.Name = "SecondNametxt";
            this.SecondNametxt.Size = new System.Drawing.Size(100, 20);
            this.SecondNametxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "createcustomerbtn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Createvehiclebtn
            // 
            this.Createvehiclebtn.Location = new System.Drawing.Point(615, 200);
            this.Createvehiclebtn.Name = "Createvehiclebtn";
            this.Createvehiclebtn.Size = new System.Drawing.Size(75, 23);
            this.Createvehiclebtn.TabIndex = 5;
            this.Createvehiclebtn.Text = "Create vehicle";
            this.Createvehiclebtn.UseVisualStyleBackColor = true;
            this.Createvehiclebtn.Click += new System.EventHandler(this.Createvehiclebtn_Click);
            // 
            // Vehicletxt
            // 
            this.Vehicletxt.Location = new System.Drawing.Point(604, 174);
            this.Vehicletxt.Name = "Vehicletxt";
            this.Vehicletxt.Size = new System.Drawing.Size(100, 20);
            this.Vehicletxt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vehicletxt);
            this.Controls.Add(this.Createvehiclebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecondNametxt);
            this.Controls.Add(this.Firstnametxt);
            this.Controls.Add(this.vehicleLstBox);
            this.Controls.Add(this.customerLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerLstBox;
        private System.Windows.Forms.ListBox vehicleLstBox;
        private System.Windows.Forms.TextBox Firstnametxt;
        private System.Windows.Forms.TextBox SecondNametxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Createvehiclebtn;
        private System.Windows.Forms.TextBox Vehicletxt;
    }
}

