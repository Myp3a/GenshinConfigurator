﻿using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static GenshinConfigurator.Enums;
using static GenshinConfigurator.JSONSchema;

namespace GenshinConfigurator
{
    internal class SettingsContainer
    {
        public GraphicsSettings Graphics;
        public ResolutionSettings Resolution;
        public AudioSettings Audio;
        public LanguageSettings Language;
        public Keybindings Keybindings;
        public ControlsKeyboardSettings ControlsKeyboard;
        public ControlsGamepadSettings ControlsGamepad;
        public ControlsMiscSettings ControlsMisc;
        MainJSON data;
        public bool controlsLoaded, graphicsLoaded, graphicsValid, inputLoaded;
        public SettingsContainer()
        {
            
        }

        public void Populate()
        {
            FromReg();
            this.controlsLoaded = data.__controlsLoaded;
            this.graphicsLoaded = data.__graphicsLoaded;
            this.inputLoaded = data.__inputLoaded;
            this.graphicsValid = data.__graphicsInRange;
        }

        public void Parse(string raw_cfg)
        {
            this.data = JsonConvert.DeserializeObject<MainJSON>(raw_cfg);
            try
            {
                this.Graphics = new GraphicsSettings(data);
            } 
            catch
            {
                this.Graphics = null;
            }
            this.Audio = new AudioSettings(data);
            this.Language = new LanguageSettings(data);
            this.Keybindings = new Keybindings(data);
            this.Resolution = new ResolutionSettings();
            this.ControlsKeyboard = new ControlsKeyboardSettings(data);
            this.ControlsGamepad = new ControlsGamepadSettings(data);
            this.ControlsMisc = new ControlsMiscSettings(data);
        }

        public void ToReg()
        {
            RegistryContainer.Save(JsonConvert.SerializeObject(this.data));
        }

        public void FromReg()
        {
            string raw_cfg = RegistryContainer.Load();
            Parse(raw_cfg);
        }

        public void Apply()
        {
            this.data = Audio.Apply(data);
            this.data = Keybindings.Apply(data);
            this.data = Graphics.Apply(data);
            this.data = Language.Apply(data);
            this.data = ControlsKeyboard.Apply(data);
            this.data = ControlsGamepad.Apply(data);
            this.data = ControlsMisc.Apply(data);
            Resolution.Apply();
        }

        public void Save(string path)
        {
            ConfigFile file = new ConfigFile
            {
                Resolution = new ResolutionConfig { Fullscreen = Convert.ToBoolean(Resolution.Get(ResolutionData.Fullscreen)), Width = Resolution.Get(ResolutionData.Width), Height = Resolution.Get(ResolutionData.Height) },
                Graphics = Graphics.ToConfig(),
                Audio = Audio.ToConfig(),
                Language = Language.ToConfig(),
                ControlsKeyboard = ControlsKeyboard.ToConfig(),
                ControlsGamepad = ControlsGamepad.ToConfig(),
                ControlsMisc = ControlsMisc.ToConfig(),
            };
            string result = JsonConvert.SerializeObject(file);
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(result);
            sw.Close();
        }

        public void Load(string path)
        {
            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            ConfigFile config = JsonConvert.DeserializeObject<ConfigFile>(file);
            if (config.Graphics != null)
            {
                this.Graphics.FromConfig(config.Graphics);
            }
            if (config.Audio != null)
            {
                this.Audio.FromConfig(config.Audio);
            }
            if (config.Language != null)
            {
                this.Language.FromConfig(config.Language);
            }
            if (config.Resolution != null)
            {
                Resolution.Change(ResolutionData.Width, config.Resolution.Width);
                Resolution.Change(ResolutionData.Height, config.Resolution.Height);
                Resolution.Change(ResolutionData.Fullscreen, Convert.ToInt32(config.Resolution.Fullscreen));
            }
            if (config.ControlsKeyboard != null)
            {
                ControlsKeyboard.FromConfig(config.ControlsKeyboard);
            }
            if (config.ControlsGamepad != null)
            {
                ControlsGamepad.FromConfig(config.ControlsGamepad);
            }
            if (config.ControlsMisc != null)
            {
                ControlsMisc.FromConfig(config.ControlsMisc);
            }
            Apply();
        }

