namespace Hospital
{
    partial class SetPrice
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
            this.Name_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpdatePrice_btn
            // 
            this.UpdatePrice_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatePrice_btn.ForeColor = System.Drawing.Color.Black;
            this.UpdatePrice_btn.Location = new System.Drawing.Point(197, 252);
            this.UpdatePrice_btn.Name = "UpdatePrice_btn";
            this.UpdatePrice_btn.Size = new System.Drawing.Size(187, 38);
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
            this.PriceMsg_lbl.Location = new System.Drawing.Point(301, 197);
            this.PriceMsg_lbl.Name = "PriceMsg_lbl";
            this.PriceMsg_lbl.Size = new System.Drawing.Size(134, 13);
            this.PriceMsg_lbl.TabIndex = 24;
            this.PriceMsg_lbl.Text = "Please, enter numbers only";
            this.PriceMsg_lbl.Visible = false;
            // 
            // UpdatedPrice_txt
            // 
            this.UpdatedPrice_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatedPrice_txt.Location = new System.Drawing.Point(274, 161);
            this.UpdatedPrice_txt.Name = "UpdatedPrice_txt";
            this.UpdatedPrice_txt.Size = new System.Drawing.Size(190, 24);
            this.UpdatedPrice_txt.TabIndex = 23;
            this.UpdatedPrice_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatedPrice_txt_KeyPress);
            // 
            // PreviousPrice_txt
            // 
            this.PreviousPrice_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PreviousPrice_txt.Location = new System.Drawing.Point(274, 105);
            this.PreviousPrice_txt.Name = "PreviousPrice_txt";
            this.PreviousPrice_txt.ReadOnly = true;
            this.PreviousPrice_txt.Size = new System.Drawing.Size(190, 24);
            this.PreviousPrice_txt.TabIndex = 22;
            // 
            // UpdatedPrice_lbl
            // 
            this.UpdatedPrice_lbl.AutoSize = true;
            this.UpdatedPrice_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.UpdatedPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.UpdatedPrice_lbl.Location = new System.Drawing.Point(129, 164);
            this.UpdatedPrice_lbl.Name = "UpdatedPrice_lbl";
            this.UpdatedPrice_lbl.Size = new System.Drawing.Size(116, 17);
            this.UpdatedPrice_lbl.TabIndex = 21;
            this.UpdatedPrice_lbl.Text = "Updated price";
            // 
            // PreviousPrice_lbl
            // 
            this.PreviousPrice_lbl.AutoSize = true;
            this.PreviousPrice_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.PreviousPrice_lbl.ForeColor = System.Drawing.Color.Black;
            this.PreviousPrice_lbl.Location = new System.Drawing.Point(127, 108);
            this.PreviousPrice_lbl.Name = "PreviousPrice_lbl";
            this.PreviousPrice_lbl.Size = new System.Drawing.Size(118, 17);
            this.PreviousPrice_lbl.TabIndex = 20;
            this.PreviousPrice_lbl.Text = "Previous price";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(194, 53);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 17);
            this.Name_lbl.TabIndex = 19;
            this.Name_lbl.Text = "Name";
            // 
            // Name_cmb
            // 
            this.Name_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_cmb.FormattingEnabled = true;
            this.Name_cmb.Location = new System.Drawing.Point(274, 50);
            this.Name_cmb.Name = "Name_cmb";
            this.Name_cmb.Size = new System.Drawing.Size(190, 24);
            this.Name_cmb.TabIndex = 18;
            this.Name_cmb.TextChanged += new System.EventHandler(this.Name_cmb_TextChanged);
            // 
            // SetPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatePrice_btn);
            this.Controls.Add(this.PriceMsg_lbl);
            this.Controls.Add(this.UpdatedPrice_txt);
            this.Controls.Add(this.PreviousPrice_txt);
            this.Controls.Add(this.UpdatedPrice_lbl);
            this.Controls.Add(this.PreviousPrice_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Name_cmb);
            this.Name = "SetPrice";
            this.Text = "SetPrice";
            this.Load += new System.EventHandler(this.SetPrice_Load);
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
        private System.Windows.Forms.ComboBox Name_cmb;
    }
}