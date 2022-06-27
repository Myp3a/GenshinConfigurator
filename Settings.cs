using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        public ControlsSettings Controls;
        MainJSON data;
        public bool controlsLoaded, graphicsLoaded;
        public SettingsContainer()
        {
            
        }

        public void Populate()
        {
            FromReg();
            this.controlsLoaded = data.__controlsLoaded;
            this.graphicsLoaded = data.__graphicsLoaded;
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
            this.Controls = new ControlsSettings(data);
            this.Resolution = new ResolutionSettings();
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
            this.data = Controls.Apply(data);
            this.data = Graphics.Apply(data);
            this.data = Language.Apply(data);
            Resolution.Apply();
        }

        public void Apply(string type)
        {
            switch (type)
            {
                case "audio":
                    this.data = Audio.Apply(data);
                    break;
                case "controls":
                    this.data = Controls.Apply(data);
                    break;
                case "graphics":
                    this.data = Graphics.Apply(data);
                    break;
                case "language":
                    this.data = Language.Apply(data);
                    break;
                case "resolution":
                    Resolution.Apply();
                    break;
            }
        }

        public void Save(string path)
        {
            ConfigFile file = new ConfigFile
            {
                Resolution = new ResolutionConfig { Fullscreen = Convert.ToBoolean(Resolution.Get((int)ResolutionData.Fullscreen)), Width = Resolution.Get((int)ResolutionData.Width), Height = Resolution.Get((int)ResolutionData.Height) },
                Graphics = Graphics.ToConfig(),
                Audio = Audio.ToConfig(),
                Language = Language.ToConfig()
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
                Apply("graphics");
            }
            if (config.Audio != null)
            {
                this.Audio.FromConfig(config.Audio);
                Apply("audio");
            }
            if (config.Language != null)
            {
                this.Language.FromConfig(config.Language);
                Apply("language");
            }
            if (config.Resolution != null)
            {
                Resolution.Change((int)ResolutionData.Width, config.Resolution.Width);
                Resolution.Change((int)ResolutionData.Height, config.Resolution.Height);
                Resolution.Change((int)ResolutionData.Fullscreen, Convert.ToInt32(config.Resolution.Fullscreen));
                Apply("resolution");
            }
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

    internal class ControlsSettings
    {
        public Controllers controllers;
        public List<string> controller_ids;

        public ControlsSettings(MainJSON data)
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

        public int Get(int setting_num)
        {
            switch (setting_num)
            {
                case (int)ResolutionData.Width:
                    return width;

                case (int)ResolutionData.Height:
                    return height;

                case (int)ResolutionData.Fullscreen:
                    return fullscreen;

                default:
                    return 0;
            }
        }

        public void Change(int setting_num, int value)
        {
            switch (setting_num)
            {
                case (int)ResolutionData.Width:
                    width = value;
                    break;

                case (int)ResolutionData.Height:
                    height = value;
                    break;

                case (int)ResolutionData.Fullscreen:
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

