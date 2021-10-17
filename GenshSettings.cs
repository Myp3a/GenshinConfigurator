using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using static GenshinConfigurator.JSONSchema;

namespace GenshinConfigurator
{
    internal class GenshSettings
    {
        RegistryKey Gensh;
        string value_name;
        MainJSON settings_json;
        GraphicsData graphics_data;

        public GenshSettings()
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
            string raw_settings = JsonConvert.SerializeObject(settings_json);
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

}
}

