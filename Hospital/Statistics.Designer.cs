namespace Hospital
{
    partial class Statistics
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
            this.Expired_btn = new System.Windows.Forms.Button();
            this.Valid_btn = new System.Windows.Forms.Button();
            this.Empty_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Expired_btn
            // 
            this.Expired_btn.ForeColor = System.Drawing.Color.Black;
            this.Expired_btn.Location = new System.Drawing.Point(54, 54);
            this.Expired_btn.Name = "Expired_btn";
            this.Expired_btn.Size = new System.Drawing.Size(146, 38);
            this.Expired_btn.TabIndex = 0;
            this.Expired_btn.Text = "Expired Medicines";
            this.Expired_btn.UseVisualStyleBackColor = true;
            this.Expired_btn.Click += new System.EventHandler(this.Expired_btn_Click);
            // 
            // Valid_btn
            // 
            this.Valid_btn.ForeColor = System.Drawing.Color.Black;
            this.Valid_btn.Location = new System.Drawing.Point(265, 54);
            this.Valid_btn.Name = "Valid_btn";
            this.Valid_btn.Size = new System.Drawing.Size(146, 38);
            this.Valid_btn.TabIndex = 1;
            this.Valid_btn.Text = "Valid Medicines";
            this.Valid_btn.UseVisualStyleBackColor = true;
            this.Valid_btn.Click += new System.EventHandler(this.Valid_btn_Click);
            // 
            // Empty_btn
            // 
            this.Empty_btn.ForeColor = System.Drawing.Color.Black;
            this.Empty_btn.Location = new System.Drawing.Point(471, 54);
            this.Empty_btn.Name = "Empty_btn";
            this.Empty_btn.Size = new System.Drawing.Size(146, 38);
            this.Empty_btn.TabIndex = 2;
            this.Empty_btn.Text = "Medicines we need";
            this.Empty_btn.UseVisualStyleBackColor = true;
            this.Empty_btn.Click += new System.EventHandler(this.Empty_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 107);
            this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 250);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Empty_btn);
            this.Controls.Add(this.Valid_btn);
            this.Controls.Add(this.Expired_btn);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Expired_btn;
        private System.Windows.Forms.Button Valid_btn;
        private System.Windows.Forms.Button Empty_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}