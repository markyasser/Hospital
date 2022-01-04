namespace Hospital
{
    partial class SellOrAsk
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
            this.PatientID_lbl = new System.Windows.Forms.Label();
            this.PatientID_cmb = new System.Windows.Forms.ComboBox();
            this.Medname1_lbl = new System.Windows.Forms.Label();
            this.Medname1_cmb = new System.Windows.Forms.ComboBox();
            this.Get_btn = new System.Windows.Forms.Button();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Med1_gb = new System.Windows.Forms.GroupBox();
            this.Price1_lbl = new System.Windows.Forms.Label();
            this.Price1_txt = new System.Windows.Forms.TextBox();
            this.Med2_gb = new System.Windows.Forms.GroupBox();
            this.Price2_lbl = new System.Windows.Forms.Label();
            this.Price2_txt = new System.Windows.Forms.TextBox();
            this.Medname2_lbl = new System.Windows.Forms.Label();
            this.Medname2_cmb = new System.Windows.Forms.ComboBox();
            this.Med3_gb = new System.Windows.Forms.GroupBox();
            this.price3_lbl = new System.Windows.Forms.Label();
            this.Price3_txt = new System.Windows.Forms.TextBox();
            this.Medname3_lbl = new System.Windows.Forms.Label();
            this.Medname3_cmb = new System.Windows.Forms.ComboBox();
            this.Med4_gb = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price4_txt = new System.Windows.Forms.TextBox();
            this.Medname4_lbl = new System.Windows.Forms.Label();
            this.Medname4_cmb = new System.Windows.Forms.ComboBox();
            this.Med5_gb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price5_txt = new System.Windows.Forms.TextBox();
            this.Medname5_lbl = new System.Windows.Forms.Label();
            this.Medname5_cmb = new System.Windows.Forms.ComboBox();
            this.TotalPrice_lbl = new System.Windows.Forms.Label();
            this.TotalPrice_txt = new System.Windows.Forms.TextBox();
            this.Med1_gb.SuspendLayout();
            this.Med2_gb.SuspendLayout();
            this.Med3_gb.SuspendLayout();
            this.Med4_gb.SuspendLayout();
            this.Med5_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientID_lbl
            // 
            this.PatientID_lbl.AutoSize = true;
            this.PatientID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PatientID_lbl.ForeColor = System.Drawing.Color.Black;
            this.PatientID_lbl.Location = new System.Drawing.Point(40, 44);
            this.PatientID_lbl.Name = "PatientID_lbl";
            this.PatientID_lbl.Size = new System.Drawing.Size(86, 17);
            this.PatientID_lbl.TabIndex = 21;
            this.PatientID_lbl.Text = "Patient ID";
            // 
            // PatientID_cmb
            // 
            this.PatientID_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PatientID_cmb.FormattingEnabled = true;
            this.PatientID_cmb.Location = new System.Drawing.Point(147, 41);
            this.PatientID_cmb.Name = "PatientID_cmb";
            this.PatientID_cmb.Size = new System.Drawing.Size(190, 24);
            this.PatientID_cmb.TabIndex = 20;
            // 
            // Medname1_lbl
            // 
            this.Medname1_lbl.AutoSize = true;
            this.Medname1_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname1_lbl.ForeColor = System.Drawing.Color.Black;
            this.Medname1_lbl.Location = new System.Drawing.Point(30, 15);
            this.Medname1_lbl.Name = "Medname1_lbl";
            this.Medname1_lbl.Size = new System.Drawing.Size(149, 17);
            this.Medname1_lbl.TabIndex = 23;
            this.Medname1_lbl.Text = "Medicine #1 name";
            // 
            // Medname1_cmb
            // 
            this.Medname1_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname1_cmb.FormattingEnabled = true;
            this.Medname1_cmb.Location = new System.Drawing.Point(207, 12);
            this.Medname1_cmb.Name = "Medname1_cmb";
            this.Medname1_cmb.Size = new System.Drawing.Size(190, 24);
            this.Medname1_cmb.TabIndex = 22;
            this.Medname1_cmb.TextChanged += new System.EventHandler(this.Medname1_cmb_TextChanged);
            // 
            // Get_btn
            // 
            this.Get_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Get_btn.ForeColor = System.Drawing.Color.Black;
            this.Get_btn.Location = new System.Drawing.Point(43, 356);
            this.Get_btn.Name = "Get_btn";
            this.Get_btn.Size = new System.Drawing.Size(162, 31);
            this.Get_btn.TabIndex = 24;
            this.Get_btn.Text = "Get";
            this.Get_btn.UseVisualStyleBackColor = true;
            this.Get_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // Show_btn
            // 
            this.Show_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.Show_btn.ForeColor = System.Drawing.Color.Black;
            this.Show_btn.Location = new System.Drawing.Point(413, 36);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(159, 33);
            this.Show_btn.TabIndex = 31;
            this.Show_btn.Text = "Add another medicine";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Med1_gb
            // 
            this.Med1_gb.Controls.Add(this.Price1_lbl);
            this.Med1_gb.Controls.Add(this.Price1_txt);
            this.Med1_gb.Controls.Add(this.Medname1_lbl);
            this.Med1_gb.Controls.Add(this.Medname1_cmb);
            this.Med1_gb.Location = new System.Drawing.Point(43, 89);
            this.Med1_gb.Name = "Med1_gb";
            this.Med1_gb.Size = new System.Drawing.Size(605, 45);
            this.Med1_gb.TabIndex = 32;
            this.Med1_gb.TabStop = false;
            this.Med1_gb.Text = "Med1";
            // 
            // Price1_lbl
            // 
            this.Price1_lbl.AutoSize = true;
            this.Price1_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Price1_lbl.ForeColor = System.Drawing.Color.Black;
            this.Price1_lbl.Location = new System.Drawing.Point(411, 16);
            this.Price1_lbl.Name = "Price1_lbl";
            this.Price1_lbl.Size = new System.Drawing.Size(46, 17);
            this.Price1_lbl.TabIndex = 41;
            this.Price1_lbl.Text = "Price";
            // 
            // Price1_txt
            // 
            this.Price1_txt.Location = new System.Drawing.Point(477, 12);
            this.Price1_txt.Name = "Price1_txt";
            this.Price1_txt.ReadOnly = true;
            this.Price1_txt.Size = new System.Drawing.Size(112, 20);
            this.Price1_txt.TabIndex = 40;
            // 
            // Med2_gb
            // 
            this.Med2_gb.Controls.Add(this.Price2_lbl);
            this.Med2_gb.Controls.Add(this.Price2_txt);
            this.Med2_gb.Controls.Add(this.Medname2_lbl);
            this.Med2_gb.Controls.Add(this.Medname2_cmb);
            this.Med2_gb.Location = new System.Drawing.Point(43, 140);
            this.Med2_gb.Name = "Med2_gb";
            this.Med2_gb.Size = new System.Drawing.Size(605, 45);
            this.Med2_gb.TabIndex = 33;
            this.Med2_gb.TabStop = false;
            this.Med2_gb.Text = "Med2";
            this.Med2_gb.Visible = false;
            // 
            // Price2_lbl
            // 
            this.Price2_lbl.AutoSize = true;
            this.Price2_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Price2_lbl.ForeColor = System.Drawing.Color.Black;
            this.Price2_lbl.Location = new System.Drawing.Point(411, 16);
            this.Price2_lbl.Name = "Price2_lbl";
            this.Price2_lbl.Size = new System.Drawing.Size(46, 17);
            this.Price2_lbl.TabIndex = 41;
            this.Price2_lbl.Text = "Price";
            // 
            // Price2_txt
            // 
            this.Price2_txt.Location = new System.Drawing.Point(477, 12);
            this.Price2_txt.Name = "Price2_txt";
            this.Price2_txt.ReadOnly = true;
            this.Price2_txt.Size = new System.Drawing.Size(112, 20);
            this.Price2_txt.TabIndex = 40;
            // 
            // Medname2_lbl
            // 
            this.Medname2_lbl.AutoSize = true;
            this.Medname2_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname2_lbl.ForeColor = System.Drawing.Color.Black;
            this.Medname2_lbl.Location = new System.Drawing.Point(30, 15);
            this.Medname2_lbl.Name = "Medname2_lbl";
            this.Medname2_lbl.Size = new System.Drawing.Size(149, 17);
            this.Medname2_lbl.TabIndex = 23;
            this.Medname2_lbl.Text = "Medicine #2 name";
            // 
            // Medname2_cmb
            // 
            this.Medname2_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname2_cmb.FormattingEnabled = true;
            this.Medname2_cmb.Location = new System.Drawing.Point(207, 12);
            this.Medname2_cmb.Name = "Medname2_cmb";
            this.Medname2_cmb.Size = new System.Drawing.Size(190, 24);
            this.Medname2_cmb.TabIndex = 22;
            this.Medname2_cmb.TextChanged += new System.EventHandler(this.Medname2_cmb_TextChanged);
            // 
            // Med3_gb
            // 
            this.Med3_gb.Controls.Add(this.price3_lbl);
            this.Med3_gb.Controls.Add(this.Price3_txt);
            this.Med3_gb.Controls.Add(this.Medname3_lbl);
            this.Med3_gb.Controls.Add(this.Medname3_cmb);
            this.Med3_gb.Location = new System.Drawing.Point(43, 199);
            this.Med3_gb.Name = "Med3_gb";
            this.Med3_gb.Size = new System.Drawing.Size(605, 45);
            this.Med3_gb.TabIndex = 34;
            this.Med3_gb.TabStop = false;
            this.Med3_gb.Text = "Med3";
            this.Med3_gb.Visible = false;
            // 
            // price3_lbl
            // 
            this.price3_lbl.AutoSize = true;
            this.price3_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.price3_lbl.ForeColor = System.Drawing.Color.Black;
            this.price3_lbl.Location = new System.Drawing.Point(411, 16);
            this.price3_lbl.Name = "price3_lbl";
            this.price3_lbl.Size = new System.Drawing.Size(46, 17);
            this.price3_lbl.TabIndex = 41;
            this.price3_lbl.Text = "Price";
            // 
            // Price3_txt
            // 
            this.Price3_txt.Location = new System.Drawing.Point(477, 12);
            this.Price3_txt.Name = "Price3_txt";
            this.Price3_txt.ReadOnly = true;
            this.Price3_txt.Size = new System.Drawing.Size(112, 20);
            this.Price3_txt.TabIndex = 40;
            // 
            // Medname3_lbl
            // 
            this.Medname3_lbl.AutoSize = true;
            this.Medname3_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname3_lbl.ForeColor = System.Drawing.Color.Black;
            this.Medname3_lbl.Location = new System.Drawing.Point(30, 15);
            this.Medname3_lbl.Name = "Medname3_lbl";
            this.Medname3_lbl.Size = new System.Drawing.Size(149, 17);
            this.Medname3_lbl.TabIndex = 23;
            this.Medname3_lbl.Text = "Medicine #3 name";
            // 
            // Medname3_cmb
            // 
            this.Medname3_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname3_cmb.FormattingEnabled = true;
            this.Medname3_cmb.Location = new System.Drawing.Point(207, 12);
            this.Medname3_cmb.Name = "Medname3_cmb";
            this.Medname3_cmb.Size = new System.Drawing.Size(190, 24);
            this.Medname3_cmb.TabIndex = 22;
            this.Medname3_cmb.TextChanged += new System.EventHandler(this.Medname3_cmb_TextChanged);
            // 
            // Med4_gb
            // 
            this.Med4_gb.Controls.Add(this.label3);
            this.Med4_gb.Controls.Add(this.Price4_txt);
            this.Med4_gb.Controls.Add(this.Medname4_lbl);
            this.Med4_gb.Controls.Add(this.Medname4_cmb);
            this.Med4_gb.Location = new System.Drawing.Point(43, 250);
            this.Med4_gb.Name = "Med4_gb";
            this.Med4_gb.Size = new System.Drawing.Size(605, 45);
            this.Med4_gb.TabIndex = 35;
            this.Med4_gb.TabStop = false;
            this.Med4_gb.Text = "Med4";
            this.Med4_gb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(411, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Price";
            // 
            // Price4_txt
            // 
            this.Price4_txt.Location = new System.Drawing.Point(477, 12);
            this.Price4_txt.Name = "Price4_txt";
            this.Price4_txt.ReadOnly = true;
            this.Price4_txt.Size = new System.Drawing.Size(112, 20);
            this.Price4_txt.TabIndex = 40;
            // 
            // Medname4_lbl
            // 
            this.Medname4_lbl.AutoSize = true;
            this.Medname4_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname4_lbl.ForeColor = System.Drawing.Color.Black;
            this.Medname4_lbl.Location = new System.Drawing.Point(30, 15);
            this.Medname4_lbl.Name = "Medname4_lbl";
            this.Medname4_lbl.Size = new System.Drawing.Size(149, 17);
            this.Medname4_lbl.TabIndex = 23;
            this.Medname4_lbl.Text = "Medicine #4 name";
            // 
            // Medname4_cmb
            // 
            this.Medname4_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname4_cmb.FormattingEnabled = true;
            this.Medname4_cmb.Location = new System.Drawing.Point(207, 12);
            this.Medname4_cmb.Name = "Medname4_cmb";
            this.Medname4_cmb.Size = new System.Drawing.Size(190, 24);
            this.Medname4_cmb.TabIndex = 22;
            this.Medname4_cmb.TextChanged += new System.EventHandler(this.Medname4_cmb_TextChanged);
            // 
            // Med5_gb
            // 
            this.Med5_gb.Controls.Add(this.label4);
            this.Med5_gb.Controls.Add(this.Price5_txt);
            this.Med5_gb.Controls.Add(this.Medname5_lbl);
            this.Med5_gb.Controls.Add(this.Medname5_cmb);
            this.Med5_gb.Location = new System.Drawing.Point(43, 301);
            this.Med5_gb.Name = "Med5_gb";
            this.Med5_gb.Size = new System.Drawing.Size(605, 45);
            this.Med5_gb.TabIndex = 36;
            this.Med5_gb.TabStop = false;
            this.Med5_gb.Text = "Med5";
            this.Med5_gb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(411, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Price";
            // 
            // Price5_txt
            // 
            this.Price5_txt.Location = new System.Drawing.Point(477, 12);
            this.Price5_txt.Name = "Price5_txt";
            this.Price5_txt.ReadOnly = true;
            this.Price5_txt.Size = new System.Drawing.Size(112, 20);
            this.Price5_txt.TabIndex = 40;
            // 
            // Medname5_lbl
            // 
            this.Medname5_lbl.AutoSize = true;
            this.Medname5_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname5_lbl.ForeColor = System.Drawing.Color.Black;
            this.Medname5_lbl.Location = new System.Drawing.Point(30, 15);
            this.Medname5_lbl.Name = "Medname5_lbl";
            this.Medname5_lbl.Size = new System.Drawing.Size(149, 17);
            this.Medname5_lbl.TabIndex = 23;
            this.Medname5_lbl.Text = "Medicine #5 name";
            // 
            // Medname5_cmb
            // 
            this.Medname5_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Medname5_cmb.FormattingEnabled = true;
            this.Medname5_cmb.Location = new System.Drawing.Point(207, 12);
            this.Medname5_cmb.Name = "Medname5_cmb";
            this.Medname5_cmb.Size = new System.Drawing.Size(190, 24);
            this.Medname5_cmb.TabIndex = 22;
            this.Medname5_cmb.TextChanged += new System.EventHandler(this.Medname5_cmb_TextChanged);
            // 
            // TotalPrice_lbl
            // 
            this.TotalPrice_lbl.AutoSize = true;
            this.TotalPrice_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.TotalPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.TotalPrice_lbl.Location = new System.Drawing.Point(410, 368);
            this.TotalPrice_lbl.Name = "TotalPrice_lbl";
            this.TotalPrice_lbl.Size = new System.Drawing.Size(90, 17);
            this.TotalPrice_lbl.TabIndex = 41;
            this.TotalPrice_lbl.Text = "Total Price";
            // 
            // TotalPrice_txt
            // 
            this.TotalPrice_txt.Location = new System.Drawing.Point(520, 367);
            this.TotalPrice_txt.Name = "TotalPrice_txt";
            this.TotalPrice_txt.ReadOnly = true;
            this.TotalPrice_txt.Size = new System.Drawing.Size(112, 20);
            this.TotalPrice_txt.TabIndex = 40;
            // 
            // SellOrAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPrice_lbl);
            this.Controls.Add(this.TotalPrice_txt);
            this.Controls.Add(this.Med5_gb);
            this.Controls.Add(this.Med4_gb);
            this.Controls.Add(this.Med3_gb);
            this.Controls.Add(this.Med2_gb);
            this.Controls.Add(this.Med1_gb);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Get_btn);
            this.Controls.Add(this.PatientID_lbl);
            this.Controls.Add(this.PatientID_cmb);
            this.Name = "SellOrAsk";
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.SellOrAsk_Load);
            this.Med1_gb.ResumeLayout(false);
            this.Med1_gb.PerformLayout();
            this.Med2_gb.ResumeLayout(false);
            this.Med2_gb.PerformLayout();
            this.Med3_gb.ResumeLayout(false);
            this.Med3_gb.PerformLayout();
            this.Med4_gb.ResumeLayout(false);
            this.Med4_gb.PerformLayout();
            this.Med5_gb.ResumeLayout(false);
            this.Med5_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientID_lbl;
        private System.Windows.Forms.ComboBox PatientID_cmb;
        private System.Windows.Forms.Label Medname1_lbl;
        private System.Windows.Forms.ComboBox Medname1_cmb;
        private System.Windows.Forms.Button Get_btn;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.GroupBox Med1_gb;
        private System.Windows.Forms.GroupBox Med2_gb;
        private System.Windows.Forms.Label Medname2_lbl;
        private System.Windows.Forms.ComboBox Medname2_cmb;
        private System.Windows.Forms.GroupBox Med3_gb;
        private System.Windows.Forms.Label Medname3_lbl;
        private System.Windows.Forms.ComboBox Medname3_cmb;
        private System.Windows.Forms.GroupBox Med4_gb;
        private System.Windows.Forms.Label Medname4_lbl;
        private System.Windows.Forms.ComboBox Medname4_cmb;
        private System.Windows.Forms.GroupBox Med5_gb;
        private System.Windows.Forms.Label Medname5_lbl;
        private System.Windows.Forms.ComboBox Medname5_cmb;
        private System.Windows.Forms.Label Price1_lbl;
        private System.Windows.Forms.TextBox Price1_txt;
        private System.Windows.Forms.Label Price2_lbl;
        private System.Windows.Forms.TextBox Price2_txt;
        private System.Windows.Forms.Label price3_lbl;
        private System.Windows.Forms.TextBox Price3_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price4_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price5_txt;
        private System.Windows.Forms.Label TotalPrice_lbl;
        private System.Windows.Forms.TextBox TotalPrice_txt;
    }
}