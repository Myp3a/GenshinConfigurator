namespace GenshinConfigurator
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.FPS_Label = new System.Windows.Forms.Label();
            this.FPS_Box = new System.Windows.Forms.ComboBox();
            this.VSync_Box = new System.Windows.Forms.ComboBox();
            this.VSync_Label = new System.Windows.Forms.Label();
            this.RenderResolution_Box = new System.Windows.Forms.ComboBox();
            this.RenderResolution_Label = new System.Windows.Forms.Label();
            this.ShadowQuality_Box = new System.Windows.Forms.ComboBox();
            this.ShadowQuality_Label = new System.Windows.Forms.Label();
            this.VisualEffects_Box = new System.Windows.Forms.ComboBox();
            this.VisualEffects_Label = new System.Windows.Forms.Label();
            this.SFXQuality_Box = new System.Windows.Forms.ComboBox();
            this.SFXQuality_Label = new System.Windows.Forms.Label();
            this.EnvironmentDetail_Box = new System.Windows.Forms.ComboBox();
            this.EnvironmentDetail_Label = new System.Windows.Forms.Label();
            this.Antialiasing_Box = new System.Windows.Forms.ComboBox();
            this.Antialiasing_Label = new System.Windows.Forms.Label();
            this.VolumetricFog_Box = new System.Windows.Forms.ComboBox();
            this.VolumetricFog_Label = new System.Windows.Forms.Label();
            this.Reflections_Box = new System.Windows.Forms.ComboBox();
            this.Reflections_Label = new System.Windows.Forms.Label();
            this.MotionBlur_Box = new System.Windows.Forms.ComboBox();
            this.MotionBlur_Label = new System.Windows.Forms.Label();
            this.Bloom_Box = new System.Windows.Forms.ComboBox();
            this.Bloom_Label = new System.Windows.Forms.Label();
            this.CrowdDensity_Box = new System.Windows.Forms.ComboBox();
            this.CrowdDensity_Label = new System.Windows.Forms.Label();
            this.SubsurfaceScattering_Box = new System.Windows.Forms.ComboBox();
            this.SubsurfaceScattering_Label = new System.Windows.Forms.Label();
            this.TeammateEffects_Box = new System.Windows.Forms.ComboBox();
            this.TeammateEffects_Label = new System.Windows.Forms.Label();
            this.AnisotropicFiltering_Box = new System.Windows.Forms.ComboBox();
            this.AnisotropicFiltering_Label = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.Width_Text = new System.Windows.Forms.TextBox();
            this.Height_Text = new System.Windows.Forms.TextBox();
            this.Fullscreen_Check = new System.Windows.Forms.CheckBox();
            this.Preset_Box = new System.Windows.Forms.ComboBox();
            this.Preset_Label = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.ToolStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Reset_Timer = new System.Windows.Forms.Timer(this.components);
            this.TopBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FPS_Label
            // 
            this.FPS_Label.AutoSize = true;
            this.FPS_Label.Location = new System.Drawing.Point(11, 59);
            this.FPS_Label.Name = "FPS_Label";
            this.FPS_Label.Size = new System.Drawing.Size(27, 13);
            this.FPS_Label.TabIndex = 0;
            this.FPS_Label.Text = "FPS";
            // 
            // FPS_Box
            // 
            this.FPS_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPS_Box.FormattingEnabled = true;
            this.FPS_Box.Location = new System.Drawing.Point(119, 56);
            this.FPS_Box.Name = "FPS_Box";
            this.FPS_Box.Size = new System.Drawing.Size(121, 21);
            this.FPS_Box.TabIndex = 1;
            // 
            // VSync_Box
            // 
            this.VSync_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSync_Box.FormattingEnabled = true;
            this.VSync_Box.Location = new System.Drawing.Point(119, 83);
            this.VSync_Box.Name = "VSync_Box";
            this.VSync_Box.Size = new System.Drawing.Size(121, 21);
            this.VSync_Box.TabIndex = 3;
            // 
            // VSync_Label
            // 
            this.VSync_Label.AutoSize = true;
            this.VSync_Label.Location = new System.Drawing.Point(11, 86);
            this.VSync_Label.Name = "VSync_Label";
            this.VSync_Label.Size = new System.Drawing.Size(38, 13);
            this.VSync_Label.TabIndex = 2;
            this.VSync_Label.Text = "VSync";
            // 
            // RenderResolution_Box
            // 
            this.RenderResolution_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RenderResolution_Box.FormattingEnabled = true;
            this.RenderResolution_Box.Location = new System.Drawing.Point(119, 110);
            this.RenderResolution_Box.Name = "RenderResolution_Box";
            this.RenderResolution_Box.Size = new System.Drawing.Size(121, 21);
            this.RenderResolution_Box.TabIndex = 5;
            // 
            // RenderResolution_Label
            // 
            this.RenderResolution_Label.AutoSize = true;
            this.RenderResolution_Label.Location = new System.Drawing.Point(11, 113);
            this.RenderResolution_Label.Name = "RenderResolution_Label";
            this.RenderResolution_Label.Size = new System.Drawing.Size(95, 13);
            this.RenderResolution_Label.TabIndex = 4;
            this.RenderResolution_Label.Text = "Render Resolution";
            // 
            // ShadowQuality_Box
            // 
            this.ShadowQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowQuality_Box.FormattingEnabled = true;
            this.ShadowQuality_Box.Location = new System.Drawing.Point(119, 137);
            this.ShadowQuality_Box.Name = "ShadowQuality_Box";
            this.ShadowQuality_Box.Size = new System.Drawing.Size(121, 21);
            this.ShadowQuality_Box.TabIndex = 7;
            this.ShadowQuality_Box.SelectedIndexChanged += new System.EventHandler(this.ShadowQuality_Box_SelectedIndexChanged);
            // 
            // ShadowQuality_Label
            // 
            this.ShadowQuality_Label.AutoSize = true;
            this.ShadowQuality_Label.Location = new System.Drawing.Point(11, 140);
            this.ShadowQuality_Label.Name = "ShadowQuality_Label";
            this.ShadowQuality_Label.Size = new System.Drawing.Size(81, 13);
            this.ShadowQuality_Label.TabIndex = 6;
            this.ShadowQuality_Label.Text = "Shadow Quality";
            // 
            // VisualEffects_Box
            // 
            this.VisualEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualEffects_Box.FormattingEnabled = true;
            this.VisualEffects_Box.Location = new System.Drawing.Point(119, 164);
            this.VisualEffects_Box.Name = "VisualEffects_Box";
            this.VisualEffects_Box.Size = new System.Drawing.Size(121, 21);
            this.VisualEffects_Box.TabIndex = 9;
            // 
            // VisualEffects_Label
            // 
            this.VisualEffects_Label.AutoSize = true;
            this.VisualEffects_Label.Location = new System.Drawing.Point(11, 167);
            this.VisualEffects_Label.Name = "VisualEffects_Label";
            this.VisualEffects_Label.Size = new System.Drawing.Size(71, 13);
            this.VisualEffects_Label.TabIndex = 8;
            this.VisualEffects_Label.Text = "Visual Effects";
            // 
            // SFXQuality_Box
            // 
            this.SFXQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SFXQuality_Box.FormattingEnabled = true;
            this.SFXQuality_Box.Location = new System.Drawing.Point(119, 191);
            this.SFXQuality_Box.Name = "SFXQuality_Box";
            this.SFXQuality_Box.Size = new System.Drawing.Size(121, 21);
            this.SFXQuality_Box.TabIndex = 11;
            // 
            // SFXQuality_Label
            // 
            this.SFXQuality_Label.AutoSize = true;
            this.SFXQuality_Label.Location = new System.Drawing.Point(11, 194);
            this.SFXQuality_Label.Name = "SFXQuality_Label";
            this.SFXQuality_Label.Size = new System.Drawing.Size(62, 13);
            this.SFXQuality_Label.TabIndex = 10;
            this.SFXQuality_Label.Text = "SFX Quality";
            // 
            // EnvironmentDetail_Box
            // 
            this.EnvironmentDetail_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentDetail_Box.FormattingEnabled = true;
            this.EnvironmentDetail_Box.Location = new System.Drawing.Point(119, 218);
            this.EnvironmentDetail_Box.Name = "EnvironmentDetail_Box";
            this.EnvironmentDetail_Box.Size = new System.Drawing.Size(121, 21);
            this.EnvironmentDetail_Box.TabIndex = 13;
            // 
            // EnvironmentDetail_Label
            // 
            this.EnvironmentDetail_Label.AutoSize = true;
            this.EnvironmentDetail_Label.Location = new System.Drawing.Point(11, 221);
            this.EnvironmentDetail_Label.Name = "EnvironmentDetail_Label";
            this.EnvironmentDetail_Label.Size = new System.Drawing.Size(96, 13);
            this.EnvironmentDetail_Label.TabIndex = 12;
            this.EnvironmentDetail_Label.Text = "Environment Detail";
            // 
            // Antialiasing_Box
            // 
            this.Antialiasing_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Antialiasing_Box.FormattingEnabled = true;
            this.Antialiasing_Box.Location = new System.Drawing.Point(119, 245);
            this.Antialiasing_Box.Name = "Antialiasing_Box";
            this.Antialiasing_Box.Size = new System.Drawing.Size(121, 21);
            this.Antialiasing_Box.TabIndex = 15;
            // 
            // Antialiasing_Label
            // 
            this.Antialiasing_Label.AutoSize = true;
            this.Antialiasing_Label.Location = new System.Drawing.Point(11, 248);
            this.Antialiasing_Label.Name = "Antialiasing_Label";
            this.Antialiasing_Label.Size = new System.Drawing.Size(60, 13);
            this.Antialiasing_Label.TabIndex = 14;
            this.Antialiasing_Label.Text = "Antialiasing";
            // 
            // VolumetricFog_Box
            // 
            this.VolumetricFog_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VolumetricFog_Box.FormattingEnabled = true;
            this.VolumetricFog_Box.Location = new System.Drawing.Point(404, 56);
            this.VolumetricFog_Box.Name = "VolumetricFog_Box";
            this.VolumetricFog_Box.Size = new System.Drawing.Size(121, 21);
            this.VolumetricFog_Box.TabIndex = 17;
            // 
            // VolumetricFog_Label
            // 
            this.VolumetricFog_Label.AutoSize = true;
            this.VolumetricFog_Label.Location = new System.Drawing.Point(290, 59);
            this.VolumetricFog_Label.Name = "VolumetricFog_Label";
            this.VolumetricFog_Label.Size = new System.Drawing.Size(77, 13);
            this.VolumetricFog_Label.TabIndex = 16;
            this.VolumetricFog_Label.Text = "Volumetric Fog";
            // 
            // Reflections_Box
            // 
            this.Reflections_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Reflections_Box.FormattingEnabled = true;
            this.Reflections_Box.Location = new System.Drawing.Point(404, 83);
            this.Reflections_Box.Name = "Reflections_Box";
            this.Reflections_Box.Size = new System.Drawing.Size(121, 21);
            this.Reflections_Box.TabIndex = 19;
            // 
            // Reflections_Label
            // 
            this.Reflections_Label.AutoSize = true;
            this.Reflections_Label.Location = new System.Drawing.Point(290, 86);
            this.Reflections_Label.Name = "Reflections_Label";
            this.Reflections_Label.Size = new System.Drawing.Size(60, 13);
            this.Reflections_Label.TabIndex = 18;
            this.Reflections_Label.Text = "Reflections";
            // 
            // MotionBlur_Box
            // 
            this.MotionBlur_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotionBlur_Box.FormattingEnabled = true;
            this.MotionBlur_Box.Location = new System.Drawing.Point(404, 110);
            this.MotionBlur_Box.Name = "MotionBlur_Box";
            this.MotionBlur_Box.Size = new System.Drawing.Size(121, 21);
            this.MotionBlur_Box.TabIndex = 21;
            // 
            // MotionBlur_Label
            // 
            this.MotionBlur_Label.AutoSize = true;
            this.MotionBlur_Label.Location = new System.Drawing.Point(290, 113);
            this.MotionBlur_Label.Name = "MotionBlur_Label";
            this.MotionBlur_Label.Size = new System.Drawing.Size(60, 13);
            this.MotionBlur_Label.TabIndex = 20;
            this.MotionBlur_Label.Text = "Motion Blur";
            // 
            // Bloom_Box
            // 
            this.Bloom_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bloom_Box.FormattingEnabled = true;
            this.Bloom_Box.Location = new System.Drawing.Point(404, 137);
            this.Bloom_Box.Name = "Bloom_Box";
            this.Bloom_Box.Size = new System.Drawing.Size(121, 21);
            this.Bloom_Box.TabIndex = 23;
            // 
            // Bloom_Label
            // 
            this.Bloom_Label.AutoSize = true;
            this.Bloom_Label.Location = new System.Drawing.Point(290, 140);
            this.Bloom_Label.Name = "Bloom_Label";
            this.Bloom_Label.Size = new System.Drawing.Size(36, 13);
            this.Bloom_Label.TabIndex = 22;
            this.Bloom_Label.Text = "Bloom";
            // 
            // CrowdDensity_Box
            // 
            this.CrowdDensity_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrowdDensity_Box.FormattingEnabled = true;
            this.CrowdDensity_Box.Location = new System.Drawing.Point(404, 164);
            this.CrowdDensity_Box.Name = "CrowdDensity_Box";
            this.CrowdDensity_Box.Size = new System.Drawing.Size(121, 21);
            this.CrowdDensity_Box.TabIndex = 25;
            // 
            // CrowdDensity_Label
            // 
            this.CrowdDensity_Label.AutoSize = true;
            this.CrowdDensity_Label.Location = new System.Drawing.Point(290, 167);
            this.CrowdDensity_Label.Name = "CrowdDensity_Label";
            this.CrowdDensity_Label.Size = new System.Drawing.Size(75, 13);
            this.CrowdDensity_Label.TabIndex = 24;
            this.CrowdDensity_Label.Text = "Crowd Density";
            // 
            // SubsurfaceScattering_Box
            // 
            this.SubsurfaceScattering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubsurfaceScattering_Box.FormattingEnabled = true;
            this.SubsurfaceScattering_Box.Location = new System.Drawing.Point(404, 191);
            this.SubsurfaceScattering_Box.Name = "SubsurfaceScattering_Box";
            this.SubsurfaceScattering_Box.Size = new System.Drawing.Size(121, 21);
            this.SubsurfaceScattering_Box.TabIndex = 27;
            // 
            // SubsurfaceScattering_Label
            // 
            this.SubsurfaceScattering_Label.AutoSize = true;
            this.SubsurfaceScattering_Label.Location = new System.Drawing.Point(290, 194);
            this.SubsurfaceScattering_Label.Name = "SubsurfaceScattering_Label";
            this.SubsurfaceScattering_Label.Size = new System.Drawing.Size(112, 13);
            this.SubsurfaceScattering_Label.TabIndex = 26;
            this.SubsurfaceScattering_Label.Text = "Subsurface Scattering";
            // 
            // TeammateEffects_Box
            // 
            this.TeammateEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeammateEffects_Box.FormattingEnabled = true;
            this.TeammateEffects_Box.Location = new System.Drawing.Point(404, 218);
            this.TeammateEffects_Box.Name = "TeammateEffects_Box";
            this.TeammateEffects_Box.Size = new System.Drawing.Size(121, 21);
            this.TeammateEffects_Box.TabIndex = 29;
            // 
            // TeammateEffects_Label
            // 
            this.TeammateEffects_Label.AutoSize = true;
            this.TeammateEffects_Label.Location = new System.Drawing.Point(290, 221);
            this.TeammateEffects_Label.Name = "TeammateEffects_Label";
            this.TeammateEffects_Label.Size = new System.Drawing.Size(93, 13);
            this.TeammateEffects_Label.TabIndex = 28;
            this.TeammateEffects_Label.Text = "Teammate Effects";
            // 
            // AnisotropicFiltering_Box
            // 
            this.AnisotropicFiltering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnisotropicFiltering_Box.FormattingEnabled = true;
            this.AnisotropicFiltering_Box.Location = new System.Drawing.Point(404, 245);
            this.AnisotropicFiltering_Box.Name = "AnisotropicFiltering_Box";
            this.AnisotropicFiltering_Box.Size = new System.Drawing.Size(121, 21);
            this.AnisotropicFiltering_Box.TabIndex = 31;
            // 
            // AnisotropicFiltering_Label
            // 
            this.AnisotropicFiltering_Label.AutoSize = true;
            this.AnisotropicFiltering_Label.Location = new System.Drawing.Point(290, 248);
            this.AnisotropicFiltering_Label.Name = "AnisotropicFiltering_Label";
            this.AnisotropicFiltering_Label.Size = new System.Drawing.Size(98, 13);
            this.AnisotropicFiltering_Label.TabIndex = 30;
            this.AnisotropicFiltering_Label.Text = "Anisotropic Filtering";
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(369, 290);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 32;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Apply_Button
            // 
            this.Apply_Button.Location = new System.Drawing.Point(450, 290);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(75, 23);
            this.Apply_Button.TabIndex = 33;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Width_Text
            // 
            this.Width_Text.Location = new System.Drawing.Point(14, 290);
            this.Width_Text.Name = "Width_Text";
            this.Width_Text.Size = new System.Drawing.Size(100, 20);
            this.Width_Text.TabIndex = 34;
            // 
            // Height_Text
            // 
            this.Height_Text.Location = new System.Drawing.Point(140, 290);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(100, 20);
            this.Height_Text.TabIndex = 35;
            // 
            // Fullscreen_Check
            // 
            this.Fullscreen_Check.AutoSize = true;
            this.Fullscreen_Check.Location = new System.Drawing.Point(246, 292);
            this.Fullscreen_Check.Name = "Fullscreen_Check";
            this.Fullscreen_Check.Size = new System.Drawing.Size(74, 17);
            this.Fullscreen_Check.TabIndex = 36;
            this.Fullscreen_Check.Text = "Fullscreen";
            this.Fullscreen_Check.UseVisualStyleBackColor = true;
            // 
            // Preset_Box
            // 
            this.Preset_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preset_Box.FormattingEnabled = true;
            this.Preset_Box.Location = new System.Drawing.Point(119, 29);
            this.Preset_Box.Name = "Preset_Box";
            this.Preset_Box.Size = new System.Drawing.Size(121, 21);
            this.Preset_Box.TabIndex = 37;
            this.Preset_Box.SelectedIndexChanged += new System.EventHandler(this.Preset_Box_SelectedIndexChanged);
            // 
            // Preset_Label
            // 
            this.Preset_Label.AutoSize = true;
            this.Preset_Label.Location = new System.Drawing.Point(11, 32);
            this.Preset_Label.Name = "Preset_Label";
            this.Preset_Label.Size = new System.Drawing.Size(37, 13);
            this.Preset_Label.TabIndex = 38;
            this.Preset_Label.Text = "Preset";
            // 
            // TopBar
            // 
            this.TopBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(552, 25);
            this.TopBar.TabIndex = 39;
            this.TopBar.Text = "toolStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.LoadButton});
            this.FileMenu.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu.Image")));
            this.FileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.ShowDropDownArrow = false;
            this.FileMenu.Size = new System.Drawing.Size(29, 22);
            this.FileMenu.Text = "File";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 22);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(537, 17);
            this.Status_Label.Spring = true;
            this.Status_Label.Text = "Opened";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Status_Reset_Timer
            // 
            this.Status_Reset_Timer.Interval = 5000;
            this.Status_Reset_Timer.Tick += new System.EventHandler(this.Status_Reset_Timer_Tick);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 338);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.Preset_Label);
            this.Controls.Add(this.Preset_Box);
            this.Controls.Add(this.Fullscreen_Check);
            this.Controls.Add(this.Height_Text);
            this.Controls.Add(this.Width_Text);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.AnisotropicFiltering_Box);
            this.Controls.Add(this.AnisotropicFiltering_Label);
            this.Controls.Add(this.TeammateEffects_Box);
            this.Controls.Add(this.TeammateEffects_Label);
            this.Controls.Add(this.SubsurfaceScattering_Box);
            this.Controls.Add(this.SubsurfaceScattering_Label);
            this.Controls.Add(this.CrowdDensity_Box);
            this.Controls.Add(this.CrowdDensity_Label);
            this.Controls.Add(this.Bloom_Box);
            this.Controls.Add(this.Bloom_Label);
            this.Controls.Add(this.MotionBlur_Box);
            this.Controls.Add(this.MotionBlur_Label);
            this.Controls.Add(this.Reflections_Box);
            this.Controls.Add(this.Reflections_Label);
            this.Controls.Add(this.VolumetricFog_Box);
            this.Controls.Add(this.VolumetricFog_Label);
            this.Controls.Add(this.Antialiasing_Box);
            this.Controls.Add(this.Antialiasing_Label);
            this.Controls.Add(this.EnvironmentDetail_Box);
            this.Controls.Add(this.EnvironmentDetail_Label);
            this.Controls.Add(this.SFXQuality_Box);
            this.Controls.Add(this.SFXQuality_Label);
            this.Controls.Add(this.VisualEffects_Box);
            this.Controls.Add(this.VisualEffects_Label);
            this.Controls.Add(this.ShadowQuality_Box);
            this.Controls.Add(this.ShadowQuality_Label);
            this.Controls.Add(this.RenderResolution_Box);
            this.Controls.Add(this.RenderResolution_Label);
            this.Controls.Add(this.VSync_Box);
            this.Controls.Add(this.VSync_Label);
            this.Controls.Add(this.FPS_Box);
            this.Controls.Add(this.FPS_Label);
            this.Name = "MainWin";
            this.Text = "Genshin Impact Configurator";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FPS_Label;
        private System.Windows.Forms.ComboBox FPS_Box;
        private System.Windows.Forms.ComboBox VSync_Box;
        private System.Windows.Forms.Label VSync_Label;
        private System.Windows.Forms.ComboBox RenderResolution_Box;
        private System.Windows.Forms.Label RenderResolution_Label;
        private System.Windows.Forms.ComboBox ShadowQuality_Box;
        private System.Windows.Forms.Label ShadowQuality_Label;
        private System.Windows.Forms.ComboBox VisualEffects_Box;
        private System.Windows.Forms.Label VisualEffects_Label;
        private System.Windows.Forms.ComboBox SFXQuality_Box;
        private System.Windows.Forms.Label SFXQuality_Label;
        private System.Windows.Forms.ComboBox EnvironmentDetail_Box;
        private System.Windows.Forms.Label EnvironmentDetail_Label;
        private System.Windows.Forms.ComboBox Antialiasing_Box;
        private System.Windows.Forms.Label Antialiasing_Label;
        private System.Windows.Forms.ComboBox VolumetricFog_Box;
        private System.Windows.Forms.Label VolumetricFog_Label;
        private System.Windows.Forms.ComboBox Reflections_Box;
        private System.Windows.Forms.Label Reflections_Label;
        private System.Windows.Forms.ComboBox MotionBlur_Box;
        private System.Windows.Forms.Label MotionBlur_Label;
        private System.Windows.Forms.ComboBox Bloom_Box;
        private System.Windows.Forms.Label Bloom_Label;
        private System.Windows.Forms.ComboBox CrowdDensity_Box;
        private System.Windows.Forms.Label CrowdDensity_Label;
        private System.Windows.Forms.ComboBox SubsurfaceScattering_Box;
        private System.Windows.Forms.Label SubsurfaceScattering_Label;
        private System.Windows.Forms.ComboBox TeammateEffects_Box;
        private System.Windows.Forms.Label TeammateEffects_Label;
        private System.Windows.Forms.ComboBox AnisotropicFiltering_Box;
        private System.Windows.Forms.Label AnisotropicFiltering_Label;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.TextBox Width_Text;
        private System.Windows.Forms.TextBox Height_Text;
        private System.Windows.Forms.CheckBox Fullscreen_Check;
        private System.Windows.Forms.ComboBox Preset_Box;
        private System.Windows.Forms.Label Preset_Label;
        private System.Windows.Forms.ToolStrip TopBar;
        private System.Windows.Forms.ToolStripDropDownButton FileMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem LoadButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private System.Windows.Forms.Timer Status_Reset_Timer;
    }
}

