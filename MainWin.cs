using System;
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
            foreach (string controller_id in Graphics.settings_json._overrideControllerMapKeyList)
            {
                string[] parts = controller_id.Split(new[] { "__" }, StringSplitOptions.None);
                devicesList.Items.Add(parts[1] + "__" + parts[2]);
            }
            devicesList.SelectedIndex = 0;
            Task.Run(() => Populate_Controls());
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
            List<Control> auto_controls =  splitContainerControls.Panel2.Controls.Cast<Control>().Where(c => c.Tag == "auto").ToList();
            foreach (Control control in auto_controls)
            {
                splitContainerControls.Panel2.Controls.Remove(control);
            }
            XNamespace ns = "http://guavaman.com/rewired";
            XElement remap_xml = Graphics.settings_json._overrideControllerMapValueList[devicesList.SelectedIndex];
            if (remap_xml.Element(ns + "hardwareGuid").Value == "00000000-0000-0000-0000-000000000000")
            {
                if (remap_xml.Name == ns + "KeyboardMap")
                {
                    IEnumerable<XElement> keybindings =
                        from el in remap_xml.Descendants()
                        where el.Name == ns + "ActionElementMap"
                        select el;
                    int top = labelControlTemplate.Top;
                    int height = 25;
                    int mult = 0;
                    foreach (XElement bindingNode in keybindings)
                    {
                        KeyboardKeybind bind = new KeyboardKeybind(bindingNode);

                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = Keycodes.actions.ContainsKey(bind.action_id) ? Keycodes.actions[bind.action_id] : "?";
                        newlabel.Tag = "auto";
                        newlabel.AutoSize = true;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        Button newbutton = new Button();
                        newbutton.Left = buttonKeyTemplate.Left;
                        newbutton.Top = buttonKeyTemplate.Top + height * mult;
                        newbutton.Width = buttonKeyTemplate.Width;
                        newbutton.Text = Keycodes.keynames[bind.keyboard_keycode];
                        newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newbutton.Tag = "auto";
                        splitContainerControls.Panel2.Controls.Add(newbutton);

                        CheckBox newctrl = new CheckBox();
                        newctrl.Checked = bind.ctrl;
                        newctrl.Left = checkBoxCtrlTemplate.Left;
                        newctrl.Top = checkBoxCtrlTemplate.Top + height * mult;
                        newctrl.Text = "Ctrl";
                        newctrl.Width = checkBoxCtrlTemplate.Width;
                        newctrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newctrl.Tag = "auto";
                        splitContainerControls.Panel2.Controls.Add(newctrl);

                        CheckBox newshift = new CheckBox();
                        newshift.Checked = bind.shift;
                        newshift.Left = checkBoxShiftTemplate.Left;
                        newshift.Top = checkBoxShiftTemplate.Top + height * mult;
                        newshift.Text = "Shift";
                        newshift.Width = checkBoxShiftTemplate.Width;
                        newshift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newshift.Tag = "auto";
                        splitContainerControls.Panel2.Controls.Add(newshift);

                        CheckBox newalt = new CheckBox();
                        newalt.Checked = bind.alt;
                        newalt.Left = checkBoxAltTemplate.Left;
                        newalt.Top = checkBoxAltTemplate.Top + height * mult;
                        newalt.Text = "Alt";
                        newalt.Width = checkBoxAltTemplate.Width;
                        newalt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newalt.Tag = "auto";
                        splitContainerControls.Panel2.Controls.Add(newalt);
                        mult++;
                    }
                }
            }
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
    }
}
