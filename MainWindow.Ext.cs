using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenshinConfigurator.Enums;

namespace GenshinConfigurator
{
    public partial class MainWindow
    {
        #region Graphics
        public int GraphicsPreset
        {
            get { if (Settings.Graphics.current_preset == -1) return 4; else return Settings.Graphics.current_preset; }
            set
            {
                switch (value)
                {
                    case 0:
                        Settings.Graphics.current_preset = value;
                        GraphicsLowestSettings();
                        break;
                    case 1:
                        Settings.Graphics.current_preset = value;
                        GraphicsLowSettings();
                        break;
                    case 2:
                        Settings.Graphics.current_preset = value;
                        GraphicsMediumSettings();
                        break;
                    case 3:
                        Settings.Graphics.current_preset = value;
                        GraphicsHighSettings();
                        break;
                    case 4:
                        Settings.Graphics.current_preset = -1;
                        break;
                }
                RefreshBoxes();
            }
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

        public int GraphicsDynamicCharacterResolution
        {
            get => Settings.Graphics.Get(SettingsType.DynamicCharacterResolution) - 1;
            set
            {
                Settings.Graphics.Change(SettingsType.DynamicCharacterResolution, value + 1);
                GraphicsPresetComboBox.SelectedIndex = 4;
            }
        }

        public double GraphicsGamma
        {
            get => Settings.Graphics.gamma;
            set => Settings.Graphics.gamma = value;
        }
        #endregion

        #region Resolution
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
        #endregion

        #region Input
        public List<Controller> InputControllers => Settings.Keybindings.controllers.controllers;
        #endregion

        #region Controls (Keyboard)
        public int ControlsKeyboardHorizontalSensitivity
        {
            get => Settings.ControlsKeyboard.horizontal_sensitivity + 1;
            set => Settings.ControlsKeyboard.horizontal_sensitivity = value - 1;
        }

        public int ControlsKeyboardVerticalSensitivity
        {
            get => Settings.ControlsKeyboard.vertical_sensitivity + 1;
            set => Settings.ControlsKeyboard.vertical_sensitivity = value - 1;
        }

        public int ControlsKeyboardHorizontalSensitivityAiming
        {
            get => Settings.ControlsKeyboard.horizontal_sensitivity_aiming + 1;
            set => Settings.ControlsKeyboard.horizontal_sensitivity_aiming = value - 1;
        }

        public int ControlsKeyboardVerticalSensitivityAiming
        {
            get => Settings.ControlsKeyboard.vertical_sensitivity_aiming + 1;
            set => Settings.ControlsKeyboard.vertical_sensitivity_aiming = value - 1;
        }
        #endregion

        #region Controls (Gamepad)
        public int ControlsGamepadHorizontalSensitivity
        {
            get => Settings.ControlsGamepad.horizontal_sensitivity + 1;
            set => Settings.ControlsGamepad.horizontal_sensitivity = value - 1;
        }

        public int ControlsGamepadVerticalSensitivity
        {
            get => Settings.ControlsGamepad.vertical_sensitivity + 1;
            set => Settings.ControlsGamepad.vertical_sensitivity = value - 1;
        }

        public int ControlsGamepadHorizontalSensitivityAiming
        {
            get => Settings.ControlsGamepad.horizontal_sensitivity_aiming + 1;
            set => Settings.ControlsGamepad.horizontal_sensitivity_aiming = value - 1;
        }

        public int ControlsGamepadVerticalSensitivityAiming
        {
            get => Settings.ControlsGamepad.vertical_sensitivity_aiming + 1;
            set => Settings.ControlsGamepad.vertical_sensitivity_aiming = value - 1;
        }

        public bool ControlsGamepadInvertHorizontalAxis
        {
            get => Settings.ControlsGamepad.invert_horizontal_axis;
            set => Settings.ControlsGamepad.invert_horizontal_axis = value;
        }

        public bool ControlsGamepadInvertVerticalAxis
        {
            get => Settings.ControlsGamepad.invert_vertical_axis;
            set => Settings.ControlsGamepad.invert_vertical_axis = value;
        }

        public bool ControlsGamepadInvertHorizontalAxisAiming
        {
            get => Settings.ControlsGamepad.invert_horizontal_axis_aiming;
            set => Settings.ControlsGamepad.invert_horizontal_axis_aiming = value;
        }

        public bool ControlsGamepadInvertVerticalAxisAiming
        {
            get => Settings.ControlsGamepad.invert_vertical_axis_aiming;
            set => Settings.ControlsGamepad.invert_vertical_axis_aiming = value;
        }

        public bool ControlsGamepadGyroAiming
        {
            get => Settings.ControlsGamepad.gyro_aiming;
            set => Settings.ControlsGamepad.gyro_aiming = value;
        }

        public int ControlsGamepadGyroAxis
        {
            get => Settings.ControlsGamepad.gyro_axis;
            set => Settings.ControlsGamepad.gyro_axis = value;
        }

        public int ControlsGamepadGyroHorizontalSensitivity
        {
            get => Settings.ControlsGamepad.gyro_horizontal_sensitivity + 1;
            set => Settings.ControlsGamepad.gyro_horizontal_sensitivity = value - 1;
        }

        public int ControlsGamepadGyroVerticalSensitivity
        {
            get => Settings.ControlsGamepad.gyro_vertical_sensitivity + 1;
            set => Settings.ControlsGamepad.gyro_vertical_sensitivity = value - 1;
        }

        public bool ControlsGamepadGyroDisableRightStickVerticalInput
        {
            get => Settings.ControlsGamepad.disable_right_stick_vertical_axis;
            set => Settings.ControlsGamepad.disable_right_stick_vertical_axis = value;
        }

        public bool ControlsGamepadGyroInvertHorizontalAxis
        {
            get => Settings.ControlsGamepad.gyro_invert_horizontal_axis;
            set => Settings.ControlsGamepad.gyro_invert_horizontal_axis = value;
        }

        public bool ControlsGamepadGyroInvertVerticalAxis
        {
            get => Settings.ControlsGamepad.gyro_invert_vertical_axis;
            set => Settings.ControlsGamepad.gyro_invert_vertical_axis = value;
        }

        public int ControlsGamepadGradedVibration
        {
            get => Settings.ControlsGamepad.graded_vibration;
            set => Settings.ControlsGamepad.graded_vibration = value;
        }

        public int ControlsGamepadVibrationPower
        {
            get => Settings.ControlsGamepad.vibration_power;
            set => Settings.ControlsGamepad.vibration_power = value;
        }
        #endregion

        #region Controls (Misc)
        public bool ControlsMiscAutomaticViewHeight
        {
            get => Settings.ControlsMisc.automatic_view_height;
            set => Settings.ControlsMisc.automatic_view_height = value;
        }

        public bool ControlsMiscSmartCombatCamera
        {
            get => Settings.ControlsMisc.smart_combat_camera;
            set => Settings.ControlsMisc.smart_combat_camera = value;
        }

        public double ControlsMiscCameraHeight
        {
            get => Settings.ControlsMisc.default_camera_height;
            set => Settings.ControlsMisc.default_camera_height = value;
        }

        public int ControlsMiscBoatCameraAngleCorrection
        {
            get => Settings.ControlsMisc.automatic_boat_camera_angle_correction;
            set => Settings.ControlsMisc.automatic_boat_camera_angle_correction = value;
        }
        #endregion

        #region Audio
        public int AudioMain
        {
            get => Settings.Audio.main_volume;
            set => Settings.Audio.main_volume = value;
        }

        public int AudioMusic
        {
            get => Settings.Audio.music_volume;
            set => Settings.Audio.music_volume = value;
        }

        public int AudioSFX
        {
            get => Settings.Audio.sfx_volume;
            set => Settings.Audio.sfx_volume = value;
        }

        public int AudioVoice
        {
            get => Settings.Audio.voice_volume;
            set => Settings.Audio.voice_volume = value;
        }

        public int AudioDynamicRange
        {
            get => Settings.Audio.dynamic_range;
            set => Settings.Audio.dynamic_range = value;
        }

        public int AudioOutputFormat
        {
            get => Settings.Audio.output_format;
            set => Settings.Audio.output_format = value;
        }
        #endregion

        #region Language
        public int LanguageText
        {
            get => (int)Settings.Language.text_lang - 1;
            set => Settings.Language.text_lang = (TextLanguage)(value + 1);
        }

        public int LanguageVoice
        {
            get => (int)Settings.Language.voice_lang;
            set => Settings.Language.voice_lang = (VoiceLanguage)value;
        }
        #endregion

        public string LogText
        {
            get {
                try
                {
                    return File.ReadAllText(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName + @"\LocalLow\miHoYo\Genshin Impact\output_log.txt");
                } catch {
                    return"Log file is currently used by Genshin.";
                }
            }
        }
    }
}
