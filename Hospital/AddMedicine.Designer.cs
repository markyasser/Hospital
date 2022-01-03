namespace Hospital
{
    partial class AddMedicine
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
            this.Price_lbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ExpDate_lbl = new System.Windows.Forms.Label();
            this.Quantity_lbl = new System.Windows.Forms.Label();
            this.MedID_lbl = new System.Windows.Forms.Label();
            this.MedID_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.AddMedicine_btn = new System.Windows.Forms.Button();
            this.NameMsg_lbl = new System.Windows.Forms.Label();
            this.MedIDMsg_lbl = new System.Windows.Forms.Label();
            this.QuantityMsg_lbl = new System.Windows.Forms.Label();
            this.PriceMsg_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Price_lbl.ForeColor = System.Drawing.Color.Black;
            this.Price_lbl.Location = new System.Drawing.Point(186, 285);
            this.Price_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(46, 17);
            this.Price_lbl.TabIndex = 36;
            this.Price_lbl.Text = "Price";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 235);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 12, 30, 20, 13, 28, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // ExpDate_lbl
            // 
            this.ExpDate_lbl.AutoSize = true;
            this.ExpDate_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.ExpDate_lbl.ForeColor = System.Drawing.Color.Black;
            this.ExpDate_lbl.Location = new System.Drawing.Point(186, 235);
            this.ExpDate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExpDate_lbl.Name = "ExpDate_lbl";
            this.ExpDate_lbl.Size = new System.Drawing.Size(97, 17);
            this.ExpDate_lbl.TabIndex = 34;
            this.ExpDate_lbl.Text = "Expiry Date";
            // 
            // Quantity_lbl
            // 
            this.Quantity_lbl.AutoSize = true;
            this.Quantity_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Quantity_lbl.ForeColor = System.Drawing.Color.Black;
            this.Quantity_lbl.Location = new System.Drawing.Point(189, 165);
            this.Quantity_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity_lbl.Name = "Quantity_lbl";
            this.Quantity_lbl.Size = new System.Drawing.Size(74, 17);
            this.Quantity_lbl.TabIndex = 33;
            this.Quantity_lbl.Text = "Quantity";
            // 
            // MedID_lbl
            // 
            this.MedID_lbl.AutoSize = true;
            this.MedID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.MedID_lbl.ForeColor = System.Drawing.Color.Black;
            this.MedID_lbl.Location = new System.Drawing.Point(189, 95);
            this.MedID_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MedID_lbl.Name = "MedID_lbl";
            this.MedID_lbl.Size = new System.Drawing.Size(99, 17);
            this.MedID_lbl.TabIndex = 32;
            this.MedID_lbl.Text = "Medicine ID";
            // 
            // MedID_txt
            // 
            this.MedID_txt.Location = new System.Drawing.Point(292, 95);
            this.MedID_txt.Margin = new System.Windows.Forms.Padding(2);
            this.MedID_txt.Name = "MedID_txt";
            this.MedID_txt.Size = new System.Drawing.Size(198, 20);
            this.MedID_txt.TabIndex = 30;
            this.MedID_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedID_txt_KeyPress);
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(292, 282);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(198, 20);
            this.Price_txt.TabIndex = 29;
            this.Price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_txt_KeyPress);
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(292, 165);
            this.Quantity_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(198, 20);
            this.Quantity_txt.TabIndex = 28;
            this.Quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_txt_KeyPress);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(292, 24);
            this.Name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(198, 20);
            this.Name_txt.TabIndex = 27;
            this.Name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_txt_KeyPress);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(189, 25);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 17);
            this.Name_lbl.TabIndex = 26;
            this.Name_lbl.Text = "Name";
            // 
            // AddMedicine_btn
            // 
            this.AddMedicine_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedicine_btn.ForeColor = System.Drawing.Color.Black;
            this.AddMedicine_btn.Location = new System.Drawing.Point(226, 352);
            this.AddMedicine_btn.Name = "AddMedicine_btn";
            this.AddMedicine_btn.Size = new System.Drawing.Size(232, 41);
            this.AddMedicine_btn.TabIndex = 41;
            this.AddMedicine_btn.Text = "Add medicine";
            this.AddMedicine_btn.UseVisualStyleBackColor = true;
            // 
            // NameMsg_lbl
            // 
            this.NameMsg_lbl.AutoSize = true;
            this.NameMsg_lbl.ForeColor = System.Drawing.Color.Black;
            this.NameMsg_lbl.Location = new System.Drawing.Point(289, 57);
            this.NameMsg_lbl.Name = "NameMsg_lbl";
            this.NameMsg_lbl.Size = new System.Drawing.Size(211, 13);
            this.NameMsg_lbl.TabIndex = 42;
            this.NameMsg_lbl.Text = "Please, do not enter any special characters";
            this.NameMsg_lbl.Visible = false;
            // 
            // MedIDMsg_lbl
            // 
            this.MedIDMsg_lbl.AutoSize = true;
            this.MedIDMsg_lbl.ForeColor = System.Drawing.Color.Black;
            this.MedIDMsg_lbl.Location = new System.Drawing.Point(324, 128);
            this.MedIDMsg_lbl.Name = "MedIDMsg_lbl";
            this.MedIDMsg_lbl.Size = new System.Drawing.Size(134, 13);
            this.MedIDMsg_lbl.TabIndex = 43;
            this.MedIDMsg_lbl.Text = "Please, enter numbers only";
            this.MedIDMsg_lbl.Visible = false;
            // 
            // QuantityMsg_lbl
            // 
            this.QuantityMsg_lbl.AutoSize = true;
            this.QuantityMsg_lbl.ForeColor = System.Drawing.Color.Black;
            this.QuantityMsg_lbl.Location = new System.Drawing.Point(324, 198);
            this.QuantityMsg_lbl.Name = "QuantityMsg_lbl";
            this.QuantityMsg_lbl.Size = new System.Drawing.Size(134, 13);
            this.QuantityMsg_lbl.TabIndex = 44;
            this.QuantityMsg_lbl.Text = "Please, enter numbers only";
            this.QuantityMsg_lbl.Visible = false;
            // 
            // PriceMsg_lbl
            // 
            this.PriceMsg_lbl.AutoSize = true;
            this.PriceMsg_lbl.ForeColor = System.Drawing.Color.Black;
            this.PriceMsg_lbl.Location = new System.Drawing.Point(324, 313);
            this.PriceMsg_lbl.Name = "PriceMsg_lbl";
            this.PriceMsg_lbl.Size = new System.Drawing.Size(134, 13);
            this.PriceMsg_lbl.TabIndex = 45;
            this.PriceMsg_lbl.Text = "Please, enter numbers only";
            this.PriceMsg_lbl.Visible = false;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.PriceMsg_lbl);
            this.Controls.Add(this.QuantityMsg_lbl);
            this.Controls.Add(this.MedIDMsg_lbl);
            this.Controls.Add(this.NameMsg_lbl);
            this.Controls.Add(this.AddMedicine_btn);
            this.Controls.Add(this.Price_lbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ExpDate_lbl);
            this.Controls.Add(this.Quantity_lbl);
            this.Controls.Add(this.MedID_lbl);
            this.Controls.Add(this.MedID_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Name_lbl);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ExpDate_lbl;
        private System.Windows.Forms.Label Quantity_lbl;
        private System.Windows.Forms.Label MedID_lbl;
        private System.Windows.Forms.TextBox MedID_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Button AddMedicine_btn;
        private System.Windows.Forms.Label NameMsg_lbl;
        private System.Windows.Forms.Label MedIDMsg_lbl;
        private System.Windows.Forms.Label QuantityMsg_lbl;
        private System.Windows.Forms.Label PriceMsg_lbl;
    }
}