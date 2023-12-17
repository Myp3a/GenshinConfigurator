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
            this.TopBar = new System.Windows.Forms.ToolStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.devModeToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.addMouseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_Reset_Timer = new System.Windows.Forms.Timer(this.components);
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.GammaValueLabel = new System.Windows.Forms.Label();
            this.Gamma_Label = new System.Windows.Forms.Label();
            this.ResolutionX = new System.Windows.Forms.Label();
            this.Resolution_Label = new System.Windows.Forms.Label();
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
            this.GammaTrackBar = new System.Windows.Forms.TrackBar();
            this.tabKeybindings = new System.Windows.Forms.TabPage();
            this.splitContainerControls = new System.Windows.Forms.SplitContainer();
            this.applyControlsButton = new System.Windows.Forms.Button();
            this.inputDeviceLabel = new System.Windows.Forms.Label();
            this.devicesList = new System.Windows.Forms.ComboBox();
            this.noControlsConfiguredLabel = new System.Windows.Forms.Label();
            this.comboBoxKeybindListTemplate = new System.Windows.Forms.ComboBox();
            this.buttonKeybindRemoveTemplate = new System.Windows.Forms.Button();
            this.buttonKeybindingAddTemplate = new System.Windows.Forms.Button();
            this.gamepadAxisInvertTemplate = new System.Windows.Forms.CheckBox();
            this.gamepadAxisTemplate = new System.Windows.Forms.ComboBox();
            this.inputButtonTemplate = new System.Windows.Forms.TextBox();
            this.labelControlTemplate = new System.Windows.Forms.Label();
            this.buttonKeyTemplate = new System.Windows.Forms.Button();
            this.checkBoxAltTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftTemplate = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrlTemplate = new System.Windows.Forms.CheckBox();
            this.gamepadButtonTemplate = new System.Windows.Forms.ComboBox();
            this.tabControlsKeyboard = new System.Windows.Forms.TabPage();
            this.ApplyKeyboardControlsButton = new System.Windows.Forms.Button();
            this.KeyboardVerticalSensitivity_Label = new System.Windows.Forms.Label();
            this.KeyboardVerticalSensitivity_Value = new System.Windows.Forms.Label();
            this.KeyboardHorizontalSensitivity_Label = new System.Windows.Forms.Label();
            this.KeyboardHorizontalSensitivity_Value = new System.Windows.Forms.Label();
            this.KeyboardVerticalSensitivityAiming_Value = new System.Windows.Forms.Label();
            this.KeyboardVerticalSensitivityAiming_Label = new System.Windows.Forms.Label();
            this.KeyboardHorizontalSensitivityAiming_Label = new System.Windows.Forms.Label();
            this.KeyboardHorizontalSensitivityAiming_Value = new System.Windows.Forms.Label();
            this.KeyboardHorizontalSensitivity_TrackBar = new System.Windows.Forms.TrackBar();
            this.KeyboardVerticalSensitivity_TrackBar = new System.Windows.Forms.TrackBar();
            this.KeyboardHorizontalSensitivityAiming_TrackBar = new System.Windows.Forms.TrackBar();
            this.KeyboardVerticalSensitivityAiming_TrackBar = new System.Windows.Forms.TrackBar();
            this.tabControlsGamepad = new System.Windows.Forms.TabPage();
            this.tabAudio = new System.Windows.Forms.TabPage();
            this.comboBoxAudioFormat = new System.Windows.Forms.ComboBox();
            this.labelAudioOutputFormat = new System.Windows.Forms.Label();
            this.comboBoxAudioDynamicRange = new System.Windows.Forms.ComboBox();
            this.labelAudioDynamicRange = new System.Windows.Forms.Label();
            this.ApplyVolumeButton = new System.Windows.Forms.Button();
            this.VoiceVolumeValueLabel = new System.Windows.Forms.Label();
            this.trackBarVoiceVolume = new System.Windows.Forms.TrackBar();
            this.VoiceVolumeLabel = new System.Windows.Forms.Label();
            this.SFXVolumeValueLabel = new System.Windows.Forms.Label();
            this.trackBarSFXVolume = new System.Windows.Forms.TrackBar();
            this.SFXVolumeLabel = new System.Windows.Forms.Label();
            this.MusicVolumeValueLabel = new System.Windows.Forms.Label();
            this.trackBarMusicVolume = new System.Windows.Forms.TrackBar();
            this.MusicVolumeLabel = new System.Windows.Forms.Label();
            this.MainVolumeValueLabel = new System.Windows.Forms.Label();
            this.trackBarMainVolume = new System.Windows.Forms.TrackBar();
            this.MainVolumeLabel = new System.Windows.Forms.Label();
            this.tabLanguage = new System.Windows.Forms.TabPage();
            this.LanguageApplyButton = new System.Windows.Forms.Button();
            this.comboBoxVoiceLanguage = new System.Windows.Forms.ComboBox();
            this.labelVoiceLanguage = new System.Windows.Forms.Label();
            this.comboBoxTextLanguage = new System.Windows.Forms.ComboBox();
            this.labelTextLanguage = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.Reload_Log_Button = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabRawConfig = new System.Windows.Forms.TabPage();
            this.textBox_Config_Raw = new System.Windows.Forms.TextBox();
            this.Load_Button_Raw = new System.Windows.Forms.Button();
            this.Save_Button_Raw = new System.Windows.Forms.Button();
            this.ControlsKeyboardResetButton = new System.Windows.Forms.Button();
            this.AudioResetButton = new System.Windows.Forms.Button();
            this.LanguageResetButton = new System.Windows.Forms.Button();
            this.GamepadVerticalSensitivity_Label = new System.Windows.Forms.Label();
            this.GamepadVerticalSensitivity_Value = new System.Windows.Forms.Label();
            this.GamepadHorizontalSensitivity_Label = new System.Windows.Forms.Label();
            this.GamepadHorizontalSensitivity_Value = new System.Windows.Forms.Label();
            this.GamepadVerticalSensitivityAiming_Value = new System.Windows.Forms.Label();
            this.GamepadVerticalSensitivityAiming_Label = new System.Windows.Forms.Label();
            this.GamepadHorizontalSensitivityAiming_Label = new System.Windows.Forms.Label();
            this.GamepadHorizontalSensitivityAiming_Value = new System.Windows.Forms.Label();
            this.GamepadHorizontalSensitivity_TrackBar = new System.Windows.Forms.TrackBar();
            this.GamepadVerticalSensitivity_TrackBar = new System.Windows.Forms.TrackBar();
            this.GamepadHorizontalSensitivityAiming_TrackBar = new System.Windows.Forms.TrackBar();
            this.GamepadVerticalSensitivityAiming_TrackBar = new System.Windows.Forms.TrackBar();
            this.ResetGamepadControls_Button = new System.Windows.Forms.Button();
            this.ApplyGamepadControls_Button = new System.Windows.Forms.Button();
            this.tabControlsMisc = new System.Windows.Forms.TabPage();
            this.MiscAutomaticBoatCameraAngleCorrection_Box = new System.Windows.Forms.ComboBox();
            this.MiscAutomaticBoatCameraAngleCorrection_Label = new System.Windows.Forms.Label();
            this.MiscDefaultCameraHeight_Value = new System.Windows.Forms.Label();
            this.MiscDefaultCameraHeight_Label = new System.Windows.Forms.Label();
            this.MiscSmartCombatCamera_Checkbox = new System.Windows.Forms.CheckBox();
            this.MiscAutomaticViewHeight_Checkbox = new System.Windows.Forms.CheckBox();
            this.MiscDefaultCameraHeight_TrackBar = new System.Windows.Forms.TrackBar();
            this.MiscResetButton = new System.Windows.Forms.Button();
            this.MiscApplyButton = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.settingsTabs.SuspendLayout();
            this.tabGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).BeginInit();
            this.tabKeybindings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).BeginInit();
            this.splitContainerControls.Panel1.SuspendLayout();
            this.splitContainerControls.Panel2.SuspendLayout();
            this.splitContainerControls.SuspendLayout();
            this.tabControlsKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardHorizontalSensitivity_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardVerticalSensitivity_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardHorizontalSensitivityAiming_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardVerticalSensitivityAiming_TrackBar)).BeginInit();
            this.tabControlsGamepad.SuspendLayout();
            this.tabAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSFXVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMainVolume)).BeginInit();
            this.tabLanguage.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabRawConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadHorizontalSensitivity_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadVerticalSensitivity_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadHorizontalSensitivityAiming_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadVerticalSensitivityAiming_TrackBar)).BeginInit();
            this.tabControlsMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiscDefaultCameraHeight_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.controlsMenu});
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(729, 27);
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
            this.FileMenu.Size = new System.Drawing.Size(36, 24);
            this.FileMenu.Text = "File";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(161, 26);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(161, 26);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // devModeToggle
            // 
            this.devModeToggle.CheckOnClick = true;
            this.devModeToggle.Name = "devModeToggle";
            this.devModeToggle.Size = new System.Drawing.Size(161, 26);
            this.devModeToggle.Text = "Dev Mode";
            this.devModeToggle.CheckedChanged += new System.EventHandler(this.devModeToggle_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(161, 26);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // controlsMenu
            // 
            this.controlsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.controlsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMouseButton});
            this.controlsMenu.Image = ((System.Drawing.Image)(resources.GetObject("controlsMenu.Image")));
            this.controlsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.controlsMenu.Name = "controlsMenu";
            this.controlsMenu.ShowDropDownArrow = false;
            this.controlsMenu.Size = new System.Drawing.Size(68, 24);
            this.controlsMenu.Text = "Controls";
            this.controlsMenu.Visible = false;
            // 
            // addMouseButton
            // 
            this.addMouseButton.Name = "addMouseButton";
            this.addMouseButton.Size = new System.Drawing.Size(236, 26);
            this.addMouseButton.Text = "Add Mouse controller";
            this.addMouseButton.Click += new System.EventHandler(this.addMouseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(729, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_Label
            // 
            this.Status_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(709, 20);
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
            this.settingsTabs.Controls.Add(this.tabKeybindings);
            this.settingsTabs.Controls.Add(this.tabControlsKeyboard);
            this.settingsTabs.Controls.Add(this.tabControlsGamepad);
            this.settingsTabs.Controls.Add(this.tabControlsMisc);
            this.settingsTabs.Controls.Add(this.tabAudio);
            this.settingsTabs.Controls.Add(this.tabLanguage);
            this.settingsTabs.Controls.Add(this.tabLog);
            this.settingsTabs.Controls.Add(this.tabRawConfig);
            this.settingsTabs.Location = new System.Drawing.Point(0, 31);
            this.settingsTabs.Margin = new System.Windows.Forms.Padding(0);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(729, 420);
            this.settingsTabs.TabIndex = 41;
            this.settingsTabs.SelectedIndexChanged += new System.EventHandler(this.settingsTabs_SelectedIndexChanged);
            // 
            // tabGraphics
            // 
            this.tabGraphics.AutoScroll = true;
            this.tabGraphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGraphics.Controls.Add(this.GammaValueLabel);
            this.tabGraphics.Controls.Add(this.Gamma_Label);
            this.tabGraphics.Controls.Add(this.ResolutionX);
            this.tabGraphics.Controls.Add(this.Resolution_Label);
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
            this.tabGraphics.Controls.Add(this.GammaTrackBar);
            this.tabGraphics.Location = new System.Drawing.Point(4, 25);
            this.tabGraphics.Margin = new System.Windows.Forms.Padding(4);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(4);
            this.tabGraphics.Size = new System.Drawing.Size(721, 391);
            this.tabGraphics.TabIndex = 0;
            this.tabGraphics.Text = "Graphics";
            // 
            // GammaValueLabel
            // 
            this.GammaValueLabel.AutoSize = true;
            this.GammaValueLabel.Location = new System.Drawing.Point(660, 315);
            this.GammaValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GammaValueLabel.Name = "GammaValueLabel";
            this.GammaValueLabel.Size = new System.Drawing.Size(31, 16);
            this.GammaValueLabel.TabIndex = 82;
            this.GammaValueLabel.Text = "0.00";
            // 
            // Gamma_Label
            // 
            this.Gamma_Label.AutoSize = true;
            this.Gamma_Label.Location = new System.Drawing.Point(389, 315);
            this.Gamma_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gamma_Label.Name = "Gamma_Label";
            this.Gamma_Label.Size = new System.Drawing.Size(55, 16);
            this.Gamma_Label.TabIndex = 80;
            this.Gamma_Label.Text = "Gamma";
            // 
            // ResolutionX
            // 
            this.ResolutionX.AutoSize = true;
            this.ResolutionX.Location = new System.Drawing.Point(165, 353);
            this.ResolutionX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.Size = new System.Drawing.Size(13, 16);
            this.ResolutionX.TabIndex = 79;
            this.ResolutionX.Text = "x";
            // 
            // Resolution_Label
            // 
            this.Resolution_Label.AutoSize = true;
            this.Resolution_Label.Location = new System.Drawing.Point(17, 330);
            this.Resolution_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resolution_Label.Name = "Resolution_Label";
            this.Resolution_Label.Size = new System.Drawing.Size(71, 16);
            this.Resolution_Label.TabIndex = 78;
            this.Resolution_Label.Text = "Resolution";
            // 
            // Preset_Label
            // 
            this.Preset_Label.AutoSize = true;
            this.Preset_Label.Location = new System.Drawing.Point(17, 15);
            this.Preset_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Preset_Label.Name = "Preset_Label";
            this.Preset_Label.Size = new System.Drawing.Size(46, 16);
            this.Preset_Label.TabIndex = 77;
            this.Preset_Label.Text = "Preset";
            // 
            // Preset_Box
            // 
            this.Preset_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preset_Box.FormattingEnabled = true;
            this.Preset_Box.Location = new System.Drawing.Point(161, 11);
            this.Preset_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Preset_Box.Name = "Preset_Box";
            this.Preset_Box.Size = new System.Drawing.Size(160, 24);
            this.Preset_Box.TabIndex = 76;
            this.Preset_Box.SelectedIndexChanged += new System.EventHandler(this.Preset_Box_SelectedIndexChanged);
            // 
            // Fullscreen_Check
            // 
            this.Fullscreen_Check.AutoSize = true;
            this.Fullscreen_Check.Location = new System.Drawing.Point(331, 352);
            this.Fullscreen_Check.Margin = new System.Windows.Forms.Padding(4);
            this.Fullscreen_Check.Name = "Fullscreen_Check";
            this.Fullscreen_Check.Size = new System.Drawing.Size(91, 20);
            this.Fullscreen_Check.TabIndex = 75;
            this.Fullscreen_Check.Text = "Fullscreen";
            this.Fullscreen_Check.UseVisualStyleBackColor = true;
            // 
            // Height_Text
            // 
            this.Height_Text.Location = new System.Drawing.Point(189, 350);
            this.Height_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Height_Text.Name = "Height_Text";
            this.Height_Text.Size = new System.Drawing.Size(132, 22);
            this.Height_Text.TabIndex = 74;
            // 
            // Width_Text
            // 
            this.Width_Text.Location = new System.Drawing.Point(21, 350);
            this.Width_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Width_Text.Name = "Width_Text";
            this.Width_Text.Size = new System.Drawing.Size(132, 22);
            this.Width_Text.TabIndex = 73;
            // 
            // Apply_Button_Graphics
            // 
            this.Apply_Button_Graphics.Location = new System.Drawing.Point(603, 350);
            this.Apply_Button_Graphics.Margin = new System.Windows.Forms.Padding(4);
            this.Apply_Button_Graphics.Name = "Apply_Button_Graphics";
            this.Apply_Button_Graphics.Size = new System.Drawing.Size(100, 28);
            this.Apply_Button_Graphics.TabIndex = 72;
            this.Apply_Button_Graphics.Text = "Apply";
            this.Apply_Button_Graphics.UseVisualStyleBackColor = true;
            this.Apply_Button_Graphics.Click += new System.EventHandler(this.Apply_Graphics_Button_Click);
            // 
            // Reset_Button_Graphics
            // 
            this.Reset_Button_Graphics.Location = new System.Drawing.Point(495, 350);
            this.Reset_Button_Graphics.Margin = new System.Windows.Forms.Padding(4);
            this.Reset_Button_Graphics.Name = "Reset_Button_Graphics";
            this.Reset_Button_Graphics.Size = new System.Drawing.Size(100, 28);
            this.Reset_Button_Graphics.TabIndex = 71;
            this.Reset_Button_Graphics.Text = "Reset";
            this.Reset_Button_Graphics.UseVisualStyleBackColor = true;
            this.Reset_Button_Graphics.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // AnisotropicFiltering_Box
            // 
            this.AnisotropicFiltering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnisotropicFiltering_Box.FormattingEnabled = true;
            this.AnisotropicFiltering_Box.Location = new System.Drawing.Point(541, 277);
            this.AnisotropicFiltering_Box.Margin = new System.Windows.Forms.Padding(4);
            this.AnisotropicFiltering_Box.Name = "AnisotropicFiltering_Box";
            this.AnisotropicFiltering_Box.Size = new System.Drawing.Size(160, 24);
            this.AnisotropicFiltering_Box.TabIndex = 70;
            // 
            // AnisotropicFiltering_Label
            // 
            this.AnisotropicFiltering_Label.AutoSize = true;
            this.AnisotropicFiltering_Label.Location = new System.Drawing.Point(389, 281);
            this.AnisotropicFiltering_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnisotropicFiltering_Label.Name = "AnisotropicFiltering_Label";
            this.AnisotropicFiltering_Label.Size = new System.Drawing.Size(124, 16);
            this.AnisotropicFiltering_Label.TabIndex = 69;
            this.AnisotropicFiltering_Label.Text = "Anisotropic Filtering";
            // 
            // TeammateEffects_Box
            // 
            this.TeammateEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeammateEffects_Box.FormattingEnabled = true;
            this.TeammateEffects_Box.Location = new System.Drawing.Point(541, 244);
            this.TeammateEffects_Box.Margin = new System.Windows.Forms.Padding(4);
            this.TeammateEffects_Box.Name = "TeammateEffects_Box";
            this.TeammateEffects_Box.Size = new System.Drawing.Size(160, 24);
            this.TeammateEffects_Box.TabIndex = 68;
            // 
            // TeammateEffects_Label
            // 
            this.TeammateEffects_Label.AutoSize = true;
            this.TeammateEffects_Label.Location = new System.Drawing.Point(389, 247);
            this.TeammateEffects_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeammateEffects_Label.Name = "TeammateEffects_Label";
            this.TeammateEffects_Label.Size = new System.Drawing.Size(116, 16);
            this.TeammateEffects_Label.TabIndex = 67;
            this.TeammateEffects_Label.Text = "Teammate Effects";
            // 
            // SubsurfaceScattering_Box
            // 
            this.SubsurfaceScattering_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubsurfaceScattering_Box.FormattingEnabled = true;
            this.SubsurfaceScattering_Box.Location = new System.Drawing.Point(541, 210);
            this.SubsurfaceScattering_Box.Margin = new System.Windows.Forms.Padding(4);
            this.SubsurfaceScattering_Box.Name = "SubsurfaceScattering_Box";
            this.SubsurfaceScattering_Box.Size = new System.Drawing.Size(160, 24);
            this.SubsurfaceScattering_Box.TabIndex = 66;
            // 
            // SubsurfaceScattering_Label
            // 
            this.SubsurfaceScattering_Label.AutoSize = true;
            this.SubsurfaceScattering_Label.Location = new System.Drawing.Point(389, 214);
            this.SubsurfaceScattering_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubsurfaceScattering_Label.Name = "SubsurfaceScattering_Label";
            this.SubsurfaceScattering_Label.Size = new System.Drawing.Size(138, 16);
            this.SubsurfaceScattering_Label.TabIndex = 65;
            this.SubsurfaceScattering_Label.Text = "Subsurface Scattering";
            // 
            // CrowdDensity_Box
            // 
            this.CrowdDensity_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrowdDensity_Box.FormattingEnabled = true;
            this.CrowdDensity_Box.Location = new System.Drawing.Point(541, 177);
            this.CrowdDensity_Box.Margin = new System.Windows.Forms.Padding(4);
            this.CrowdDensity_Box.Name = "CrowdDensity_Box";
            this.CrowdDensity_Box.Size = new System.Drawing.Size(160, 24);
            this.CrowdDensity_Box.TabIndex = 64;
            // 
            // CrowdDensity_Label
            // 
            this.CrowdDensity_Label.AutoSize = true;
            this.CrowdDensity_Label.Location = new System.Drawing.Point(389, 181);
            this.CrowdDensity_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CrowdDensity_Label.Name = "CrowdDensity_Label";
            this.CrowdDensity_Label.Size = new System.Drawing.Size(93, 16);
            this.CrowdDensity_Label.TabIndex = 63;
            this.CrowdDensity_Label.Text = "Crowd Density";
            // 
            // Bloom_Box
            // 
            this.Bloom_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bloom_Box.FormattingEnabled = true;
            this.Bloom_Box.Location = new System.Drawing.Point(541, 144);
            this.Bloom_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Bloom_Box.Name = "Bloom_Box";
            this.Bloom_Box.Size = new System.Drawing.Size(160, 24);
            this.Bloom_Box.TabIndex = 62;
            // 
            // Bloom_Label
            // 
            this.Bloom_Label.AutoSize = true;
            this.Bloom_Label.Location = new System.Drawing.Point(389, 148);
            this.Bloom_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bloom_Label.Name = "Bloom_Label";
            this.Bloom_Label.Size = new System.Drawing.Size(46, 16);
            this.Bloom_Label.TabIndex = 61;
            this.Bloom_Label.Text = "Bloom";
            // 
            // MotionBlur_Box
            // 
            this.MotionBlur_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MotionBlur_Box.FormattingEnabled = true;
            this.MotionBlur_Box.Location = new System.Drawing.Point(541, 111);
            this.MotionBlur_Box.Margin = new System.Windows.Forms.Padding(4);
            this.MotionBlur_Box.Name = "MotionBlur_Box";
            this.MotionBlur_Box.Size = new System.Drawing.Size(160, 24);
            this.MotionBlur_Box.TabIndex = 60;
            // 
            // MotionBlur_Label
            // 
            this.MotionBlur_Label.AutoSize = true;
            this.MotionBlur_Label.Location = new System.Drawing.Point(389, 114);
            this.MotionBlur_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MotionBlur_Label.Name = "MotionBlur_Label";
            this.MotionBlur_Label.Size = new System.Drawing.Size(73, 16);
            this.MotionBlur_Label.TabIndex = 59;
            this.MotionBlur_Label.Text = "Motion Blur";
            // 
            // Reflections_Box
            // 
            this.Reflections_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Reflections_Box.FormattingEnabled = true;
            this.Reflections_Box.Location = new System.Drawing.Point(541, 78);
            this.Reflections_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Reflections_Box.Name = "Reflections_Box";
            this.Reflections_Box.Size = new System.Drawing.Size(160, 24);
            this.Reflections_Box.TabIndex = 58;
            // 
            // Reflections_Label
            // 
            this.Reflections_Label.AutoSize = true;
            this.Reflections_Label.Location = new System.Drawing.Point(389, 81);
            this.Reflections_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reflections_Label.Name = "Reflections_Label";
            this.Reflections_Label.Size = new System.Drawing.Size(74, 16);
            this.Reflections_Label.TabIndex = 57;
            this.Reflections_Label.Text = "Reflections";
            // 
            // VolumetricFog_Box
            // 
            this.VolumetricFog_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VolumetricFog_Box.FormattingEnabled = true;
            this.VolumetricFog_Box.Location = new System.Drawing.Point(541, 44);
            this.VolumetricFog_Box.Margin = new System.Windows.Forms.Padding(4);
            this.VolumetricFog_Box.Name = "VolumetricFog_Box";
            this.VolumetricFog_Box.Size = new System.Drawing.Size(160, 24);
            this.VolumetricFog_Box.TabIndex = 56;
            // 
            // VolumetricFog_Label
            // 
            this.VolumetricFog_Label.AutoSize = true;
            this.VolumetricFog_Label.Location = new System.Drawing.Point(389, 48);
            this.VolumetricFog_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolumetricFog_Label.Name = "VolumetricFog_Label";
            this.VolumetricFog_Label.Size = new System.Drawing.Size(97, 16);
            this.VolumetricFog_Label.TabIndex = 55;
            this.VolumetricFog_Label.Text = "Volumetric Fog";
            // 
            // Antialiasing_Box
            // 
            this.Antialiasing_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Antialiasing_Box.FormattingEnabled = true;
            this.Antialiasing_Box.Location = new System.Drawing.Point(161, 277);
            this.Antialiasing_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Antialiasing_Box.Name = "Antialiasing_Box";
            this.Antialiasing_Box.Size = new System.Drawing.Size(160, 24);
            this.Antialiasing_Box.TabIndex = 54;
            // 
            // Antialiasing_Label
            // 
            this.Antialiasing_Label.AutoSize = true;
            this.Antialiasing_Label.Location = new System.Drawing.Point(17, 281);
            this.Antialiasing_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Antialiasing_Label.Name = "Antialiasing_Label";
            this.Antialiasing_Label.Size = new System.Drawing.Size(76, 16);
            this.Antialiasing_Label.TabIndex = 53;
            this.Antialiasing_Label.Text = "Antialiasing";
            // 
            // EnvironmentDetail_Box
            // 
            this.EnvironmentDetail_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnvironmentDetail_Box.FormattingEnabled = true;
            this.EnvironmentDetail_Box.Location = new System.Drawing.Point(161, 244);
            this.EnvironmentDetail_Box.Margin = new System.Windows.Forms.Padding(4);
            this.EnvironmentDetail_Box.Name = "EnvironmentDetail_Box";
            this.EnvironmentDetail_Box.Size = new System.Drawing.Size(160, 24);
            this.EnvironmentDetail_Box.TabIndex = 52;
            // 
            // EnvironmentDetail_Label
            // 
            this.EnvironmentDetail_Label.AutoSize = true;
            this.EnvironmentDetail_Label.Location = new System.Drawing.Point(17, 247);
            this.EnvironmentDetail_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnvironmentDetail_Label.Name = "EnvironmentDetail_Label";
            this.EnvironmentDetail_Label.Size = new System.Drawing.Size(119, 16);
            this.EnvironmentDetail_Label.TabIndex = 51;
            this.EnvironmentDetail_Label.Text = "Environment Detail";
            // 
            // SFXQuality_Box
            // 
            this.SFXQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SFXQuality_Box.FormattingEnabled = true;
            this.SFXQuality_Box.Location = new System.Drawing.Point(161, 210);
            this.SFXQuality_Box.Margin = new System.Windows.Forms.Padding(4);
            this.SFXQuality_Box.Name = "SFXQuality_Box";
            this.SFXQuality_Box.Size = new System.Drawing.Size(160, 24);
            this.SFXQuality_Box.TabIndex = 50;
            // 
            // SFXQuality_Label
            // 
            this.SFXQuality_Label.AutoSize = true;
            this.SFXQuality_Label.Location = new System.Drawing.Point(17, 214);
            this.SFXQuality_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SFXQuality_Label.Name = "SFXQuality_Label";
            this.SFXQuality_Label.Size = new System.Drawing.Size(76, 16);
            this.SFXQuality_Label.TabIndex = 49;
            this.SFXQuality_Label.Text = "SFX Quality";
            // 
            // VisualEffects_Box
            // 
            this.VisualEffects_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisualEffects_Box.FormattingEnabled = true;
            this.VisualEffects_Box.Location = new System.Drawing.Point(161, 177);
            this.VisualEffects_Box.Margin = new System.Windows.Forms.Padding(4);
            this.VisualEffects_Box.Name = "VisualEffects_Box";
            this.VisualEffects_Box.Size = new System.Drawing.Size(160, 24);
            this.VisualEffects_Box.TabIndex = 48;
            // 
            // VisualEffects_Label
            // 
            this.VisualEffects_Label.AutoSize = true;
            this.VisualEffects_Label.Location = new System.Drawing.Point(17, 181);
            this.VisualEffects_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VisualEffects_Label.Name = "VisualEffects_Label";
            this.VisualEffects_Label.Size = new System.Drawing.Size(87, 16);
            this.VisualEffects_Label.TabIndex = 47;
            this.VisualEffects_Label.Text = "Visual Effects";
            // 
            // ShadowQuality_Box
            // 
            this.ShadowQuality_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShadowQuality_Box.FormattingEnabled = true;
            this.ShadowQuality_Box.Location = new System.Drawing.Point(161, 144);
            this.ShadowQuality_Box.Margin = new System.Windows.Forms.Padding(4);
            this.ShadowQuality_Box.Name = "ShadowQuality_Box";
            this.ShadowQuality_Box.Size = new System.Drawing.Size(160, 24);
            this.ShadowQuality_Box.TabIndex = 46;
            this.ShadowQuality_Box.SelectedIndexChanged += new System.EventHandler(this.ShadowQuality_Box_SelectedIndexChanged);
            // 
            // ShadowQuality_Label
            // 
            this.ShadowQuality_Label.AutoSize = true;
            this.ShadowQuality_Label.Location = new System.Drawing.Point(17, 148);
            this.ShadowQuality_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShadowQuality_Label.Name = "ShadowQuality_Label";
            this.ShadowQuality_Label.Size = new System.Drawing.Size(100, 16);
            this.ShadowQuality_Label.TabIndex = 45;
            this.ShadowQuality_Label.Text = "Shadow Quality";
            // 
            // RenderResolution_Box
            // 
            this.RenderResolution_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RenderResolution_Box.FormattingEnabled = true;
            this.RenderResolution_Box.Location = new System.Drawing.Point(161, 111);
            this.RenderResolution_Box.Margin = new System.Windows.Forms.Padding(4);
            this.RenderResolution_Box.Name = "RenderResolution_Box";
            this.RenderResolution_Box.Size = new System.Drawing.Size(160, 24);
            this.RenderResolution_Box.TabIndex = 44;
            // 
            // RenderResolution_Label
            // 
            this.RenderResolution_Label.AutoSize = true;
            this.RenderResolution_Label.Location = new System.Drawing.Point(17, 114);
            this.RenderResolution_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RenderResolution_Label.Name = "RenderResolution_Label";
            this.RenderResolution_Label.Size = new System.Drawing.Size(119, 16);
            this.RenderResolution_Label.TabIndex = 43;
            this.RenderResolution_Label.Text = "Render Resolution";
            // 
            // VSync_Box
            // 
            this.VSync_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSync_Box.FormattingEnabled = true;
            this.VSync_Box.Location = new System.Drawing.Point(161, 78);
            this.VSync_Box.Margin = new System.Windows.Forms.Padding(4);
            this.VSync_Box.Name = "VSync_Box";
            this.VSync_Box.Size = new System.Drawing.Size(160, 24);
            this.VSync_Box.TabIndex = 42;
            // 
            // VSync_Label
            // 
            this.VSync_Label.AutoSize = true;
            this.VSync_Label.Location = new System.Drawing.Point(17, 81);
            this.VSync_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VSync_Label.Name = "VSync_Label";
            this.VSync_Label.Size = new System.Drawing.Size(46, 16);
            this.VSync_Label.TabIndex = 41;
            this.VSync_Label.Text = "VSync";
            // 
            // FPS_Box
            // 
            this.FPS_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPS_Box.FormattingEnabled = true;
            this.FPS_Box.Location = new System.Drawing.Point(161, 44);
            this.FPS_Box.Margin = new System.Windows.Forms.Padding(4);
            this.FPS_Box.Name = "FPS_Box";
            this.FPS_Box.Size = new System.Drawing.Size(160, 24);
            this.FPS_Box.TabIndex = 40;
            // 
            // FPS_Label
            // 
            this.FPS_Label.AutoSize = true;
            this.FPS_Label.Location = new System.Drawing.Point(17, 48);
            this.FPS_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPS_Label.Name = "FPS_Label";
            this.FPS_Label.Size = new System.Drawing.Size(33, 16);
            this.FPS_Label.TabIndex = 39;
            this.FPS_Label.Text = "FPS";
            // 
            // GammaTrackBar
            // 
            this.GammaTrackBar.Location = new System.Drawing.Point(455, 310);
            this.GammaTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.GammaTrackBar.Maximum = 160;
            this.GammaTrackBar.Name = "GammaTrackBar";
            this.GammaTrackBar.Size = new System.Drawing.Size(197, 56);
            this.GammaTrackBar.TabIndex = 81;
            this.GammaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GammaTrackBar.ValueChanged += new System.EventHandler(this.GammaTrackBar_ValueChanged);
            // 
            // tabKeybindings
            // 
            this.tabKeybindings.Controls.Add(this.splitContainerControls);
            this.tabKeybindings.Location = new System.Drawing.Point(4, 25);
            this.tabKeybindings.Margin = new System.Windows.Forms.Padding(4);
            this.tabKeybindings.Name = "tabKeybindings";
            this.tabKeybindings.Padding = new System.Windows.Forms.Padding(4);
            this.tabKeybindings.Size = new System.Drawing.Size(721, 391);
            this.tabKeybindings.TabIndex = 3;
            this.tabKeybindings.Text = "Keybindings";
            // 
            // splitContainerControls
            // 
            this.splitContainerControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControls.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerControls.Location = new System.Drawing.Point(4, 4);
            this.splitContainerControls.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControls.Name = "splitContainerControls";
            this.splitContainerControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerControls.Panel1
            // 
            this.splitContainerControls.Panel1.Controls.Add(this.applyControlsButton);
            this.splitContainerControls.Panel1.Controls.Add(this.inputDeviceLabel);
            this.splitContainerControls.Panel1.Controls.Add(this.devicesList);
            // 
            // splitContainerControls.Panel2
            // 
            this.splitContainerControls.Panel2.AutoScroll = true;
            this.splitContainerControls.Panel2.Controls.Add(this.noControlsConfiguredLabel);
            this.splitContainerControls.Panel2.Controls.Add(this.comboBoxKeybindListTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonKeybindRemoveTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonKeybindingAddTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadAxisInvertTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadAxisTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.inputButtonTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.labelControlTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.buttonKeyTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxAltTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxShiftTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.checkBoxCtrlTemplate);
            this.splitContainerControls.Panel2.Controls.Add(this.gamepadButtonTemplate);
            this.splitContainerControls.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_BG);
            this.splitContainerControls.Size = new System.Drawing.Size(713, 383);
            this.splitContainerControls.SplitterDistance = 36;
            this.splitContainerControls.SplitterWidth = 5;
            this.splitContainerControls.TabIndex = 8;
            // 
            // applyControlsButton
            // 
            this.applyControlsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyControlsButton.Location = new System.Drawing.Point(604, 6);
            this.applyControlsButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyControlsButton.Name = "applyControlsButton";
            this.applyControlsButton.Size = new System.Drawing.Size(100, 28);
            this.applyControlsButton.TabIndex = 8;
            this.applyControlsButton.Text = "Apply";
            this.applyControlsButton.UseVisualStyleBackColor = true;
            this.applyControlsButton.Click += new System.EventHandler(this.Apply_Controls_Button_Click);
            // 
            // inputDeviceLabel
            // 
            this.inputDeviceLabel.AutoSize = true;
            this.inputDeviceLabel.Location = new System.Drawing.Point(9, 12);
            this.inputDeviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputDeviceLabel.Name = "inputDeviceLabel";
            this.inputDeviceLabel.Size = new System.Drawing.Size(79, 16);
            this.inputDeviceLabel.TabIndex = 7;
            this.inputDeviceLabel.Text = "Input device";
            // 
            // devicesList
            // 
            this.devicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesList.FormattingEnabled = true;
            this.devicesList.Location = new System.Drawing.Point(215, 7);
            this.devicesList.Margin = new System.Windows.Forms.Padding(4);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(380, 24);
            this.devicesList.TabIndex = 6;
            this.devicesList.SelectedIndexChanged += new System.EventHandler(this.Reload_Controls);
            // 
            // noControlsConfiguredLabel
            // 
            this.noControlsConfiguredLabel.AutoSize = true;
            this.noControlsConfiguredLabel.Location = new System.Drawing.Point(9, 12);
            this.noControlsConfiguredLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noControlsConfiguredLabel.Name = "noControlsConfiguredLabel";
            this.noControlsConfiguredLabel.Size = new System.Drawing.Size(527, 16);
            this.noControlsConfiguredLabel.TabIndex = 13;
            this.noControlsConfiguredLabel.Text = "No controls override configured. Please, change controls settings in game to gene" +
    "rate it.";
            this.noControlsConfiguredLabel.Visible = false;
            // 
            // comboBoxKeybindListTemplate
            // 
            this.comboBoxKeybindListTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeybindListTemplate.Enabled = false;
            this.comboBoxKeybindListTemplate.FormattingEnabled = true;
            this.comboBoxKeybindListTemplate.Location = new System.Drawing.Point(5, 6);
            this.comboBoxKeybindListTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKeybindListTemplate.Name = "comboBoxKeybindListTemplate";
            this.comboBoxKeybindListTemplate.Size = new System.Drawing.Size(160, 24);
            this.comboBoxKeybindListTemplate.TabIndex = 12;
            this.comboBoxKeybindListTemplate.Visible = false;
            // 
            // buttonKeybindRemoveTemplate
            // 
            this.buttonKeybindRemoveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeybindRemoveTemplate.Enabled = false;
            this.buttonKeybindRemoveTemplate.Location = new System.Drawing.Point(494, 5);
            this.buttonKeybindRemoveTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeybindRemoveTemplate.Name = "buttonKeybindRemoveTemplate";
            this.buttonKeybindRemoveTemplate.Size = new System.Drawing.Size(31, 28);
            this.buttonKeybindRemoveTemplate.TabIndex = 11;
            this.buttonKeybindRemoveTemplate.Text = "X";
            this.buttonKeybindRemoveTemplate.UseVisualStyleBackColor = true;
            this.buttonKeybindRemoveTemplate.Visible = false;
            // 
            // buttonKeybindingAddTemplate
            // 
            this.buttonKeybindingAddTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeybindingAddTemplate.Enabled = false;
            this.buttonKeybindingAddTemplate.Location = new System.Drawing.Point(782, 5);
            this.buttonKeybindingAddTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeybindingAddTemplate.Name = "buttonKeybindingAddTemplate";
            this.buttonKeybindingAddTemplate.Size = new System.Drawing.Size(100, 28);
            this.buttonKeybindingAddTemplate.TabIndex = 10;
            this.buttonKeybindingAddTemplate.Text = "Add";
            this.buttonKeybindingAddTemplate.UseVisualStyleBackColor = true;
            this.buttonKeybindingAddTemplate.Visible = false;
            // 
            // gamepadAxisInvertTemplate
            // 
            this.gamepadAxisInvertTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamepadAxisInvertTemplate.AutoSize = true;
            this.gamepadAxisInvertTemplate.Location = new System.Drawing.Point(652, 7);
            this.gamepadAxisInvertTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.gamepadAxisInvertTemplate.Name = "gamepadAxisInvertTemplate";
            this.gamepadAxisInvertTemplate.Size = new System.Drawing.Size(61, 20);
            this.gamepadAxisInvertTemplate.TabIndex = 9;
            this.gamepadAxisInvertTemplate.Text = "Invert";
            this.gamepadAxisInvertTemplate.UseVisualStyleBackColor = true;
            this.gamepadAxisInvertTemplate.Visible = false;
            // 
            // gamepadAxisTemplate
            // 
            this.gamepadAxisTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamepadAxisTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamepadAxisTemplate.Enabled = false;
            this.gamepadAxisTemplate.FormattingEnabled = true;
            this.gamepadAxisTemplate.Location = new System.Drawing.Point(721, 6);
            this.gamepadAxisTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.gamepadAxisTemplate.Name = "gamepadAxisTemplate";
            this.gamepadAxisTemplate.Size = new System.Drawing.Size(160, 24);
            this.gamepadAxisTemplate.TabIndex = 8;
            this.gamepadAxisTemplate.Visible = false;
            // 
            // inputButtonTemplate
            // 
            this.inputButtonTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButtonTemplate.Enabled = false;
            this.inputButtonTemplate.Location = new System.Drawing.Point(533, 6);
            this.inputButtonTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.inputButtonTemplate.Name = "inputButtonTemplate";
            this.inputButtonTemplate.Size = new System.Drawing.Size(156, 22);
            this.inputButtonTemplate.TabIndex = 6;
            this.inputButtonTemplate.Visible = false;
            // 
            // labelControlTemplate
            // 
            this.labelControlTemplate.AutoSize = true;
            this.labelControlTemplate.Location = new System.Drawing.Point(9, 11);
            this.labelControlTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelControlTemplate.Name = "labelControlTemplate";
            this.labelControlTemplate.Size = new System.Drawing.Size(89, 16);
            this.labelControlTemplate.TabIndex = 0;
            this.labelControlTemplate.Text = "Control Name";
            this.labelControlTemplate.Visible = false;
            // 
            // buttonKeyTemplate
            // 
            this.buttonKeyTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeyTemplate.Location = new System.Drawing.Point(533, 4);
            this.buttonKeyTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeyTemplate.Name = "buttonKeyTemplate";
            this.buttonKeyTemplate.Size = new System.Drawing.Size(157, 28);
            this.buttonKeyTemplate.TabIndex = 1;
            this.buttonKeyTemplate.Text = "Selected Key";
            this.buttonKeyTemplate.UseVisualStyleBackColor = true;
            this.buttonKeyTemplate.Visible = false;
            // 
            // checkBoxAltTemplate
            // 
            this.checkBoxAltTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAltTemplate.AutoSize = true;
            this.checkBoxAltTemplate.Location = new System.Drawing.Point(839, 7);
            this.checkBoxAltTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAltTemplate.Name = "checkBoxAltTemplate";
            this.checkBoxAltTemplate.Size = new System.Drawing.Size(44, 20);
            this.checkBoxAltTemplate.TabIndex = 4;
            this.checkBoxAltTemplate.Text = "Alt";
            this.checkBoxAltTemplate.UseVisualStyleBackColor = true;
            this.checkBoxAltTemplate.Visible = false;
            // 
            // checkBoxShiftTemplate
            // 
            this.checkBoxShiftTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShiftTemplate.AutoSize = true;
            this.checkBoxShiftTemplate.Location = new System.Drawing.Point(770, 7);
            this.checkBoxShiftTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShiftTemplate.Name = "checkBoxShiftTemplate";
            this.checkBoxShiftTemplate.Size = new System.Drawing.Size(54, 20);
            this.checkBoxShiftTemplate.TabIndex = 2;
            this.checkBoxShiftTemplate.Text = "Shift";
            this.checkBoxShiftTemplate.UseVisualStyleBackColor = true;
            this.checkBoxShiftTemplate.Visible = false;
            // 
            // checkBoxCtrlTemplate
            // 
            this.checkBoxCtrlTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCtrlTemplate.AutoSize = true;
            this.checkBoxCtrlTemplate.Location = new System.Drawing.Point(705, 7);
            this.checkBoxCtrlTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCtrlTemplate.Name = "checkBoxCtrlTemplate";
            this.checkBoxCtrlTemplate.Size = new System.Drawing.Size(48, 20);
            this.checkBoxCtrlTemplate.TabIndex = 3;
            this.checkBoxCtrlTemplate.Text = "Ctrl";
            this.checkBoxCtrlTemplate.UseVisualStyleBackColor = true;
            this.checkBoxCtrlTemplate.Visible = false;
            // 
            // gamepadButtonTemplate
            // 
            this.gamepadButtonTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gamepadButtonTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamepadButtonTemplate.Enabled = false;
            this.gamepadButtonTemplate.FormattingEnabled = true;
            this.gamepadButtonTemplate.Location = new System.Drawing.Point(721, 6);
            this.gamepadButtonTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.gamepadButtonTemplate.Name = "gamepadButtonTemplate";
            this.gamepadButtonTemplate.Size = new System.Drawing.Size(160, 24);
            this.gamepadButtonTemplate.TabIndex = 7;
            this.gamepadButtonTemplate.Visible = false;
            // 
            // tabControlsKeyboard
            // 
            this.tabControlsKeyboard.AutoScroll = true;
            this.tabControlsKeyboard.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlsKeyboard.Controls.Add(this.ControlsKeyboardResetButton);
            this.tabControlsKeyboard.Controls.Add(this.ApplyKeyboardControlsButton);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivity_Label);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivity_Value);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivity_Label);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivity_Value);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivityAiming_Value);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivityAiming_Label);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivityAiming_Label);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivityAiming_Value);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivity_TrackBar);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivity_TrackBar);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardHorizontalSensitivityAiming_TrackBar);
            this.tabControlsKeyboard.Controls.Add(this.KeyboardVerticalSensitivityAiming_TrackBar);
            this.tabControlsKeyboard.Location = new System.Drawing.Point(4, 25);
            this.tabControlsKeyboard.Name = "tabControlsKeyboard";
            this.tabControlsKeyboard.Size = new System.Drawing.Size(721, 391);
            this.tabControlsKeyboard.TabIndex = 7;
            this.tabControlsKeyboard.Text = "Controls (Keyboard)";
            // 
            // ApplyKeyboardControlsButton
            // 
            this.ApplyKeyboardControlsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyKeyboardControlsButton.Location = new System.Drawing.Point(612, 353);
            this.ApplyKeyboardControlsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyKeyboardControlsButton.Name = "ApplyKeyboardControlsButton";
            this.ApplyKeyboardControlsButton.Size = new System.Drawing.Size(100, 28);
            this.ApplyKeyboardControlsButton.TabIndex = 20;
            this.ApplyKeyboardControlsButton.Text = "Apply";
            this.ApplyKeyboardControlsButton.UseVisualStyleBackColor = true;
            this.ApplyKeyboardControlsButton.Click += new System.EventHandler(this.ApplyKeyboardControlsButton_Click);
            // 
            // KeyboardVerticalSensitivity_Label
            // 
            this.KeyboardVerticalSensitivity_Label.AutoSize = true;
            this.KeyboardVerticalSensitivity_Label.Location = new System.Drawing.Point(5, 59);
            this.KeyboardVerticalSensitivity_Label.Name = "KeyboardVerticalSensitivity_Label";
            this.KeyboardVerticalSensitivity_Label.Size = new System.Drawing.Size(115, 16);
            this.KeyboardVerticalSensitivity_Label.TabIndex = 1;
            this.KeyboardVerticalSensitivity_Label.Text = "Vertical Sensitivity";
            // 
            // KeyboardVerticalSensitivity_Value
            // 
            this.KeyboardVerticalSensitivity_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardVerticalSensitivity_Value.AutoSize = true;
            this.KeyboardVerticalSensitivity_Value.Location = new System.Drawing.Point(686, 59);
            this.KeyboardVerticalSensitivity_Value.Name = "KeyboardVerticalSensitivity_Value";
            this.KeyboardVerticalSensitivity_Value.Size = new System.Drawing.Size(18, 16);
            this.KeyboardVerticalSensitivity_Value.TabIndex = 2;
            this.KeyboardVerticalSensitivity_Value.Text = "-1";
            // 
            // KeyboardHorizontalSensitivity_Label
            // 
            this.KeyboardHorizontalSensitivity_Label.AutoSize = true;
            this.KeyboardHorizontalSensitivity_Label.Location = new System.Drawing.Point(5, 6);
            this.KeyboardHorizontalSensitivity_Label.Name = "KeyboardHorizontalSensitivity_Label";
            this.KeyboardHorizontalSensitivity_Label.Size = new System.Drawing.Size(130, 16);
            this.KeyboardHorizontalSensitivity_Label.TabIndex = 4;
            this.KeyboardHorizontalSensitivity_Label.Text = "Horizontal Sensitivity";
            // 
            // KeyboardHorizontalSensitivity_Value
            // 
            this.KeyboardHorizontalSensitivity_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardHorizontalSensitivity_Value.AutoSize = true;
            this.KeyboardHorizontalSensitivity_Value.Location = new System.Drawing.Point(686, 6);
            this.KeyboardHorizontalSensitivity_Value.Name = "KeyboardHorizontalSensitivity_Value";
            this.KeyboardHorizontalSensitivity_Value.Size = new System.Drawing.Size(18, 16);
            this.KeyboardHorizontalSensitivity_Value.TabIndex = 5;
            this.KeyboardHorizontalSensitivity_Value.Text = "-1";
            // 
            // KeyboardVerticalSensitivityAiming_Value
            // 
            this.KeyboardVerticalSensitivityAiming_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardVerticalSensitivityAiming_Value.AutoSize = true;
            this.KeyboardVerticalSensitivityAiming_Value.Location = new System.Drawing.Point(686, 165);
            this.KeyboardVerticalSensitivityAiming_Value.Name = "KeyboardVerticalSensitivityAiming_Value";
            this.KeyboardVerticalSensitivityAiming_Value.Size = new System.Drawing.Size(18, 16);
            this.KeyboardVerticalSensitivityAiming_Value.TabIndex = 11;
            this.KeyboardVerticalSensitivityAiming_Value.Text = "-1";
            // 
            // KeyboardVerticalSensitivityAiming_Label
            // 
            this.KeyboardVerticalSensitivityAiming_Label.AutoSize = true;
            this.KeyboardVerticalSensitivityAiming_Label.Location = new System.Drawing.Point(5, 165);
            this.KeyboardVerticalSensitivityAiming_Label.Name = "KeyboardVerticalSensitivityAiming_Label";
            this.KeyboardVerticalSensitivityAiming_Label.Size = new System.Drawing.Size(167, 16);
            this.KeyboardVerticalSensitivityAiming_Label.TabIndex = 10;
            this.KeyboardVerticalSensitivityAiming_Label.Text = "Vertical Sensitivity (Aiming)";
            // 
            // KeyboardHorizontalSensitivityAiming_Label
            // 
            this.KeyboardHorizontalSensitivityAiming_Label.AutoSize = true;
            this.KeyboardHorizontalSensitivityAiming_Label.Location = new System.Drawing.Point(5, 112);
            this.KeyboardHorizontalSensitivityAiming_Label.Name = "KeyboardHorizontalSensitivityAiming_Label";
            this.KeyboardHorizontalSensitivityAiming_Label.Size = new System.Drawing.Size(182, 16);
            this.KeyboardHorizontalSensitivityAiming_Label.TabIndex = 7;
            this.KeyboardHorizontalSensitivityAiming_Label.Text = "Horizontal Sensitivity (Aiming)";
            // 
            // KeyboardHorizontalSensitivityAiming_Value
            // 
            this.KeyboardHorizontalSensitivityAiming_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardHorizontalSensitivityAiming_Value.AutoSize = true;
            this.KeyboardHorizontalSensitivityAiming_Value.Location = new System.Drawing.Point(686, 112);
            this.KeyboardHorizontalSensitivityAiming_Value.Name = "KeyboardHorizontalSensitivityAiming_Value";
            this.KeyboardHorizontalSensitivityAiming_Value.Size = new System.Drawing.Size(18, 16);
            this.KeyboardHorizontalSensitivityAiming_Value.TabIndex = 8;
            this.KeyboardHorizontalSensitivityAiming_Value.Text = "-1";
            // 
            // KeyboardHorizontalSensitivity_TrackBar
            // 
            this.KeyboardHorizontalSensitivity_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardHorizontalSensitivity_TrackBar.Location = new System.Drawing.Point(3, 25);
            this.KeyboardHorizontalSensitivity_TrackBar.Maximum = 5;
            this.KeyboardHorizontalSensitivity_TrackBar.Minimum = 1;
            this.KeyboardHorizontalSensitivity_TrackBar.Name = "KeyboardHorizontalSensitivity_TrackBar";
            this.KeyboardHorizontalSensitivity_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.KeyboardHorizontalSensitivity_TrackBar.TabIndex = 0;
            this.KeyboardHorizontalSensitivity_TrackBar.Value = 1;
            this.KeyboardHorizontalSensitivity_TrackBar.ValueChanged += new System.EventHandler(this.KeyboardHorizontalSensitivity_TrackBar_ValueChanged);
            // 
            // KeyboardVerticalSensitivity_TrackBar
            // 
            this.KeyboardVerticalSensitivity_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardVerticalSensitivity_TrackBar.Location = new System.Drawing.Point(3, 78);
            this.KeyboardVerticalSensitivity_TrackBar.Maximum = 5;
            this.KeyboardVerticalSensitivity_TrackBar.Minimum = 1;
            this.KeyboardVerticalSensitivity_TrackBar.Name = "KeyboardVerticalSensitivity_TrackBar";
            this.KeyboardVerticalSensitivity_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.KeyboardVerticalSensitivity_TrackBar.TabIndex = 1;
            this.KeyboardVerticalSensitivity_TrackBar.Value = 1;
            this.KeyboardVerticalSensitivity_TrackBar.ValueChanged += new System.EventHandler(this.KeyboardVerticalSensitivity_TrackBar_ValueChanged);
            // 
            // KeyboardHorizontalSensitivityAiming_TrackBar
            // 
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Location = new System.Drawing.Point(3, 131);
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Maximum = 5;
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Minimum = 1;
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Name = "KeyboardHorizontalSensitivityAiming_TrackBar";
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.KeyboardHorizontalSensitivityAiming_TrackBar.TabIndex = 6;
            this.KeyboardHorizontalSensitivityAiming_TrackBar.Value = 1;
            this.KeyboardHorizontalSensitivityAiming_TrackBar.ValueChanged += new System.EventHandler(this.KeyboardHorizontalSensitivityAiming_TrackBar_ValueChanged);
            // 
            // KeyboardVerticalSensitivityAiming_TrackBar
            // 
            this.KeyboardVerticalSensitivityAiming_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardVerticalSensitivityAiming_TrackBar.Location = new System.Drawing.Point(3, 184);
            this.KeyboardVerticalSensitivityAiming_TrackBar.Maximum = 5;
            this.KeyboardVerticalSensitivityAiming_TrackBar.Minimum = 1;
            this.KeyboardVerticalSensitivityAiming_TrackBar.Name = "KeyboardVerticalSensitivityAiming_TrackBar";
            this.KeyboardVerticalSensitivityAiming_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.KeyboardVerticalSensitivityAiming_TrackBar.TabIndex = 9;
            this.KeyboardVerticalSensitivityAiming_TrackBar.Value = 1;
            this.KeyboardVerticalSensitivityAiming_TrackBar.ValueChanged += new System.EventHandler(this.KeyboardVerticalSensitivityAiming_TrackBar_ValueChanged);
            // 
            // tabControlsGamepad
            // 
            this.tabControlsGamepad.AutoScroll = true;
            this.tabControlsGamepad.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlsGamepad.Controls.Add(this.ResetGamepadControls_Button);
            this.tabControlsGamepad.Controls.Add(this.ApplyGamepadControls_Button);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivity_Label);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivity_Value);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivity_Label);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivity_Value);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivityAiming_Value);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivityAiming_Label);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivityAiming_Label);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivityAiming_Value);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivity_TrackBar);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivity_TrackBar);
            this.tabControlsGamepad.Controls.Add(this.GamepadHorizontalSensitivityAiming_TrackBar);
            this.tabControlsGamepad.Controls.Add(this.GamepadVerticalSensitivityAiming_TrackBar);
            this.tabControlsGamepad.Location = new System.Drawing.Point(4, 25);
            this.tabControlsGamepad.Name = "tabControlsGamepad";
            this.tabControlsGamepad.Size = new System.Drawing.Size(721, 391);
            this.tabControlsGamepad.TabIndex = 8;
            this.tabControlsGamepad.Text = "Controls (Gamepad)";
            // 
            // tabAudio
            // 
            this.tabAudio.AutoScroll = true;
            this.tabAudio.BackColor = System.Drawing.SystemColors.Control;
            this.tabAudio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAudio.Controls.Add(this.AudioResetButton);
            this.tabAudio.Controls.Add(this.comboBoxAudioFormat);
            this.tabAudio.Controls.Add(this.labelAudioOutputFormat);
            this.tabAudio.Controls.Add(this.comboBoxAudioDynamicRange);
            this.tabAudio.Controls.Add(this.labelAudioDynamicRange);
            this.tabAudio.Controls.Add(this.ApplyVolumeButton);
            this.tabAudio.Controls.Add(this.VoiceVolumeValueLabel);
            this.tabAudio.Controls.Add(this.trackBarVoiceVolume);
            this.tabAudio.Controls.Add(this.VoiceVolumeLabel);
            this.tabAudio.Controls.Add(this.SFXVolumeValueLabel);
            this.tabAudio.Controls.Add(this.trackBarSFXVolume);
            this.tabAudio.Controls.Add(this.SFXVolumeLabel);
            this.tabAudio.Controls.Add(this.MusicVolumeValueLabel);
            this.tabAudio.Controls.Add(this.trackBarMusicVolume);
            this.tabAudio.Controls.Add(this.MusicVolumeLabel);
            this.tabAudio.Controls.Add(this.MainVolumeValueLabel);
            this.tabAudio.Controls.Add(this.trackBarMainVolume);
            this.tabAudio.Controls.Add(this.MainVolumeLabel);
            this.tabAudio.Location = new System.Drawing.Point(4, 25);
            this.tabAudio.Margin = new System.Windows.Forms.Padding(4);
            this.tabAudio.Name = "tabAudio";
            this.tabAudio.Size = new System.Drawing.Size(721, 391);
            this.tabAudio.TabIndex = 4;
            this.tabAudio.Text = "Audio";
            // 
            // comboBoxAudioFormat
            // 
            this.comboBoxAudioFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAudioFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioFormat.FormattingEnabled = true;
            this.comboBoxAudioFormat.Items.AddRange(new object[] {
            "Stereo",
            "Surround"});
            this.comboBoxAudioFormat.Location = new System.Drawing.Point(545, 321);
            this.comboBoxAudioFormat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAudioFormat.Name = "comboBoxAudioFormat";
            this.comboBoxAudioFormat.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAudioFormat.TabIndex = 16;
            // 
            // labelAudioOutputFormat
            // 
            this.labelAudioOutputFormat.AutoSize = true;
            this.labelAudioOutputFormat.Location = new System.Drawing.Point(9, 325);
            this.labelAudioOutputFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAudioOutputFormat.Name = "labelAudioOutputFormat";
            this.labelAudioOutputFormat.Size = new System.Drawing.Size(90, 16);
            this.labelAudioOutputFormat.TabIndex = 15;
            this.labelAudioOutputFormat.Text = "Output Format";
            // 
            // comboBoxAudioDynamicRange
            // 
            this.comboBoxAudioDynamicRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAudioDynamicRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioDynamicRange.FormattingEnabled = true;
            this.comboBoxAudioDynamicRange.Items.AddRange(new object[] {
            "Full",
            "Limited"});
            this.comboBoxAudioDynamicRange.Location = new System.Drawing.Point(545, 288);
            this.comboBoxAudioDynamicRange.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAudioDynamicRange.Name = "comboBoxAudioDynamicRange";
            this.comboBoxAudioDynamicRange.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAudioDynamicRange.TabIndex = 14;
            // 
            // labelAudioDynamicRange
            // 
            this.labelAudioDynamicRange.AutoSize = true;
            this.labelAudioDynamicRange.Location = new System.Drawing.Point(9, 292);
            this.labelAudioDynamicRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAudioDynamicRange.Name = "labelAudioDynamicRange";
            this.labelAudioDynamicRange.Size = new System.Drawing.Size(104, 16);
            this.labelAudioDynamicRange.TabIndex = 13;
            this.labelAudioDynamicRange.Text = "Dynamic Range";
            // 
            // ApplyVolumeButton
            // 
            this.ApplyVolumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyVolumeButton.Location = new System.Drawing.Point(607, 353);
            this.ApplyVolumeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyVolumeButton.Name = "ApplyVolumeButton";
            this.ApplyVolumeButton.Size = new System.Drawing.Size(100, 28);
            this.ApplyVolumeButton.TabIndex = 12;
            this.ApplyVolumeButton.Text = "Apply";
            this.ApplyVolumeButton.UseVisualStyleBackColor = true;
            this.ApplyVolumeButton.Click += new System.EventHandler(this.Apply_Audio_Button_Click);
            // 
            // VoiceVolumeValueLabel
            // 
            this.VoiceVolumeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoiceVolumeValueLabel.AutoSize = true;
            this.VoiceVolumeValueLabel.Location = new System.Drawing.Point(685, 213);
            this.VoiceVolumeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VoiceVolumeValueLabel.Name = "VoiceVolumeValueLabel";
            this.VoiceVolumeValueLabel.Size = new System.Drawing.Size(18, 16);
            this.VoiceVolumeValueLabel.TabIndex = 11;
            this.VoiceVolumeValueLabel.Text = "-1";
            // 
            // trackBarVoiceVolume
            // 
            this.trackBarVoiceVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVoiceVolume.Location = new System.Drawing.Point(13, 233);
            this.trackBarVoiceVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarVoiceVolume.Name = "trackBarVoiceVolume";
            this.trackBarVoiceVolume.Size = new System.Drawing.Size(693, 56);
            this.trackBarVoiceVolume.TabIndex = 10;
            this.trackBarVoiceVolume.ValueChanged += new System.EventHandler(this.trackBarVoiceVolume_ValueChanged);
            // 
            // VoiceVolumeLabel
            // 
            this.VoiceVolumeLabel.AutoSize = true;
            this.VoiceVolumeLabel.Location = new System.Drawing.Point(9, 213);
            this.VoiceVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VoiceVolumeLabel.Name = "VoiceVolumeLabel";
            this.VoiceVolumeLabel.Size = new System.Drawing.Size(91, 16);
            this.VoiceVolumeLabel.TabIndex = 9;
            this.VoiceVolumeLabel.Text = "Voice Volume";
            // 
            // SFXVolumeValueLabel
            // 
            this.SFXVolumeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SFXVolumeValueLabel.AutoSize = true;
            this.SFXVolumeValueLabel.Location = new System.Drawing.Point(685, 150);
            this.SFXVolumeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SFXVolumeValueLabel.Name = "SFXVolumeValueLabel";
            this.SFXVolumeValueLabel.Size = new System.Drawing.Size(18, 16);
            this.SFXVolumeValueLabel.TabIndex = 8;
            this.SFXVolumeValueLabel.Text = "-1";
            // 
            // trackBarSFXVolume
            // 
            this.trackBarSFXVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSFXVolume.Location = new System.Drawing.Point(13, 170);
            this.trackBarSFXVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarSFXVolume.Name = "trackBarSFXVolume";
            this.trackBarSFXVolume.Size = new System.Drawing.Size(693, 56);
            this.trackBarSFXVolume.TabIndex = 7;
            this.trackBarSFXVolume.ValueChanged += new System.EventHandler(this.trackBarSFXVolume_ValueChanged);
            // 
            // SFXVolumeLabel
            // 
            this.SFXVolumeLabel.AutoSize = true;
            this.SFXVolumeLabel.Location = new System.Drawing.Point(9, 150);
            this.SFXVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SFXVolumeLabel.Name = "SFXVolumeLabel";
            this.SFXVolumeLabel.Size = new System.Drawing.Size(81, 16);
            this.SFXVolumeLabel.TabIndex = 6;
            this.SFXVolumeLabel.Text = "SFX Volume";
            // 
            // MusicVolumeValueLabel
            // 
            this.MusicVolumeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicVolumeValueLabel.AutoSize = true;
            this.MusicVolumeValueLabel.Location = new System.Drawing.Point(685, 87);
            this.MusicVolumeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MusicVolumeValueLabel.Name = "MusicVolumeValueLabel";
            this.MusicVolumeValueLabel.Size = new System.Drawing.Size(18, 16);
            this.MusicVolumeValueLabel.TabIndex = 5;
            this.MusicVolumeValueLabel.Text = "-1";
            // 
            // trackBarMusicVolume
            // 
            this.trackBarMusicVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMusicVolume.Location = new System.Drawing.Point(13, 107);
            this.trackBarMusicVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMusicVolume.Name = "trackBarMusicVolume";
            this.trackBarMusicVolume.Size = new System.Drawing.Size(693, 56);
            this.trackBarMusicVolume.TabIndex = 4;
            this.trackBarMusicVolume.ValueChanged += new System.EventHandler(this.trackBarMusicVolume_ValueChanged);
            // 
            // MusicVolumeLabel
            // 
            this.MusicVolumeLabel.AutoSize = true;
            this.MusicVolumeLabel.Location = new System.Drawing.Point(9, 87);
            this.MusicVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MusicVolumeLabel.Name = "MusicVolumeLabel";
            this.MusicVolumeLabel.Size = new System.Drawing.Size(91, 16);
            this.MusicVolumeLabel.TabIndex = 3;
            this.MusicVolumeLabel.Text = "Music Volume";
            // 
            // MainVolumeValueLabel
            // 
            this.MainVolumeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainVolumeValueLabel.AutoSize = true;
            this.MainVolumeValueLabel.Location = new System.Drawing.Point(685, 14);
            this.MainVolumeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainVolumeValueLabel.Name = "MainVolumeValueLabel";
            this.MainVolumeValueLabel.Size = new System.Drawing.Size(18, 16);
            this.MainVolumeValueLabel.TabIndex = 2;
            this.MainVolumeValueLabel.Text = "-1";
            // 
            // trackBarMainVolume
            // 
            this.trackBarMainVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMainVolume.Location = new System.Drawing.Point(13, 33);
            this.trackBarMainVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMainVolume.Name = "trackBarMainVolume";
            this.trackBarMainVolume.Size = new System.Drawing.Size(693, 56);
            this.trackBarMainVolume.TabIndex = 1;
            this.trackBarMainVolume.ValueChanged += new System.EventHandler(this.trackBarMainVolume_ValueChanged);
            // 
            // MainVolumeLabel
            // 
            this.MainVolumeLabel.AutoSize = true;
            this.MainVolumeLabel.Location = new System.Drawing.Point(9, 14);
            this.MainVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainVolumeLabel.Name = "MainVolumeLabel";
            this.MainVolumeLabel.Size = new System.Drawing.Size(85, 16);
            this.MainVolumeLabel.TabIndex = 0;
            this.MainVolumeLabel.Text = "Main Volume";
            // 
            // tabLanguage
            // 
            this.tabLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.tabLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLanguage.Controls.Add(this.LanguageResetButton);
            this.tabLanguage.Controls.Add(this.LanguageApplyButton);
            this.tabLanguage.Controls.Add(this.comboBoxVoiceLanguage);
            this.tabLanguage.Controls.Add(this.labelVoiceLanguage);
            this.tabLanguage.Controls.Add(this.comboBoxTextLanguage);
            this.tabLanguage.Controls.Add(this.labelTextLanguage);
            this.tabLanguage.Location = new System.Drawing.Point(4, 25);
            this.tabLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.tabLanguage.Name = "tabLanguage";
            this.tabLanguage.Size = new System.Drawing.Size(721, 391);
            this.tabLanguage.TabIndex = 6;
            this.tabLanguage.Text = "Language";
            // 
            // LanguageApplyButton
            // 
            this.LanguageApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageApplyButton.Location = new System.Drawing.Point(612, 353);
            this.LanguageApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageApplyButton.Name = "LanguageApplyButton";
            this.LanguageApplyButton.Size = new System.Drawing.Size(100, 28);
            this.LanguageApplyButton.TabIndex = 4;
            this.LanguageApplyButton.Text = "Apply";
            this.LanguageApplyButton.UseVisualStyleBackColor = true;
            this.LanguageApplyButton.Click += new System.EventHandler(this.Apply_Language_Button_Click);
            // 
            // comboBoxVoiceLanguage
            // 
            this.comboBoxVoiceLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVoiceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoiceLanguage.FormattingEnabled = true;
            this.comboBoxVoiceLanguage.Location = new System.Drawing.Point(545, 39);
            this.comboBoxVoiceLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVoiceLanguage.Name = "comboBoxVoiceLanguage";
            this.comboBoxVoiceLanguage.Size = new System.Drawing.Size(160, 24);
            this.comboBoxVoiceLanguage.TabIndex = 3;
            // 
            // labelVoiceLanguage
            // 
            this.labelVoiceLanguage.AutoSize = true;
            this.labelVoiceLanguage.Location = new System.Drawing.Point(9, 43);
            this.labelVoiceLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoiceLanguage.Name = "labelVoiceLanguage";
            this.labelVoiceLanguage.Size = new System.Drawing.Size(106, 16);
            this.labelVoiceLanguage.TabIndex = 2;
            this.labelVoiceLanguage.Text = "Voice Language";
            // 
            // comboBoxTextLanguage
            // 
            this.comboBoxTextLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTextLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTextLanguage.FormattingEnabled = true;
            this.comboBoxTextLanguage.Location = new System.Drawing.Point(545, 6);
            this.comboBoxTextLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTextLanguage.Name = "comboBoxTextLanguage";
            this.comboBoxTextLanguage.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTextLanguage.TabIndex = 1;
            // 
            // labelTextLanguage
            // 
            this.labelTextLanguage.AutoSize = true;
            this.labelTextLanguage.Location = new System.Drawing.Point(9, 10);
            this.labelTextLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextLanguage.Name = "labelTextLanguage";
            this.labelTextLanguage.Size = new System.Drawing.Size(97, 16);
            this.labelTextLanguage.TabIndex = 0;
            this.labelTextLanguage.Text = "Text Language";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.Reload_Log_Button);
            this.tabLog.Controls.Add(this.textBoxLog);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(4);
            this.tabLog.Size = new System.Drawing.Size(721, 391);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Launch Log";
            // 
            // Reload_Log_Button
            // 
            this.Reload_Log_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reload_Log_Button.Location = new System.Drawing.Point(608, 334);
            this.Reload_Log_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Reload_Log_Button.Name = "Reload_Log_Button";
            this.Reload_Log_Button.Size = new System.Drawing.Size(100, 28);
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
            this.textBoxLog.Location = new System.Drawing.Point(4, 4);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLog.MaxLength = 3276700;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(709, 322);
            this.textBoxLog.TabIndex = 0;
            // 
            // tabRawConfig
            // 
            this.tabRawConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRawConfig.Controls.Add(this.textBox_Config_Raw);
            this.tabRawConfig.Controls.Add(this.Load_Button_Raw);
            this.tabRawConfig.Controls.Add(this.Save_Button_Raw);
            this.tabRawConfig.Location = new System.Drawing.Point(4, 25);
            this.tabRawConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tabRawConfig.Name = "tabRawConfig";
            this.tabRawConfig.Padding = new System.Windows.Forms.Padding(4);
            this.tabRawConfig.Size = new System.Drawing.Size(721, 391);
            this.tabRawConfig.TabIndex = 1;
            this.tabRawConfig.Text = "Raw Config";
            // 
            // textBox_Config_Raw
            // 
            this.textBox_Config_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Config_Raw.Location = new System.Drawing.Point(12, 9);
            this.textBox_Config_Raw.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Config_Raw.MaxLength = 3276700;
            this.textBox_Config_Raw.Multiline = true;
            this.textBox_Config_Raw.Name = "textBox_Config_Raw";
            this.textBox_Config_Raw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Config_Raw.Size = new System.Drawing.Size(695, 317);
            this.textBox_Config_Raw.TabIndex = 2;
            // 
            // Load_Button_Raw
            // 
            this.Load_Button_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Button_Raw.Location = new System.Drawing.Point(500, 334);
            this.Load_Button_Raw.Margin = new System.Windows.Forms.Padding(4);
            this.Load_Button_Raw.Name = "Load_Button_Raw";
            this.Load_Button_Raw.Size = new System.Drawing.Size(100, 28);
            this.Load_Button_Raw.TabIndex = 1;
            this.Load_Button_Raw.Text = "Load";
            this.Load_Button_Raw.UseVisualStyleBackColor = true;
            this.Load_Button_Raw.Click += new System.EventHandler(this.Load_Button_Raw_Click);
            // 
            // Save_Button_Raw
            // 
            this.Save_Button_Raw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button_Raw.Location = new System.Drawing.Point(608, 334);
            this.Save_Button_Raw.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Button_Raw.Name = "Save_Button_Raw";
            this.Save_Button_Raw.Size = new System.Drawing.Size(100, 28);
            this.Save_Button_Raw.TabIndex = 0;
            this.Save_Button_Raw.Text = "Save";
            this.Save_Button_Raw.UseVisualStyleBackColor = true;
            this.Save_Button_Raw.Click += new System.EventHandler(this.Save_Button_Raw_Click);
            // 
            // ControlsKeyboardResetButton
            // 
            this.ControlsKeyboardResetButton.Location = new System.Drawing.Point(504, 353);
            this.ControlsKeyboardResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ControlsKeyboardResetButton.Name = "ControlsKeyboardResetButton";
            this.ControlsKeyboardResetButton.Size = new System.Drawing.Size(100, 28);
            this.ControlsKeyboardResetButton.TabIndex = 72;
            this.ControlsKeyboardResetButton.Text = "Reset";
            this.ControlsKeyboardResetButton.UseVisualStyleBackColor = true;
            this.ControlsKeyboardResetButton.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // AudioResetButton
            // 
            this.AudioResetButton.Location = new System.Drawing.Point(499, 353);
            this.AudioResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.AudioResetButton.Name = "AudioResetButton";
            this.AudioResetButton.Size = new System.Drawing.Size(100, 28);
            this.AudioResetButton.TabIndex = 72;
            this.AudioResetButton.Text = "Reset";
            this.AudioResetButton.UseVisualStyleBackColor = true;
            this.AudioResetButton.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // LanguageResetButton
            // 
            this.LanguageResetButton.Location = new System.Drawing.Point(504, 353);
            this.LanguageResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageResetButton.Name = "LanguageResetButton";
            this.LanguageResetButton.Size = new System.Drawing.Size(100, 28);
            this.LanguageResetButton.TabIndex = 72;
            this.LanguageResetButton.Text = "Reset";
            this.LanguageResetButton.UseVisualStyleBackColor = true;
            this.LanguageResetButton.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // GamepadVerticalSensitivity_Label
            // 
            this.GamepadVerticalSensitivity_Label.AutoSize = true;
            this.GamepadVerticalSensitivity_Label.Location = new System.Drawing.Point(5, 59);
            this.GamepadVerticalSensitivity_Label.Name = "GamepadVerticalSensitivity_Label";
            this.GamepadVerticalSensitivity_Label.Size = new System.Drawing.Size(115, 16);
            this.GamepadVerticalSensitivity_Label.TabIndex = 22;
            this.GamepadVerticalSensitivity_Label.Text = "Vertical Sensitivity";
            // 
            // GamepadVerticalSensitivity_Value
            // 
            this.GamepadVerticalSensitivity_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadVerticalSensitivity_Value.AutoSize = true;
            this.GamepadVerticalSensitivity_Value.Location = new System.Drawing.Point(686, 59);
            this.GamepadVerticalSensitivity_Value.Name = "GamepadVerticalSensitivity_Value";
            this.GamepadVerticalSensitivity_Value.Size = new System.Drawing.Size(18, 16);
            this.GamepadVerticalSensitivity_Value.TabIndex = 23;
            this.GamepadVerticalSensitivity_Value.Text = "-1";
            // 
            // GamepadHorizontalSensitivity_Label
            // 
            this.GamepadHorizontalSensitivity_Label.AutoSize = true;
            this.GamepadHorizontalSensitivity_Label.Location = new System.Drawing.Point(5, 6);
            this.GamepadHorizontalSensitivity_Label.Name = "GamepadHorizontalSensitivity_Label";
            this.GamepadHorizontalSensitivity_Label.Size = new System.Drawing.Size(130, 16);
            this.GamepadHorizontalSensitivity_Label.TabIndex = 24;
            this.GamepadHorizontalSensitivity_Label.Text = "Horizontal Sensitivity";
            // 
            // GamepadHorizontalSensitivity_Value
            // 
            this.GamepadHorizontalSensitivity_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadHorizontalSensitivity_Value.AutoSize = true;
            this.GamepadHorizontalSensitivity_Value.Location = new System.Drawing.Point(686, 6);
            this.GamepadHorizontalSensitivity_Value.Name = "GamepadHorizontalSensitivity_Value";
            this.GamepadHorizontalSensitivity_Value.Size = new System.Drawing.Size(18, 16);
            this.GamepadHorizontalSensitivity_Value.TabIndex = 25;
            this.GamepadHorizontalSensitivity_Value.Text = "-1";
            // 
            // GamepadVerticalSensitivityAiming_Value
            // 
            this.GamepadVerticalSensitivityAiming_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadVerticalSensitivityAiming_Value.AutoSize = true;
            this.GamepadVerticalSensitivityAiming_Value.Location = new System.Drawing.Point(686, 165);
            this.GamepadVerticalSensitivityAiming_Value.Name = "GamepadVerticalSensitivityAiming_Value";
            this.GamepadVerticalSensitivityAiming_Value.Size = new System.Drawing.Size(18, 16);
            this.GamepadVerticalSensitivityAiming_Value.TabIndex = 31;
            this.GamepadVerticalSensitivityAiming_Value.Text = "-1";
            // 
            // GamepadVerticalSensitivityAiming_Label
            // 
            this.GamepadVerticalSensitivityAiming_Label.AutoSize = true;
            this.GamepadVerticalSensitivityAiming_Label.Location = new System.Drawing.Point(5, 165);
            this.GamepadVerticalSensitivityAiming_Label.Name = "GamepadVerticalSensitivityAiming_Label";
            this.GamepadVerticalSensitivityAiming_Label.Size = new System.Drawing.Size(167, 16);
            this.GamepadVerticalSensitivityAiming_Label.TabIndex = 30;
            this.GamepadVerticalSensitivityAiming_Label.Text = "Vertical Sensitivity (Aiming)";
            // 
            // GamepadHorizontalSensitivityAiming_Label
            // 
            this.GamepadHorizontalSensitivityAiming_Label.AutoSize = true;
            this.GamepadHorizontalSensitivityAiming_Label.Location = new System.Drawing.Point(5, 112);
            this.GamepadHorizontalSensitivityAiming_Label.Name = "GamepadHorizontalSensitivityAiming_Label";
            this.GamepadHorizontalSensitivityAiming_Label.Size = new System.Drawing.Size(182, 16);
            this.GamepadHorizontalSensitivityAiming_Label.TabIndex = 27;
            this.GamepadHorizontalSensitivityAiming_Label.Text = "Horizontal Sensitivity (Aiming)";
            // 
            // GamepadHorizontalSensitivityAiming_Value
            // 
            this.GamepadHorizontalSensitivityAiming_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadHorizontalSensitivityAiming_Value.AutoSize = true;
            this.GamepadHorizontalSensitivityAiming_Value.Location = new System.Drawing.Point(686, 112);
            this.GamepadHorizontalSensitivityAiming_Value.Name = "GamepadHorizontalSensitivityAiming_Value";
            this.GamepadHorizontalSensitivityAiming_Value.Size = new System.Drawing.Size(18, 16);
            this.GamepadHorizontalSensitivityAiming_Value.TabIndex = 28;
            this.GamepadHorizontalSensitivityAiming_Value.Text = "-1";
            // 
            // GamepadHorizontalSensitivity_TrackBar
            // 
            this.GamepadHorizontalSensitivity_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadHorizontalSensitivity_TrackBar.Location = new System.Drawing.Point(3, 25);
            this.GamepadHorizontalSensitivity_TrackBar.Maximum = 5;
            this.GamepadHorizontalSensitivity_TrackBar.Minimum = 1;
            this.GamepadHorizontalSensitivity_TrackBar.Name = "GamepadHorizontalSensitivity_TrackBar";
            this.GamepadHorizontalSensitivity_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.GamepadHorizontalSensitivity_TrackBar.TabIndex = 20;
            this.GamepadHorizontalSensitivity_TrackBar.Value = 1;
            this.GamepadHorizontalSensitivity_TrackBar.ValueChanged += new System.EventHandler(this.GamepadHorizontalSensitivity_TrackBar_ValueChanged);
            // 
            // GamepadVerticalSensitivity_TrackBar
            // 
            this.GamepadVerticalSensitivity_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadVerticalSensitivity_TrackBar.Location = new System.Drawing.Point(3, 78);
            this.GamepadVerticalSensitivity_TrackBar.Maximum = 5;
            this.GamepadVerticalSensitivity_TrackBar.Minimum = 1;
            this.GamepadVerticalSensitivity_TrackBar.Name = "GamepadVerticalSensitivity_TrackBar";
            this.GamepadVerticalSensitivity_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.GamepadVerticalSensitivity_TrackBar.TabIndex = 21;
            this.GamepadVerticalSensitivity_TrackBar.Value = 1;
            this.GamepadVerticalSensitivity_TrackBar.ValueChanged += new System.EventHandler(this.GamepadVerticalSensitivity_TrackBar_ValueChanged);
            // 
            // GamepadHorizontalSensitivityAiming_TrackBar
            // 
            this.GamepadHorizontalSensitivityAiming_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadHorizontalSensitivityAiming_TrackBar.Location = new System.Drawing.Point(3, 131);
            this.GamepadHorizontalSensitivityAiming_TrackBar.Maximum = 5;
            this.GamepadHorizontalSensitivityAiming_TrackBar.Minimum = 1;
            this.GamepadHorizontalSensitivityAiming_TrackBar.Name = "GamepadHorizontalSensitivityAiming_TrackBar";
            this.GamepadHorizontalSensitivityAiming_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.GamepadHorizontalSensitivityAiming_TrackBar.TabIndex = 26;
            this.GamepadHorizontalSensitivityAiming_TrackBar.Value = 1;
            this.GamepadHorizontalSensitivityAiming_TrackBar.ValueChanged += new System.EventHandler(this.GamepadHorizontalSensitivityAiming_TrackBar_ValueChanged);
            // 
            // GamepadVerticalSensitivityAiming_TrackBar
            // 
            this.GamepadVerticalSensitivityAiming_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamepadVerticalSensitivityAiming_TrackBar.Location = new System.Drawing.Point(3, 184);
            this.GamepadVerticalSensitivityAiming_TrackBar.Maximum = 5;
            this.GamepadVerticalSensitivityAiming_TrackBar.Minimum = 1;
            this.GamepadVerticalSensitivityAiming_TrackBar.Name = "GamepadVerticalSensitivityAiming_TrackBar";
            this.GamepadVerticalSensitivityAiming_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.GamepadVerticalSensitivityAiming_TrackBar.TabIndex = 29;
            this.GamepadVerticalSensitivityAiming_TrackBar.Value = 1;
            this.GamepadVerticalSensitivityAiming_TrackBar.ValueChanged += new System.EventHandler(this.GamepadVerticalSensitivityAiming_TrackBar_ValueChanged);
            // 
            // ResetGamepadControls_Button
            // 
            this.ResetGamepadControls_Button.Location = new System.Drawing.Point(502, 355);
            this.ResetGamepadControls_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ResetGamepadControls_Button.Name = "ResetGamepadControls_Button";
            this.ResetGamepadControls_Button.Size = new System.Drawing.Size(100, 28);
            this.ResetGamepadControls_Button.TabIndex = 74;
            this.ResetGamepadControls_Button.Text = "Reset";
            this.ResetGamepadControls_Button.UseVisualStyleBackColor = true;
            this.ResetGamepadControls_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // ApplyGamepadControls_Button
            // 
            this.ApplyGamepadControls_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyGamepadControls_Button.Location = new System.Drawing.Point(610, 355);
            this.ApplyGamepadControls_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyGamepadControls_Button.Name = "ApplyGamepadControls_Button";
            this.ApplyGamepadControls_Button.Size = new System.Drawing.Size(100, 28);
            this.ApplyGamepadControls_Button.TabIndex = 73;
            this.ApplyGamepadControls_Button.Text = "Apply";
            this.ApplyGamepadControls_Button.UseVisualStyleBackColor = true;
            this.ApplyGamepadControls_Button.Click += new System.EventHandler(this.ApplyGamepadControls_Button_Click);
            // 
            // tabControlsMisc
            // 
            this.tabControlsMisc.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlsMisc.Controls.Add(this.MiscResetButton);
            this.tabControlsMisc.Controls.Add(this.MiscApplyButton);
            this.tabControlsMisc.Controls.Add(this.MiscAutomaticBoatCameraAngleCorrection_Box);
            this.tabControlsMisc.Controls.Add(this.MiscAutomaticBoatCameraAngleCorrection_Label);
            this.tabControlsMisc.Controls.Add(this.MiscDefaultCameraHeight_Value);
            this.tabControlsMisc.Controls.Add(this.MiscDefaultCameraHeight_Label);
            this.tabControlsMisc.Controls.Add(this.MiscSmartCombatCamera_Checkbox);
            this.tabControlsMisc.Controls.Add(this.MiscAutomaticViewHeight_Checkbox);
            this.tabControlsMisc.Controls.Add(this.MiscDefaultCameraHeight_TrackBar);
            this.tabControlsMisc.Location = new System.Drawing.Point(4, 25);
            this.tabControlsMisc.Name = "tabControlsMisc";
            this.tabControlsMisc.Size = new System.Drawing.Size(721, 391);
            this.tabControlsMisc.TabIndex = 9;
            this.tabControlsMisc.Text = "Controls (Misc)";
            // 
            // MiscAutomaticBoatCameraAngleCorrection_Box
            // 
            this.MiscAutomaticBoatCameraAngleCorrection_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiscAutomaticBoatCameraAngleCorrection_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MiscAutomaticBoatCameraAngleCorrection_Box.FormattingEnabled = true;
            this.MiscAutomaticBoatCameraAngleCorrection_Box.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Not in combat"});
            this.MiscAutomaticBoatCameraAngleCorrection_Box.Location = new System.Drawing.Point(592, 111);
            this.MiscAutomaticBoatCameraAngleCorrection_Box.Name = "MiscAutomaticBoatCameraAngleCorrection_Box";
            this.MiscAutomaticBoatCameraAngleCorrection_Box.Size = new System.Drawing.Size(121, 24);
            this.MiscAutomaticBoatCameraAngleCorrection_Box.TabIndex = 26;
            // 
            // MiscAutomaticBoatCameraAngleCorrection_Label
            // 
            this.MiscAutomaticBoatCameraAngleCorrection_Label.AutoSize = true;
            this.MiscAutomaticBoatCameraAngleCorrection_Label.Location = new System.Drawing.Point(5, 114);
            this.MiscAutomaticBoatCameraAngleCorrection_Label.Name = "MiscAutomaticBoatCameraAngleCorrection_Label";
            this.MiscAutomaticBoatCameraAngleCorrection_Label.Size = new System.Drawing.Size(250, 16);
            this.MiscAutomaticBoatCameraAngleCorrection_Label.TabIndex = 25;
            this.MiscAutomaticBoatCameraAngleCorrection_Label.Text = "Automatic Boat Camera Angle Correction";
            // 
            // MiscDefaultCameraHeight_Value
            // 
            this.MiscDefaultCameraHeight_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiscDefaultCameraHeight_Value.AutoSize = true;
            this.MiscDefaultCameraHeight_Value.Location = new System.Drawing.Point(686, 60);
            this.MiscDefaultCameraHeight_Value.Name = "MiscDefaultCameraHeight_Value";
            this.MiscDefaultCameraHeight_Value.Size = new System.Drawing.Size(18, 16);
            this.MiscDefaultCameraHeight_Value.TabIndex = 24;
            this.MiscDefaultCameraHeight_Value.Text = "-1";
            // 
            // MiscDefaultCameraHeight_Label
            // 
            this.MiscDefaultCameraHeight_Label.AutoSize = true;
            this.MiscDefaultCameraHeight_Label.Location = new System.Drawing.Point(5, 60);
            this.MiscDefaultCameraHeight_Label.Name = "MiscDefaultCameraHeight_Label";
            this.MiscDefaultCameraHeight_Label.Size = new System.Drawing.Size(142, 16);
            this.MiscDefaultCameraHeight_Label.TabIndex = 23;
            this.MiscDefaultCameraHeight_Label.Text = "Default Camera Height";
            // 
            // MiscSmartCombatCamera_Checkbox
            // 
            this.MiscSmartCombatCamera_Checkbox.AutoSize = true;
            this.MiscSmartCombatCamera_Checkbox.Location = new System.Drawing.Point(11, 37);
            this.MiscSmartCombatCamera_Checkbox.Name = "MiscSmartCombatCamera_Checkbox";
            this.MiscSmartCombatCamera_Checkbox.Size = new System.Drawing.Size(152, 20);
            this.MiscSmartCombatCamera_Checkbox.TabIndex = 21;
            this.MiscSmartCombatCamera_Checkbox.Text = "Smart Battle Camera";
            this.MiscSmartCombatCamera_Checkbox.UseVisualStyleBackColor = true;
            // 
            // MiscAutomaticViewHeight_Checkbox
            // 
            this.MiscAutomaticViewHeight_Checkbox.AutoSize = true;
            this.MiscAutomaticViewHeight_Checkbox.Location = new System.Drawing.Point(11, 11);
            this.MiscAutomaticViewHeight_Checkbox.Name = "MiscAutomaticViewHeight_Checkbox";
            this.MiscAutomaticViewHeight_Checkbox.Size = new System.Drawing.Size(162, 20);
            this.MiscAutomaticViewHeight_Checkbox.TabIndex = 20;
            this.MiscAutomaticViewHeight_Checkbox.Text = "Automatic View Height";
            this.MiscAutomaticViewHeight_Checkbox.UseVisualStyleBackColor = true;
            // 
            // MiscDefaultCameraHeight_TrackBar
            // 
            this.MiscDefaultCameraHeight_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MiscDefaultCameraHeight_TrackBar.Location = new System.Drawing.Point(3, 79);
            this.MiscDefaultCameraHeight_TrackBar.Maximum = 60;
            this.MiscDefaultCameraHeight_TrackBar.Minimum = 45;
            this.MiscDefaultCameraHeight_TrackBar.Name = "MiscDefaultCameraHeight_TrackBar";
            this.MiscDefaultCameraHeight_TrackBar.Size = new System.Drawing.Size(710, 56);
            this.MiscDefaultCameraHeight_TrackBar.TabIndex = 22;
            this.MiscDefaultCameraHeight_TrackBar.Value = 45;
            this.MiscDefaultCameraHeight_TrackBar.ValueChanged += new System.EventHandler(this.DefaultCameraHeight_TrackBar_ValueChanged);
            // 
            // MiscResetButton
            // 
            this.MiscResetButton.Location = new System.Drawing.Point(505, 359);
            this.MiscResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.MiscResetButton.Name = "MiscResetButton";
            this.MiscResetButton.Size = new System.Drawing.Size(100, 28);
            this.MiscResetButton.TabIndex = 76;
            this.MiscResetButton.Text = "Reset";
            this.MiscResetButton.UseVisualStyleBackColor = true;
            this.MiscResetButton.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // MiscApplyButton
            // 
            this.MiscApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MiscApplyButton.Location = new System.Drawing.Point(613, 359);
            this.MiscApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.MiscApplyButton.Name = "MiscApplyButton";
            this.MiscApplyButton.Size = new System.Drawing.Size(100, 28);
            this.MiscApplyButton.TabIndex = 75;
            this.MiscApplyButton.Text = "Apply";
            this.MiscApplyButton.UseVisualStyleBackColor = true;
            this.MiscApplyButton.Click += new System.EventHandler(this.ApplyMiscControlsButton_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(729, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.settingsTabs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(747, 528);
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
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).EndInit();
            this.tabKeybindings.ResumeLayout(false);
            this.splitContainerControls.Panel1.ResumeLayout(false);
            this.splitContainerControls.Panel1.PerformLayout();
            this.splitContainerControls.Panel2.ResumeLayout(false);
            this.splitContainerControls.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControls)).EndInit();
            this.splitContainerControls.ResumeLayout(false);
            this.tabControlsKeyboard.ResumeLayout(false);
            this.tabControlsKeyboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardHorizontalSensitivity_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardVerticalSensitivity_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardHorizontalSensitivityAiming_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardVerticalSensitivityAiming_TrackBar)).EndInit();
            this.tabControlsGamepad.ResumeLayout(false);
            this.tabControlsGamepad.PerformLayout();
            this.tabAudio.ResumeLayout(false);
            this.tabAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSFXVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMainVolume)).EndInit();
            this.tabLanguage.ResumeLayout(false);
            this.tabLanguage.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabRawConfig.ResumeLayout(false);
            this.tabRawConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadHorizontalSensitivity_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadVerticalSensitivity_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadHorizontalSensitivityAiming_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamepadVerticalSensitivityAiming_TrackBar)).EndInit();
            this.tabControlsMisc.ResumeLayout(false);
            this.tabControlsMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiscDefaultCameraHeight_TrackBar)).EndInit();
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
        private System.Windows.Forms.TabPage tabKeybindings;
        private System.Windows.Forms.Label inputDeviceLabel;
        private System.Windows.Forms.ComboBox devicesList;
        private System.Windows.Forms.SplitContainer splitContainerControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem devModeToggle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.CheckBox gamepadAxisInvertTemplate;
        private System.Windows.Forms.ComboBox gamepadAxisTemplate;
        private System.Windows.Forms.TextBox inputButtonTemplate;
        private System.Windows.Forms.Label labelControlTemplate;
        private System.Windows.Forms.Button buttonKeyTemplate;
        private System.Windows.Forms.CheckBox checkBoxAltTemplate;
        private System.Windows.Forms.CheckBox checkBoxShiftTemplate;
        private System.Windows.Forms.CheckBox checkBoxCtrlTemplate;
        private System.Windows.Forms.ComboBox gamepadButtonTemplate;
        private System.Windows.Forms.Button applyControlsButton;
        private System.Windows.Forms.Label ResolutionX;
        private System.Windows.Forms.Label Resolution_Label;
        private System.Windows.Forms.Button buttonKeybindRemoveTemplate;
        private System.Windows.Forms.Button buttonKeybindingAddTemplate;
        private System.Windows.Forms.ComboBox comboBoxKeybindListTemplate;
        private System.Windows.Forms.TabPage tabAudio;
        private System.Windows.Forms.Label MusicVolumeValueLabel;
        private System.Windows.Forms.TrackBar trackBarMusicVolume;
        private System.Windows.Forms.Label MusicVolumeLabel;
        private System.Windows.Forms.Label MainVolumeValueLabel;
        private System.Windows.Forms.TrackBar trackBarMainVolume;
        private System.Windows.Forms.Label MainVolumeLabel;
        private System.Windows.Forms.Label VoiceVolumeValueLabel;
        private System.Windows.Forms.TrackBar trackBarVoiceVolume;
        private System.Windows.Forms.Label VoiceVolumeLabel;
        private System.Windows.Forms.Label SFXVolumeValueLabel;
        private System.Windows.Forms.TrackBar trackBarSFXVolume;
        private System.Windows.Forms.Label SFXVolumeLabel;
        private System.Windows.Forms.Button ApplyVolumeButton;
        private System.Windows.Forms.ToolStripDropDownButton controlsMenu;
        private System.Windows.Forms.ToolStripMenuItem addMouseButton;
        private System.Windows.Forms.TabPage tabLanguage;
        private System.Windows.Forms.Button LanguageApplyButton;
        private System.Windows.Forms.ComboBox comboBoxVoiceLanguage;
        private System.Windows.Forms.Label labelVoiceLanguage;
        private System.Windows.Forms.ComboBox comboBoxTextLanguage;
        private System.Windows.Forms.Label labelTextLanguage;
        private System.Windows.Forms.ComboBox comboBoxAudioFormat;
        private System.Windows.Forms.Label labelAudioOutputFormat;
        private System.Windows.Forms.ComboBox comboBoxAudioDynamicRange;
        private System.Windows.Forms.Label labelAudioDynamicRange;
        private System.Windows.Forms.Label GammaValueLabel;
        private System.Windows.Forms.Label Gamma_Label;
        private System.Windows.Forms.TrackBar GammaTrackBar;
        private System.Windows.Forms.Label noControlsConfiguredLabel;
        private System.Windows.Forms.TabPage tabControlsKeyboard;
        private System.Windows.Forms.TabPage tabControlsGamepad;
        private System.Windows.Forms.Label KeyboardVerticalSensitivity_Label;
        private System.Windows.Forms.Label KeyboardVerticalSensitivity_Value;
        private System.Windows.Forms.Label KeyboardHorizontalSensitivity_Label;
        private System.Windows.Forms.Label KeyboardHorizontalSensitivity_Value;
        private System.Windows.Forms.Label KeyboardVerticalSensitivityAiming_Value;
        private System.Windows.Forms.Label KeyboardVerticalSensitivityAiming_Label;
        private System.Windows.Forms.Label KeyboardHorizontalSensitivityAiming_Label;
        private System.Windows.Forms.Label KeyboardHorizontalSensitivityAiming_Value;
        private System.Windows.Forms.TrackBar KeyboardHorizontalSensitivity_TrackBar;
        private System.Windows.Forms.TrackBar KeyboardVerticalSensitivity_TrackBar;
        private System.Windows.Forms.TrackBar KeyboardHorizontalSensitivityAiming_TrackBar;
        private System.Windows.Forms.TrackBar KeyboardVerticalSensitivityAiming_TrackBar;
        private System.Windows.Forms.Button ApplyKeyboardControlsButton;
        private System.Windows.Forms.Button ControlsKeyboardResetButton;
        private System.Windows.Forms.Button AudioResetButton;
        private System.Windows.Forms.Button LanguageResetButton;
        private System.Windows.Forms.Label GamepadVerticalSensitivity_Label;
        private System.Windows.Forms.Label GamepadVerticalSensitivity_Value;
        private System.Windows.Forms.Label GamepadHorizontalSensitivity_Label;
        private System.Windows.Forms.Label GamepadHorizontalSensitivity_Value;
        private System.Windows.Forms.Label GamepadVerticalSensitivityAiming_Value;
        private System.Windows.Forms.Label GamepadVerticalSensitivityAiming_Label;
        private System.Windows.Forms.Label GamepadHorizontalSensitivityAiming_Label;
        private System.Windows.Forms.Label GamepadHorizontalSensitivityAiming_Value;
        private System.Windows.Forms.TrackBar GamepadHorizontalSensitivity_TrackBar;
        private System.Windows.Forms.TrackBar GamepadVerticalSensitivity_TrackBar;
        private System.Windows.Forms.TrackBar GamepadHorizontalSensitivityAiming_TrackBar;
        private System.Windows.Forms.TrackBar GamepadVerticalSensitivityAiming_TrackBar;
        private System.Windows.Forms.Button ResetGamepadControls_Button;
        private System.Windows.Forms.Button ApplyGamepadControls_Button;
        private System.Windows.Forms.TabPage tabControlsMisc;
        private System.Windows.Forms.ComboBox MiscAutomaticBoatCameraAngleCorrection_Box;
        private System.Windows.Forms.Label MiscAutomaticBoatCameraAngleCorrection_Label;
        private System.Windows.Forms.Label MiscDefaultCameraHeight_Value;
        private System.Windows.Forms.Label MiscDefaultCameraHeight_Label;
        private System.Windows.Forms.CheckBox MiscSmartCombatCamera_Checkbox;
        private System.Windows.Forms.CheckBox MiscAutomaticViewHeight_Checkbox;
        private System.Windows.Forms.TrackBar MiscDefaultCameraHeight_TrackBar;
        private System.Windows.Forms.Button MiscResetButton;
        private System.Windows.Forms.Button MiscApplyButton;
    }
}

