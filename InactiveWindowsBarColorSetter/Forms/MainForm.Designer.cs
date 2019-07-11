namespace RegistryUtils
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windowsColorDialog = new System.Windows.Forms.ColorDialog();
            this.winColorPaletteBtn = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.colorBarRed = new System.Windows.Forms.Panel();
            this.colorBarGreen = new System.Windows.Forms.Panel();
            this.colorBarBlue = new System.Windows.Forms.Panel();
            this.restoreDefaultBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.autoBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentActiveAccentColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentInactiveAccentColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInactiveAccentColorAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentAccentColorsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // winColorPaletteBtn
            // 
            resources.ApplyResources(this.winColorPaletteBtn, "winColorPaletteBtn");
            this.winColorPaletteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.winColorPaletteBtn.Name = "winColorPaletteBtn";
            this.winColorPaletteBtn.UseVisualStyleBackColor = false;
            this.winColorPaletteBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // trackBarRed
            // 
            resources.ApplyResources(this.trackBarRed, "trackBarRed");
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Value = 255;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            resources.ApplyResources(this.trackBarGreen, "trackBarGreen");
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Value = 255;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            resources.ApplyResources(this.trackBarBlue, "trackBarBlue");
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Value = 255;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // textBoxRed
            // 
            resources.ApplyResources(this.textBoxRed, "textBoxRed");
            this.textBoxRed.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRed.ForeColor = System.Drawing.Color.Red;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            this.textBoxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxRed.Leave += new System.EventHandler(this.textBoxRed_Leave);
            // 
            // textBoxGreen
            // 
            resources.ApplyResources(this.textBoxGreen, "textBoxGreen");
            this.textBoxGreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxGreen.ForeColor = System.Drawing.Color.Green;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxGreen.Leave += new System.EventHandler(this.textBoxGreen_Leave);
            // 
            // textBoxBlue
            // 
            resources.ApplyResources(this.textBoxBlue, "textBoxBlue");
            this.textBoxBlue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBlue.ForeColor = System.Drawing.Color.Blue;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxBlue.Leave += new System.EventHandler(this.textBoxBlue_Leave);
            // 
            // textBoxHash
            // 
            resources.ApplyResources(this.textBoxHash, "textBoxHash");
            this.textBoxHash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.TextChanged += new System.EventHandler(this.textBoxHash_TextChanged);
            this.textBoxHash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHash_KeyPress);
            // 
            // colorBarRed
            // 
            resources.ApplyResources(this.colorBarRed, "colorBarRed");
            this.colorBarRed.BackColor = System.Drawing.Color.Red;
            this.colorBarRed.Name = "colorBarRed";
            // 
            // colorBarGreen
            // 
            resources.ApplyResources(this.colorBarGreen, "colorBarGreen");
            this.colorBarGreen.BackColor = System.Drawing.Color.Lime;
            this.colorBarGreen.Name = "colorBarGreen";
            // 
            // colorBarBlue
            // 
            resources.ApplyResources(this.colorBarBlue, "colorBarBlue");
            this.colorBarBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBarBlue.Name = "colorBarBlue";
            // 
            // restoreDefaultBtn
            // 
            resources.ApplyResources(this.restoreDefaultBtn, "restoreDefaultBtn");
            this.restoreDefaultBtn.BackColor = System.Drawing.Color.White;
            this.restoreDefaultBtn.Name = "restoreDefaultBtn";
            this.restoreDefaultBtn.UseVisualStyleBackColor = false;
            this.restoreDefaultBtn.Click += new System.EventHandler(this.restoreDefaultBtn_Click);
            // 
            // submitBtn
            // 
            resources.ApplyResources(this.submitBtn, "submitBtn");
            this.submitBtn.BackColor = System.Drawing.Color.White;
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.restoreDefaultBtn, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // autoBtn
            // 
            resources.ApplyResources(this.autoBtn, "autoBtn");
            this.autoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.UseVisualStyleBackColor = false;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromRegistryToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveInactiveAccentColorAsToolStripMenuItem,
            this.saveCurrentAccentColorsAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // importFromRegistryToolStripMenuItem
            // 
            resources.ApplyResources(this.importFromRegistryToolStripMenuItem, "importFromRegistryToolStripMenuItem");
            this.importFromRegistryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentActiveAccentColorToolStripMenuItem,
            this.currentInactiveAccentColorToolStripMenuItem});
            this.importFromRegistryToolStripMenuItem.Name = "importFromRegistryToolStripMenuItem";
            // 
            // currentActiveAccentColorToolStripMenuItem
            // 
            resources.ApplyResources(this.currentActiveAccentColorToolStripMenuItem, "currentActiveAccentColorToolStripMenuItem");
            this.currentActiveAccentColorToolStripMenuItem.Name = "currentActiveAccentColorToolStripMenuItem";
            this.currentActiveAccentColorToolStripMenuItem.Click += new System.EventHandler(this.currentActiveAccentColorToolStripMenuItem_Click);
            // 
            // currentInactiveAccentColorToolStripMenuItem
            // 
            resources.ApplyResources(this.currentInactiveAccentColorToolStripMenuItem, "currentInactiveAccentColorToolStripMenuItem");
            this.currentInactiveAccentColorToolStripMenuItem.Name = "currentInactiveAccentColorToolStripMenuItem";
            this.currentInactiveAccentColorToolStripMenuItem.Click += new System.EventHandler(this.currentInactiveAccentColorToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveInactiveAccentColorAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveInactiveAccentColorAsToolStripMenuItem, "saveInactiveAccentColorAsToolStripMenuItem");
            this.saveInactiveAccentColorAsToolStripMenuItem.Name = "saveInactiveAccentColorAsToolStripMenuItem";
            this.saveInactiveAccentColorAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveCurrentAccentColorsAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveCurrentAccentColorsAsToolStripMenuItem, "saveCurrentAccentColorsAsToolStripMenuItem");
            this.saveCurrentAccentColorsAsToolStripMenuItem.Name = "saveCurrentAccentColorsAsToolStripMenuItem";
            this.saveCurrentAccentColorsAsToolStripMenuItem.Click += new System.EventHandler(this.exportAccentColorsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // MainForm
            // 
            this.AcceptButton = this.submitBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.colorBarBlue);
            this.Controls.Add(this.colorBarGreen);
            this.Controls.Add(this.colorBarRed);
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.winColorPaletteBtn);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog windowsColorDialog;
        private System.Windows.Forms.Button winColorPaletteBtn;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Panel colorBarRed;
        private System.Windows.Forms.Panel colorBarGreen;
        private System.Windows.Forms.Panel colorBarBlue;
        private System.Windows.Forms.Button restoreDefaultBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button autoBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInactiveAccentColorAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentAccentColorsAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentActiveAccentColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentInactiveAccentColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