        public string Raw()
        {
            return JsonConvert.SerializeObject(this.data);
        }
    }

    internal class AudioSettings
    {
        public int main_volume;
        public int music_volume;
        public int sfx_volume;
        public int voice_volume;
        public int dynamic_range;
        public int output_format;

        public AudioSettings(MainJSON data)
        {
            Load(data);
        }

        public AudioSettings(AudioConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            this.main_volume = data.volumeGlobal;
            this.music_volume = data.volumeMusic;
            this.sfx_volume = data.volumeSFX;
            this.voice_volume = data.volumeVoice;
            this.dynamic_range = data.audioDynamicRange;
            this.output_format = data.audioOutput;
        }

        public MainJSON Apply(MainJSON data)
        {
            data.volumeGlobal = this.main_volume;
            data.volumeMusic = this.music_volume;
            data.volumeVoice = this.voice_volume;
            data.volumeSFX = this.sfx_volume;
            data.audioOutput = this.output_format;
            data.audioDynamicRange = this.dynamic_range;
            return data;
        }

        public AudioConfig ToConfig()
        {
            AudioConfig config = new AudioConfig
            {
                Main = this.main_volume,
                Music = this.music_volume,
                SFX = this.sfx_volume,
                Voice = this.voice_volume,
                DynamicRange = this.dynamic_range,
                OutputFormat = this.output_format
            };
            return config;
        }

        public void FromConfig(AudioConfig config)
        {
            if (config.Main != null)
            {
                this.main_volume = (int)config.Main;
            }
            if (config.Music != null)
            {
                this.music_volume = (int)config.Music;
            }
            if (config.SFX != null)
            {
                this.sfx_volume = (int)config.SFX;
            }
            if (config.Voice != null)
            {
                this.voice_volume = (int)config.Voice;
            }
            if (config.DynamicRange != null)
            {
                this.dynamic_range = (int)config.DynamicRange;
            }
            if (config.OutputFormat != null)
            {
                this.output_format = (int)config.OutputFormat;
            }
        }
    }

    internal class Keybindings
    {
        public Controllers controllers;
        public List<string> controller_ids;

        public Keybindings(MainJSON data)
        {
            Load(data);
        }

        public void Load(MainJSON data)
        {
            this.controller_ids = data._overrideControllerMapKeyList;
            this.controllers = data._overrideControllerMapValueList;
        }

        public MainJSON Apply(MainJSON data)
        {
            data._overrideControllerMapValueList = this.controllers;
            data._overrideControllerMapKeyList = this.controller_ids;
            return data;
        }
    }

    internal class GraphicsSettings
    {
        public int current_preset;
        public List<GraphicsSetting> settings;
        public double gamma;

        public GraphicsSettings(MainJSON data)
        {
            Load(data);
        }

        public GraphicsSettings(GraphicsConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            current_preset = data.graphicsData.currentVolatielGrade;
            settings = (List<GraphicsSetting>)data.graphicsData.customVolatileGrades;
            gamma = data.gammaValue;
        }

        public MainJSON Apply(MainJSON data)
        {
            data.graphicsData.currentVolatielGrade = current_preset;
            data.graphicsData.customVolatileGrades = settings;
            data.gammaValue = gamma;
            globalPerfData perfdata = data.globalPerfData;
            perfdata.portedVersion = data.graphicsData.volatileVersion;
            perfdata.saveItems = new List<perfItem>();
            foreach (GraphicsSetting setting in settings)
            {
                perfItem perfitem = new perfItem
                {
                    entryType = setting.key,
                    index = setting.value - 1,
                    itemVersion = data.graphicsData.volatileVersion
                };
                perfdata.saveItems.Add(perfitem);
            }
            return data;
        }

