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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_secondname = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_resetvehicle = new System.Windows.Forms.Button();
            this.housenumtxt = new System.Windows.Forms.TextBox();
            this.lbl_housenum = new System.Windows.Forms.Label();
            this.street_txt = new System.Windows.Forms.TextBox();
            this.street_lbl = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.SecondNametxt.Location = new System.Drawing.Point(721, 24);
            this.SecondNametxt.Name = "SecondNametxt";
            this.SecondNametxt.Size = new System.Drawing.Size(100, 20);
            this.SecondNametxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "createcustomerbtn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Createvehiclebtn
            // 
            this.Createvehiclebtn.Location = new System.Drawing.Point(615, 207);
            this.Createvehiclebtn.Name = "Createvehiclebtn";
            this.Createvehiclebtn.Size = new System.Drawing.Size(99, 23);
            this.Createvehiclebtn.TabIndex = 5;
            this.Createvehiclebtn.Text = "Enter vehicle";
            this.Createvehiclebtn.UseVisualStyleBackColor = true;
            this.Createvehiclebtn.Click += new System.EventHandler(this.Createvehiclebtn_Click);
            // 
            // Vehicletxt
            // 
            this.Vehicletxt.Location = new System.Drawing.Point(615, 181);
            this.Vehicletxt.Name = "Vehicletxt";
            this.Vehicletxt.Size = new System.Drawing.Size(100, 20);
            this.Vehicletxt.TabIndex = 6;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Location = new System.Drawing.Point(612, 8);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(55, 13);
            this.lbl_firstname.TabIndex = 7;
            this.lbl_firstname.Text = "First name";
            // 
            // lbl_secondname
            // 
            this.lbl_secondname.AutoSize = true;
            this.lbl_secondname.Location = new System.Drawing.Point(721, 9);
            this.lbl_secondname.Name = "lbl_secondname";
            this.lbl_secondname.Size = new System.Drawing.Size(73, 13);
            this.lbl_secondname.TabIndex = 8;
            this.lbl_secondname.Text = "Second name";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(827, 120);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 28);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_resetvehicle
            // 
            this.btn_resetvehicle.Location = new System.Drawing.Point(615, 236);
            this.btn_resetvehicle.Name = "btn_resetvehicle";
            this.btn_resetvehicle.Size = new System.Drawing.Size(99, 23);
            this.btn_resetvehicle.TabIndex = 10;
            this.btn_resetvehicle.Text = "Reset vehicle";
            this.btn_resetvehicle.UseVisualStyleBackColor = true;
            this.btn_resetvehicle.Visible = false;
            this.btn_resetvehicle.Click += new System.EventHandler(this.btn_resetvehicle_Click);
            // 
            // housenumtxt
            // 
            this.housenumtxt.Location = new System.Drawing.Point(827, 24);
            this.housenumtxt.Name = "housenumtxt";
            this.housenumtxt.Size = new System.Drawing.Size(100, 20);
            this.housenumtxt.TabIndex = 11;
            // 
            // lbl_housenum
            // 
            this.lbl_housenum.AutoSize = true;
            this.lbl_housenum.Location = new System.Drawing.Point(827, 9);
            this.lbl_housenum.Name = "lbl_housenum";
            this.lbl_housenum.Size = new System.Drawing.Size(76, 13);
            this.lbl_housenum.TabIndex = 12;
            this.lbl_housenum.Text = "House number";
            // 
            // street_txt
            // 
            this.street_txt.Location = new System.Drawing.Point(933, 24);
            this.street_txt.Name = "street_txt";
            this.street_txt.Size = new System.Drawing.Size(100, 20);
            this.street_txt.TabIndex = 13;
            // 
            // street_lbl
            // 
            this.street_lbl.AutoSize = true;
            this.street_lbl.Location = new System.Drawing.Point(933, 9);
            this.street_lbl.Name = "street_lbl";
            this.street_lbl.Size = new System.Drawing.Size(35, 13);
            this.street_lbl.TabIndex = 14;
            this.street_lbl.Text = "Street";
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(1039, 24);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(100, 20);
            this.city_txt.TabIndex = 15;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(1039, 9);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(24, 13);
            this.lbl_city.TabIndex = 16;
            this.lbl_city.Text = "City";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ford ",
            "Apple car",
            "Shrozzer the J car",
            "Mcar"});
            this.comboBox1.Location = new System.Drawing.Point(225, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 623);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.street_lbl);
            this.Controls.Add(this.street_txt);
            this.Controls.Add(this.lbl_housenum);
            this.Controls.Add(this.housenumtxt);
            this.Controls.Add(this.btn_resetvehicle);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_secondname);
            this.Controls.Add(this.lbl_firstname);
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
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_secondname;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_resetvehicle;
        private System.Windows.Forms.TextBox housenumtxt;
        private System.Windows.Forms.Label lbl_housenum;
        private System.Windows.Forms.TextBox street_txt;
        private System.Windows.Forms.Label street_lbl;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

