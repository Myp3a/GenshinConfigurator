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
            this.TopBar = new System.Windows.Forms.ToolStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Reset_Timer = new System.Windows.Forms.Timer(this.components);
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.Preset_Label = new System.Windows.Forms.Label();
            this.Preset_Box = new System.Windows.Forms.ComboBox();
            this.Fullscreen_Check = new System.Windows.Forms.CheckBox();
            this.Height_Text = new System.Windows.Forms.TextBox();
            this.Width_Text = new System.Windows.Forms.TextBox();
            this.Apply_Button_Graphics = new System.Windows.Forms.Button();
            this.Reset_Button_Graphics = new System.Windows.Forms.Button();
            this.AnisotropicFiltering_Box = new System.Windows.Forms.ComboBox();
            this.AnisotropicFiltering_Label = new System.Windows.Forms.Label();
            this.TeammateEffects_Box = new System.Windows.Forms.ComboBox();
            this.TeammateEffects_Label = new System.Windows.Forms.Label();
            this.SubsurfaceScattering_Box = new System.Windows.Forms.ComboBox();
            this.SubsurfaceScattering_Label = new System.Windows.Forms.Label();
            this.CrowdDensity_Box = new System.Windows.Forms.ComboBox();
            this.CrowdDensity_Label = new System.Windows.Forms.Label();
            this.Bloom_Box = new System.Windows.Forms.ComboBox();
            this.Bloom_Label = new System.Windows.Forms.Label();
            this.MotionBlur_Box = new System.Windows.Forms.ComboBox();
            this.MotionBlur_Label = new System.Windows.Forms.Label();
            this.Reflections_Box = new System.Windows.Forms.ComboBox();
            this.Reflections_Label = new System.Windows.Forms.Label();
            this.VolumetricFog_Box = new System.Windows.Forms.ComboBox();
            this.VolumetricFog_Label = new System.Windows.Forms.Label();
            this.Antialiasing_Box = new System.Windows.Forms.ComboBox();
            this.Antialiasing_Label = new System.Windows.Forms.Label();
            this.EnvironmentDetail_Box = new System.Windows.Forms.ComboBox();
            this.EnvironmentDetail_Label = new System.Windows.Forms.Label();
            this.SFXQuality_Box = new System.Windows.Forms.ComboBox();
            this.SFXQuality_Label = new System.Windows.Forms.Label();
            this.VisualEffects_Box = new System.Windows.Forms.ComboBox();
            this.VisualEffects_Label = new System.Windows.Forms.Label();
            this.ShadowQuality_Box = new System.Windows.Forms.ComboBox();
            this.ShadowQuality_Label = new System.Windows.Forms.Label();
            this.RenderResolution_Box = new System.Windows.Forms.ComboBox();
            this.RenderResolution_Label = new System.Windows.Forms.Label();
            this.VSync_Box = new System.Windows.Forms.ComboBox();
            this.VSync_Label = new System.Windows.Forms.Label();
            this.FPS_Box = new System.Windows.Forms.ComboBox();
            this.FPS_Label = new System.Windows.Forms.Label();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.splitContainerControls = new System.Windows.Forms.SplitContainer();
            this.inputDeviceLabel = new System.Windows.Forms.Label();
            this.devicesList = new System.Windows.Forms.ComboBox();
            this.inputButtonTemplate = new System.Windows.Forms.TextBox();
            this.labelControlTemplate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeyTemplate = new System.Windows.Forms.Button();
            this.checkBoxAltTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlTemplate = new System.Windows.Forms.CheckBox();
            this.gamepadButtonTemplate = new System.Windows.Forms.ComboBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.Reload_Log_Button = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabRawConfig = new System.Windows.Forms.TabPage();
            this.textBox_Config_Raw = new System.Windows.Forms.TextBox();
            this.Load_Button_Raw = new System.Windows.Forms.Button();
            this.Save_Button_Raw = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.devModeToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.gamepadAxisTemplate = new System.Windows.Forms.ComboBox();
            this.gamepadAxisInvertTemplate = new System.Windows.Forms.CheckBox();
            this.TopBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.settingsTabs.SuspendLayout();
            this.tabGraphics.SuspendLayout();
            this.tabControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).BeginInit();
            this.splitContainerControls.Panel1.SuspendLayout();
            this.splitContainerControls.Panel2.SuspendLayout();
            this.splitContainerControls.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabRawConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(547, 25);
            this.TopBar.TabIndex = 39;
            this.TopBar.Text = "toolStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.LoadButton,
            this.toolStripSeparator1,
            this.devModeToggle,
            this.toolStripSeparator2,
            this.exitButton});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.ShowDropDownArrow = false;
            this.FileMenu.Size = new System.Drawing.Size(29, 22);
            this.FileMenu.Text = "File";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(180, 22);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(532, 17);
            this.Status_Label.Spring = true;
            this.Status_Label.Text = "Opened";
            this.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Status_Reset_Timer
            // 
            this.Status_Reset_Timer.Interval = 5000;
            this.Status_Reset_Timer.Tick += new System.EventHandler(this.Status_Reset_Timer_Tick);
            // 
            // settingsTabs
            // 
            this.settingsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabs.Controls.Add(this.tabGraphics);
            this.settingsTabs.Controls.Add(this.tabControls);
            this.settingsTabs.Controls.Add(this.tabLog);
            this.settingsTabs.Controls.Add(this.tabRawConfig);
            this.settingsTabs.Location = new System.Drawing.Point(0, 25);
            this.settingsTabs.Margin = new System.Windows.Forms.Padding(0);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(547, 326);
            this.settingsTabs.TabIndex = 41;
            this.settingsTabs.SelectedIndexChanged += new System.EventHandler(this.settingsTabs_SelectedIndexChanged);
            // 
            // tabGraphics
            // 
            this.tabGraphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGraphics.Controls.Add(this.Preset_Label);
            this.tabGraphics.Controls.Add(this.Preset_Box);
            this.tabGraphics.Controls.Add(this.Fullscreen_Check);
            this.tabGraphics.Controls.Add(this.Height_Text);
            this.tabGraphics.Controls.Add(this.Width_Text);
            this.tabGraphics.Controls.Add(this.Apply_Button_Graphics);
            this.tabGraphics.Controls.Add(this.Reset_Button_Graphics);
            this.tabGraphics.Controls.Add(this.AnisotropicFiltering_Box);
            this.tabGraphics.Controls.Add(this.AnisotropicFiltering_Label);
            this.tabGraphics.Controls.Add(this.TeammateEffects_Box);
            this.tabGraphics.Controls.Add(this.TeammateEffects_Label);
            this.tabGraphics.Controls.Add(this.SubsurfaceScattering_Box);
            this.tabGraphics.Controls.Add(this.SubsurfaceScattering_Label);
            this.tabGraphics.Controls.Add(this.CrowdDensity_Box);
            this.tabGraphics.Controls.Add(this.CrowdDensity_Label);
            this.tabGraphics.Controls.Add(this.Bloom_Box);
            this.tabGraphics.Controls.Add(this.Bloom_Label);
            this.tabGraphics.Controls.Add(this.MotionBlur_Box);
            this.tabGraphics.Controls.Add(this.MotionBlur_Label);
            this.tabGraphics.Controls.Add(this.Reflections_Box);
            this.tabGraphics.Controls.Add(this.Reflections_Label);
            this.tabGraphics.Controls.Add(this.VolumetricFog_Box);
            this.tabGraphics.Controls.Add(this.VolumetricFog_Label);
            this.tabGraphics.Controls.Add(this.Antialiasing_Box);
            this.tabGraphics.Controls.Add(this.Antialiasing_Label);
            this.tabGraphics.Controls.Add(this.EnvironmentDetail_Box);
            this.tabGraphics.Controls.Add(this.EnvironmentDetail_Label);
            this.tabGraphics.Controls.Add(this.SFXQuality_Box);
            this.tabGraphics.Controls.Add(this.SFXQuality_Label);
            this.tabGraphics.Controls.Add(this.VisualEffects_Box);
            this.tabGraphics.Controls.Add(this.VisualEffects_Label);
            this.tabGraphics.Controls.Add(this.ShadowQuality_Box);
            this.tabGraphics.Controls.Add(this.ShadowQuality_Label);
            this.tabGraphics.Controls.Add(this.RenderResolution_Box);
            this.tabGraphics.Controls.Add(this.RenderResolution_Label);
            this.tabGraphics.Controls.Add(this.VSync_Box);
            this.tabGraphics.Controls.Add(this.VSync_Label);
            this.tabGraphics.Controls.Add(this.FPS_Box);
            this.tabGraphics.Controls.Add(this.FPS_Label);
            this.tabGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphics.Size = new System.Drawing.Size(539, 300);
            this.tabGraphics.TabIndex = 0;
            this.tabGraphics.Text = "Graphics";
            // 
            // Preset_Label
            // 
            this.Preset_Label.AutoSize = true;
            this.Preset_Label.Location = new System.Drawing.Point(13, 12);
            this.Preset_Label.Name = "Preset_Label";
            this.Preset_Label.Size = new System.Drawing.Size(37, 13);
            this.Preset_Label.TabIndex = 77;
            this.Preset_Label.Text = "Preset";
            // 
            // Preset_Box
            // 
            this.Preset_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preset_Box.FormattingEnabled = true;
            this.Preset_Box.Location = new System.Drawing.Point(121, 9);
            this.Preset_Box.Name = "Preset_Box";
            this.Preset_Box.Size = new System.Drawing.Size(121, 21);
            this.Preset_Box.TabIndex = 76;
            this.Preset_Box.SelectedIndexChanged += new System.EventHandler(this.Preset_Box_SelectedIndexChanged);
            // 
            // Fullscreen_Check
            // 
            this.Fullscreen_Check.AutoSize = true;
            this.Fullscreen_Check.Location = new System.Drawing.Point(248, 272);
            this.Fullscreen_Check.Name = "Fullscreen_Check";
            this.Fullscreen_Check.Size = new System.Drawing.Size(74, 17);
            this.Fullscreen_Check.TabIndex = 75;
            this.Fullscreen_Check.Text = "Fullscreen";
            this.Fullscreen_Check.UseVisualStyleBackColor = true;
            // 
            // Height_Text
            // 
            this.Height_Text.Location = new System.Drawing.Point(142, 270);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(100, 20);
            this.Height_Text.TabIndex = 74;
            // 
            // Width_Text
            // 
            this.Width_Text.Location = new System.Drawing.Point(16, 270);
            this.Width_Text.Name = "Width_Text";
            this.Width_Text.Size = new System.Drawing.Size(100, 20);
            this.Width_Text.TabIndex = 73;
            // 
            // Apply_Button_Graphics
            // 
            this.Apply_Button_Graphics.Location = new System.Drawing.Point(452, 270);
            this.Apply_Button_Graphics.Name = "Apply_Button_Graphics";
            this.Apply_Button_Graphics.Size = new System.Drawing.Size(75, 23);
            this.Apply_Button_Graphics.TabIndex = 72;
            this.Apply_Button_Graphics.Text = "Apply";
            this.Apply_Button_Graphics.UseVisualStyleBackColor = true;
            this.Apply_Button_Graphics.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Reset_Button_Graphics
            // 
            this.Reset_Button_Graphics.Location = new System.Drawing.Point(371, 270);
            this.Reset_Button_Graphics.Name = "Reset_Button_Graphics";
            this.Reset_Button_Graphics.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button_Graphics.TabIndex = 71;
            this.Reset_Button_Graphics.Text = "Reset";
            this.Reset_Button_Graphics.UseVisualStyleBackColor = true;
            this.Reset_Button_Graphics.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // AnisotropicFiltering_Box
            // 
            this.AnisotropicFiltering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnisotropicFiltering_Box.FormattingEnabled = true;
            this.AnisotropicFiltering_Box.Location = new System.Drawing.Point(406, 225);
            this.AnisotropicFiltering_Box.Name = "AnisotropicFiltering_Box";
            this.AnisotropicFiltering_Box.Size = new System.Drawing.Size(121, 21);
            this.AnisotropicFiltering_Box.TabIndex = 70;
            // 
            // AnisotropicFiltering_Label
            // 
            this.AnisotropicFiltering_Label.AutoSize = true;
            this.AnisotropicFiltering_Label.Location = new System.Drawing.Point(292, 228);
            this.AnisotropicFiltering_Label.Name = "AnisotropicFiltering_Label";
            this.AnisotropicFiltering_Label.Size = new System.Drawing.Size(98, 13);
            this.AnisotropicFiltering_Label.TabIndex = 69;
            this.AnisotropicFiltering_Label.Text = "Anisotropic Filtering";
            // 
            // TeammateEffects_Box
            // 
            this.TeammateEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeammateEffects_Box.FormattingEnabled = true;
            this.TeammateEffects_Box.Location = new System.Drawing.Point(406, 198);
            this.TeammateEffects_Box.Name = "TeammateEffects_Box";
            this.TeammateEffects_Box.Size = new System.Drawing.Size(121, 21);
            this.TeammateEffects_Box.TabIndex = 68;
            // 
            // TeammateEffects_Label
            // 
            this.TeammateEffects_Label.AutoSize = true;
            this.TeammateEffects_Label.Location = new System.Drawing.Point(292, 201);
            this.TeammateEffects_Label.Name = "TeammateEffects_Label";
            this.TeammateEffects_Label.Size = new System.Drawing.Size(93, 13);
            this.TeammateEffects_Label.TabIndex = 67;
            this.TeammateEffects_Label.Text = "Teammate Effects";
            // 
            // SubsurfaceScattering_Box
            // 
            this.SubsurfaceScattering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubsurfaceScattering_Box.FormattingEnabled = true;
            this.SubsurfaceScattering_Box.Location = new System.Drawing.Point(406, 171);
            this.SubsurfaceScattering_Box.Name = "SubsurfaceScattering_Box";
            this.SubsurfaceScattering_Box.Size = new System.Drawing.Size(121, 21);
            this.SubsurfaceScattering_Box.TabIndex = 66;
            // 
            // SubsurfaceScattering_Label
            // 
            this.SubsurfaceScattering_Label.AutoSize = true;
            this.SubsurfaceScattering_Label.Location = new System.Drawing.Point(292, 174);
            this.SubsurfaceScattering_Label.Name = "SubsurfaceScattering_Label";
            this.SubsurfaceScattering_Label.Size = new System.Drawing.Size(112, 13);
            this.SubsurfaceScattering_Label.TabIndex = 65;
            this.SubsurfaceScattering_Label.Text = "Subsurface Scattering";
            // 
            // CrowdDensity_Box
            // 
            this.CrowdDensity_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrowdDensity_Box.FormattingEnabled = true;
            this.CrowdDensity_Box.Location = new System.Drawing.Point(406, 144);
            this.CrowdDensity_Box.Name = "CrowdDensity_Box";
            this.CrowdDensity_Box.Size = new System.Drawing.Size(121, 21);
            this.CrowdDensity_Box.TabIndex = 64;
            // 
            // CrowdDensity_Label
            // 
            this.CrowdDensity_Label.AutoSize = true;
            this.CrowdDensity_Label.Location = new System.Drawing.Point(292, 147);
            this.CrowdDensity_Label.Name = "CrowdDensity_Label";
            this.CrowdDensity_Label.Size = new System.Drawing.Size(75, 13);
            this.CrowdDensity_Label.TabIndex = 63;
            this.CrowdDensity_Label.Text = "Crowd Density";
            // 
            // Bloom_Box
            // 
            this.Bloom_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bloom_Box.FormattingEnabled = true;
            this.Bloom_Box.Location = new System.Drawing.Point(406, 117);
            this.Bloom_Box.Name = "Bloom_Box";
            this.Bloom_Box.Size = new System.Drawing.Size(121, 21);
            this.Bloom_Box.TabIndex = 62;
            // 
            // Bloom_Label
            // 
            this.Bloom_Label.AutoSize = true;
            this.Bloom_Label.Location = new System.Drawing.Point(292, 120);
            this.Bloom_Label.Name = "Bloom_Label";
            this.Bloom_Label.Size = new System.Drawing.Size(36, 13);
            this.Bloom_Label.TabIndex = 61;
            this.Bloom_Label.Text = "Bloom";
            // 
            // MotionBlur_Box
            // 
            this.MotionBlur_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotionBlur_Box.FormattingEnabled = true;
            this.MotionBlur_Box.Location = new System.Drawing.Point(406, 90);
            this.MotionBlur_Box.Name = "MotionBlur_Box";
            this.MotionBlur_Box.Size = new System.Drawing.Size(121, 21);
            this.MotionBlur_Box.TabIndex = 60;
            // 
            // MotionBlur_Label
            // 
            this.MotionBlur_Label.AutoSize = true;
            this.MotionBlur_Label.Location = new System.Drawing.Point(292, 93);
            this.MotionBlur_Label.Name = "MotionBlur_Label";
            this.MotionBlur_Label.Size = new System.Drawing.Size(60, 13);
            this.MotionBlur_Label.TabIndex = 59;
            this.MotionBlur_Label.Text = "Motion Blur";
            // 
            // Reflections_Box
            // 
            this.Reflections_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Reflections_Box.FormattingEnabled = true;
            this.Reflections_Box.Location = new System.Drawing.Point(406, 63);
            this.Reflections_Box.Name = "Reflections_Box";
            this.Reflections_Box.Size = new System.Drawing.Size(121, 21);
            this.Reflections_Box.TabIndex = 58;
            // 
            // Reflections_Label
            // 
            this.Reflections_Label.AutoSize = true;
            this.Reflections_Label.Location = new System.Drawing.Point(292, 66);
            this.Reflections_Label.Name = "Reflections_Label";
            this.Reflections_Label.Size = new System.Drawing.Size(60, 13);
            this.Reflections_Label.TabIndex = 57;
            this.Reflections_Label.Text = "Reflections";
            // 
            // VolumetricFog_Box
            // 
            this.VolumetricFog_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VolumetricFog_Box.FormattingEnabled = true;
            this.VolumetricFog_Box.Location = new System.Drawing.Point(406, 36);
            this.VolumetricFog_Box.Name = "VolumetricFog_Box";
            this.VolumetricFog_Box.Size = new System.Drawing.Size(121, 21);
            this.VolumetricFog_Box.TabIndex = 56;
            // 
            // VolumetricFog_Label
            // 
            this.VolumetricFog_Label.AutoSize = true;
            this.VolumetricFog_Label.Location = new System.Drawing.Point(292, 39);
            this.VolumetricFog_Label.Name = "VolumetricFog_Label";
            this.VolumetricFog_Label.Size = new System.Drawing.Size(77, 13);
            this.VolumetricFog_Label.TabIndex = 55;
            this.VolumetricFog_Label.Text = "Volumetric Fog";
            // 
            // Antialiasing_Box
            // 
            this.Antialiasing_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Antialiasing_Box.FormattingEnabled = true;
            this.Antialiasing_Box.Location = new System.Drawing.Point(121, 225);
            this.Antialiasing_Box.Name = "Antialiasing_Box";
            this.Antialiasing_Box.Size = new System.Drawing.Size(121, 21);
            this.Antialiasing_Box.TabIndex = 54;
            // 
            // Antialiasing_Label
            // 
            this.Antialiasing_Label.AutoSize = true;
            this.Antialiasing_Label.Location = new System.Drawing.Point(13, 228);
            this.Antialiasing_Label.Name = "Antialiasing_Label";
            this.Antialiasing_Label.Size = new System.Drawing.Size(60, 13);
            this.Antialiasing_Label.TabIndex = 53;
            this.Antialiasing_Label.Text = "Antialiasing";
            // 
            // EnvironmentDetail_Box
            // 
            this.EnvironmentDetail_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentDetail_Box.FormattingEnabled = true;
            this.EnvironmentDetail_Box.Location = new System.Drawing.Point(121, 198);
            this.EnvironmentDetail_Box.Name = "EnvironmentDetail_Box";
            this.EnvironmentDetail_Box.Size = new System.Drawing.Size(121, 21);
            this.EnvironmentDetail_Box.TabIndex = 52;
            // 
            // EnvironmentDetail_Label
            // 
            this.EnvironmentDetail_Label.AutoSize = true;
            this.EnvironmentDetail_Label.Location = new System.Drawing.Point(13, 201);
            this.EnvironmentDetail_Label.Name = "EnvironmentDetail_Label";
            this.EnvironmentDetail_Label.Size = new System.Drawing.Size(96, 13);
            this.EnvironmentDetail_Label.TabIndex = 51;
            this.EnvironmentDetail_Label.Text = "Environment Detail";
            // 
            // SFXQuality_Box
            // 
            this.SFXQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SFXQuality_Box.FormattingEnabled = true;
            this.SFXQuality_Box.Location = new System.Drawing.Point(121, 171);
            this.SFXQuality_Box.Name = "SFXQuality_Box";
            this.SFXQuality_Box.Size = new System.Drawing.Size(121, 21);
            this.SFXQuality_Box.TabIndex = 50;
            // 
            // SFXQuality_Label
            // 
            this.SFXQuality_Label.AutoSize = true;
            this.SFXQuality_Label.Location = new System.Drawing.Point(13, 174);
            this.SFXQuality_Label.Name = "SFXQuality_Label";
            this.SFXQuality_Label.Size = new System.Drawing.Size(62, 13);
            this.SFXQuality_Label.TabIndex = 49;
            this.SFXQuality_Label.Text = "SFX Quality";
            // 
            // VisualEffects_Box
            // 
            this.VisualEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualEffects_Box.FormattingEnabled = true;
            this.VisualEffects_Box.Location = new System.Drawing.Point(121, 144);
            this.VisualEffects_Box.Name = "VisualEffects_Box";
            this.VisualEffects_Box.Size = new System.Drawing.Size(121, 21);
            this.VisualEffects_Box.TabIndex = 48;
            // 
            // VisualEffects_Label
            // 
            this.VisualEffects_Label.AutoSize = true;
            this.VisualEffects_Label.Location = new System.Drawing.Point(13, 147);
            this.VisualEffects_Label.Name = "VisualEffects_Label";
            this.VisualEffects_Label.Size = new System.Drawing.Size(71, 13);
            this.VisualEffects_Label.TabIndex = 47;
            this.VisualEffects_Label.Text = "Visual Effects";
            // 
            // ShadowQuality_Box
            // 
            this.ShadowQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowQuality_Box.FormattingEnabled = true;
            this.ShadowQuality_Box.Location = new System.Drawing.Point(121, 117);
            this.ShadowQuality_Box.Name = "ShadowQuality_Box";
            this.ShadowQuality_Box.Size = new System.Drawing.Size(121, 21);
            this.ShadowQuality_Box.TabIndex = 46;
            this.ShadowQuality_Box.SelectedIndexChanged += new System.EventHandler(this.ShadowQuality_Box_SelectedIndexChanged);
            // 
            // ShadowQuality_Label
            // 
            this.ShadowQuality_Label.AutoSize = true;
            this.ShadowQuality_Label.Location = new System.Drawing.Point(13, 120);
            this.ShadowQuality_Label.Name = "ShadowQuality_Label";
            this.ShadowQuality_Label.Size = new System.Drawing.Size(81, 13);
            this.ShadowQuality_Label.TabIndex = 45;
            this.ShadowQuality_Label.Text = "Shadow Quality";
            // 
            // RenderResolution_Box
            // 
            this.RenderResolution_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RenderResolution_Box.FormattingEnabled = true;
            this.RenderResolution_Box.Location = new System.Drawing.Point(121, 90);
            this.RenderResolution_Box.Name = "RenderResolution_Box";
            this.RenderResolution_Box.Size = new System.Drawing.Size(121, 21);
            this.RenderResolution_Box.TabIndex = 44;
            // 
            // RenderResolution_Label
            // 
            this.RenderResolution_Label.AutoSize = true;
            this.RenderResolution_Label.Location = new System.Drawing.Point(13, 93);
            this.RenderResolution_Label.Name = "RenderResolution_Label";
            this.RenderResolution_Label.Size = new System.Drawing.Size(95, 13);
            this.RenderResolution_Label.TabIndex = 43;
            this.RenderResolution_Label.Text = "Render Resolution";
            // 
            // VSync_Box
            // 
            this.VSync_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSync_Box.FormattingEnabled = true;
            this.VSync_Box.Location = new System.Drawing.Point(121, 63);
            this.VSync_Box.Name = "VSync_Box";
            this.VSync_Box.Size = new System.Drawing.Size(121, 21);
            this.VSync_Box.TabIndex = 42;
            // 
            // VSync_Label
            // 
            this.VSync_Label.AutoSize = true;
            this.VSync_Label.Location = new System.Drawing.Point(13, 66);
            this.VSync_Label.Name = "VSync_Label";
            this.VSync_Label.Size = new System.Drawing.Size(38, 13);
            this.VSync_Label.TabIndex = 41;
            this.VSync_Label.Text = "VSync";
            // 
            // FPS_Box
            // 
            this.FPS_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPS_Box.FormattingEnabled = true;
            this.FPS_Box.Location = new System.Drawing.Point(121, 36);
            this.FPS_Box.Name = "FPS_Box";
            this.FPS_Box.Size = new System.Drawing.Size(121, 21);
            this.FPS_Box.TabIndex = 40;
            // 
            // FPS_Label
            // 
            this.FPS_Label.AutoSize = true;
            this.FPS_Label.Location = new System.Drawing.Point(13, 39);
            this.FPS_Label.Name = "FPS_Label";
            this.FPS_Label.Size = new System.Drawing.Size(27, 13);
            this.FPS_Label.TabIndex = 39;
            this.FPS_Label.Text = "FPS";
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.splitContainerControls);
            this.tabControls.Location = new System.Drawing.Point(4, 22);
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabControls.Size = new System.Drawing.Size(539, 300);
            this.tabControls.TabIndex = 3;
            this.tabControls.Text = "Controls";
            // 
            // splitContainerControls
            // 
            this.splitContainerControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControls.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerControls.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControls.Name = "splitContainerControls";
            this.splitContainerControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerControls.Panel1
            // 
            this.splitContainerControls.Panel1.Controls.Add(this.inputDeviceLabel);
            this.splitContainerControls.Panel1.Controls.Add(this.devicesList);
            // 
            // splitContainerControls.Panel2
            // 
            this.splitContainerControls.Panel2.AutoScroll = true;
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadAxisInvertTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadAxisTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.inputButtonTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.labelControlTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.label1);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonKeyTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxAltTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxShiftTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxCtrlTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadButtonTemplate);
            this.splitContainerControls.Size = new System.Drawing.Size(533, 294);
            this.splitContainerControls.SplitterDistance = 36;
            this.splitContainerControls.TabIndex = 8;
            // 
            // inputDeviceLabel
            // 
            this.inputDeviceLabel.AutoSize = true;
            this.inputDeviceLabel.Location = new System.Drawing.Point(7, 11);
            this.inputDeviceLabel.Name = "inputDeviceLabel";
            this.inputDeviceLabel.Size = new System.Drawing.Size(66, 13);
            this.inputDeviceLabel.TabIndex = 7;
            this.inputDeviceLabel.Text = "Input device";
            // 
            // devicesList
            // 
            this.devicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(240, 8);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(286, 21);
            this.devicesList.TabIndex = 6;
            this.devicesList.SelectedIndexChanged += new System.EventHandler(this.Reload_Controls);
            // 
            // inputButtonTemplate
            // 
            this.inputButtonTemplate.Enabled = false;
            this.inputButtonTemplate.Location = new System.Drawing.Point(264, 5);
            this.inputButtonTemplate.Name = "inputButtonTemplate";
            this.inputButtonTemplate.Size = new System.Drawing.Size(118, 20);
            this.inputButtonTemplate.TabIndex = 6;
            this.inputButtonTemplate.Visible = false;
            // 
            // labelControlTemplate
            // 
            this.labelControlTemplate.AutoSize = true;
            this.labelControlTemplate.Location = new System.Drawing.Point(7, 9);
            this.labelControlTemplate.Name = "labelControlTemplate";
            this.labelControlTemplate.Size = new System.Drawing.Size(71, 13);
            this.labelControlTemplate.TabIndex = 0;
            this.labelControlTemplate.Text = "Control Name";
            this.labelControlTemplate.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(407, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "It should be like that.\r\nFor some reason.";
            this.label1.Visible = false;
            // 
            // buttonKeyTemplate
            // 
            this.buttonKeyTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeyTemplate.Location = new System.Drawing.Point(264, 3);
            this.buttonKeyTemplate.Name = "buttonKeyTemplate";
            this.buttonKeyTemplate.Size = new System.Drawing.Size(118, 23);
            this.buttonKeyTemplate.TabIndex = 1;
            this.buttonKeyTemplate.Text = "Selected Key";
            this.buttonKeyTemplate.UseVisualStyleBackColor = true;
            this.buttonKeyTemplate.Visible = false;
            // 
            // checkBoxAltTemplate
            // 
            this.checkBoxAltTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAltTemplate.AutoSize = true;
            this.checkBoxAltTemplate.Location = new System.Drawing.Point(488, 3);
            this.checkBoxAltTemplate.Name = "checkBoxAltTemplate";
            this.checkBoxAltTemplate.Size = new System.Drawing.Size(38, 17);
            this.checkBoxAltTemplate.TabIndex = 4;
            this.checkBoxAltTemplate.Text = "Alt";
            this.checkBoxAltTemplate.UseVisualStyleBackColor = true;
            this.checkBoxAltTemplate.Visible = false;
            // 
            // checkBoxShiftTemplate
            // 
            this.checkBoxShiftTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShiftTemplate.AutoSize = true;
            this.checkBoxShiftTemplate.Location = new System.Drawing.Point(435, 3);
            this.checkBoxShiftTemplate.Name = "checkBoxShiftTemplate";
            this.checkBoxShiftTemplate.Size = new System.Drawing.Size(47, 17);
            this.checkBoxShiftTemplate.TabIndex = 2;
            this.checkBoxShiftTemplate.Text = "Shift";
            this.checkBoxShiftTemplate.UseVisualStyleBackColor = true;
            this.checkBoxShiftTemplate.Visible = false;
            // 
            // checkBoxCtrlTemplate
            // 
            this.checkBoxCtrlTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCtrlTemplate.AutoSize = true;
            this.checkBoxCtrlTemplate.Location = new System.Drawing.Point(388, 3);
            this.checkBoxCtrlTemplate.Name = "checkBoxCtrlTemplate";
            this.checkBoxCtrlTemplate.Size = new System.Drawing.Size(41, 17);
            this.checkBoxCtrlTemplate.TabIndex = 3;
            this.checkBoxCtrlTemplate.Text = "Ctrl";
            this.checkBoxCtrlTemplate.UseVisualStyleBackColor = true;
            this.checkBoxCtrlTemplate.Visible = false;
            // 
            // gamepadButtonTemplate
            // 
            this.gamepadButtonTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamepadButtonTemplate.FormattingEnabled = true;
            this.gamepadButtonTemplate.Items.AddRange(new object[] {
            "LT",
            "RT",
            "A",
            "B",
            "X",
            "Y",
            "LB",
            "RB",
            "Back",
            "Start",
            "Left Stick",
            "Right Stick",
            "D-Pad Up",
            "D-Pad Right",
            "D-Pad Down",
            "D-Pad Left",
            "LS?",
            "RS?",
            "Guide"});
            this.gamepadButtonTemplate.Location = new System.Drawing.Point(405, 4);
            this.gamepadButtonTemplate.Name = "gamepadButtonTemplate";
            this.gamepadButtonTemplate.Size = new System.Drawing.Size(121, 21);
            this.gamepadButtonTemplate.TabIndex = 7;
            this.gamepadButtonTemplate.Visible = false;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.Reload_Log_Button);
            this.tabLog.Controls.Add(this.textBoxLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(539, 300);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Launch Log";
            // 
            // Reload_Log_Button
            // 
            this.Reload_Log_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload_Log_Button.Location = new System.Drawing.Point(456, 271);
            this.Reload_Log_Button.Name = "Reload_Log_Button";
            this.Reload_Log_Button.Size = new System.Drawing.Size(75, 23);
            this.Reload_Log_Button.TabIndex = 1;
            this.Reload_Log_Button.Text = "Reload";
            this.Reload_Log_Button.UseVisualStyleBackColor = true;
            this.Reload_Log_Button.Click += new System.EventHandler(this.Reload_Log_Button_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.MaxLength = 3276700;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(533, 262);
            this.textBoxLog.TabIndex = 0;
            // 
            // tabRawConfig
            // 
            this.tabRawConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRawConfig.Controls.Add(this.textBox_Config_Raw);
            this.tabRawConfig.Controls.Add(this.Load_Button_Raw);
            this.tabRawConfig.Controls.Add(this.Save_Button_Raw);
            this.tabRawConfig.Location = new System.Drawing.Point(4, 22);
            this.tabRawConfig.Name = "tabRawConfig";
            this.tabRawConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawConfig.Size = new System.Drawing.Size(539, 300);
            this.tabRawConfig.TabIndex = 1;
            this.tabRawConfig.Text = "Raw Config";
            // 
            // textBox_Config_Raw
            // 
            this.textBox_Config_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Config_Raw.Location = new System.Drawing.Point(9, 7);
            this.textBox_Config_Raw.MaxLength = 3276700;
            this.textBox_Config_Raw.Multiline = true;
            this.textBox_Config_Raw.Name = "textBox_Config_Raw";
            this.textBox_Config_Raw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Config_Raw.Size = new System.Drawing.Size(522, 258);
            this.textBox_Config_Raw.TabIndex = 2;
            // 
            // Load_Button_Raw
            // 
            this.Load_Button_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Button_Raw.Location = new System.Drawing.Point(375, 271);
            this.Load_Button_Raw.Name = "Load_Button_Raw";
            this.Load_Button_Raw.Size = new System.Drawing.Size(75, 23);
            this.Load_Button_Raw.TabIndex = 1;
            this.Load_Button_Raw.Text = "Load";
            this.Load_Button_Raw.UseVisualStyleBackColor = true;
            this.Load_Button_Raw.Click += new System.EventHandler(this.Load_Button_Raw_Click);
            // 
            // Save_Button_Raw
            // 
            this.Save_Button_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button_Raw.Location = new System.Drawing.Point(456, 271);
            this.Save_Button_Raw.Name = "Save_Button_Raw";
            this.Save_Button_Raw.Size = new System.Drawing.Size(75, 23);
            this.Save_Button_Raw.TabIndex = 0;
            this.Save_Button_Raw.Text = "Save";
            this.Save_Button_Raw.UseVisualStyleBackColor = true;
            this.Save_Button_Raw.Click += new System.EventHandler(this.Save_Button_Raw_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // devModeToggle
            // 
            this.devModeToggle.CheckOnClick = true;
            this.devModeToggle.Name = "devModeToggle";
            this.devModeToggle.Size = new System.Drawing.Size(180, 22);
            this.devModeToggle.Text = "Dev Mode";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gamepadAxisTemplate
            // 
            this.gamepadAxisTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamepadAxisTemplate.FormattingEnabled = true;
            this.gamepadAxisTemplate.Items.AddRange(new object[] {
            "Left Stick X",
            "Left Stick Y",
            "Right Stick X",
            "Right Stick Y",
            "LT",
            "RT"});
            this.gamepadAxisTemplate.Location = new System.Drawing.Point(218, 7);
            this.gamepadAxisTemplate.Name = "gamepadAxisTemplate";
            this.gamepadAxisTemplate.Size = new System.Drawing.Size(121, 21);
            this.gamepadAxisTemplate.TabIndex = 8;
            // 
            // gamepadAxisInvertTemplate
            // 
            this.gamepadAxisInvertTemplate.AutoSize = true;
            this.gamepadAxisInvertTemplate.Location = new System.Drawing.Point(159, 9);
            this.gamepadAxisInvertTemplate.Name = "gamepadAxisInvertTemplate";
            this.gamepadAxisInvertTemplate.Size = new System.Drawing.Size(53, 17);
            this.gamepadAxisInvertTemplate.TabIndex = 9;
            this.gamepadAxisInvertTemplate.Text = "Invert";
            this.gamepadAxisInvertTemplate.UseVisualStyleBackColor = true;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 376);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.settingsTabs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWin";
            this.Text = "Genshin Impact Configurator";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.settingsTabs.ResumeLayout(false);
            this.tabGraphics.ResumeLayout(false);
            this.tabGraphics.PerformLayout();
            this.tabControls.ResumeLayout(false);
            this.splitContainerControls.Panel1.ResumeLayout(false);
            this.splitContainerControls.Panel1.PerformLayout();
            this.splitContainerControls.Panel2.ResumeLayout(false);
            this.splitContainerControls.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).EndInit();
            this.splitContainerControls.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabRawConfig.ResumeLayout(false);
            this.tabRawConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip TopBar;
        private System.Windows.Forms.ToolStripDropDownButton FileMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem LoadButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_Label;
        private System.Windows.Forms.Timer Status_Reset_Timer;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage tabGraphics;
        private System.Windows.Forms.Label Preset_Label;
        private System.Windows.Forms.ComboBox Preset_Box;
        private System.Windows.Forms.CheckBox Fullscreen_Check;
        private System.Windows.Forms.TextBox Height_Text;
        private System.Windows.Forms.TextBox Width_Text;
        private System.Windows.Forms.Button Apply_Button_Graphics;
        private System.Windows.Forms.Button Reset_Button_Graphics;
        private System.Windows.Forms.ComboBox AnisotropicFiltering_Box;
        private System.Windows.Forms.Label AnisotropicFiltering_Label;
        private System.Windows.Forms.ComboBox TeammateEffects_Box;
        private System.Windows.Forms.Label TeammateEffects_Label;
        private System.Windows.Forms.ComboBox SubsurfaceScattering_Box;
        private System.Windows.Forms.Label SubsurfaceScattering_Label;
        private System.Windows.Forms.ComboBox CrowdDensity_Box;
        private System.Windows.Forms.Label CrowdDensity_Label;
        private System.Windows.Forms.ComboBox Bloom_Box;
        private System.Windows.Forms.Label Bloom_Label;
        private System.Windows.Forms.ComboBox MotionBlur_Box;
        private System.Windows.Forms.Label MotionBlur_Label;
        private System.Windows.Forms.ComboBox Reflections_Box;
        private System.Windows.Forms.Label Reflections_Label;
        private System.Windows.Forms.ComboBox VolumetricFog_Box;
        private System.Windows.Forms.Label VolumetricFog_Label;
        private System.Windows.Forms.ComboBox Antialiasing_Box;
        private System.Windows.Forms.Label Antialiasing_Label;
        private System.Windows.Forms.ComboBox EnvironmentDetail_Box;
        private System.Windows.Forms.Label EnvironmentDetail_Label;
        private System.Windows.Forms.ComboBox SFXQuality_Box;
        private System.Windows.Forms.Label SFXQuality_Label;
        private System.Windows.Forms.ComboBox VisualEffects_Box;
        private System.Windows.Forms.Label VisualEffects_Label;
        private System.Windows.Forms.ComboBox ShadowQuality_Box;
        private System.Windows.Forms.Label ShadowQuality_Label;
        private System.Windows.Forms.ComboBox RenderResolution_Box;
        private System.Windows.Forms.Label RenderResolution_Label;
        private System.Windows.Forms.ComboBox VSync_Box;
        private System.Windows.Forms.Label VSync_Label;
        private System.Windows.Forms.ComboBox FPS_Box;
        private System.Windows.Forms.Label FPS_Label;
        private System.Windows.Forms.TabPage tabRawConfig;
        private System.Windows.Forms.TextBox textBox_Config_Raw;
        private System.Windows.Forms.Button Load_Button_Raw;
        private System.Windows.Forms.Button Save_Button_Raw;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button Reload_Log_Button;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.CheckBox checkBoxAltTemplate;
        private System.Windows.Forms.CheckBox checkBoxCtrlTemplate;
        private System.Windows.Forms.CheckBox checkBoxShiftTemplate;
        private System.Windows.Forms.Button buttonKeyTemplate;
        private System.Windows.Forms.Label labelControlTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inputDeviceLabel;
        private System.Windows.Forms.ComboBox devicesList;
        private System.Windows.Forms.SplitContainer splitContainerControls;
        private System.Windows.Forms.TextBox inputButtonTemplate;
        private System.Windows.Forms.ComboBox gamepadButtonTemplate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem devModeToggle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.CheckBox gamepadAxisInvertTemplate;
        private System.Windows.Forms.ComboBox gamepadAxisTemplate;
    }
}

