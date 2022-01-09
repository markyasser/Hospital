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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Serve_btn = new FontAwesome.Sharp.IconButton();
            this.AskMedicine_btn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.Settings_iconButton = new FontAwesome.Sharp.IconButton();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.SideMenu.Controls.Add(this.Settings_iconButton);
            this.SideMenu.Controls.Add(this.Serve_btn);
            this.SideMenu.Controls.Add(this.AskMedicine_btn);
            this.SideMenu.Controls.Add(this.Logo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(193, 554);
            this.SideMenu.TabIndex = 0;
            this.SideMenu.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // Serve_btn
            // 
            this.Serve_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Serve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Serve_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serve_btn.ForeColor = System.Drawing.Color.White;
            this.Serve_btn.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.Serve_btn.IconColor = System.Drawing.Color.Black;
            this.Serve_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Serve_btn.IconSize = 30;
            this.Serve_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Serve_btn.Location = new System.Drawing.Point(0, 149);
            this.Serve_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serve_btn.Name = "Serve_btn";
            this.Serve_btn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Serve_btn.Size = new System.Drawing.Size(193, 69);
            this.Serve_btn.TabIndex = 3;
            this.Serve_btn.Text = "Serve";
            this.Serve_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Serve_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Serve_btn.UseVisualStyleBackColor = true;
            this.Serve_btn.Click += new System.EventHandler(this.Serve_btn_Click);
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
            this.AskMedicine_btn.Location = new System.Drawing.Point(0, 80);
            this.AskMedicine_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AskMedicine_btn.Name = "AskMedicine_btn";
            this.AskMedicine_btn.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.AskMedicine_btn.Size = new System.Drawing.Size(193, 69);
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
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(193, 80);
            this.Logo.TabIndex = 0;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // ChildPanel
            // 
            this.ChildPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ChildPanel.Location = new System.Drawing.Point(193, 0);
            this.ChildPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(874, 554);
            this.ChildPanel.TabIndex = 1;
            // 
            // Settings_iconButton
            // 
            this.Settings_iconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.Settings_iconButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings_iconButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_iconButton.ForeColor = System.Drawing.Color.White;
            this.Settings_iconButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.Settings_iconButton.IconColor = System.Drawing.Color.Black;
            this.Settings_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings_iconButton.IconSize = 30;
            this.Settings_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_iconButton.Location = new System.Drawing.Point(0, 485);
            this.Settings_iconButton.Margin = new System.Windows.Forms.Padding(4);
            this.Settings_iconButton.Name = "Settings_iconButton";
            this.Settings_iconButton.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Settings_iconButton.Size = new System.Drawing.Size(193, 69);
            this.Settings_iconButton.TabIndex = 6;
            this.Settings_iconButton.Text = "Settings";
            this.Settings_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings_iconButton.UseVisualStyleBackColor = false;
            this.Settings_iconButton.Click += new System.EventHandler(this.Settings_iconButton_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.SideMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nurse_FormClosing);
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideMenu;
        private FontAwesome.Sharp.IconButton Serve_btn;
        private FontAwesome.Sharp.IconButton AskMedicine_btn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel ChildPanel;
        private FontAwesome.Sharp.IconButton Settings_iconButton;
    }
}