using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static GenshinConfigurator.Enums;

namespace GenshinConfigurator
{
    public partial class MainWin : Form
    {
        SettingsContainer Settings;
        ResolutionSettings Resolution;
        public MainWin()
        {
            InitializeComponent();
        }

        // Global functions
        private void MainWin_Load(object sender, EventArgs e)
        {
            try
            {
                Settings = new SettingsContainer();
                Resolution = Settings.Resolution;
                if (Settings.controlsLoaded == false || Settings.graphicsLoaded == false)
                {
                    DialogResult result = MessageBox.Show("Some part of your config is corrupted. Continuing may be dangerous.\nLaunch recovery mode?", "Config error", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Shown += (s, args) => this.Hide();
                        Recovery rec = new Recovery();
                        rec.Closed += (s, args) => this.Close();
                        rec.Show();
                    }
                }
                if (Settings.controlsLoaded)
                {
                    if (Settings.Controls.controller_ids.Count == 0)
                    {
                        devicesList.Items.Add("No devices");
                        devicesList.Enabled = false;
                        applyControlsButton.Enabled = false;
                        noControlsConfiguredLabel.Visible = true;
                    }
                    else
                    {
                        foreach (string controller_id in Settings.Controls.controller_ids)
                        {
                            string[] parts = controller_id.Split(new[] { "__" }, StringSplitOptions.None);
                            string name = "";
                            if (parts[1] == "d74a350e-fe8b-4e9e-bbcd-efff16d34115")
                            {
                                name = "XInput Gamepad (" + parts[2] + ")";
                            }
                            else if ((parts[1] == "00000000-0000-0000-0000-000000000000") && (parts[2] == "0"))
                            {
                                name = "Keyboard (" + parts[2] + ")";
                            }
                            else if ((parts[1] == "00000000-0000-0000-0000-000000000000") && (parts[2] == "1000000"))
                            {
                                name = "Mouse (" + parts[2] + ")";
                            }
                            devicesList.Items.Add(name);
                        }
                    }
                    devicesList.SelectedIndex = 0;
                    //Task.Run(() => Populate_Controls());
                }
                if (Settings.graphicsLoaded)
                {
                    FPS_Box.Items.AddRange(Enum.GetNames(typeof(FPS)).Skip(1).ToArray());
                    VSync_Box.Items.AddRange(Enum.GetNames(typeof(VSync)).Skip(1).ToArray());
                    RenderResolution_Box.Items.AddRange(Enum.GetNames(typeof(RenderResolution)).Skip(1).ToArray());
                    ShadowQuality_Box.Items.AddRange(Enum.GetNames(typeof(ShadowQuality)).Skip(1).ToArray());
                    VisualEffects_Box.Items.AddRange(Enum.GetNames(typeof(VisualEffects)).Skip(1).ToArray());
                    SFXQuality_Box.Items.AddRange(Enum.GetNames(typeof(SFXQuality)).Skip(1).ToArray());
                    EnvironmentDetail_Box.Items.AddRange(Enum.GetNames(typeof(EnvironmentDetail)).Skip(1).ToArray());
                    Antialiasing_Box.Items.AddRange(Enum.GetNames(typeof(Antialiasing)).Skip(1).ToArray());
                    VolumetricFog_Box.Items.AddRange(Enum.GetNames(typeof(VolumetricFog)).Skip(1).ToArray());
                    Reflections_Box.Items.AddRange(Enum.GetNames(typeof(Reflections)).Skip(1).ToArray());
                    MotionBlur_Box.Items.AddRange(Enum.GetNames(typeof(MotionBlur)).Skip(1).ToArray());
                    Bloom_Box.Items.AddRange(Enum.GetNames(typeof(Bloom)).Skip(1).ToArray());
                    CrowdDensity_Box.Items.AddRange(Enum.GetNames(typeof(CrowdDensity)).Skip(1).ToArray());
                    SubsurfaceScattering_Box.Items.AddRange(Enum.GetNames(typeof(SubsurfaceScattering)).Skip(1).ToArray());
                    TeammateEffects_Box.Items.AddRange(Enum.GetNames(typeof(TeammateEffects)).Skip(1).ToArray());
                    AnisotropicFiltering_Box.Items.AddRange(Enum.GetNames(typeof(AnisotropicFiltering)).Skip(1).ToArray());
                    Preset_Box.Items.AddRange(Enum.GetNames(typeof(OverallQuality)));
                    Reset_Button_Click(null, null);
                }
                Status_Label.Text = "Loaded config from registry.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            } 
            catch
            {
                DialogResult result = MessageBox.Show("Some part of your config is corrupted. Can't contunue loading.\nLaunch recovery mode?", "Config error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Shown += (s, args) => this.Hide();
                    Recovery rec = new Recovery();
                    rec.Closed += (s, args) => this.Close();
                    rec.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog
            {
                Filter = "JSON config|*.json",
                DefaultExt = ".json",
                AddExtension = true,
                RestoreDirectory = true,
                OverwritePrompt = true
            };
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Save(Path.GetFullPath(savedialog.FileName));
                Status_Label.Text = $"Saved config to {savedialog.FileName}.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loaddialog = new OpenFileDialog
            {
                Filter = "JSON config|*.json",
                RestoreDirectory = true
            };
            if (loaddialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Load(Path.GetFullPath(loaddialog.FileName));
                Status_Label.Text = $"Loaded config from {loaddialog.FileName}. Apply necessary parts.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            }
            Reset_Button_Click(null, null);
        }

        private void Status_Reset_Timer_Tick(object sender, EventArgs e)
        {
            Status_Label.Text = "Ready.";
            Status_Reset_Timer.Enabled = false;
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            if (Settings.Graphics.current_preset == -1)
            {
                Preset_Box.SelectedIndex = 4;
            }
            else
            {
                Preset_Box.SelectedIndex = Settings.Graphics.current_preset - 1;
            }
            FPS_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.FPS) - 1;
            VSync_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.VSync) - 1;
            RenderResolution_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.RenderResolution) - 1;
            ShadowQuality_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.ShadowQuality) - 1;
            VisualEffects_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.VisualEffects) - 1;
            SFXQuality_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.SFXQuality) - 1;
            EnvironmentDetail_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.EnvironmentDetail) - 1;
            Antialiasing_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.Antialiasing) - 1;
            VolumetricFog_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.VolumetricFog) - 1;
            Reflections_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.Reflections) - 1;
            MotionBlur_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.MotionBlur) - 1;
            Bloom_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.Bloom) - 1;
            CrowdDensity_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.CrowdDensity) - 1;
            SubsurfaceScattering_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.SubsurfaceScattering) - 1;
            TeammateEffects_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.TeammateEffects) - 1;
            AnisotropicFiltering_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.AnisotropicFiltering) - 1;
            Width_Text.Text = Resolution.Get((int)ResolutionData.Width).ToString();
            Height_Text.Text = Resolution.Get((int)ResolutionData.Height).ToString();
            if (Convert.ToBoolean(Resolution.Get((int)ResolutionData.Fullscreen)))
            {
                Fullscreen_Check.Checked = true;
            }
            else
            {
                Fullscreen_Check.Checked = false;
            }
            trackBarVoiceVolume.Value = Settings.Audio.voice_volume;
            trackBarSFXVolume.Value = Settings.Audio.sfx_volume;
            trackBarMusicVolume.Value = Settings.Audio.music_volume;
            trackBarMainVolume.Value = Settings.Audio.main_volume;
            comboBoxAudioFormat.SelectedIndex = Settings.Audio.output_format;
            comboBoxAudioDynamicRange.SelectedIndex = Settings.Audio.dynamic_range;
            comboBoxTextLanguage.SelectedIndex = (int)Settings.Language.text_lang - 1;
            comboBoxVoiceLanguage.SelectedIndex = (int)Settings.Language.voice_lang;
            if (sender != null)
            {
                Status_Label.Text = "Reloaded config from registry.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            }
            int GammaVal = (int)(Settings.Graphics.gamma * 100);
            // double precision fix
            if (GammaVal > 300) GammaVal = 300;
            if (GammaVal < 140) GammaVal = 140;

            // GammaVal is in range 300-140.
            // Slider is in range 0-160.
            GammaTrackBar.Value = 160 - (GammaVal - 140);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // End of global functions

        // Graphics functions
        private void Lowest_Settings()
        {
            FPS_Box.SelectedIndex = 0;
            VSync_Box.SelectedIndex = 1;
            RenderResolution_Box.SelectedIndex = 1;
            ShadowQuality_Box.SelectedIndex = 0;
            VisualEffects_Box.SelectedIndex = 0;
            SFXQuality_Box.SelectedIndex = 0;
            EnvironmentDetail_Box.SelectedIndex = 0;
            Antialiasing_Box.SelectedIndex = 0;
            VolumetricFog_Box.SelectedIndex = 0;
            Reflections_Box.SelectedIndex = 0;
            MotionBlur_Box.SelectedIndex = 0;
            Bloom_Box.SelectedIndex = 1;
            CrowdDensity_Box.SelectedIndex = 1;
            SubsurfaceScattering_Box.SelectedIndex = 0;
            TeammateEffects_Box.SelectedIndex = 0;
            AnisotropicFiltering_Box.SelectedIndex = 0;
        }

        private void Low_Settings()
        {
            FPS_Box.SelectedIndex = 0;
            VSync_Box.SelectedIndex = 1;
            RenderResolution_Box.SelectedIndex = 2;
            ShadowQuality_Box.SelectedIndex = 1;
            VisualEffects_Box.SelectedIndex = 1;
            SFXQuality_Box.SelectedIndex = 1;
            EnvironmentDetail_Box.SelectedIndex = 1;
            Antialiasing_Box.SelectedIndex = 2;
            VolumetricFog_Box.SelectedIndex = 0;
            Reflections_Box.SelectedIndex = 0;
            MotionBlur_Box.SelectedIndex = 0;
            Bloom_Box.SelectedIndex = 1;
            CrowdDensity_Box.SelectedIndex = 1;
            SubsurfaceScattering_Box.SelectedIndex = 1;
            TeammateEffects_Box.SelectedIndex = 0;
            AnisotropicFiltering_Box.SelectedIndex = 0;
        }

        private void Medium_Settings()
        {
            FPS_Box.SelectedIndex = 1;
            VSync_Box.SelectedIndex = 1;
            RenderResolution_Box.SelectedIndex = 2;
            ShadowQuality_Box.SelectedIndex = 2;
            VisualEffects_Box.SelectedIndex = 2;
            SFXQuality_Box.SelectedIndex = 2;
            EnvironmentDetail_Box.SelectedIndex = 2;
            Antialiasing_Box.SelectedIndex = 2;
            VolumetricFog_Box.SelectedIndex = 1;
            Reflections_Box.SelectedIndex = 0;
            MotionBlur_Box.SelectedIndex = 2;
            Bloom_Box.SelectedIndex = 1;
            CrowdDensity_Box.SelectedIndex = 1;
            SubsurfaceScattering_Box.SelectedIndex = 1;
            TeammateEffects_Box.SelectedIndex = 0;
            AnisotropicFiltering_Box.SelectedIndex = 0;
        }

        private void High_Settings()
        {
            FPS_Box.SelectedIndex = 1;
            VSync_Box.SelectedIndex = 1;
            RenderResolution_Box.SelectedIndex = 3;
            ShadowQuality_Box.SelectedIndex = 3;
            VisualEffects_Box.SelectedIndex = 3;
            SFXQuality_Box.SelectedIndex = 3;
            EnvironmentDetail_Box.SelectedIndex = 3;
            Antialiasing_Box.SelectedIndex = 2;
            VolumetricFog_Box.SelectedIndex = 1;
            Reflections_Box.SelectedIndex = 1;
            MotionBlur_Box.SelectedIndex = 3;
            Bloom_Box.SelectedIndex = 1;
            CrowdDensity_Box.SelectedIndex = 1;
            SubsurfaceScattering_Box.SelectedIndex = 2;
            TeammateEffects_Box.SelectedIndex = 0;
            AnisotropicFiltering_Box.SelectedIndex = 0;
        }

        private void Unlock_Graphics(bool action)
        {
            FPS_Box.Enabled = action;
            VSync_Box.Enabled = action;
            RenderResolution_Box.Enabled = action;
            ShadowQuality_Box.Enabled = action;
            VisualEffects_Box.Enabled = action;
            SFXQuality_Box.Enabled = action;
            EnvironmentDetail_Box.Enabled = action;
            Antialiasing_Box.Enabled = action;
            VolumetricFog_Box.Enabled = action;
            Reflections_Box.Enabled = action;
            MotionBlur_Box.Enabled = action;
            Bloom_Box.Enabled = action;
            CrowdDensity_Box.Enabled = action;
            SubsurfaceScattering_Box.Enabled = action;
            TeammateEffects_Box.Enabled = action;
            AnisotropicFiltering_Box.Enabled = action;
        }

        private void ShadowQuality_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShadowQuality_Box.SelectedIndex > 1)
            {
                Unlock_VolumetricFog(true);
            }
            else
            {
                Unlock_VolumetricFog(false);
            }
        }

        private void Unlock_VolumetricFog(bool enabled)
        {
            if (enabled)
            {
                VolumetricFog_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.VolumetricFog) - 1;
                VolumetricFog_Box.Enabled = true;
            } else
            {
                VolumetricFog_Box.SelectedIndex = 0;
                VolumetricFog_Box.Enabled = false;
            }
        }

        private void Preset_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Preset_Box.SelectedIndex)
            {
                case 0:
                    Lowest_Settings();
                    break;
                case 1:
                    Low_Settings();
                    break;
                case 2:
                    Medium_Settings();
                    break;
                case 3:
                    High_Settings();
                    break;
                case 4:
                    break;
            }
            if (Preset_Box.SelectedIndex == 4)
            {
                Unlock_Graphics(true);
            }
            else
            {
                Unlock_Graphics(false);
            }
        }

        private void GammaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Return back from range 0-160 to 300-140
            double origval = 140 + (160 - GammaTrackBar.Value);
            double val = (double)origval / 100;
            GammaValueLabel.Text = val.ToString();
            Settings.Graphics.gamma = val;
        }

        private void Apply_Graphics_Button_Click(object sender, EventArgs e)
        {
            GraphicsSettings graphics = Settings.Graphics;
            if (Preset_Box.SelectedIndex == 4)
            {
                graphics.current_preset = -1;
            }
            else
            {
                graphics.current_preset = Preset_Box.SelectedIndex + 1;
            }
            graphics.Change(SettingsType.FPS, FPS_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.VSync, VSync_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.RenderResolution, RenderResolution_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.ShadowQuality, ShadowQuality_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.VisualEffects, VisualEffects_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.SFXQuality, SFXQuality_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.EnvironmentDetail, EnvironmentDetail_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.Antialiasing, Antialiasing_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.VolumetricFog, VolumetricFog_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.Reflections, Reflections_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.MotionBlur, MotionBlur_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.Bloom, Bloom_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.CrowdDensity, CrowdDensity_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.SubsurfaceScattering, SubsurfaceScattering_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.TeammateEffects, TeammateEffects_Box.SelectedIndex + 1);
            graphics.Change(SettingsType.AnisotropicFiltering, AnisotropicFiltering_Box.SelectedIndex + 1);
            Settings.Apply("graphics");
            Resolution.Change((int)ResolutionData.Width, Convert.ToInt32(Width_Text.Text));
            Resolution.Change((int)ResolutionData.Height, Convert.ToInt32(Height_Text.Text));
            if (Fullscreen_Check.Checked)
            {
                Resolution.Change((int)ResolutionData.Fullscreen, 1);
            } else
            {
                Resolution.Change((int)ResolutionData.Fullscreen, 0);
            }
            Settings.Apply("resolution");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }
        // End of graphics functions

        // Controls functions
        private void Populate_Controls()
        {
            if (devicesList.Enabled == false)
            {
                return;
            }
            int top = labelControlTemplate.Top;
            int height = 25;
            int mult = 0;
            void Reset_Layout()
            {
                Status_Label.Text = "Loading controls...";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
                splitContainerControls.Panel2.VerticalScroll.Value = 0;
                splitContainerControls.Panel2.Enabled = false;
                splitContainerControls.Panel2.SuspendLayout();
                List<Control> auto_controls = splitContainerControls.Panel2.Controls.Cast<Control>().Where(c => c.Visible).ToList();
                foreach (Control control in auto_controls)
                {
                    splitContainerControls.Panel2.Controls.Remove(control);
                }
            }
            void Resume_Layout()
            {
                splitContainerControls.Panel2.ResumeLayout();
                splitContainerControls.Panel2.Enabled = true;
                Status_Label.Text = "Controls loaded.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            }
            void Add_Label(Keybind bind, int mlt)
            {
                string text = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                if (devModeToggle.Checked)
                {
                    text += " (" + bind.actionId.ToString() + ")";
                }
                Label newlabel = new Label
                {
                    Left = labelControlTemplate.Left,
                    Top = labelControlTemplate.Top + height * mlt,
                    Text = text,
                    AutoSize = true,
                    Tag = bind
                };
                splitContainerControls.Panel2.Controls.Add(newlabel);
            }
            void Add_Keyboard_Binding(Keybind bind, int mlt)
            {
                TextBox newinput = new TextBox
                {
                    Width = inputButtonTemplate.Width,
                    Left = inputButtonTemplate.Left,
                    Top = inputButtonTemplate.Top + height * mlt,
                    Text = Keycodes.keynames[bind.elementIdentifierId],
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = bind,
                    TextAlign = HorizontalAlignment.Center
                };
                newinput.KeyPress += Prevent_Input;
                newinput.KeyDown += Edit_Keyboard_Key;
                newinput.GotFocus += Toggle_Binding_Edit;
                newinput.LostFocus += Toggle_Binding_Edit;
                splitContainerControls.Panel2.Controls.Add(newinput);
            }
            void Add_Keyboard_Modifiers(Keybind _bind, int mlt)
            {
                KeyboardKeybind bind = (KeyboardKeybind)_bind;
                CheckBox newctrl = new CheckBox
                {
                    Checked = bind.ctrl,
                    Left = checkBoxCtrlTemplate.Left,
                    Top = checkBoxCtrlTemplate.Top + height * mlt - 3, // CheckBox size is different to inputBox size
                    Text = "Ctrl",
                    Width = checkBoxCtrlTemplate.Width,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = bind,
                    BackColor = Color.Transparent
                };
                splitContainerControls.Panel2.Controls.Add(newctrl);

                CheckBox newshift = new CheckBox
                {
                    Checked = bind.shift,
                    Left = checkBoxShiftTemplate.Left,
                    Top = checkBoxShiftTemplate.Top + height * mlt - 3,
                    Text = "Shift",
                    Width = checkBoxShiftTemplate.Width,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = bind,
                    BackColor = Color.Transparent
                };
                splitContainerControls.Panel2.Controls.Add(newshift);

                CheckBox newalt = new CheckBox
                {
                    Checked = bind.alt,
                    Left = checkBoxAltTemplate.Left,
                    Top = checkBoxAltTemplate.Top + height * mlt - 3,
                    Text = "Alt",
                    Width = checkBoxAltTemplate.Width,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = bind,
                    BackColor = Color.Transparent
                };
                splitContainerControls.Panel2.Controls.Add(newalt);
            }
            void Add_Controller_Binding(Keybind bind, string[] bindings, int mlt)
            {
                // this one is slowest
                Controller cnt = Settings.Controls.controllers.Controller_By_Bind(bind);
                int offset = 0;
                switch (cnt)
                {
                    case MouseController _:
                        offset = 3;
                        break;
                    case XBoxController _:
                        offset = 4;
                        break;
                }
                ComboBox newbutton = new ComboBox
                {
                    Left = gamepadButtonTemplate.Left,
                    Top = gamepadButtonTemplate.Top + height * mlt,
                    Tag = bind,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                newbutton.Items.AddRange(bindings);
                newbutton.SelectedIndex = bind.elementIdentifierId - offset;
                newbutton.SelectedValueChanged += Edit_Controller_Key;
                splitContainerControls.Panel2.Controls.Add(newbutton);
            }
            void Add_Controller_Axes(Keybind bind, string[] bindings, int mlt)
            {
                ComboBox newbutton = new ComboBox
                {
                    Left = gamepadAxisTemplate.Left,
                    Top = gamepadAxisTemplate.Top + height * mult,
                    Tag = bind,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                newbutton.Items.AddRange(bindings);
                newbutton.SelectedIndex = bind.elementIdentifierId;
                newbutton.SelectedValueChanged += Edit_Controller_Axis;
                splitContainerControls.Panel2.Controls.Add(newbutton);
            }
            void Add_Invert_Checkbox(Keybind bind, int mlt)
            {
                CheckBox newinvert = new CheckBox
                {
                    Checked = bind.invert,
                    Top = gamepadAxisInvertTemplate.Top + height * mlt - 3,
                    Left = gamepadAxisInvertTemplate.Left,
                    Tag = bind,
                    Text = "Invert",
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    BackColor = Color.Transparent
                };
                newinvert.CheckedChanged += Invert_Gamepad_Axis;
                splitContainerControls.Panel2.Controls.Add(newinvert);
            }
            void Add_Delete_Button(Keybind bind, int mlt)
            {
                Button delkeybind = new Button
                {
                    Text = "X",
                    Left = buttonKeybindRemoveTemplate.Left,
                    Top = buttonKeybindRemoveTemplate.Top + height * mlt,
                    Width = buttonKeybindRemoveTemplate.Width,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = bind
                };
                delkeybind.Click += Remove_Keybind;
                splitContainerControls.Panel2.Controls.Add(delkeybind);
            }
            void Add_New_Keybind(Keybind bind, string[] binds, int mlt)
            {
                ComboBox newkeybindlist = new ComboBox
                {
                    Left = comboBoxKeybindListTemplate.Left,
                    Top = comboBoxKeybindListTemplate.Top + height * mlt,
                    Tag = bind
                };
                newkeybindlist.Items.AddRange(binds);
                splitContainerControls.Panel2.Controls.Add(newkeybindlist);

                Button newkeybind = new Button
                {
                    Text = "Add",
                    Left = buttonKeybindingAddTemplate.Left,
                    Top = buttonKeybindingAddTemplate.Top + height * mult,
                    Width = buttonKeybindingAddTemplate.Width,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Tag = newkeybindlist
                };
                newkeybind.Click += Add_Keybind;
                splitContainerControls.Panel2.Controls.Add(newkeybind);
            }


            Reset_Layout();
            Controller cntrl = Settings.Controls.controllers.List().ToArray()[devicesList.SelectedIndex];
            if (cntrl is KeyboardController)
            {
                // While keyboard is very flexible and have many actions, it still intersects with gamepad in some ways.
                List<int> keyboardActionsBlacklist = new List<int> { 5 };
                foreach (KeyboardKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !keyboardActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Add_Label(bind, mult);
                        Add_Keyboard_Binding(bind, mult);
                        Add_Keyboard_Modifiers(bind, mult);
                        if (devModeToggle.Checked)
                        {
                            Add_Delete_Button(bind, mult);
                        }
                        mult++;
                    }

                }
            }
            else if (cntrl is MouseController)
            {
                foreach (GamepadKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if (!name.Contains("?") || devModeToggle.Checked)
                    {
                        string[] mouse_keys = Keycodes.mouse_keys.ToArray();
                        Add_Label(bind, mult);
                        Add_Controller_Binding(bind, mouse_keys, mult);
                        if (devModeToggle.Checked)
                        {
                            Add_Delete_Button(bind, mult);
                        }
                        mult++;
                    }
                }
                foreach (GamepadAxis bind in cntrl.axes)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if (!name.Contains("?") || devModeToggle.Checked)
                    {
                        string[] mouse_axes = Keycodes.mouse_axes.ToArray();
                        Add_Label(bind, mult);
                        Add_Controller_Axes(bind,mouse_axes, mult);
                        Add_Invert_Checkbox(bind, mult);
                        if (devModeToggle.Checked)
                        {
                            Add_Delete_Button(bind, mult);
                        }
                        mult++;
                    }
                }
            }
            else if (cntrl is XBoxController)
            {
                string[] gamepad_keys = gamepadButtonTemplate.Items.Cast<String>().ToArray();
                string[] gamepad_axes = gamepadAxisTemplate.Items.Cast<String>().ToArray();
                // These buttons have mappings for them, however, they do not appear doing something useful.
                List<int> gamepadActionsBlacklist = new List<int> { 87, 88 };
                foreach (GamepadKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Add_Label(bind, mult);
                        Add_Controller_Binding(bind, gamepad_keys, mult);
                        if (devModeToggle.Checked)
                        {
                            Add_Delete_Button(bind, mult);
                        }
                        mult++;
                    }
                }
                foreach (GamepadAxis bind in cntrl.axes)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Add_Label(bind, mult);
                        if (bind.elementIdentifierId > 3) // LT, RT as buttons
                        {
                            Add_Controller_Binding(bind, gamepad_keys, mult);
                        }
                        else
                        {
                            Add_Controller_Axes(bind, gamepad_axes, mult);
                            Add_Invert_Checkbox(bind, mult);
                        }
                        if (devModeToggle.Checked)
                        {
                            Add_Delete_Button(bind, mult);
                        }
                        mult++;
                    }
                }
            }
            if (devModeToggle.Checked)
            {
                List<string> avail_keybinds = new List<string>();
                List<int> binded_keybinds = new List<int>();
                foreach (Control ctrl in splitContainerControls.Panel2.Controls)
                {
                    if ((ctrl is Label) && (ctrl.Tag != null)) binded_keybinds.Add(((Keybind)ctrl.Tag).actionId);
                }
                foreach (KeyValuePair<int, string> pair in Keycodes.actions)
                {
                    if (!binded_keybinds.Contains(pair.Key))
                    {
                        avail_keybinds.Add(pair.Value);
                    }
                }
                Keybind bind = (Keybind)splitContainerControls.Panel2.Controls.Cast<Control>().Where(c => c.Tag != null).First(c => c is Label).Tag; // First bind
                Add_New_Keybind(bind, avail_keybinds.ToArray(), mult);
            }
            Resume_Layout();
        }

        private void Paint_BG(object sender, PaintEventArgs e)
        {
            int count = 0;
            foreach (Control ctrl in splitContainerControls.Panel2.Controls)
            {
                if (ctrl is Label) count++;
            }
            e.Graphics.TranslateTransform(splitContainerControls.Panel2.AutoScrollPosition.X, splitContainerControls.Panel2.AutoScrollPosition.Y);
            for (int i = 2; i < count * 25; i += 25)
            {
                e.Graphics.DrawLine(Pens.Black, 0, i, splitContainerControls.Panel2.Width, i);
            }
        }

        private void devModeToggle_CheckedChanged(object sender, EventArgs e)
        {
            bool mouse = false;
            if (devModeToggle.Checked)
            {
                controlsMenu.Visible = true;

            }
            else
            {
                controlsMenu.Visible = false;
            }
            foreach (Controller cntrl in Settings.Controls.controllers.List())
            {
                if (cntrl is MouseController)
                {
                    mouse = true;
                }
            }
            if (mouse)
            {
                addMouseButton.Enabled = false;
            }
            else
            {
                addMouseButton.Enabled = true;
            }
        }

        private void Add_Keybind(object sender, EventArgs e)
        {
            // Controller is selected by the first bind
            Button add_button = (Button)sender;                             // "Add bind" button
            ComboBox bind_selector = add_button.Tag as ComboBox;            // ComboBox with selected bind
            Keybind first_bind = (Keybind)bind_selector.Tag;   // First bind on the page (tied to the first label)
            Controller cntrl = Settings.Controls.controllers.Controller_By_Bind(first_bind);  // Controller from bind
            int actionId = Controllers.GetActionByName(bind_selector.Text);
            cntrl.AddBind(actionId);
            Populate_Controls();
        }

        private void Remove_Keybind(object sender, EventArgs e)
        {
            Controller cntrl = Settings.Controls.controllers.Controller_By_Bind((Keybind)((Button)sender).Tag);
            Keybind bind = (Keybind)((Button)sender).Tag;
            cntrl.DeleteBind(bind);
            Populate_Controls();
        }

        private void Reload_Controls(object sender, EventArgs e)
        {
            Populate_Controls();
        }

        private void Invert_Gamepad_Axis(object sender, EventArgs e)
        {
            CheckBox invert = (CheckBox)sender;
            ((GamepadAxis)invert.Tag).invert = invert.Checked;
        }

        private void Toggle_Binding_Edit(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            if (input.Focused)
            {
                input.Text = "Press desired key...";
            }
            else
            {
                input.Text = Keycodes.keynames[((KeyboardKeybind)input.Tag).elementIdentifierId];
            }
        }

        private void Edit_Controller_Axis(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            Keybind bind = (Keybind)input.Tag;
            Controller cntrl = Settings.Controls.controllers.Controller_By_Bind(bind);
            cntrl.EditBind(bind, input.SelectedIndex);
        }

        private void Edit_Controller_Key(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            Keybind bind = (Keybind)input.Tag;
            Controller cntrl = Settings.Controls.controllers.Controller_By_Bind(bind);
            int offset = 0;
            switch (cntrl)
            {
                case MouseController _:
                    offset = 3;
                    break;
                case XBoxController _:
                    offset = 4;
                    break;
            }
            cntrl.EditBind(bind, input.SelectedIndex + offset);
        }

        private void Edit_Keyboard_Key(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            Keybind bind = (Keybind)input.Tag;
            Controller cntrl = Settings.Controls.controllers.Controller_By_Bind(bind);
            if (Keycodes.keyboard.ContainsKey(((KeyEventArgs)e).KeyCode)) //Valid key
            {
                cntrl.EditBind(bind, Keycodes.keyboard[((KeyEventArgs)e).KeyCode]);
                input.Text = Keycodes.keynames[Keycodes.keyboard[((KeyEventArgs)e).KeyCode]];
            }
            tabControls.Focus();
        }

        private void Prevent_Input(object sender, EventArgs e)
        {
            ((KeyPressEventArgs)e).Handled = true;
        }

        private void addMouseButton_Click(object sender, EventArgs e)
        {
            MouseController cntrl = new MouseController
            {
                name = "",
                enabled = true,
                hardwareGuid = "00000000-0000-0000-0000-000000000000"
            };

            GamepadKeybind lmb = new GamepadKeybind
            {
                elementIdentifierId = 3,
                actionId = 138
            };
            GamepadKeybind rmb = new GamepadKeybind
            {
                elementIdentifierId = 4,
                actionId = 139
            };
            GamepadKeybind attack = new GamepadKeybind
            {
                elementIdentifierId = 3,
                actionId = 16
            };
            GamepadKeybind sprint = new GamepadKeybind
            {
                elementIdentifierId = 4,
                actionId = 21
            };
            GamepadKeybind elvision = new GamepadKeybind
            {
                elementIdentifierId = 5,
                actionId = 57
            };

            GamepadAxis horizontal = new GamepadAxis
            {
                elementIdentifierId = 0,
                actionId = 30
            };
            GamepadAxis vertical = new GamepadAxis
            {
                elementIdentifierId = 1,
                actionId = 31
            };
            GamepadAxis zoom = new GamepadAxis
            {
                elementIdentifierId = 2,
                actionId = 54
            };

            cntrl.keybinds.Add(lmb);
            cntrl.keybinds.Add(rmb);
            cntrl.keybinds.Add(attack);
            cntrl.keybinds.Add(sprint);
            cntrl.keybinds.Add(elvision);
            cntrl.axes.Add(horizontal);
            cntrl.axes.Add(vertical);
            cntrl.axes.Add(zoom);

            Settings.Controls.controllers.Add(cntrl);
            Settings.Controls.controller_ids.Add("OverrideControllerMap__00000000-0000-0000-0000-000000000000__1000000");
            Settings.Apply("controls");
            Settings.ToReg();
            MessageBox.Show("Mouse added! Please, restart the application.");
        }

        private void Apply_Controls_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("controls");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }
        // End of controls functions

        // Audio functions
        private void trackBarMusicVolume_ValueChanged(object sender, EventArgs e)
        {
            MusicVolumeValueLabel.Text = trackBarMusicVolume.Value.ToString();
            Settings.Audio.music_volume = trackBarMusicVolume.Value;
        }

        private void trackBarMainVolume_ValueChanged(object sender, EventArgs e)
        {
            MainVolumeValueLabel.Text = trackBarMainVolume.Value.ToString();
            Settings.Audio.main_volume = trackBarMainVolume.Value;
        }

        private void trackBarSFXVolume_ValueChanged(object sender, EventArgs e)
        {
            SFXVolumeValueLabel.Text = trackBarSFXVolume.Value.ToString();
            Settings.Audio.sfx_volume = trackBarSFXVolume.Value;
        }

        private void trackBarVoiceVolume_ValueChanged(object sender, EventArgs e)
        {
            VoiceVolumeValueLabel.Text = trackBarVoiceVolume.Value.ToString();
            Settings.Audio.voice_volume = trackBarVoiceVolume.Value;
        }

        private void comboBoxAudioDynamicRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Audio.dynamic_range = comboBoxAudioDynamicRange.SelectedIndex;
        }

        private void comboBoxAudioFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Audio.output_format = comboBoxAudioFormat.SelectedIndex;
        }

        private void Apply_Audio_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("audio");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }
        // End of audio functions

        // Language functions
        private void comboBoxTextLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Language.text_lang = (TextLanguage)comboBoxTextLanguage.SelectedIndex + 1;
        }

        private void comboBoxVoiceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Language.voice_lang = (VoiceLanguage)comboBoxVoiceLanguage.SelectedIndex;
        }

        private void Apply_Language_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("language");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }
        // End of language functions

        // Log functions
        private void Reload_Log_Button_Click(object sender, EventArgs e)
        {
            string log_path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName + @"\LocalLow\miHoYo\Genshin Impact\output_log.txt";
            try
            {
                textBoxLog.Text = File.ReadAllText(log_path);
            }
            catch (System.IO.IOException)
            {
                textBoxLog.Text = "Log file is currently used by Genshin.";
            }
            Status_Label.Text = "Loaded log file.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void settingsTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 1:

                    break;
                case 2:
                    Reload_Log_Button_Click(null, null);
                    break;
            }
        }
        // End of log functions

        // Raw config functions
        private void Load_Button_Raw_Click(object sender, EventArgs e)
        {
            textBox_Config_Raw.Text = Settings.Raw();
            Status_Label.Text = $"Loaded raw config from registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Save_Button_Raw_Click(object sender, EventArgs e)
        {
            Settings.Parse(textBox_Config_Raw.Text);
            Settings.Apply();
            Settings.ToReg();
            Status_Label.Text = $"Saved raw config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }
        // End of raw config functions
    }
}
