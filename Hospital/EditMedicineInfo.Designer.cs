namespace Hospital
{
    partial class EditMedicineInfo
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
            this.UpdatePrice_btn = new System.Windows.Forms.Button();
            this.PriceMsg_lbl = new System.Windows.Forms.Label();
            this.UpdatedPrice_txt = new System.Windows.Forms.TextBox();
            this.PreviousPrice_txt = new System.Windows.Forms.TextBox();
            this.UpdatedPrice_lbl = new System.Windows.Forms.Label();
            this.PreviousPrice_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.UPName_cmb = new System.Windows.Forms.ComboBox();
            this.UpdatePrice_gb = new System.Windows.Forms.GroupBox();
            this.UpdateQuantity_gb = new System.Windows.Forms.GroupBox();
            this.UpdatedQuantity_NUD = new System.Windows.Forms.NumericUpDown();
            this.UQName_cmb = new System.Windows.Forms.ComboBox();
            this.UpdateQuantity_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateQuantity_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdatePrice_gb.SuspendLayout();
            this.UpdateQuantity_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedQuantity_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdatePrice_btn
            // 
            this.UpdatePrice_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatePrice_btn.ForeColor = System.Drawing.Color.Black;
            this.UpdatePrice_btn.Location = new System.Drawing.Point(135, 266);
            this.UpdatePrice_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatePrice_btn.Name = "UpdatePrice_btn";
            this.UpdatePrice_btn.Size = new System.Drawing.Size(249, 47);
            this.UpdatePrice_btn.TabIndex = 25;
            this.UpdatePrice_btn.Text = "Update price";
            this.UpdatePrice_btn.UseVisualStyleBackColor = true;
            this.UpdatePrice_btn.Click += new System.EventHandler(this.UpdatePrice_btn_Click);
            // 
            // PriceMsg_lbl
            // 
            this.PriceMsg_lbl.AutoSize = true;
            this.PriceMsg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PriceMsg_lbl.ForeColor = System.Drawing.Color.Black;
            this.PriceMsg_lbl.Location = new System.Drawing.Point(312, 199);
            this.PriceMsg_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceMsg_lbl.Name = "PriceMsg_lbl";
            this.PriceMsg_lbl.Size = new System.Drawing.Size(181, 17);
            this.PriceMsg_lbl.TabIndex = 24;
            this.PriceMsg_lbl.Text = "Please, enter numbers only";
            this.PriceMsg_lbl.Visible = false;
            // 
            // UpdatedPrice_txt
            // 
            this.UpdatedPrice_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatedPrice_txt.Location = new System.Drawing.Point(276, 155);
            this.UpdatedPrice_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatedPrice_txt.Name = "UpdatedPrice_txt";
            this.UpdatedPrice_txt.Size = new System.Drawing.Size(252, 28);
            this.UpdatedPrice_txt.TabIndex = 23;
            this.UpdatedPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatedPrice_txt_KeyPress);
            // 
            // PreviousPrice_txt
            // 
            this.PreviousPrice_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PreviousPrice_txt.Location = new System.Drawing.Point(276, 86);
            this.PreviousPrice_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PreviousPrice_txt.Name = "PreviousPrice_txt";
            this.PreviousPrice_txt.ReadOnly = true;
            this.PreviousPrice_txt.Size = new System.Drawing.Size(252, 28);
            this.PreviousPrice_txt.TabIndex = 22;
            // 
            // UpdatedPrice_lbl
            // 
            this.UpdatedPrice_lbl.AutoSize = true;
            this.UpdatedPrice_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatedPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.UpdatedPrice_lbl.Location = new System.Drawing.Point(44, 158);
            this.UpdatedPrice_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdatedPrice_lbl.Name = "UpdatedPrice_lbl";
            this.UpdatedPrice_lbl.Size = new System.Drawing.Size(142, 20);
            this.UpdatedPrice_lbl.TabIndex = 21;
            this.UpdatedPrice_lbl.Text = "Updated price";
            // 
            // PreviousPrice_lbl
            // 
            this.PreviousPrice_lbl.AutoSize = true;
            this.PreviousPrice_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PreviousPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.PreviousPrice_lbl.Location = new System.Drawing.Point(41, 89);
            this.PreviousPrice_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreviousPrice_lbl.Name = "PreviousPrice_lbl";
            this.PreviousPrice_lbl.Size = new System.Drawing.Size(144, 20);
            this.PreviousPrice_lbl.TabIndex = 20;
            this.PreviousPrice_lbl.Text = "Previous price";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(44, 21);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(63, 20);
            this.Name_lbl.TabIndex = 19;
            this.Name_lbl.Text = "Name";
            // 
            // UPName_cmb
            // 
            this.UPName_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UPName_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UPName_cmb.FormattingEnabled = true;
            this.UPName_cmb.Location = new System.Drawing.Point(276, 18);
            this.UPName_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPName_cmb.Name = "UPName_cmb";
            this.UPName_cmb.Size = new System.Drawing.Size(252, 28);
            this.UPName_cmb.TabIndex = 18;
            this.UPName_cmb.TextChanged += new System.EventHandler(this.Name_cmb_TextChanged);
            // 
            // UpdatePrice_gb
            // 
            this.UpdatePrice_gb.Controls.Add(this.UPName_cmb);
            this.UpdatePrice_gb.Controls.Add(this.UpdatePrice_btn);
            this.UpdatePrice_gb.Controls.Add(this.Name_lbl);
            this.UpdatePrice_gb.Controls.Add(this.PriceMsg_lbl);
            this.UpdatePrice_gb.Controls.Add(this.PreviousPrice_lbl);
            this.UpdatePrice_gb.Controls.Add(this.UpdatedPrice_txt);
            this.UpdatePrice_gb.Controls.Add(this.UpdatedPrice_lbl);
            this.UpdatePrice_gb.Controls.Add(this.PreviousPrice_txt);
            this.UpdatePrice_gb.Location = new System.Drawing.Point(31, 55);
            this.UpdatePrice_gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatePrice_gb.Name = "UpdatePrice_gb";
            this.UpdatePrice_gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatePrice_gb.Size = new System.Drawing.Size(578, 336);
            this.UpdatePrice_gb.TabIndex = 26;
            this.UpdatePrice_gb.TabStop = false;
            this.UpdatePrice_gb.Text = "Update Price";
            // 
            // UpdateQuantity_gb
            // 
            this.UpdateQuantity_gb.Controls.Add(this.UpdatedQuantity_NUD);
            this.UpdateQuantity_gb.Controls.Add(this.UQName_cmb);
            this.UpdateQuantity_gb.Controls.Add(this.UpdateQuantity_btn);
            this.UpdateQuantity_gb.Controls.Add(this.label1);
            this.UpdateQuantity_gb.Controls.Add(this.UpdateQuantity_lbl);
            this.UpdateQuantity_gb.Location = new System.Drawing.Point(642, 55);
            this.UpdateQuantity_gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateQuantity_gb.Name = "UpdateQuantity_gb";
            this.UpdateQuantity_gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateQuantity_gb.Size = new System.Drawing.Size(624, 336);
            this.UpdateQuantity_gb.TabIndex = 27;
            this.UpdateQuantity_gb.TabStop = false;
            this.UpdateQuantity_gb.Text = "Update Quantity";
            // 
            // UpdatedQuantity_NUD
            // 
            this.UpdatedQuantity_NUD.Location = new System.Drawing.Point(281, 129);
            this.UpdatedQuantity_NUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdatedQuantity_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpdatedQuantity_NUD.Name = "UpdatedQuantity_NUD";
            this.UpdatedQuantity_NUD.Size = new System.Drawing.Size(253, 22);
            this.UpdatedQuantity_NUD.TabIndex = 26;
            this.UpdatedQuantity_NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdatedQuantity_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UQName_cmb
            // 
            this.UQName_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UQName_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UQName_cmb.FormattingEnabled = true;
            this.UQName_cmb.Location = new System.Drawing.Point(281, 47);
            this.UQName_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UQName_cmb.Name = "UQName_cmb";
            this.UQName_cmb.Size = new System.Drawing.Size(252, 28);
            this.UQName_cmb.TabIndex = 18;
            // 
            // UpdateQuantity_btn
            // 
            this.UpdateQuantity_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateQuantity_btn.ForeColor = System.Drawing.Color.Black;
            this.UpdateQuantity_btn.Location = new System.Drawing.Point(194, 266);
            this.UpdateQuantity_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateQuantity_btn.Name = "UpdateQuantity_btn";
            this.UpdateQuantity_btn.Size = new System.Drawing.Size(249, 47);
            this.UpdateQuantity_btn.TabIndex = 25;
            this.UpdateQuantity_btn.Text = "Update Quantity";
            this.UpdateQuantity_btn.UseVisualStyleBackColor = true;
            this.UpdateQuantity_btn.Click += new System.EventHandler(this.UpdateQuantity_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // UpdateQuantity_lbl
            // 
            this.UpdateQuantity_lbl.AutoSize = true;
            this.UpdateQuantity_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateQuantity_lbl.ForeColor = System.Drawing.Color.Black;
            this.UpdateQuantity_lbl.Location = new System.Drawing.Point(37, 129);
            this.UpdateQuantity_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateQuantity_lbl.Name = "UpdateQuantity_lbl";
            this.UpdateQuantity_lbl.Size = new System.Drawing.Size(177, 20);
            this.UpdateQuantity_lbl.TabIndex = 21;
            this.UpdateQuantity_lbl.Text = "Updated Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(223, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Update Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(845, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Update Quantity";
            // 
            // EditMedicineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateQuantity_gb);
            this.Controls.Add(this.UpdatePrice_gb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditMedicineInfo";
            this.Text = "Edit Medicine Info";
            this.Load += new System.EventHandler(this.SetPrice_Load);
            this.UpdatePrice_gb.ResumeLayout(false);
            this.UpdatePrice_gb.PerformLayout();
            this.UpdateQuantity_gb.ResumeLayout(false);
            this.UpdateQuantity_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatedQuantity_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdatePrice_btn;
        private System.Windows.Forms.Label PriceMsg_lbl;
        private System.Windows.Forms.TextBox UpdatedPrice_txt;
        private System.Windows.Forms.TextBox PreviousPrice_txt;
        private System.Windows.Forms.Label UpdatedPrice_lbl;
        private System.Windows.Forms.Label PreviousPrice_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.ComboBox UPName_cmb;
        private System.Windows.Forms.GroupBox UpdatePrice_gb;
        private System.Windows.Forms.GroupBox UpdateQuantity_gb;
        private System.Windows.Forms.ComboBox UQName_cmb;
        private System.Windows.Forms.Button UpdateQuantity_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpdateQuantity_lbl;
        private System.Windows.Forms.NumericUpDown UpdatedQuantity_NUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}