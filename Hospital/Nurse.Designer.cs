namespace Hospital
{
    partial class Nurse
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
            this.SideMenu = new System.Windows.Forms.Panel();
            this.MedicalTest_btn = new FontAwesome.Sharp.IconButton();
            this.AskMedicine_btn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.SideMenu.Controls.Add(this.MedicalTest_btn);
            this.SideMenu.Controls.Add(this.AskMedicine_btn);
            this.SideMenu.Controls.Add(this.Logo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(145, 450);
            this.SideMenu.TabIndex = 0;
            // 
            // MedicalTest_btn
            // 
            this.MedicalTest_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MedicalTest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MedicalTest_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalTest_btn.ForeColor = System.Drawing.Color.White;
            this.MedicalTest_btn.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.MedicalTest_btn.IconColor = System.Drawing.Color.Black;
            this.MedicalTest_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MedicalTest_btn.IconSize = 30;
            this.MedicalTest_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedicalTest_btn.Location = new System.Drawing.Point(0, 121);
            this.MedicalTest_btn.Name = "MedicalTest_btn";
            this.MedicalTest_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MedicalTest_btn.Size = new System.Drawing.Size(145, 56);
            this.MedicalTest_btn.TabIndex = 3;
            this.MedicalTest_btn.Text = "Medical test";
            this.MedicalTest_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedicalTest_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MedicalTest_btn.UseVisualStyleBackColor = true;
            this.MedicalTest_btn.Click += new System.EventHandler(this.MedicalTest_btn_Click);
            // 
            // AskMedicine_btn
            // 
            this.AskMedicine_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AskMedicine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AskMedicine_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskMedicine_btn.ForeColor = System.Drawing.Color.White;
            this.AskMedicine_btn.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.AskMedicine_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.AskMedicine_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AskMedicine_btn.IconSize = 30;
            this.AskMedicine_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AskMedicine_btn.Location = new System.Drawing.Point(0, 65);
            this.AskMedicine_btn.Name = "AskMedicine_btn";
            this.AskMedicine_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AskMedicine_btn.Size = new System.Drawing.Size(145, 56);
            this.AskMedicine_btn.TabIndex = 1;
            this.AskMedicine_btn.Text = "Ask for a medicine";
            this.AskMedicine_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AskMedicine_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AskMedicine_btn.UseVisualStyleBackColor = true;
            this.AskMedicine_btn.Click += new System.EventHandler(this.AskMedicine_btn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(145, 65);
            this.Logo.TabIndex = 0;
            // 
            // ChildPanel
            // 
            this.ChildPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChildPanel.Location = new System.Drawing.Point(145, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(655, 450);
            this.ChildPanel.TabIndex = 1;
            this.ChildPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildPanel_Paint);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.SideMenu);
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideMenu;
        private FontAwesome.Sharp.IconButton MedicalTest_btn;
        private FontAwesome.Sharp.IconButton AskMedicine_btn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel ChildPanel;
    }
}