        public void Change(SettingsType s_type, int value)
        {
            foreach (GraphicsSetting setting in settings)
            {
                if (setting.key == (int)s_type)
                {
                    setting.value = value;
                }
            }
        }

        public int Get(SettingsType s_type)
        {
            foreach (GraphicsSetting setting in settings)
            {
                if (setting.key == (int)s_type)
                {
                    return setting.value;
                }
            }
            return 0; // Should never be called
        }

        public static bool Check(int s_int, int val)
        {
            SettingsType s_type = (SettingsType)s_int;
            // Is there a better way of doing this?
            Type val_enum = null;
            switch (s_type)
            {
                case SettingsType.VSync:
                    val_enum = typeof(VSync);
                    break;
                case SettingsType.RenderResolution:
                    val_enum = typeof(RenderResolution);
                    break;
                case SettingsType.ShadowQuality:
                    val_enum = typeof(ShadowQuality);
                    break;
                case SettingsType.VisualEffects:
                    val_enum = typeof(VisualEffects);
                    break;
                case SettingsType.SFXQuality:
                    val_enum = typeof(SFXQuality);
                    break;
                case SettingsType.EnvironmentDetail:
                    val_enum = typeof(EnvironmentDetail);
                    break;
                case SettingsType.FPS:
                    val_enum = typeof(FPS);
                    break;
                case SettingsType.Antialiasing:
                    val_enum = typeof(Antialiasing);
                    break;
                case SettingsType.VolumetricFog:
                    val_enum = typeof(VolumetricFog);
                    break;
                case SettingsType.Reflections:
                    val_enum = typeof(Reflections);
                    break;
                case SettingsType.MotionBlur:
                    val_enum = typeof(MotionBlur);
                    break;
                case SettingsType.Bloom:
                    val_enum = typeof(Bloom);
                    break;
                case SettingsType.CrowdDensity:
                    val_enum = typeof(CrowdDensity);
                    break;
                case SettingsType.SubsurfaceScattering:
                    val_enum = typeof(SubsurfaceScattering);
                    break;
                case SettingsType.TeammateEffects:
                    val_enum = typeof(TeammateEffects);
                    break;
                case SettingsType.AnisotropicFiltering:
                    val_enum = typeof(AnisotropicFiltering);
                    break;
                case SettingsType.DynamicCharacterResolution:
                    val_enum = typeof(DynamicCharacterResolution);
                    break;
            }
            if (val_enum == null) return false;
            return Enum.GetValues(val_enum).Cast<int>().ToArray().Contains(val) && val > 0;
        }

        public GraphicsConfig ToConfig()
        {
            GraphicsConfig config = new GraphicsConfig
            {
                preset = current_preset,
                custom = new Dictionary<int, int>(),
                gamma = gamma
            };
            foreach (GraphicsSetting setting in settings)
            {
                config.custom[setting.key] = setting.value;
            }
            return config;
        }

        public void FromConfig(GraphicsConfig config)
        {
            if (config.preset != null)
            {
                this.current_preset = (int)config.preset;
            }
            if (config.custom.Keys.Count > 0)
            {
                this.settings = new List<GraphicsSetting>();
                foreach (KeyValuePair<int, int> pair in config.custom)
                {
                    GraphicsSetting setting = new GraphicsSetting
                    {
                        key = pair.Key,
                        value = pair.Value
                    };
                    this.settings.Add(setting);
                }
            }
            if (config.gamma != null)
            {
                this.gamma = (double)config.gamma;
            }
        }
    }

    internal class LanguageSettings
    {
        public TextLanguage text_lang;
        public VoiceLanguage voice_lang;

        public LanguageSettings(MainJSON data)
        {
            Load(data);
        }

        public LanguageSettings(LanguageConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            this.text_lang = (TextLanguage)data.deviceLanguageType;
            this.voice_lang = (VoiceLanguage)data.deviceVoiceLanguageType;
        }

        public MainJSON Apply(MainJSON data)
        {
            data.deviceLanguageType = (int)text_lang;
            data.deviceVoiceLanguageType = (int)voice_lang;
            return data;
        }

