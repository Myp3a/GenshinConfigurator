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
        ResolutionSettings Resolution;
        public MainWin()
        {
            InitializeComponent();
        }

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
                VolumetricFog_Box.SelectedIndex = Settings.Graphics.Get(SettingsType.VolumetricFog) - 1;
                VolumetricFog_Box.Enabled = true;
            } else
            {
                VolumetricFog_Box.SelectedIndex = 0;
                VolumetricFog_Box.Enabled = false;
            }
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
            } else
            {
                Fullscreen_Check.Checked = false;
            }
            trackBarVoiceVolume.Value = Settings.Audio.voice_volume;
            trackBarSFXVolume.Value = Settings.Audio.sfx_volume;
            trackBarMusicVolume.Value = Settings.Audio.music_volume;
            trackBarMainVolume.Value = Settings.Audio.main_volume;
            comboBoxTextLanguage.SelectedIndex = (int)Settings.Language.text_lang - 1;
            comboBoxVoiceLanguage.SelectedIndex = (int)Settings.Language.voice_lang;
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

        private void Apply_Audio_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("audio");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Apply_Language_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("language");
            Settings.ToReg();
            Status_Label.Text = "Saved config to registry.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Apply_Controls_Button_Click(object sender, EventArgs e)
        {
            Settings.Apply("controls");
            Settings.ToReg();
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

        private void Remove_Keybind(object sender, EventArgs e)
        {
            Controller cntrl = Controller_By_Bind((Keybind)((Button)sender).Tag);
            // TODO: easier add/remove of binds
            if (cntrl is KeyboardController)
            {
                ((KeyboardController)cntrl).keybinds.Remove((KeyboardKeybind)((Button)sender).Tag);
            } 
            else if (cntrl is XBoxController)
            {
                if (((Button)sender).Tag is GamepadKeybind)
                {
                    ((XBoxController)cntrl).keybinds.Remove((GamepadKeybind)((Button)sender).Tag);
                } 
                else if (((Button)sender).Tag is GamepadAxis) 
                {
                    ((XBoxController)cntrl).axes.Remove((GamepadAxis)((Button)sender).Tag);
                }
            }
            else if (cntrl is MouseController)
            {
                if (((Button)sender).Tag is GamepadKeybind)
                {
                    ((MouseController)cntrl).keybinds.Remove((GamepadKeybind)((Button)sender).Tag);
                }
                else if (((Button)sender).Tag is GamepadAxis)
                {
                    ((MouseController)cntrl).axes.Remove((GamepadAxis)((Button)sender).Tag);
                }
            }
            Populate_Controls();
        }

        private void Add_Keybind(object sender, EventArgs e)
        {
            // Controller is selected by the first bind
            Button add_button = (Button)sender;
            ComboBox bind_selector = add_button.Tag as ComboBox;
            Keybind first_bind = (Keybind)((Label)bind_selector.Tag).Tag;
            Controller cntrl = Controller_By_Bind(first_bind);
            if (cntrl is KeyboardController)
            {
                KeyboardKeybind newbind = new KeyboardKeybind();
                newbind.elementIdentifierId = 0;
                try
                {
                    newbind.actionId = Convert.ToInt32(bind_selector.Text);
                }
                catch
                {
                    newbind.actionId = Keycodes.actions.Where(c => c.Value == bind_selector.Text).First().Key;
                }
                ((KeyboardController)cntrl).keybinds.Add(newbind);
            }
            else if (cntrl is XBoxController) 
            {
                int actionId;
                try
                {
                    actionId = Convert.ToInt32(bind_selector.Text);
                }
                catch
                {
                    actionId = Keycodes.actions.Where(c => c.Value == bind_selector.Text).First().Key;
                }
                List<int> axis_actions = new List<int> { 0, 1 }; // Forward and side movement. Axis keybinds are different, so let's leave it like that for now
                if (axis_actions.Contains(actionId))
                {
                    GamepadAxis newbind = new GamepadAxis();
                    newbind.elementIdentifierId = 22;
                    newbind.actionId = actionId;
                    ((XBoxController)cntrl).axes.Add(newbind);
                } 
                else
                {
                    GamepadKeybind newbind = new GamepadKeybind();
                    newbind.elementIdentifierId = 22;
                    newbind.actionId = actionId;
                    ((XBoxController)cntrl).keybinds.Add(newbind);
                }
            }
            else if (cntrl is MouseController)
            {
                int actionId;
                try
                {
                    actionId = Convert.ToInt32(bind_selector.Text);
                }
                catch
                {
                    actionId = Keycodes.actions.Where(c => c.Value == bind_selector.Text).First().Key;
                }
                List<int> axis_actions = new List<int> { 0, 1 }; // Forward and side movement. Axis keybinds are different, so let's leave it like that for now
                if (axis_actions.Contains(actionId))
                {
                    GamepadAxis newbind = new GamepadAxis();
                    newbind.elementIdentifierId = 0;
                    newbind.actionId = actionId;
                    ((MouseController)cntrl).axes.Add(newbind);
                }
                else
                {
                    GamepadKeybind newbind = new GamepadKeybind();
                    newbind.elementIdentifierId = 3;
                    newbind.actionId = actionId;
                    ((MouseController)cntrl).keybinds.Add(newbind);
                }
            }
            Populate_Controls();
        }

        private void Populate_Controls()
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
            Controller cntrl = Settings.Controls.controllers[devicesList.SelectedIndex];
            int top = labelControlTemplate.Top;
            int height = 25;
            int mult = 0;
            if (cntrl is KeyboardController)
            {
                // While keyboard is very flexible and have many actions, it still intersects with gamepad in some ways.
                List<int> keyboardActionsBlacklist = new List<int> { 5 };
                foreach (KeyboardKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !keyboardActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        newlabel.Tag = bind;
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
                        newctrl.Top = checkBoxCtrlTemplate.Top + height * mult - 3; // CheckBox size is different to inputBox size
                        newctrl.Text = "Ctrl";
                        newctrl.Width = checkBoxCtrlTemplate.Width;
                        newctrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newctrl.Tag = bind;
                        newctrl.BackColor = Color.Transparent;
                        splitContainerControls.Panel2.Controls.Add(newctrl);

                        CheckBox newshift = new CheckBox();
                        newshift.Checked = bind.shift;
                        newshift.Left = checkBoxShiftTemplate.Left;
                        newshift.Top = checkBoxShiftTemplate.Top + height * mult - 3;
                        newshift.Text = "Shift";
                        newshift.Width = checkBoxShiftTemplate.Width;
                        newshift.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newshift.Tag = bind;
                        newshift.BackColor = Color.Transparent;
                        splitContainerControls.Panel2.Controls.Add(newshift);

                        CheckBox newalt = new CheckBox();
                        newalt.Checked = bind.alt;
                        newalt.Left = checkBoxAltTemplate.Left;
                        newalt.Top = checkBoxAltTemplate.Top + height * mult - 3;
                        newalt.Text = "Alt";
                        newalt.Width = checkBoxAltTemplate.Width;
                        newalt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newalt.Tag = bind;
                        newalt.BackColor = Color.Transparent;
                        splitContainerControls.Panel2.Controls.Add(newalt);

                        if (devModeToggle.Checked)
                        {
                            Button delkeybind = new Button();
                            delkeybind.Text = "X";
                            delkeybind.Left = buttonKeybindRemoveTemplate.Left;
                            delkeybind.Top = buttonKeybindRemoveTemplate.Top + height * mult;
                            delkeybind.Width = buttonKeybindRemoveTemplate.Width;
                            delkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            delkeybind.Tag = bind;
                            delkeybind.Click += Remove_Keybind;
                            splitContainerControls.Panel2.Controls.Add(delkeybind);
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
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        newlabel.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        ComboBox newbutton = new ComboBox();
                        newbutton.Left = gamepadButtonTemplate.Left;
                        newbutton.Top = gamepadButtonTemplate.Top + height * mult;
                        newbutton.Items.AddRange(Keycodes.mouse_keys.ToArray());
                        newbutton.SelectedIndex = bind.elementIdentifierId - 3;
                        newbutton.Tag = bind;
                        newbutton.SelectedValueChanged += Edit_Mouse_Key;
                        newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newbutton.DropDownStyle = ComboBoxStyle.DropDownList;
                        splitContainerControls.Panel2.Controls.Add(newbutton);

                        if (devModeToggle.Checked)
                        {
                            Button delkeybind = new Button();
                            delkeybind.Text = "X";
                            delkeybind.Left = buttonKeybindRemoveTemplate.Left;
                            delkeybind.Top = buttonKeybindRemoveTemplate.Top + height * mult;
                            delkeybind.Width = buttonKeybindRemoveTemplate.Width;
                            delkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            delkeybind.Tag = bind;
                            delkeybind.Click += Remove_Keybind;
                            splitContainerControls.Panel2.Controls.Add(delkeybind);
                        }

                        mult++;
                    }
                }
                foreach (GamepadAxis bind in ((MouseController)cntrl).axes)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if (!name.Contains("?") || devModeToggle.Checked)
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        ComboBox newbutton = new ComboBox();
                        newbutton.Left = gamepadAxisTemplate.Left;
                        newbutton.Top = gamepadAxisTemplate.Top + height * mult;
                        newbutton.Items.AddRange(Keycodes.mouse_axes.ToArray());
                        newbutton.SelectedIndex = bind.elementIdentifierId;
                        newbutton.Tag = bind;
                        newbutton.SelectedValueChanged += Edit_Gamepad_Axis;
                        newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newbutton.DropDownStyle = ComboBoxStyle.DropDownList;
                        splitContainerControls.Panel2.Controls.Add(newbutton);

                        CheckBox newinvert = new CheckBox();
                        newinvert.Checked = bind.invert;
                        newinvert.Top = gamepadAxisInvertTemplate.Top + height * mult - 3;
                        newinvert.Left = gamepadAxisInvertTemplate.Left;
                        newinvert.Tag = bind;
                        newinvert.Text = "Invert";
                        newinvert.CheckedChanged += Invert_Gamepad_Axis;
                        newinvert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newinvert.BackColor = Color.Transparent;
                        splitContainerControls.Panel2.Controls.Add(newinvert);

                        if (devModeToggle.Checked)
                        {
                            Button delkeybind = new Button();
                            delkeybind.Text = "X";
                            delkeybind.Left = buttonKeybindRemoveTemplate.Left;
                            delkeybind.Top = buttonKeybindRemoveTemplate.Top + height * mult;
                            delkeybind.Width = buttonKeybindRemoveTemplate.Width;
                            delkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            delkeybind.Tag = bind;
                            delkeybind.Click += Remove_Keybind;
                            splitContainerControls.Panel2.Controls.Add(delkeybind);
                        }

                        mult++;
                    }
                }
            }
            else if (cntrl is XBoxController)
            {
                // These buttons have mappings for them, however, they do not appear doing something useful.
                List<int> gamepadActionsBlacklist = new List<int> { 87, 88 };
                foreach (GamepadKeybind bind in cntrl.keybinds)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
                    {
                        Label newlabel = new Label();
                        newlabel.Left = labelControlTemplate.Left;
                        newlabel.Top = labelControlTemplate.Top + height * mult;
                        newlabel.Text = (Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?");
                        if (devModeToggle.Checked) newlabel.Text += " (" + bind.actionId.ToString() + ")";
                        newlabel.AutoSize = true;
                        newlabel.Tag = bind;
                        splitContainerControls.Panel2.Controls.Add(newlabel);

                        ComboBox newbutton = new ComboBox();
                        newbutton.Left = gamepadButtonTemplate.Left;
                        newbutton.Top = gamepadButtonTemplate.Top + height * mult;
                        newbutton.Items.AddRange(gamepadButtonTemplate.Items.Cast<Object>().ToArray());
                        newbutton.SelectedIndex = bind.elementIdentifierId - 4;
                        newbutton.Tag = bind;
                        newbutton.SelectedValueChanged += Edit_Gamepad_Key;
                        newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        newbutton.DropDownStyle = ComboBoxStyle.DropDownList;
                        splitContainerControls.Panel2.Controls.Add(newbutton);

                        if (devModeToggle.Checked)
                        {
                            Button delkeybind = new Button();
                            delkeybind.Text = "X";
                            delkeybind.Left = buttonKeybindRemoveTemplate.Left;
                            delkeybind.Top = buttonKeybindRemoveTemplate.Top + height * mult;
                            delkeybind.Width = buttonKeybindRemoveTemplate.Width;
                            delkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            delkeybind.Tag = bind;
                            delkeybind.Click += Remove_Keybind;
                            splitContainerControls.Panel2.Controls.Add(delkeybind);
                        }

                        mult++;
                    }
                }
                foreach (GamepadAxis bind in ((XBoxController)cntrl).axes)
                {
                    string name = Keycodes.actions.ContainsKey(bind.actionId) ? Keycodes.actions[bind.actionId] : "?";
                    if ((!name.Contains("?") && !gamepadActionsBlacklist.Contains(bind.actionId)) || devModeToggle.Checked)
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
                            newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            newbutton.DropDownStyle = ComboBoxStyle.DropDownList;
                            splitContainerControls.Panel2.Controls.Add(newbutton);
                        }
                        else
                        {
                            ComboBox newbutton = new ComboBox();
                            newbutton.Left = gamepadAxisTemplate.Left;
                            newbutton.Top = gamepadAxisTemplate.Top + height * mult;
                            newbutton.Items.AddRange(gamepadAxisTemplate.Items.Cast<Object>().ToArray());
                            newbutton.SelectedIndex = bind.elementIdentifierId;
                            newbutton.Tag = bind;
                            newbutton.SelectedValueChanged += Edit_Gamepad_Axis;
                            newbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            newbutton.DropDownStyle = ComboBoxStyle.DropDownList;
                            splitContainerControls.Panel2.Controls.Add(newbutton);

                            CheckBox newinvert = new CheckBox();
                            newinvert.Checked = bind.invert;
                            newinvert.Top = gamepadAxisInvertTemplate.Top + height * mult - 3;
                            newinvert.Left = gamepadAxisInvertTemplate.Left;
                            newinvert.Tag = bind;
                            newinvert.Text = "Invert";
                            newinvert.CheckedChanged += Invert_Gamepad_Axis;
                            newinvert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            newinvert.BackColor = Color.Transparent;
                            splitContainerControls.Panel2.Controls.Add(newinvert);
                        }

                        if (devModeToggle.Checked)
                        {
                            Button delkeybind = new Button();
                            delkeybind.Text = "X";
                            delkeybind.Left = buttonKeybindRemoveTemplate.Left;
                            delkeybind.Top = buttonKeybindRemoveTemplate.Top + height * mult;
                            delkeybind.Width = buttonKeybindRemoveTemplate.Width;
                            delkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                            delkeybind.Tag = bind;
                            delkeybind.Click += Remove_Keybind;
                            splitContainerControls.Panel2.Controls.Add(delkeybind);
                        }

                        mult++;
                    }
                }
            }
            if (devModeToggle.Checked)
            {
                ComboBox newkeybindlist = new ComboBox();
                List<string> avail_keybinds = new List<string>();
                List<int> binded_keybinds = new List<int>();
                foreach (Control ctrl in splitContainerControls.Panel2.Controls)
                {
                    if ((ctrl is Label) && (ctrl.Tag != null)) binded_keybinds.Add(((Keybind)ctrl.Tag).actionId);
                }
                foreach (KeyValuePair<int,string> pair in Keycodes.actions)
                {
                    if (!binded_keybinds.Contains(pair.Key))
                    {
                        avail_keybinds.Add(pair.Value);
                    }
                }
                newkeybindlist.Items.AddRange(avail_keybinds.ToArray());
                newkeybindlist.SelectedIndex = 0;
                newkeybindlist.Left = comboBoxKeybindListTemplate.Left;
                newkeybindlist.Top = comboBoxKeybindListTemplate.Top + height * mult;
                newkeybindlist.Tag = splitContainerControls.Panel2.Controls.Cast<Control>().Where(c => c.Tag != null).Where(c => c is Label).First(); // First bind
                splitContainerControls.Panel2.Controls.Add(newkeybindlist);

                Button newkeybind = new Button();
                newkeybind.Text = "Add";
                newkeybind.Left = buttonKeybindingAddTemplate.Left;
                newkeybind.Top = buttonKeybindingAddTemplate.Top + height * mult;
                newkeybind.Width = buttonKeybindingAddTemplate.Width;
                newkeybind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                newkeybind.Tag = newkeybindlist;
                newkeybind.Click += Add_Keybind;
                splitContainerControls.Panel2.Controls.Add(newkeybind);
            }
            splitContainerControls.Panel2.ResumeLayout();
            splitContainerControls.Panel2.Enabled = true;
            Status_Label.Text = "Controls loaded.";
            Status_Reset_Timer.Enabled = false;
            Status_Reset_Timer.Enabled = true;
        }

        private void Paint_BG(object sender, PaintEventArgs e)
        {
            int count = 0;
            foreach (Control ctrl in splitContainerControls.Panel2.Controls)
            {
                if (ctrl is Label) count++;
            }
            e.Graphics.TranslateTransform(splitContainerControls.Panel2.AutoScrollPosition.X, splitContainerControls.Panel2.AutoScrollPosition.Y);
            for (int i = 2; i < count*25; i += 25)
            {
                e.Graphics.DrawLine(Pens.Black, 0, i, splitContainerControls.Panel2.Width, i);
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

        private Controller Controller_By_Bind(Keybind bind)
        {
            Controller curctrl = null;
            //Search for the controller that the bind is assigned to
            foreach (Controller ctrl in Settings.Controls.controllers)
            {
                if (ctrl is XBoxController)
                {
                    if (bind is GamepadKeybind)
                    {
                        if (((XBoxController)ctrl).keybinds.Contains((GamepadKeybind)bind))
                        {
                            curctrl = ctrl as XBoxController;
                        }
                    }
                    else if (bind is GamepadAxis)
                    {
                        if (((XBoxController)ctrl).axes.Contains((GamepadAxis)bind))
                        {
                            curctrl = ctrl as XBoxController;
                        }
                    }
                }
                else if (ctrl is KeyboardController)
                {
                    if (bind is KeyboardKeybind)
                    {
                        if (((KeyboardController)ctrl).keybinds.Contains((KeyboardKeybind)bind))
                        {
                            curctrl = ctrl as KeyboardController;
                        }
                    }
                }
                else if (ctrl is MouseController)
                {
                    if (bind is GamepadKeybind)
                    {
                        if (((MouseController)ctrl).keybinds.Contains((GamepadKeybind)bind))
                        {
                            curctrl = ctrl as MouseController;
                        }
                    }
                    else if (bind is GamepadAxis)
                    {
                        if (((MouseController)ctrl).axes.Contains((GamepadAxis)bind))
                        {
                            curctrl = ctrl as MouseController;
                        }
                    }
                }
            }

            return curctrl;
        }
        private void Edit_Gamepad_Key(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;

            XBoxController curctrl = (XBoxController)Controller_By_Bind((Keybind)input.Tag); // For now, it's fine to assume that XBoxController will be returned

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

        private void Edit_Mouse_Key(object sender, EventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            ((GamepadKeybind)input.Tag).elementIdentifierId = input.SelectedIndex + 3;
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


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
            foreach (Controller cntrl in Settings.Controls.controllers)
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

        private void addMouseButton_Click(object sender, EventArgs e)
        {
            MouseController cntrl = new MouseController();
            cntrl.name = "";
            cntrl.enabled = true;
            cntrl.hardwareGuid = "00000000-0000-0000-0000-000000000000";

            GamepadKeybind lmb = new GamepadKeybind();
            lmb.elementIdentifierId = 3;
            lmb.actionId = 138;
            GamepadKeybind rmb = new GamepadKeybind();
            rmb.elementIdentifierId = 4;
            rmb.actionId = 139;
            GamepadKeybind attack = new GamepadKeybind();
            attack.elementIdentifierId = 3;
            attack.actionId = 16;
            GamepadKeybind sprint = new GamepadKeybind();
            sprint.elementIdentifierId = 4;
            sprint.actionId = 21;
            GamepadKeybind elvision = new GamepadKeybind();
            elvision.elementIdentifierId = 5;
            elvision.actionId = 57;

            GamepadAxis horizontal = new GamepadAxis();
            horizontal.elementIdentifierId = 0;
            horizontal.actionId = 30;
            GamepadAxis vertical = new GamepadAxis();
            vertical.elementIdentifierId = 1;
            vertical.actionId = 31;
            GamepadAxis zoom = new GamepadAxis();
            zoom.elementIdentifierId = 2;
            zoom.actionId = 54;

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
            Settings.Save("controls");
            MessageBox.Show("Mouse added! Please, restart the application.");
        }

        private void comboBoxTextLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Language.text_lang = (TextLanguage)comboBoxTextLanguage.SelectedIndex + 1;
        }

        private void comboBoxVoiceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Language.voice_lang = (VoiceLanguage)comboBoxVoiceLanguage.SelectedIndex;
        }
    }
}
