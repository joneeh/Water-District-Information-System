namespace Water_District_Information_System
{
    partial class waterDistrictInformationSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waterDistrictInformationSystem));
            this.mainMenuTabControls = new System.Windows.Forms.TabControl();
            this.clientAccountsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuTabControls.SuspendLayout();
            this.clientAccountsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuTabControls
            // 
            this.mainMenuTabControls.Controls.Add(this.clientAccountsTab);
            this.mainMenuTabControls.ImageList = this.iconList;
            this.mainMenuTabControls.Location = new System.Drawing.Point(0, 60);
            this.mainMenuTabControls.Margin = new System.Windows.Forms.Padding(10);
            this.mainMenuTabControls.Name = "mainMenuTabControls";
            this.mainMenuTabControls.Padding = new System.Drawing.Point(10, 7);
            this.mainMenuTabControls.SelectedIndex = 0;
            this.mainMenuTabControls.Size = new System.Drawing.Size(986, 502);
            this.mainMenuTabControls.TabIndex = 0;
            // 
            // clientAccountsTab
            // 
            this.clientAccountsTab.Controls.Add(this.splitContainer1);
            this.clientAccountsTab.ImageIndex = 0;
            this.clientAccountsTab.Location = new System.Drawing.Point(4, 30);
            this.clientAccountsTab.Name = "clientAccountsTab";
            this.clientAccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientAccountsTab.Size = new System.Drawing.Size(978, 468);
            this.clientAccountsTab.TabIndex = 0;
            this.clientAccountsTab.Text = "Client Accounts";
            this.clientAccountsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(972, 462);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "users.png");
            this.iconList.Images.SetKeyName(1, "settings.png");
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Water_District_Information_System.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // waterDistrictInformationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainMenuTabControls);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "waterDistrictInformationSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water District Information System | WDIS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.waterDistrictInformationSystem_FormClosed);
            this.mainMenuTabControls.ResumeLayout(false);
            this.clientAccountsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainMenuTabControls;
        private System.Windows.Forms.TabPage clientAccountsTab;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

