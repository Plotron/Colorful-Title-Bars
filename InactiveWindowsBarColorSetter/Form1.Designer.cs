namespace InactiveWindowsBarColorSetter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // winColorPaletteBtn
            // 
            this.winColorPaletteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winColorPaletteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winColorPaletteBtn.Location = new System.Drawing.Point(6, 7);
            this.winColorPaletteBtn.Name = "winColorPaletteBtn";
            this.winColorPaletteBtn.Size = new System.Drawing.Size(407, 33);
            this.winColorPaletteBtn.TabIndex = 0;
            this.winColorPaletteBtn.Text = "Windows Color Palette";
            this.winColorPaletteBtn.UseVisualStyleBackColor = true;
            this.winColorPaletteBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarRed.Location = new System.Drawing.Point(62, 46);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(357, 45);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarGreen.Location = new System.Drawing.Point(62, 97);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(357, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBarBlue.Location = new System.Drawing.Point(62, 148);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(357, 45);
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRed.ForeColor = System.Drawing.Color.Red;
            this.textBoxRed.Location = new System.Drawing.Point(6, 46);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.ReadOnly = true;
            this.textBoxRed.Size = new System.Drawing.Size(54, 35);
            this.textBoxRed.TabIndex = 4;
            this.textBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGreen.Location = new System.Drawing.Point(6, 97);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.ReadOnly = true;
            this.textBoxGreen.Size = new System.Drawing.Size(54, 35);
            this.textBoxGreen.TabIndex = 5;
            this.textBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBlue.Location = new System.Drawing.Point(6, 148);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.ReadOnly = true;
            this.textBoxBlue.Size = new System.Drawing.Size(54, 35);
            this.textBoxBlue.TabIndex = 6;
            this.textBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxHash
            // 
            this.textBoxHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHash.Location = new System.Drawing.Point(6, 190);
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.ReadOnly = true;
            this.textBoxHash.Size = new System.Drawing.Size(407, 35);
            this.textBoxHash.TabIndex = 10;
            this.textBoxHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHash.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // colorBarRed
            // 
            this.colorBarRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBarRed.BackColor = System.Drawing.Color.Red;
            this.colorBarRed.Location = new System.Drawing.Point(75, 71);
            this.colorBarRed.Name = "colorBarRed";
            this.colorBarRed.Size = new System.Drawing.Size(331, 10);
            this.colorBarRed.TabIndex = 11;
            this.colorBarRed.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // colorBarGreen
            // 
            this.colorBarGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBarGreen.BackColor = System.Drawing.Color.Lime;
            this.colorBarGreen.Location = new System.Drawing.Point(75, 122);
            this.colorBarGreen.Name = "colorBarGreen";
            this.colorBarGreen.Size = new System.Drawing.Size(331, 10);
            this.colorBarGreen.TabIndex = 12;
            this.colorBarGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // colorBarBlue
            // 
            this.colorBarBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBarBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBarBlue.Location = new System.Drawing.Point(75, 173);
            this.colorBarBlue.Name = "colorBarBlue";
            this.colorBarBlue.Size = new System.Drawing.Size(331, 10);
            this.colorBarBlue.TabIndex = 13;
            // 
            // restoreDefaultBtn
            // 
            this.restoreDefaultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreDefaultBtn.BackColor = System.Drawing.Color.White;
            this.restoreDefaultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restoreDefaultBtn.Location = new System.Drawing.Point(238, 0);
            this.restoreDefaultBtn.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.restoreDefaultBtn.Name = "restoreDefaultBtn";
            this.restoreDefaultBtn.Size = new System.Drawing.Size(169, 46);
            this.restoreDefaultBtn.TabIndex = 9;
            this.restoreDefaultBtn.Text = "Restore Default";
            this.restoreDefaultBtn.UseVisualStyleBackColor = false;
            this.restoreDefaultBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitBtn.Location = new System.Drawing.Point(0, 0);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(235, 46);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.restoreDefaultBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 49);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 285);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(999999, 324);
            this.MinimumSize = new System.Drawing.Size(16, 324);
            this.Name = "Form1";
            this.Text = "Inactive Windows Bar Color Setter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
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
    }
}

