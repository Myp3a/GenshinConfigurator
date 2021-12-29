﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static GenshinConfigurator.Enums;

namespace GenshinConfigurator
{
    public partial class MainWin : Form
    {
        SettingsContainer Settings;
        GraphicsSettings Graphics;
        ResolutionSettings Resolution;
        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            Settings = new SettingsContainer();
            Graphics = Settings.Graphics;
            Resolution = Settings.Resolution;
            if (Graphics.settings_json.__controlsLoaded == false || Graphics.settings_json.__graphicsLoaded == false)
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
            if (Graphics.settings_json.__controlsLoaded)
            {
                foreach (string controller_id in Graphics.settings_json._overrideControllerMapKeyList)
                {
                    string[] parts = controller_id.Split(new[] { "__" }, StringSplitOptions.None);
                    devicesList.Items.Add(parts[1] + "__" + parts[2]);
                }
                devicesList.SelectedIndex = 0;
                //Task.Run(() => Populate_Controls());
            }
            if (Graphics.settings_json.__graphicsLoaded)
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

        private void Unlock_VolumetricFog(bool enabled)
        {
            if (enabled)
            {
                VolumetricFog_Box.SelectedIndex = Graphics.Get((int)SettingsType.VolumetricFog) - 1;
                VolumetricFog_Box.Enabled = true;
            } else
            {
                VolumetricFog_Box.SelectedIndex = 0;
                VolumetricFog_Box.Enabled = false;
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Preset_Box.SelectedIndex = Graphics.currentPreset;
            FPS_Box.SelectedIndex = Graphics.Get((int)SettingsType.FPS) - 1;
            VSync_Box.SelectedIndex = Graphics.Get((int)SettingsType.VSync) - 1;
            RenderResolution_Box.SelectedIndex = Graphics.Get((int)SettingsType.RenderResolution) - 1;
            ShadowQuality_Box.SelectedIndex = Graphics.Get((int)SettingsType.ShadowQuality) - 1;
            VisualEffects_Box.SelectedIndex = Graphics.Get((int)SettingsType.VisualEffects) - 1;
            SFXQuality_Box.SelectedIndex = Graphics.Get((int)SettingsType.SFXQuality) - 1;
            EnvironmentDetail_Box.SelectedIndex = Graphics.Get((int)SettingsType.EnvironmentDetail) - 1;
            Antialiasing_Box.SelectedIndex = Graphics.Get((int)SettingsType.Antialiasing) - 1;
            VolumetricFog_Box.SelectedIndex = Graphics.Get((int)SettingsType.VolumetricFog) - 1;
            Reflections_Box.SelectedIndex = Graphics.Get((int)SettingsType.Reflections) - 1;
            MotionBlur_Box.SelectedIndex = Graphics.Get((int)SettingsType.MotionBlur) - 1;
            Bloom_Box.SelectedIndex = Graphics.Get((int)SettingsType.Bloom) - 1;
            CrowdDensity_Box.SelectedIndex = Graphics.Get((int)SettingsType.CrowdDensity) - 1;
            SubsurfaceScattering_Box.SelectedIndex = Graphics.Get((int)SettingsType.SubsurfaceScattering) - 1;
            TeammateEffects_Box.SelectedIndex = Graphics.Get((int)SettingsType.TeammateEffects) - 1;
            AnisotropicFiltering_Box.SelectedIndex = Graphics.Get((int)SettingsType.AnisotropicFiltering) - 1;
            Width_Text.Text = Resolution.Get((int)ResolutionData.Width).ToString();
            Height_Text.Text = Resolution.Get((int)ResolutionData.Height).ToString();
            if (Convert.ToBoolean(Resolution.Get((int)ResolutionData.Fullscreen)))
            {
                Fullscreen_Check.Checked = true;
            } else
            {
                Fullscreen_Check.Checked = false;
            }
            if (sender != null)
            {
                Status_Label.Text = "Reloaded config from registry.";
                Status_Reset_Timer.Enabled = false;
                Status_Reset_Timer.Enabled = true;
            }
        }

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
        private void Apply_Button_Click(object sender, EventArgs e)
        {
            Graphics.currentPreset = Preset_Box.SelectedIndex;
            Graphics.Change((int)SettingsType.FPS, FPS_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.VSync, VSync_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.RenderResolution, RenderResolution_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.ShadowQuality, ShadowQuality_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.VisualEffects, VisualEffects_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.SFXQuality, SFXQuality_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.EnvironmentDetail, EnvironmentDetail_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.Antialiasing, Antialiasing_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.VolumetricFog, VolumetricFog_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.Reflections, Reflections_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.MotionBlur, MotionBlur_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.Bloom, Bloom_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.CrowdDensity, CrowdDensity_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.SubsurfaceScattering, SubsurfaceScattering_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.TeammateEffects, TeammateEffects_Box.SelectedIndex + 1);
            Graphics.Change((int)SettingsType.AnisotropicFiltering, AnisotropicFiltering_Box.SelectedIndex + 1);
            Graphics.Save();
            Resolution.Change((int)ResolutionData.Width, Convert.ToInt32(Width_Text.Text));
            Resolution.Change((int)ResolutionData.Height, Convert.ToInt32(Height_Text.Text));
            if (Fullscreen_Check.Checked)
            {
                Resolution.Change((int)ResolutionData.Fullscreen, 1);
            } else
            {
                Resolution.Change((int)ResolutionData.Fullscreen, 0);
            }
            Resolution.Save();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Filter = "JSON config|*.json";
            savedialog.DefaultExt = ".json";
            savedialog.AddExtension = true;
            savedialog.RestoreDirectory = true;
            savedialog.OverwritePrompt = true;
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
            OpenFileDialog loaddialog = new OpenFileDialog();
            loaddialog.Filter = "JSON config|*.json";
            loaddialog.RestoreDirectory = true;
            if (loaddialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Load(Path.GetFullPath(loaddialog.FileName));
                Status_Label.Text = $"Loaded config from {loaddialog.FileName}.";
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

        private void ShadowQuality_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShadowQuality_Box.SelectedIndex > 1)
            {
                Unlock_VolumetricFog(true);
            } else
            {
                Unlock_VolumetricFog(false);
            }
        }

        private void Load_Button_Raw_Click(object sender, EventArgs e)
        {
            textBox_Config_Raw.Text = Graphics.GetJSON(true);
            Status_Label.Text = $"Loaded raw config from registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Save_Button_Raw_Click(object sender, EventArgs e)
        {
            Graphics.Write(textBox_Config_Raw.Text);
            Status_Label.Text = $"Saved raw config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Reload_Log_Button_Click(object sender, EventArgs e)
        {
            string log_path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName + @"\LocalLow\miHoYo\Genshin Impact\output_log.txt";
            try
            {
                textBoxLog.Text = File.ReadAllText(log_path);
            } catch (System.IO.IOException)
            {
                textBoxLog.Text = "Log file is currently used by Genshin.";
            }
            Status_Label.Text = "Loaded log file.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        
        private void Populate_Controls()
        {
            List<Control> auto_controls = splitContainerControls.Panel2.Controls.Cast<Control>().Where(c => c.Visible).ToList();
            foreach (Control control in auto_controls)
            {
                splitContainerControls.Panel2.Controls.Remove(control);
            }
            Controller cntrl = Graphics.settings_json._overrideControllerMapValueList[devicesList.SelectedIndex];
            if (cntrl.hardwareGuid == "00000000-0000-0000-0000-000000000000")
            {
                // While keyboard is very flexible and have many actions, it still intersects with gamepad in some ways.
                List<int> keyboardActionsBlacklist = new List<int> { 5 };
                int top = labelControlTemplate.Top;
                int height = 25;
                int mult = 0;
                foreach (KeyboardKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((name != "?" && !keyboardActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        TextBox newinput = new TextBox();
                        newinput.Width = inputButtonTemplate.Width;
                        newinput.Left = inputButtonTemplate.Left;
                        newinput.Top = inputButtonTemplate.Top + height * mult;
                        newinput.Text = Keycodes.keynames[bind.elementIdentifierId];
                        newinput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newinput.Tag = bind;
                        newinput.TextAlign = HorizontalAlignment.Center;
                        newinput.KeyPress += Prevent_Input;
                        newinput.KeyDown += Edit_Binding;
                        newinput.GotFocus += Toggle_Binding_Edit;
                        newinput.LostFocus += Toggle_Binding_Edit;
                        splitContainerControls.Panel2.Controls.Add(newinput);
                        /*Button newbutton = new Button();
                        newbutton.Left = buttonKeyTemplate.Left;
                        newbutton.Top = buttonKeyTemplate.Top + height * mult;
                        newbutton.Width = buttonKeyTemplate.Width;
                        newbutton.Text = Keycodes.keynames[bind.keyboard_keycode];
                        newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newbutton.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newbutton);*/

                        CheckBox newctrl = new CheckBox();
                        newctrl.Checked = bind.ctrl;
                        newctrl.Left = checkBoxCtrlTemplate.Left;
                        newctrl.Top = checkBoxCtrlTemplate.Top + height * mult;
                        newctrl.Text = "Ctrl";
                        newctrl.Width = checkBoxCtrlTemplate.Width;
                        newctrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newctrl.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newctrl);

                        CheckBox newshift = new CheckBox();
                        newshift.Checked = bind.shift;
                        newshift.Left = checkBoxShiftTemplate.Left;
                        newshift.Top = checkBoxShiftTemplate.Top + height * mult;
                        newshift.Text = "Shift";
                        newshift.Width = checkBoxShiftTemplate.Width;
                        newshift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newshift.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newshift);

                        CheckBox newalt = new CheckBox();
                        newalt.Checked = bind.alt;
                        newalt.Left = checkBoxAltTemplate.Left;
                        newalt.Top = checkBoxAltTemplate.Top + height * mult;
                        newalt.Text = "Alt";
                        newalt.Width = checkBoxAltTemplate.Width;
                        newalt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newalt.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newalt);
                        mult++;
                    }
                    
                }
            } else if (cntrl.hardwareGuid == "d74a350e-fe8b-4e9e-bbcd-efff16d34115")
            {
                // These buttons have mappings for them, however, they do not appear doing something useful.
                List<int> gamepadActionsBlacklist = new List<int> { 87, 88, 99 };
                int top = labelControlTemplate.Top;
                int height = 25;
                int mult = 0;
                foreach (GamepadKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((name != "?" && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked )
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        ComboBox newbutton = new ComboBox();
                        newbutton.Left = gamepadButtonTemplate.Left;
                        newbutton.Top = gamepadButtonTemplate.Top + height * mult;
                        newbutton.Items.AddRange(gamepadButtonTemplate.Items.Cast<Object>().ToArray());
                        newbutton.SelectedIndex = bind.elementIdentifierId - 4;
                        newbutton.Tag = bind;
                        newbutton.SelectedValueChanged += Edit_Gamepad_Key;
                        splitContainerControls.Panel2.Controls.Add(newbutton);
                        mult++;
                    }
                }
                foreach (GamepadAxis bind in ((XBoxController)cntrl).axes)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((name != "?" && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        if (bind.elementIdentifierId > 3) // LT, RT as buttons
                        {
                            ComboBox newbutton = new ComboBox();
                            newbutton.Left = gamepadButtonTemplate.Left;
                            newbutton.Top = gamepadButtonTemplate.Top + height * mult;
                            newbutton.Items.AddRange(gamepadButtonTemplate.Items.Cast<Object>().ToArray());
                            newbutton.SelectedIndex = bind.elementIdentifierId - 4;
                            newbutton.Tag = bind;
                            newbutton.SelectedValueChanged += Edit_Gamepad_Key;
                            splitContainerControls.Panel2.Controls.Add(newbutton);
                        } else
                        {
                            ComboBox newbutton = new ComboBox();
                            newbutton.Left = gamepadAxisTemplate.Left;
                            newbutton.Top = gamepadAxisTemplate.Top + height * mult;
                            newbutton.Items.AddRange(gamepadAxisTemplate.Items.Cast<Object>().ToArray());
                            newbutton.SelectedIndex = bind.elementIdentifierId;
                            newbutton.Tag = bind;
                            newbutton.SelectedValueChanged += Edit_Gamepad_Axis;
                            splitContainerControls.Panel2.Controls.Add(newbutton);

                            CheckBox newinvert = new CheckBox();
                            newinvert.Checked = bind.invert;
                            newinvert.Top = gamepadAxisInvertTemplate.Top + height * mult;
                            newinvert.Left = gamepadAxisInvertTemplate.Left;
                            newinvert.Tag = bind;
                            newinvert.CheckedChanged += Invert_Gamepad_Axis;
                            splitContainerControls.Panel2.Controls.Add(newinvert);
                        }
                        mult++;
                    }
                }
            }
        }

        private void Edit_Gamepad_Axis(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            ((GamepadAxis)input.Tag).elementIdentifierId = input.SelectedIndex;
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
            } else
            {
                input.Text = Keycodes.keynames[((KeyboardKeybind)input.Tag).elementIdentifierId];
            }
        }
        private void Edit_Binding(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            if (Keycodes.keyboard.ContainsKey(((KeyEventArgs)e).KeyCode))
            {
                ((KeyboardKeybind)input.Tag).elementIdentifierId = Keycodes.keyboard[((KeyEventArgs)e).KeyCode];
                input.Text = Keycodes.keynames[Keycodes.keyboard[((KeyEventArgs)e).KeyCode]];
            }
            tabControls.Focus();
        }

        private void Prevent_Input(object sender, EventArgs e)
        {
            ((KeyPressEventArgs)e).Handled = true;
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

        private void Reload_Controls(object sender, EventArgs e)
        {
            Populate_Controls();
        }

        private void Edit_Gamepad_Key(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            XBoxController curctrl = null;

            //Search for the controller that the bind is assigned to
            foreach (Controller ctrl in Graphics.settings_json._overrideControllerMapValueList)
            {
                if (ctrl is XBoxController)
                {
                    if (input.Tag is GamepadKeybind)
                    {
                        if (((XBoxController)ctrl).keybinds.Contains((GamepadKeybind)input.Tag))
                        {
                            curctrl = ctrl as XBoxController;
                        }
                    } else if (input.Tag is GamepadAxis)
                    {
                        if (((XBoxController)ctrl).axes.Contains((GamepadAxis)input.Tag))
                        {
                            curctrl = ctrl as XBoxController;
                        }
                    }
                }
            }
            if (input.SelectedIndex < 2) // LT, RT
            {
                // Convert axis to button or vice-versa
                if ((input.Tag is GamepadKeybind) && curctrl.keybinds.Contains((GamepadKeybind)input.Tag))
                {
                    curctrl.keybinds.Remove((GamepadKeybind)input.Tag);
                    GamepadAxis axis = new GamepadAxis((GamepadKeybind)input.Tag);
                    axis.elementIdentifierId = input.SelectedIndex + 4;
                    curctrl.axes.Add(axis);
                    input.Tag = axis;
                } else
                {
                    ((GamepadAxis)input.Tag).elementIdentifierId = input.SelectedIndex + 4;
                }
            } else
            {
                if ((input.Tag is GamepadAxis) && curctrl.axes.Contains((GamepadAxis)input.Tag))
                {
                    curctrl.axes.Remove((GamepadAxis)input.Tag);
                    GamepadKeybind bind = new GamepadKeybind((GamepadAxis)input.Tag);
                    bind.elementIdentifierId = input.SelectedIndex + 4;
                    curctrl.keybinds.Add(bind);
                    input.Tag = bind;
                } else
                {
                    ((GamepadKeybind)input.Tag).elementIdentifierId = input.SelectedIndex + 4;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