        public void FromConfig(LanguageConfig config)
        {
            if (config.Text != null)
            {
                this.text_lang = (TextLanguage)config.Text;
            }
            if (config.Voice != null)
            {
                this.voice_lang = (VoiceLanguage)config.Voice;
            }
        }

        public LanguageConfig ToConfig()
        {
            LanguageConfig config = new LanguageConfig
            {
                Text = (int)text_lang,
                Voice = (int)voice_lang
            };
            return config;
        }
    }

    internal class ControlsMiscSettings
    {
        public bool automatic_view_height;
        public bool smart_combat_camera;
        public double default_camera_height;
        public int automatic_boat_camera_angle_correction;

        public ControlsMiscSettings(MainJSON data)
        {
            Load(data);
        }

        public ControlsMiscSettings(ControlsMiscConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            this.automatic_view_height = data.enableCameraSlope;
            this.smart_combat_camera = data.enableCameraCombatLock;
            this.default_camera_height = Math.Round(data.inputData.cameraDistanceRatio * 1.5 + 4.5, 1);
            if (data.inputData.skiffCameraAutoFix && data.inputData.skiffCameraAutoFixInCombat)
            {
                this.automatic_boat_camera_angle_correction = 1;
            }
            else if (data.inputData.skiffCameraAutoFix)
            {
                this.automatic_boat_camera_angle_correction = 2;
            }
            else
            {
                this.automatic_boat_camera_angle_correction = 0;
            }
        }

        public MainJSON Apply(MainJSON data)
        {
            data.enableCameraSlope = this.automatic_view_height;
            data.enableCameraCombatLock = this.smart_combat_camera;
            data.inputData.cameraDistanceRatio = (this.default_camera_height - 4.5) / 1.5;
            switch (this.automatic_boat_camera_angle_correction)
            {
                case 0:
                    data.inputData.skiffCameraAutoFix = false;
                    data.inputData.skiffCameraAutoFixInCombat = false;
                    break;
                case 1:
                    data.inputData.skiffCameraAutoFix = true;
                    data.inputData.skiffCameraAutoFixInCombat = true;
                    break;
                case 2:
                    data.inputData.skiffCameraAutoFix = true;
                    data.inputData.skiffCameraAutoFixInCombat = false;
                    break;
            }
            return data;
        }

        public void FromConfig(ControlsMiscConfig config)
        {
            if (config.AutomaticViewHeight != null) this.automatic_view_height = (bool)config.AutomaticViewHeight;
            if (config.SmartCombatCamera != null) this.smart_combat_camera = (bool)config.SmartCombatCamera;
            if (config.DefaultCameraHeight != null) this.default_camera_height = (double)config.DefaultCameraHeight;
            if (config.AutomaticBoatCameraAngleCorrection != null) this.automatic_boat_camera_angle_correction = (int)config.AutomaticBoatCameraAngleCorrection;
        }

        public ControlsMiscConfig ToConfig()
        {
            ControlsMiscConfig config = new ControlsMiscConfig
            {
                AutomaticViewHeight = this.automatic_view_height,
                SmartCombatCamera = this.smart_combat_camera,
                DefaultCameraHeight = this.default_camera_height,
                AutomaticBoatCameraAngleCorrection = this.automatic_boat_camera_angle_correction,
            };
            return config;
        }
    }

    internal class ControlsKeyboardSettings
    {
        public int vertical_sensitivity;
        public int horizontal_sensitivity;
        public int vertical_sensitivity_aiming;
        public int horizontal_sensitivity_aiming;

        public ControlsKeyboardSettings(MainJSON data)
        {
            Load(data);
        }

        public ControlsKeyboardSettings(ControlsKeyboardConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            this.vertical_sensitivity = data.inputData.mouseSenseIndexY;
            this.horizontal_sensitivity = data.inputData.mouseSenseIndex;
            this.vertical_sensitivity_aiming = data.inputData.mouseFocusSenseIndexY;
            this.horizontal_sensitivity_aiming = data.inputData.mouseFocusSenseIndex;
        }

