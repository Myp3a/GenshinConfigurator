using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GenshinConfigurator.Enums;

namespace GenshinConfigurator
{
    public partial class MainWin : Form
    {
        GenshSettings MySettings;
        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            MySettings = new GenshSettings();
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
            Reset_Button_Click(null, null);
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            FPS_Box.SelectedIndex = MySettings.Get((int)Settings.FPS) - 1;
            VSync_Box.SelectedIndex = MySettings.Get((int)Settings.VSync) - 1;
            RenderResolution_Box.SelectedIndex = MySettings.Get((int)Settings.RenderResolution) - 1;
            ShadowQuality_Box.SelectedIndex = MySettings.Get((int)Settings.ShadowQuality) - 1;
            VisualEffects_Box.SelectedIndex = MySettings.Get((int)Settings.VisualEffects) - 1;
            SFXQuality_Box.SelectedIndex = MySettings.Get((int)Settings.SFXQuality) - 1;
            EnvironmentDetail_Box.SelectedIndex = MySettings.Get((int)Settings.EnvironmentDetail) - 1;
            Antialiasing_Box.SelectedIndex = MySettings.Get((int)Settings.Antialiasing) - 1;
            VolumetricFog_Box.SelectedIndex = MySettings.Get((int)Settings.VolumetricFog) - 1;
            Reflections_Box.SelectedIndex = MySettings.Get((int)Settings.Reflections) - 1;
            MotionBlur_Box.SelectedIndex = MySettings.Get((int)Settings.MotionBlur) - 1;
            Bloom_Box.SelectedIndex = MySettings.Get((int)Settings.Bloom) - 1;
            CrowdDensity_Box.SelectedIndex = MySettings.Get((int)Settings.CrowdDensity) - 1;
            SubsurfaceScattering_Box.SelectedIndex = MySettings.Get((int)Settings.SubsurfaceScattering) - 1;
            TeammateEffects_Box.SelectedIndex = MySettings.Get((int)Settings.TeammateEffects) - 1;
            AnisotropicFiltering_Box.SelectedIndex = MySettings.Get((int)Settings.AnisotropicFiltering) - 1;
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            MySettings.Change((int)Settings.FPS, FPS_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.VSync, VSync_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.RenderResolution, RenderResolution_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.ShadowQuality, ShadowQuality_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.VisualEffects, VisualEffects_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.SFXQuality, SFXQuality_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.EnvironmentDetail, EnvironmentDetail_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.Antialiasing, Antialiasing_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.VolumetricFog, VolumetricFog_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.Reflections, Reflections_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.MotionBlur, MotionBlur_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.Bloom, Bloom_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.CrowdDensity, CrowdDensity_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.SubsurfaceScattering, SubsurfaceScattering_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.TeammateEffects, TeammateEffects_Box.SelectedIndex + 1);
            MySettings.Change((int)Settings.AnisotropicFiltering, AnisotropicFiltering_Box.SelectedIndex + 1);
            MySettings.Save();
        }
    }
}
