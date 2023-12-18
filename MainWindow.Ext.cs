using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenshinConfigurator.Enums;

namespace GenshinConfiguratorWPF
{
    public partial class MainWindow
    {
        public int GraphicsPreset
        {
            get { if (Settings.Graphics.current_preset == -1) return 4; else return Settings.Graphics.current_preset; }
            set { if (value == 4) Settings.Graphics.current_preset = -1; else Settings.Graphics.current_preset = value; } // reset presets
        }

        public int GraphicsFPSIndex
        {
            get => Settings.Graphics.Get(SettingsType.FPS) - 1;
            set 
            { Settings.Graphics.Change(SettingsType.FPS, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsVSync
        {
            get => Settings.Graphics.Get(SettingsType.VSync) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.VSync, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsRenderResolution
        {
            get => Settings.Graphics.Get(SettingsType.RenderResolution) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.RenderResolution, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsShadowQuality
        {
            get => Settings.Graphics.Get(SettingsType.ShadowQuality) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.ShadowQuality, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsVisualEffects
        {
            get => Settings.Graphics.Get(SettingsType.VisualEffects) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.VisualEffects, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsSFXQuality
        {
            get => Settings.Graphics.Get(SettingsType.SFXQuality) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.SFXQuality, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsEnvironmentDetail
        {
            get => Settings.Graphics.Get(SettingsType.EnvironmentDetail) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.EnvironmentDetail, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsAntialiasing
        {
            get => Settings.Graphics.Get(SettingsType.Antialiasing) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.Antialiasing, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsVolumetricFog
        {
            get => Settings.Graphics.Get(SettingsType.VolumetricFog) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.VolumetricFog, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsReflections
        {
            get => Settings.Graphics.Get(SettingsType.Reflections) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.Reflections, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsMotionBlur
        {
            get => Settings.Graphics.Get(SettingsType.MotionBlur) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.MotionBlur, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsBloom
        {
            get => Settings.Graphics.Get(SettingsType.Bloom) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.Bloom, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsCrowdDensity
        {
            get => Settings.Graphics.Get(SettingsType.CrowdDensity) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.CrowdDensity, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsSubsurfaceScattering
        {
            get => Settings.Graphics.Get(SettingsType.SubsurfaceScattering) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.SubsurfaceScattering, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsTeammateEffects
        {
            get => Settings.Graphics.Get(SettingsType.TeammateEffects) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.TeammateEffects, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public int GraphicsAnisotropicFiltering
        {
            get => Settings.Graphics.Get(SettingsType.AnisotropicFiltering) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.AnisotropicFiltering, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public double GraphicsGamma
        {
            get => Settings.Graphics.gamma;
            set => Settings.Graphics.gamma = value;
        }

        public int ResolutionWidth
        {
            get => Settings.Resolution.Get(ResolutionData.Width);
            set => Settings.Resolution.Change(ResolutionData.Width, value);
        }

        public int ResolutionHeight
        {
            get => Settings.Resolution.Get(ResolutionData.Height);
            set => Settings.Resolution.Change(ResolutionData.Height, value);
        }

        public bool ResolutionFullscreen
        {
            get => Convert.ToBoolean(Settings.Resolution.Get(ResolutionData.Fullscreen));
            set => Settings.Resolution.Change(ResolutionData.Fullscreen, Convert.ToInt32(value));
        }
    }
}