        public MainJSON Apply(MainJSON data)
        {
            data.inputData.mouseSenseIndexY = this.vertical_sensitivity;
            data.inputData.mouseSenseIndex = this.horizontal_sensitivity;
            data.inputData.mouseFocusSenseIndexY = this.vertical_sensitivity_aiming;
            data.inputData.mouseFocusSenseIndex = this.horizontal_sensitivity_aiming;
            return data;
        }

        public void FromConfig(ControlsKeyboardConfig config)
        {
            if (config.VerticalSensitivity != null) this.vertical_sensitivity = (int)config.VerticalSensitivity;
            if (config.HorizontalSensitivity != null) this.horizontal_sensitivity = (int)config.HorizontalSensitivity;
            if (config.VerticalSensitivityAiming != null) this.vertical_sensitivity_aiming = (int)config.VerticalSensitivityAiming;
            if (config.HorizontalSensitivityAiming != null) this.horizontal_sensitivity_aiming = (int)config.HorizontalSensitivityAiming;
        }

        public ControlsKeyboardConfig ToConfig()
        {
            ControlsKeyboardConfig config = new ControlsKeyboardConfig
            {
                VerticalSensitivity = this.vertical_sensitivity,
                HorizontalSensitivity = this.horizontal_sensitivity,
                VerticalSensitivityAiming = this.vertical_sensitivity_aiming,
                HorizontalSensitivityAiming = this.horizontal_sensitivity_aiming,
            };
            return config;
        }
    }

    internal class ControlsGamepadSettings
    {
        public int vertical_sensitivity;
        public int horizontal_sensitivity;
        public int vertical_sensitivity_aiming;
        public int horizontal_sensitivity_aiming;
        public bool invert_horizontal_axis;
        public bool invert_vertical_axis;
        public bool invert_horizontal_axis_aiming;
        public bool invert_vertical_axis_aiming;
        public bool gyro_aiming;
        public int gyro_axis;
        public int gyro_horizontal_sensitivity;
        public int gyro_vertical_sensitivity;
        public bool disable_right_stick_vertical_axis;
        public bool gyro_invert_horizontal_axis;
        public bool gyro_invert_vertical_axis;
        public int graded_vibration;
        public int vibration_power;

        public ControlsGamepadSettings(MainJSON data)
        {
            Load(data);
        }

        public ControlsGamepadSettings(ControlsGamepadConfig config)
        {
            FromConfig(config);
        }

        public void Load(MainJSON data)
        {
            this.vertical_sensitivity = data.inputData.joypadSenseIndexY;
            this.horizontal_sensitivity = data.inputData.joypadSenseIndex;
            this.vertical_sensitivity_aiming = data.inputData.joypadFocusSenseIndexY;
            this.horizontal_sensitivity_aiming = data.inputData.joypadFocusSenseIndex;
            this.invert_horizontal_axis = data.inputData.joypadInvertCameraX;
            this.invert_vertical_axis = data.inputData.joypadInvertCameraY;
            this.invert_horizontal_axis_aiming = data.inputData.joypadInvertFocusCameraX;
            this.invert_vertical_axis_aiming = data.inputData.joypadInvertFocusCameraY;
            this.gyro_aiming = data.gyroAiming;
            this.gyro_axis = data.gyroRotateType;
            this.gyro_horizontal_sensitivity = data.gyroHorMoveSpeedIndex;
            this.gyro_vertical_sensitivity = data.gyroVerMoveSpeedIndex;
            this.disable_right_stick_vertical_axis = data.gyroExcludeRightStickVerInput;
            this.gyro_invert_horizontal_axis = data.gyroHorReverse;
            this.gyro_invert_vertical_axis = data.gyroVerReverse;
            this.graded_vibration = data.vibrationLevel;
            this.vibration_power = data.vibrationIntensity;
        }

