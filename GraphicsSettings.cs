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
        public SettingsContainer()
        {
            Graphics = new GraphicsSettings();
            Resolution = new ResolutionSettings();
        }

        public void Save(string path)
        {
            ConfigFile file = new ConfigFile();
            file.Graphics = JsonConvert.DeserializeObject<GraphicsData>(JsonConvert.SerializeObject(Graphics.GetObject()));
            file.Resolution = new ResolutionConfig { Fullscreen = Convert.ToBoolean(Resolution.Get((int)ResolutionData.Fullscreen)), Width = Resolution.Get((int)ResolutionData.Width), Height = Resolution.Get((int)ResolutionData.Height) };
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
            foreach (GraphicsSetting setting in config.Graphics.customVolatileGrades)
            {
                Graphics.Change(setting.key, setting.value);
            }
            Graphics.currentPreset = config.Graphics.currentVolatielGrade;
            Resolution.Change((int)ResolutionData.Width, config.Resolution.Width);
            Resolution.Change((int)ResolutionData.Height, config.Resolution.Height);
            Resolution.Change((int)ResolutionData.Fullscreen, Convert.ToInt32(config.Resolution.Fullscreen));
        }
    }

    internal class GraphicsSettings
    {
        RegistryKey Gensh;
        string value_name;
        MainJSON settings_json;
        GraphicsData graphics_data;
        public int currentPreset
        {
            get
            {
                if (graphics_data.currentVolatielGrade == -1) return 4;
                else return graphics_data.currentVolatielGrade - 1;
            }
            set
            {
                if (value == 4) graphics_data.currentVolatielGrade = -1;
                else if (value == -1) graphics_data.currentVolatielGrade = value; 
                else graphics_data.currentVolatielGrade = value + 1;
                UpdateSettings();
            }
        }
        public GraphicsSettings()
        {
            RegistryKey HKCU = Registry.CurrentUser;
            Gensh = HKCU.OpenSubKey("SOFTWARE\\miHoYo\\Genshin Impact",true);
            string[] names = Gensh.GetValueNames();
            foreach (string name in names)
            {
                if (name.Contains("GENERAL_DATA"))
                {
                    value_name = name;
                    break;
                }
            }
            Read();
        }

        public void Change(int setting_num, int value_num)
        {
            foreach (GraphicsSetting setting in graphics_data.customVolatileGrades)
            {
                if (setting.key == setting_num)
                {
                    setting.value = value_num;
                    break;
                }
            }
            UpdateSettings();
        }

        public int Get(int setting_num)
        {
                foreach (GraphicsSetting setting in graphics_data.customVolatileGrades)
            {
                if (setting.key == setting_num)
                {
                    return setting.value;
                }
            }
            return 0;
        }

        public GraphicsData GetObject()
        {
            return graphics_data;
        }
        public void Save()
        {
            Write();
        }
        private void Read()
        {
            string raw_settings = Encoding.UTF8.GetString((byte[])Gensh.GetValue(value_name));
            settings_json = JsonConvert.DeserializeObject<MainJSON>(raw_settings);
            graphics_data = JsonConvert.DeserializeObject<GraphicsData>(settings_json.graphicsData);
        }

        private void Write()
        {
            string raw_settings = GetJSONFull();
            byte[] bytes_raw = Encoding.UTF8.GetBytes(raw_settings);
            byte[] bytes = new byte[bytes_raw.Length + 1];
            bytes_raw.CopyTo(bytes, 0);
            bytes[bytes.Length - 1] = (byte)'\x00';
            Gensh.SetValue(value_name, bytes);
        }

        private void UpdateSettings()
        {
            settings_json.graphicsData = JsonConvert.SerializeObject(graphics_data);
        }

        public string GetJSONFull()
        {
            return JsonConvert.SerializeObject(settings_json);
        }

        public string GetJSONGraphics()
        {
            return JsonConvert.SerializeObject(graphics_data);
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
            Save();
        }

        public void Save()
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

