namespace GenshinConfigurator
{
    partial class Recovery
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
            this.textBoxRecovery = new System.Windows.Forms.TextBox();
            this.checkboxMainConfig = new System.Windows.Forms.CheckBox();
            this.checkboxGraphics = new System.Windows.Forms.CheckBox();
            this.checkboxControls = new System.Windows.Forms.CheckBox();
            this.buttonRecoverySave = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRecovery
            // 
            this.textBoxRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecovery.Location = new System.Drawing.Point(13, 13);
            this.textBoxRecovery.MaxLength = 3276700;
            this.textBoxRecovery.Multiline = true;
            this.textBoxRecovery.Name = "textBoxRecovery";
            this.textBoxRecovery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecovery.Size = new System.Drawing.Size(775, 409);
            this.textBoxRecovery.TabIndex = 0;
            // 
            // checkboxMainConfig
            // 
            this.checkboxMainConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxMainConfig.AutoSize = true;
            this.checkboxMainConfig.Enabled = false;
            this.checkboxMainConfig.Location = new System.Drawing.Point(13, 428);
            this.checkboxMainConfig.Name = "checkboxMainConfig";
            this.checkboxMainConfig.Size = new System.Drawing.Size(116, 17);
            this.checkboxMainConfig.TabIndex = 1;
            this.checkboxMainConfig.Text = "Main config loaded";
            this.checkboxMainConfig.UseVisualStyleBackColor = true;
            // 
            // checkboxGraphics
            // 
            this.checkboxGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxGraphics.AutoSize = true;
            this.checkboxGraphics.Enabled = false;
            this.checkboxGraphics.Location = new System.Drawing.Point(135, 428);
            this.checkboxGraphics.Name = "checkboxGraphics";
            this.checkboxGraphics.Size = new System.Drawing.Size(142, 17);
            this.checkboxGraphics.TabIndex = 2;
            this.checkboxGraphics.Text = "Graphics settings loaded";
            this.checkboxGraphics.UseVisualStyleBackColor = true;
            // 
            // checkboxControls
            // 
            this.checkboxControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxControls.AutoSize = true;
            this.checkboxControls.Enabled = false;
            this.checkboxControls.Location = new System.Drawing.Point(283, 428);
            this.checkboxControls.Name = "checkboxControls";
            this.checkboxControls.Size = new System.Drawing.Size(124, 17);
            this.checkboxControls.TabIndex = 3;
            this.checkboxControls.Text = "Controls XML loaded";
            this.checkboxControls.UseVisualStyleBackColor = true;
            // 
            // buttonRecoverySave
            // 
            this.buttonRecoverySave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecoverySave.Location = new System.Drawing.Point(713, 424);
            this.buttonRecoverySave.Name = "buttonRecoverySave";
            this.buttonRecoverySave.Size = new System.Drawing.Size(75, 23);
            this.buttonRecoverySave.TabIndex = 4;
            this.buttonRecoverySave.Text = "Save";
            this.buttonRecoverySave.UseVisualStyleBackColor = true;
            this.buttonRecoverySave.Click += new System.EventHandler(this.buttonRecoverySave_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(785, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonRecoverySave);
            this.Controls.Add(this.checkboxControls);
            this.Controls.Add(this.checkboxGraphics);
            this.Controls.Add(this.checkboxMainConfig);
            this.Controls.Add(this.textBoxRecovery);
            this.Name = "Recovery";
            this.Text = "Recovery";
            this.Load += new System.EventHandler(this.Recovery_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecovery;
        private System.Windows.Forms.CheckBox checkboxMainConfig;
        private System.Windows.Forms.CheckBox checkboxGraphics;
        private System.Windows.Forms.CheckBox checkboxControls;
        private System.Windows.Forms.Button buttonRecoverySave;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}