        public MainJSON Apply(MainJSON data)
        {
            data.inputData.joypadSenseIndexY = this.vertical_sensitivity;
            data.inputData.joypadSenseIndex = this.horizontal_sensitivity;
            data.inputData.joypadFocusSenseIndexY = this.vertical_sensitivity_aiming;
            data.inputData.joypadFocusSenseIndex = this.horizontal_sensitivity_aiming;
            data.inputData.joypadInvertCameraX = this.invert_vertical_axis;
            data.inputData.joypadInvertCameraY = this.invert_horizontal_axis;
            data.inputData.joypadInvertFocusCameraX = this.invert_horizontal_axis_aiming;
            data.inputData.joypadInvertFocusCameraY = this.invert_vertical_axis_aiming;
            data.gyroAiming = this.gyro_aiming;
            data.gyroRotateType = this.gyro_axis;
            data.gyroHorMoveSpeedIndex = this.gyro_horizontal_sensitivity;
            data.gyroVerMoveSpeedIndex = this.gyro_vertical_sensitivity;
            data.gyroExcludeRightStickVerInput = this.disable_right_stick_vertical_axis;
            data.gyroHorReverse = this.gyro_invert_horizontal_axis;
            data.gyroVerReverse = this.gyro_invert_vertical_axis;
            data.vibrationLevel = this.graded_vibration;
            data.vibrationIntensity = this.vibration_power;
            return data;
        }

        public void FromConfig(ControlsGamepadConfig config)
        {
            if (config.VerticalSensitivity != null) this.vertical_sensitivity = (int)config.VerticalSensitivity;
            if (config.HorizontalSensitivity != null) this.horizontal_sensitivity = (int)config.HorizontalSensitivity;
            if (config.VerticalSensitivityAiming != null) this.vertical_sensitivity_aiming = (int)config.VerticalSensitivityAiming;
            if (config.HorizontalSensitivityAiming != null) this.horizontal_sensitivity_aiming = (int)config.HorizontalSensitivityAiming;
            if (config.InvertHorizontalAxis != null) this.invert_horizontal_axis = (bool)config.InvertHorizontalAxis;
            if (config.InvertVerticalAxis != null) this.invert_vertical_axis = (bool)config.InvertVerticalAxis;
            if (config.InvertHorizontalAxisAiming != null) this.invert_horizontal_axis_aiming = (bool)config.InvertHorizontalAxisAiming;
            if (config.InvertVerticalAxisAiming != null) this.invert_vertical_axis_aiming = (bool)config.InvertVerticalAxisAiming;
            if (config.GyroAiming != null) this.gyro_aiming = (bool)config.GyroAiming;
            if (config.GyroAxis != null) this.gyro_axis = (int)config.GyroAxis;
            if (config.GyroHorizontalSensitivity != null) this.gyro_horizontal_sensitivity = (int)config.GyroHorizontalSensitivity;
            if (config.GyroVerticalSensitivity != null) this.gyro_vertical_sensitivity = (int)config.GyroVerticalSensitivity;
            if (config.DisableRightStickVerticalAxis != null) this.disable_right_stick_vertical_axis = (bool)config.DisableRightStickVerticalAxis;
            if (config.GyroInvertHorizontalAxis != null) this.gyro_invert_horizontal_axis = (bool)config.GyroInvertHorizontalAxis;
            if (config.GyroInvertVerticalAxis != null) this.gyro_invert_vertical_axis = (bool)config.GyroInvertVerticalAxis;
            if (config.GradedVibration != null) this.graded_vibration = (int)config.GradedVibration;
            if (config.VibrationPower != null) this.vibration_power = (int)config.VibrationPower;
        }

