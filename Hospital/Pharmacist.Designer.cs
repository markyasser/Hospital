
namespace Hospital
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Statistics_btn = new FontAwesome.Sharp.IconButton();
            this.Sell_btn = new FontAwesome.Sharp.IconButton();
            this.SetPrice_btn = new FontAwesome.Sharp.IconButton();
            this.AddMedicine_btn = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.Panel();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.SideMenu.Controls.Add(this.Statistics_btn);
            this.SideMenu.Controls.Add(this.Sell_btn);
            this.SideMenu.Controls.Add(this.SetPrice_btn);
            this.SideMenu.Controls.Add(this.AddMedicine_btn);
            this.SideMenu.Controls.Add(this.Logo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(145, 450);
            this.SideMenu.TabIndex = 0;
            this.SideMenu.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // Statistics_btn
            // 
            this.Statistics_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.Statistics_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Statistics_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics_btn.ForeColor = System.Drawing.Color.White;
            this.Statistics_btn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Statistics_btn.IconColor = System.Drawing.Color.Black;
            this.Statistics_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Statistics_btn.IconSize = 30;
            this.Statistics_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_btn.Location = new System.Drawing.Point(0, 233);
            this.Statistics_btn.Name = "Statistics_btn";
            this.Statistics_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Statistics_btn.Size = new System.Drawing.Size(145, 56);
            this.Statistics_btn.TabIndex = 4;
            this.Statistics_btn.Text = "Statistics";
            this.Statistics_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Statistics_btn.UseVisualStyleBackColor = false;
            this.Statistics_btn.Click += new System.EventHandler(this.Statistics_btn_Click);
            // 
            // Sell_btn
            // 
            this.Sell_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.Sell_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sell_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sell_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_btn.ForeColor = System.Drawing.Color.White;
            this.Sell_btn.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.Sell_btn.IconColor = System.Drawing.Color.Black;
            this.Sell_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Sell_btn.IconSize = 30;
            this.Sell_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sell_btn.Location = new System.Drawing.Point(0, 177);
            this.Sell_btn.Name = "Sell_btn";
            this.Sell_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Sell_btn.Size = new System.Drawing.Size(145, 56);
            this.Sell_btn.TabIndex = 3;
            this.Sell_btn.Text = "Sell";
            this.Sell_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sell_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sell_btn.UseVisualStyleBackColor = false;
            this.Sell_btn.Click += new System.EventHandler(this.Sell_btn_Click);
            // 
            // SetPrice_btn
            // 
            this.SetPrice_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetPrice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetPrice_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPrice_btn.ForeColor = System.Drawing.Color.White;
            this.SetPrice_btn.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.SetPrice_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(204)))), ((int)(((byte)(23)))));
            this.SetPrice_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SetPrice_btn.IconSize = 30;
            this.SetPrice_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetPrice_btn.Location = new System.Drawing.Point(0, 121);
            this.SetPrice_btn.Name = "SetPrice_btn";
            this.SetPrice_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SetPrice_btn.Size = new System.Drawing.Size(145, 56);
            this.SetPrice_btn.TabIndex = 2;
            this.SetPrice_btn.Text = "Set Price";
            this.SetPrice_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetPrice_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SetPrice_btn.UseVisualStyleBackColor = true;
            this.SetPrice_btn.Click += new System.EventHandler(this.SetPrice_btn_Click);
            // 
            // AddMedicine_btn
            // 
            this.AddMedicine_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddMedicine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddMedicine_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedicine_btn.ForeColor = System.Drawing.Color.White;
            this.AddMedicine_btn.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.AddMedicine_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.AddMedicine_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddMedicine_btn.IconSize = 30;
            this.AddMedicine_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMedicine_btn.Location = new System.Drawing.Point(0, 65);
            this.AddMedicine_btn.Name = "AddMedicine_btn";
            this.AddMedicine_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AddMedicine_btn.Size = new System.Drawing.Size(145, 56);
            this.AddMedicine_btn.TabIndex = 1;
            this.AddMedicine_btn.Text = "Add medicine";
            this.AddMedicine_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMedicine_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddMedicine_btn.UseVisualStyleBackColor = true;
            this.AddMedicine_btn.Click += new System.EventHandler(this.AddMedicine_btn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(145, 65);
            this.Logo.TabIndex = 0;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.SideMenu);
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideMenu;
        private FontAwesome.Sharp.IconButton Sell_btn;
        private FontAwesome.Sharp.IconButton SetPrice_btn;
        private FontAwesome.Sharp.IconButton AddMedicine_btn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel ChildPanel;
        private FontAwesome.Sharp.IconButton Statistics_btn;
    }
}