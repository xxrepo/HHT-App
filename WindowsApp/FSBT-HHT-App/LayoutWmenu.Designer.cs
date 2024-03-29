﻿namespace FSBT.HHT.App
{
    partial class LayoutWmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutWmenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.DownloadMasterForm = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationManagementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.BarcodePrintForm = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncHhtForm = new System.Windows.Forms.ToolStripMenuItem();
            this.EditQuantityForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TextFileForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportPrintForm = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupRestoreForm = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManagementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGroupManagementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.FujitsuLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusDatabase,
            this.toolStripStatusUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1008);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1637, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1352, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // toolStripStatusDatabase
            // 
            this.toolStripStatusDatabase.Name = "toolStripStatusDatabase";
            this.toolStripStatusDatabase.Size = new System.Drawing.Size(221, 25);
            this.toolStripStatusDatabase.Text = "Connected to {0} database";
            // 
            // toolStripStatusUsername
            // 
            this.toolStripStatusUsername.Name = "toolStripStatusUsername";
            this.toolStripStatusUsername.Size = new System.Drawing.Size(41, 25);
            this.toolStripStatusUsername.Text = ": {0}";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadMasterForm,
            this.LocationManagementForm,
            this.BarcodePrintForm,
            this.SyncHhtForm,
            this.EditQuantityForm,
            this.TextFileForm,
            this.ReportPrintForm,
            this.BackupRestoreForm,
            this.UserManagementForm,
            this.UserGroupManagementForm,
            this.SettingsForm,
            this.ExitForm,
            this.FujitsuLogo});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.MainMenuStrip.Size = new System.Drawing.Size(1637, 69);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            this.MainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenuStrip_ItemClicked);
            // 
            // DownloadMasterForm
            // 
            this.DownloadMasterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadMasterForm.Image = ((System.Drawing.Image)(resources.GetObject("DownloadMasterForm.Image")));
            this.DownloadMasterForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DownloadMasterForm.Name = "DownloadMasterForm";
            this.DownloadMasterForm.Size = new System.Drawing.Size(193, 63);
            this.DownloadMasterForm.Text = "Download AS400";
            this.DownloadMasterForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DownloadMasterForm.Click += new System.EventHandler(this.DownloadMasterForm_Click);
            // 
            // LocationManagementForm
            // 
            this.LocationManagementForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationManagementForm.Image = ((System.Drawing.Image)(resources.GetObject("LocationManagementForm.Image")));
            this.LocationManagementForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LocationManagementForm.Name = "LocationManagementForm";
            this.LocationManagementForm.Size = new System.Drawing.Size(106, 63);
            this.LocationManagementForm.Text = "Location";
            this.LocationManagementForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LocationManagementForm.Click += new System.EventHandler(this.LocationManagementForm_Click);
            // 
            // BarcodePrintForm
            // 
            this.BarcodePrintForm.CheckOnClick = true;
            this.BarcodePrintForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodePrintForm.Image = ((System.Drawing.Image)(resources.GetObject("BarcodePrintForm.Image")));
            this.BarcodePrintForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BarcodePrintForm.Name = "BarcodePrintForm";
            this.BarcodePrintForm.Size = new System.Drawing.Size(105, 63);
            this.BarcodePrintForm.Text = "Barcode";
            this.BarcodePrintForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BarcodePrintForm.Click += new System.EventHandler(this.BarcodePrintForm_Click);
            // 
            // SyncHhtForm
            // 
            this.SyncHhtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncHhtForm.Image = ((System.Drawing.Image)(resources.GetObject("SyncHhtForm.Image")));
            this.SyncHhtForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SyncHhtForm.Name = "SyncHhtForm";
            this.SyncHhtForm.Size = new System.Drawing.Size(171, 63);
            this.SyncHhtForm.Text = "Download HHT";
            this.SyncHhtForm.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.SyncHhtForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SyncHhtForm.Click += new System.EventHandler(this.SyncHhtForm_Click);
            // 
            // EditQuantityForm
            // 
            this.EditQuantityForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditQuantityForm.Image = ((System.Drawing.Image)(resources.GetObject("EditQuantityForm.Image")));
            this.EditQuantityForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditQuantityForm.Name = "EditQuantityForm";
            this.EditQuantityForm.Size = new System.Drawing.Size(202, 63);
            this.EditQuantityForm.Text = "QTY Management";
            this.EditQuantityForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditQuantityForm.Click += new System.EventHandler(this.EditQuantityForm_Click);
            // 
            // TextFileForm
            // 
            this.TextFileForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFileForm.Image = ((System.Drawing.Image)(resources.GetObject("TextFileForm.Image")));
            this.TextFileForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TextFileForm.Name = "TextFileForm";
            this.TextFileForm.Size = new System.Drawing.Size(106, 63);
            this.TextFileForm.Text = "Text File";
            this.TextFileForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TextFileForm.Click += new System.EventHandler(this.TextFileForm_Click);
            // 
            // ReportPrintForm
            // 
            this.ReportPrintForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPrintForm.Image = ((System.Drawing.Image)(resources.GetObject("ReportPrintForm.Image")));
            this.ReportPrintForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportPrintForm.Name = "ReportPrintForm";
            this.ReportPrintForm.Size = new System.Drawing.Size(89, 63);
            this.ReportPrintForm.Text = "Report";
            this.ReportPrintForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReportPrintForm.Click += new System.EventHandler(this.ReportPrintForm_Click);
            // 
            // BackupRestoreForm
            // 
            this.BackupRestoreForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupRestoreForm.Image = ((System.Drawing.Image)(resources.GetObject("BackupRestoreForm.Image")));
            this.BackupRestoreForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BackupRestoreForm.Name = "BackupRestoreForm";
            this.BackupRestoreForm.Size = new System.Drawing.Size(97, 63);
            this.BackupRestoreForm.Text = "Backup";
            this.BackupRestoreForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BackupRestoreForm.Click += new System.EventHandler(this.BackupRestoreForm_Click);
            // 
            // UserManagementForm
            // 
            this.UserManagementForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagementForm.Image = ((System.Drawing.Image)(resources.GetObject("UserManagementForm.Image")));
            this.UserManagementForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserManagementForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserManagementForm.Name = "UserManagementForm";
            this.UserManagementForm.Size = new System.Drawing.Size(81, 63);
            this.UserManagementForm.Text = "Users";
            this.UserManagementForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UserManagementForm.Click += new System.EventHandler(this.UserManagementForm_Click);
            // 
            // UserGroupManagementForm
            // 
            this.UserGroupManagementForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupManagementForm.Image = ((System.Drawing.Image)(resources.GetObject("UserGroupManagementForm.Image")));
            this.UserGroupManagementForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserGroupManagementForm.Name = "UserGroupManagementForm";
            this.UserGroupManagementForm.Size = new System.Drawing.Size(133, 63);
            this.UserGroupManagementForm.Text = "Permission";
            this.UserGroupManagementForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UserGroupManagementForm.Click += new System.EventHandler(this.UserGroupManagementForm_Click);
            // 
            // SettingsForm
            // 
            this.SettingsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsForm.Image = ((System.Drawing.Image)(resources.GetObject("SettingsForm.Image")));
            this.SettingsForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsForm.Name = "SettingsForm";
            this.SettingsForm.Size = new System.Drawing.Size(103, 63);
            this.SettingsForm.Text = "Settings";
            this.SettingsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingsForm.Click += new System.EventHandler(this.SettingsForm_Click);
            // 
            // ExitForm
            // 
            this.ExitForm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitForm.Image = ((System.Drawing.Image)(resources.GetObject("ExitForm.Image")));
            this.ExitForm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitForm.Name = "ExitForm";
            this.ExitForm.Size = new System.Drawing.Size(61, 63);
            this.ExitForm.Text = "Exit";
            this.ExitForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitForm.Click += new System.EventHandler(this.ExitForm_Click);
            // 
            // FujitsuLogo
            // 
            this.FujitsuLogo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FujitsuLogo.Image = global::FSBT.HHT.App.Properties.Resources.rsz_fujitsu_logosvg;
            this.FujitsuLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FujitsuLogo.Name = "FujitsuLogo";
            this.FujitsuLogo.Size = new System.Drawing.Size(137, 63);
            this.FujitsuLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // LayoutWmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1637, 1038);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(1525, 1018);
            this.Name = "LayoutWmenu";
            this.Text = "Stocktaking V 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LayoutWmenu_FormClosed);
            this.Load += new System.EventHandler(this.LayoutWmenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LocationManagementForm;
        private System.Windows.Forms.ToolStripMenuItem BarcodePrintForm;
        private System.Windows.Forms.ToolStripMenuItem EditQuantityForm;
        private System.Windows.Forms.ToolStripMenuItem DownloadMasterForm;
        private System.Windows.Forms.ToolStripMenuItem TextFileForm;
        private System.Windows.Forms.ToolStripMenuItem ReportPrintForm;
        private System.Windows.Forms.ToolStripMenuItem SettingsForm;
        private System.Windows.Forms.ToolStripMenuItem ExitForm;
        private System.Windows.Forms.ToolStripMenuItem SyncHhtForm;
        private System.Windows.Forms.ToolStripMenuItem BackupRestoreForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDatabase;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUsername;
        private System.Windows.Forms.ToolStripMenuItem UserGroupManagementForm;
        private System.Windows.Forms.ToolStripMenuItem UserManagementForm;
        private System.Windows.Forms.ToolStripMenuItem FujitsuLogo;



    }
}