        public ControlsGamepadConfig ToConfig()
        {
            ControlsGamepadConfig config = new ControlsGamepadConfig
            {
                VerticalSensitivity = this.vertical_sensitivity,
                HorizontalSensitivity = this.horizontal_sensitivity,
                VerticalSensitivityAiming = this.vertical_sensitivity_aiming,
                HorizontalSensitivityAiming = this.horizontal_sensitivity_aiming,
                InvertHorizontalAxis = this.invert_horizontal_axis,
                InvertVerticalAxis = this.invert_vertical_axis,
                InvertHorizontalAxisAiming = this.invert_horizontal_axis_aiming,
                InvertVerticalAxisAiming = this.invert_vertical_axis_aiming,
                GyroAiming = this.gyro_aiming,
                GyroAxis = this.gyro_axis,
                GyroHorizontalSensitivity = this.gyro_horizontal_sensitivity,
                GyroVerticalSensitivity = this.gyro_vertical_sensitivity,
                DisableRightStickVerticalAxis = this.disable_right_stick_vertical_axis,
                GyroInvertHorizontalAxis = this.gyro_invert_horizontal_axis,
                GyroInvertVerticalAxis = this.gyro_invert_vertical_axis,
                GradedVibration = this.graded_vibration,
                VibrationPower = this.vibration_power,
            };
            return config;
        }
    }

    internal class RegistryContainer
    {
        static string SearchName(RegistryKey key)
        {
            string value_name = "";
            string[] names = key.GetValueNames();
            foreach (string name in names)
            {
                if (name.Contains("GENERAL_DATA"))
                {
                    value_name = name;
                    break;
                }
            }
            if (value_name == "")
            {
                throw new Exception();
            }
            return value_name;
        }
        public static string Load()
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey Gensh = HKCU.OpenSubKey("SOFTWARE\\miHoYo\\Genshin Impact", true);
            string value_name = SearchName(Gensh);
            string raw_settings = Encoding.UTF8.GetString((byte[])Gensh.GetValue(value_name));
            return raw_settings;
        }

        public static void Save(string data)
        {
            RegistryKey HKCU = Registry.CurrentUser;
            RegistryKey Gensh = HKCU.OpenSubKey("SOFTWARE\\miHoYo\\Genshin Impact", true);
            string value_name = SearchName(Gensh);
            byte[] bytes_raw = Encoding.UTF8.GetBytes(data);
            byte[] bytes = new byte[bytes_raw.Length + 1];
            bytes_raw.CopyTo(bytes, 0);
            bytes[bytes.Length - 1] = (byte)'\x00';
            Gensh.SetValue(value_name, bytes);
        }
    }

    internal class ResolutionSettings
    {
        RegistryKey Gensh;
        string height_name, width_name, fullscreen_name;
        int height, width, fullscreen;
        public ResolutionSettings()
        {
            RegistryKey HKCU = Registry.CurrentUser;
            Gensh = HKCU.OpenSubKey("SOFTWARE\\miHoYo\\Genshin Impact", true);
            string[] names = Gensh.GetValueNames();
            foreach (string name in names)
            {
                if (name.Contains("Width"))
                {
                    width_name = name;
                }
                if (name.Contains("Height"))
                {
                    height_name = name;
                }
                if (name.Contains("Fullscreen"))
                {
                    fullscreen_name = name;
                }
            }
            Read();
        }

        public int Get(ResolutionData setting_num)
        {
            switch (setting_num)
            {
                case ResolutionData.Width:
                    return width;

                case ResolutionData.Height:
                    return height;

                case ResolutionData.Fullscreen:
                    return fullscreen;

                default:
                    return 0;
            }
        }

        public void Change(ResolutionData setting_num, int value)
        {
            switch (setting_num)
            {
                case ResolutionData.Width:
                    width = value;
                    break;

                case ResolutionData.Height:
                    height = value;
                    break;

                case ResolutionData.Fullscreen:
                    fullscreen = value;
                    break;
            }
        }

        public void Apply()
        {
            Write();
        }

        private void Read()
        {
            height = Convert.ToInt32(Gensh.GetValue(height_name));
            width = Convert.ToInt32(Gensh.GetValue(width_name));
            fullscreen = Convert.ToInt32(Gensh.GetValue(fullscreen_name));
        }

        private void Write()
        {
            Gensh.SetValue(height_name, height);
            Gensh.SetValue(width_name, width);
            Gensh.SetValue(fullscreen_name, fullscreen);
        }

    }
}

