namespace Hospital
{
    partial class Serve
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
            this.Serve_btn = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.ID_cmb = new System.Windows.Forms.ComboBox();
            this.RoomNumber_cmb = new System.Windows.Forms.ComboBox();
            this.Serve_gb = new System.Windows.Forms.GroupBox();
            this.DontServe_gb = new System.Windows.Forms.GroupBox();
            this.DontName_txt = new System.Windows.Forms.TextBox();
            this.DontRoomNumber_cmb = new System.Windows.Forms.ComboBox();
            this.DontID_cmb = new System.Windows.Forms.ComboBox();
            this.DontServe_btn = new System.Windows.Forms.Button();
            this.DontID_lbl = new System.Windows.Forms.Label();
            this.DontName_lbl = new System.Windows.Forms.Label();
            this.DontRoomNumber_lbl = new System.Windows.Forms.Label();
            this.Serve_gb.SuspendLayout();
            this.DontServe_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serve_btn
            // 
            this.Serve_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Serve_btn.ForeColor = System.Drawing.Color.Black;
            this.Serve_btn.Location = new System.Drawing.Point(53, 173);
            this.Serve_btn.Name = "Serve_btn";
            this.Serve_btn.Size = new System.Drawing.Size(187, 38);
            this.Serve_btn.TabIndex = 33;
            this.Serve_btn.Text = "Serve";
            this.Serve_btn.UseVisualStyleBackColor = true;
            this.Serve_btn.Click += new System.EventHandler(this.Serve_btn_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_txt.Location = new System.Drawing.Point(83, 73);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.ReadOnly = true;
            this.Name_txt.Size = new System.Drawing.Size(190, 24);
            this.Name_txt.TabIndex = 30;
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.RoomNo_lbl.ForeColor = System.Drawing.Color.Black;
            this.RoomNo_lbl.Location = new System.Drawing.Point(12, 132);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(65, 17);
            this.RoomNo_lbl.TabIndex = 29;
            this.RoomNo_lbl.Text = "Room#";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(26, 76);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 17);
            this.Name_lbl.TabIndex = 28;
            this.Name_lbl.Text = "Name";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.ID_lbl.ForeColor = System.Drawing.Color.Black;
            this.ID_lbl.Location = new System.Drawing.Point(50, 21);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(27, 17);
            this.ID_lbl.TabIndex = 27;
            this.ID_lbl.Text = "ID";
            // 
            // ID_cmb
            // 
            this.ID_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.ID_cmb.FormattingEnabled = true;
            this.ID_cmb.Location = new System.Drawing.Point(83, 18);
            this.ID_cmb.Name = "ID_cmb";
            this.ID_cmb.Size = new System.Drawing.Size(190, 24);
            this.ID_cmb.TabIndex = 26;
            this.ID_cmb.TextChanged += new System.EventHandler(this.ID_cmb_TextChanged);
            // 
            // RoomNumber_cmb
            // 
            this.RoomNumber_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.RoomNumber_cmb.FormattingEnabled = true;
            this.RoomNumber_cmb.Location = new System.Drawing.Point(83, 129);
            this.RoomNumber_cmb.Name = "RoomNumber_cmb";
            this.RoomNumber_cmb.Size = new System.Drawing.Size(190, 24);
            this.RoomNumber_cmb.TabIndex = 34;
            // 
            // Serve_gb
            // 
            this.Serve_gb.Controls.Add(this.Name_txt);
            this.Serve_gb.Controls.Add(this.RoomNumber_cmb);
            this.Serve_gb.Controls.Add(this.ID_cmb);
            this.Serve_gb.Controls.Add(this.Serve_btn);
            this.Serve_gb.Controls.Add(this.ID_lbl);
            this.Serve_gb.Controls.Add(this.Name_lbl);
            this.Serve_gb.Controls.Add(this.RoomNo_lbl);
            this.Serve_gb.Location = new System.Drawing.Point(39, 55);
            this.Serve_gb.Name = "Serve_gb";
            this.Serve_gb.Size = new System.Drawing.Size(288, 246);
            this.Serve_gb.TabIndex = 35;
            this.Serve_gb.TabStop = false;
            this.Serve_gb.Text = "Serve";
            this.Serve_gb.Enter += new System.EventHandler(this.Serve_gb_Enter);
            // 
            // DontServe_gb
            // 
            this.DontServe_gb.Controls.Add(this.DontName_txt);
            this.DontServe_gb.Controls.Add(this.DontRoomNumber_cmb);
            this.DontServe_gb.Controls.Add(this.DontID_cmb);
            this.DontServe_gb.Controls.Add(this.DontServe_btn);
            this.DontServe_gb.Controls.Add(this.DontID_lbl);
            this.DontServe_gb.Controls.Add(this.DontName_lbl);
            this.DontServe_gb.Controls.Add(this.DontRoomNumber_lbl);
            this.DontServe_gb.Location = new System.Drawing.Point(342, 55);
            this.DontServe_gb.Name = "DontServe_gb";
            this.DontServe_gb.Size = new System.Drawing.Size(288, 246);
            this.DontServe_gb.TabIndex = 36;
            this.DontServe_gb.TabStop = false;
            this.DontServe_gb.Text = "DontServe";
            // 
            // DontName_txt
            // 
            this.DontName_txt.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontName_txt.Location = new System.Drawing.Point(82, 77);
            this.DontName_txt.Name = "DontName_txt";
            this.DontName_txt.ReadOnly = true;
            this.DontName_txt.Size = new System.Drawing.Size(190, 24);
            this.DontName_txt.TabIndex = 30;
            // 
            // DontRoomNumber_cmb
            // 
            this.DontRoomNumber_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontRoomNumber_cmb.FormattingEnabled = true;
            this.DontRoomNumber_cmb.Location = new System.Drawing.Point(82, 133);
            this.DontRoomNumber_cmb.Name = "DontRoomNumber_cmb";
            this.DontRoomNumber_cmb.Size = new System.Drawing.Size(190, 24);
            this.DontRoomNumber_cmb.TabIndex = 34;
            // 
            // DontID_cmb
            // 
            this.DontID_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontID_cmb.FormattingEnabled = true;
            this.DontID_cmb.Location = new System.Drawing.Point(82, 22);
            this.DontID_cmb.Name = "DontID_cmb";
            this.DontID_cmb.Size = new System.Drawing.Size(190, 24);
            this.DontID_cmb.TabIndex = 26;
            this.DontID_cmb.TextChanged += new System.EventHandler(this.DontID_cmb_TextChanged);
            // 
            // DontServe_btn
            // 
            this.DontServe_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontServe_btn.ForeColor = System.Drawing.Color.Black;
            this.DontServe_btn.Location = new System.Drawing.Point(62, 177);
            this.DontServe_btn.Name = "DontServe_btn";
            this.DontServe_btn.Size = new System.Drawing.Size(187, 38);
            this.DontServe_btn.TabIndex = 33;
            this.DontServe_btn.Text = "Don\'t Serve";
            this.DontServe_btn.UseVisualStyleBackColor = true;
            this.DontServe_btn.Click += new System.EventHandler(this.DontServe_btn_Click);
            // 
            // DontID_lbl
            // 
            this.DontID_lbl.AutoSize = true;
            this.DontID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontID_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontID_lbl.Location = new System.Drawing.Point(49, 25);
            this.DontID_lbl.Name = "DontID_lbl";
            this.DontID_lbl.Size = new System.Drawing.Size(27, 17);
            this.DontID_lbl.TabIndex = 27;
            this.DontID_lbl.Text = "ID";
            // 
            // DontName_lbl
            // 
            this.DontName_lbl.AutoSize = true;
            this.DontName_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontName_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontName_lbl.Location = new System.Drawing.Point(25, 80);
            this.DontName_lbl.Name = "DontName_lbl";
            this.DontName_lbl.Size = new System.Drawing.Size(51, 17);
            this.DontName_lbl.TabIndex = 28;
            this.DontName_lbl.Text = "Name";
            // 
            // DontRoomNumber_lbl
            // 
            this.DontRoomNumber_lbl.AutoSize = true;
            this.DontRoomNumber_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontRoomNumber_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontRoomNumber_lbl.Location = new System.Drawing.Point(11, 136);
            this.DontRoomNumber_lbl.Name = "DontRoomNumber_lbl";
            this.DontRoomNumber_lbl.Size = new System.Drawing.Size(65, 17);
            this.DontRoomNumber_lbl.TabIndex = 29;
            this.DontRoomNumber_lbl.Text = "Room#";
            // 
            // Serve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DontServe_gb);
            this.Controls.Add(this.Serve_gb);
            this.Name = "Serve";
            this.Text = "Serve";
            this.Load += new System.EventHandler(this.Serve_Load);
            this.Serve_gb.ResumeLayout(false);
            this.Serve_gb.PerformLayout();
            this.DontServe_gb.ResumeLayout(false);
            this.DontServe_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Serve_btn;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label RoomNo_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.ComboBox ID_cmb;
        private System.Windows.Forms.ComboBox RoomNumber_cmb;
        private System.Windows.Forms.GroupBox Serve_gb;
        private System.Windows.Forms.GroupBox DontServe_gb;
        private System.Windows.Forms.TextBox DontName_txt;
        private System.Windows.Forms.ComboBox DontRoomNumber_cmb;
        private System.Windows.Forms.ComboBox DontID_cmb;
        private System.Windows.Forms.Button DontServe_btn;
        private System.Windows.Forms.Label DontID_lbl;
        private System.Windows.Forms.Label DontName_lbl;
        private System.Windows.Forms.Label DontRoomNumber_lbl;
    }
}