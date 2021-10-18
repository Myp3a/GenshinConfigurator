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
        }

        private void Preset_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
            Reset_Button_Click(null, null);
        }

        private void Antialiasing_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnvironmentDetail_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SFXQuality_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VisualEffects_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShadowQuality_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RenderResolution_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VSync_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FPS_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnisotropicFiltering_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeammateEffects_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubsurfaceScattering_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrowdDensity_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bloom_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MotionBlur_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reflections_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VolumetricFog_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
