﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using static GenshinConfigurator.Enums;

namespace GenshinConfigurator
{
    [Verb("get", HelpText = "Returns current configuration")]
    class GetOptions : Options
    {
        [Option('o', "output", Default = "human", HelpText = "Output format. Vaild values are: human, json, raw")]
        public string Output { get; set; }
    }

    [Verb("set", HelpText = "Changes current configuration")]
    class SetOptions : Options
    {
        [Option('c', "config", SetName = "config", HelpText = "Path to config file to load")]
        public string Config { get; set; }

        [Option('e', "exec", HelpText = "Executable to run after applying settings")]
        public string Executable { get; set; }

        [Option('a', "execargs", HelpText = "Arguments to the executable")]
        public string Args { get; set; }

        [Option('r', "resolution", SetName = "set", HelpText = "Preferred resoluion. Format: {Width}x{Height}x{Fullscreen (0|1)}")]
        public string Resolution { get; set; }

        [Option('s', "set", SetName = "set", HelpText = "Changes graphics setting. Format: {SettingID}:{Value}")]
        public IEnumerable<string> SetVal {  get; set; }
    }

    class Options
    {
        [Option('v', HelpText = "Enable verbose output", FlagCounter = true)]
        public int Verbose { get; set; }
    }

    internal class Cli
    {
        SettingsContainer Settings;
        ResolutionSettings Resolution;
        public Cli()
        {
            Settings = new SettingsContainer();
            Settings.Populate();
            Resolution = Settings.Resolution;
        }

        public void Run(string[] args)
        {
            var parser = new Parser(config => { config.AllowMultiInstance = true; config.HelpWriter = Console.Out; config.GetoptMode = true; });
            var result = parser.ParseArguments<Options, GetOptions, SetOptions>(args)
                .WithParsed<GetOptions>(o =>
                {
                    int pres;
                    switch (o.Output)
                    {
                        case "human":
                            string outtext = "";
                            const int offset = 25;
                            pres = Settings.Graphics.current_preset;
                            outtext += "Overall Quality:" + new string(' ', offset-15) + Enum.GetName(typeof(Enums.OverallQuality), pres) + '\n';
                            foreach (JSONSchema.GraphicsSetting setting in Settings.Graphics.settings)
                            {
                                string name;
                                string val;
                                switch (setting.key)
                                {
                                    case (int)Enums.SettingsType.VSync:
                                        name = "V-Sync";
                                        val = Enum.GetName(typeof(Enums.VSync), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.RenderResolution:
                                        name = "Render Resolution";
                                        val = Enum.GetName(typeof(Enums.RenderResolution), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.ShadowQuality:
                                        name = "Shadow Quality";
                                        val = Enum.GetName(typeof(Enums.ShadowQuality), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.VisualEffects:
                                        name = "Visual Effects";
                                        val = Enum.GetName(typeof(Enums.VisualEffects), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.SFXQuality:
                                        name = "SFX Quality";
                                        val = Enum.GetName(typeof(Enums.SFXQuality), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.EnvironmentDetail:
                                        name = "Environment Detail";
                                        val = Enum.GetName(typeof(Enums.EnvironmentDetail), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.FPS:
                                        name = "FPS Limit";
                                        val = Enum.GetName(typeof(Enums.FPS), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.Antialiasing:
                                        name = "Antialiasing";
                                        val = Enum.GetName(typeof(Enums.Antialiasing), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.VolumetricFog:
                                        name = "Volumetric Fog";
                                        val = Enum.GetName(typeof(Enums.VolumetricFog), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.Reflections:
                                        name = "Reflections";
                                        val = Enum.GetName(typeof(Enums.Reflections), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.MotionBlur:
                                        name = "Motion Blur";
                                        val = Enum.GetName(typeof(Enums.MotionBlur), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.Bloom:
                                        name = "Bloom";
                                        val = Enum.GetName(typeof(Enums.Bloom), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.CrowdDensity:
                                        name = "Crowd Density";
                                        val = Enum.GetName(typeof(Enums.CrowdDensity), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.SubsurfaceScattering:
                                        name = "Subsurface Scattering";
                                        val = Enum.GetName(typeof(Enums.SubsurfaceScattering), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.TeammateEffects:
                                        name = "Teammate Effects";
                                        val = Enum.GetName(typeof(Enums.TeammateEffects), setting.value);
                                        break;
                                    case (int)Enums.SettingsType.AnisotropicFiltering:
                                        name = "Anisotropic Filtering";
                                        val = Enum.GetName(typeof(Enums.AnisotropicFiltering), setting.value);
                                        break;
                                    default:
                                        name = "Unknown Setting (" + setting.key.ToString() + ")";
                                        val = setting.value.ToString();
                                        break;
                                }
                                outtext += $"{name+":",-offset} {val}\n";
                            }
                            Console.WriteLine(outtext);
                            break;

                        case "json":
                            Console.WriteLine(JsonConvert.SerializeObject(Settings.Graphics.ToConfig()));
                            break;

                        case "raw":
                            outtext = "";
                            pres = Settings.Graphics.current_preset;
                            outtext += "0:" + pres.ToString();
                            foreach (JSONSchema.GraphicsSetting setting in Settings.Graphics.settings)
                            {
                                outtext += $" {setting.key}:{setting.value}";
                            }
                            Console.WriteLine(outtext);
                            break;

                        default:
                            Console.WriteLine("Wrong output type. Valid options are: human, json, raw");
                            break;
                    }
                })
                .WithParsed<SetOptions>(o =>
                {
                    if (o.Config != null)
                    {
                        Settings.Load(o.Config);
                        Settings.ToReg();
                    }

                    if (o.Resolution != null)
                    {
                        try
                        {
                            string[] resdata = o.Resolution.ToString().Split('x');
                            int width = Convert.ToInt32(resdata[0]);
                            int height = Convert.ToInt32(resdata[1]);
                            int fullscreen = Convert.ToInt32(resdata[2]);
                            if (((fullscreen != 0) && (fullscreen != 1)) || (width < 1) || (height < 1)) {
                                Console.WriteLine("Wrong resolution format. Not applying.");
                            }
                            Resolution.Change(ResolutionData.Width, width);
                            Resolution.Change(ResolutionData.Height, height);
                            Resolution.Change(ResolutionData.Fullscreen, fullscreen);
                        } 
                        catch
                        {
                            Console.WriteLine("Wrong resolution format. Not applying.");
                        }
                    }

                    if (o.SetVal.ToArray().Length > 0)
                    {
                        try
                        {
                            foreach (string setting_raw in o.SetVal)
                            {
                                string[] setting = setting_raw.Split(':');
                                int key = Convert.ToInt32(setting[0]);
                                int value = Convert.ToInt32(setting[1]);
                                string name;
                                bool valid;
                                switch (key)
                                {
                                    case (int)Enums.SettingsType.OverallQuality:
                                        name = "Overall Quality";
                                        valid = Enum.IsDefined(typeof(Enums.OverallQuality), value);
                                        break;
                                    case (int)Enums.SettingsType.VSync:
                                        name = "V-Sync";
                                        valid = Enum.IsDefined(typeof(Enums.VSync), value);
                                        break;
                                    case (int)Enums.SettingsType.RenderResolution:
                                        name = "Render Resolution";
                                        valid = Enum.IsDefined(typeof(Enums.RenderResolution), value);
                                        break;
                                    case (int)Enums.SettingsType.ShadowQuality:
                                        name = "Shadow Quality";
                                        valid = Enum.IsDefined(typeof(Enums.ShadowQuality), value);
                                        break;
                                    case (int)Enums.SettingsType.VisualEffects:
                                        name = "Visual Effects";
                                        valid = Enum.IsDefined(typeof(Enums.VisualEffects), value);
                                        break;
                                    case (int)Enums.SettingsType.SFXQuality:
                                        name = "SFX Quality";
                                        valid = Enum.IsDefined(typeof(Enums.SFXQuality), value);
                                        break;
                                    case (int)Enums.SettingsType.EnvironmentDetail:
                                        name = "Environment Detail";
                                        valid = Enum.IsDefined(typeof(Enums.EnvironmentDetail), value);
                                        break;
                                    case (int)Enums.SettingsType.FPS:
                                        name = "FPS Limit";
                                        valid = Enum.IsDefined(typeof(Enums.FPS), value);
                                        break;
                                    case (int)Enums.SettingsType.Antialiasing:
                                        name = "Antialiasing";
                                        valid = Enum.IsDefined(typeof(Enums.Antialiasing), value);
                                        break;
                                    case (int)Enums.SettingsType.VolumetricFog:
                                        name = "Volumetric Fog";
                                        valid = Enum.IsDefined(typeof(Enums.VolumetricFog), value);
                                        break;
                                    case (int)Enums.SettingsType.Reflections:
                                        name = "Reflections";
                                        valid = Enum.IsDefined(typeof(Enums.Reflections), value);
                                        break;
                                    case (int)Enums.SettingsType.MotionBlur:
                                        name = "Motion Blur";
                                        valid = Enum.IsDefined(typeof(Enums.MotionBlur), value);
                                        break;
                                    case (int)Enums.SettingsType.Bloom:
                                        name = "Bloom";
                                        valid = Enum.IsDefined(typeof(Enums.Bloom), value);
                                        break;
                                    case (int)Enums.SettingsType.CrowdDensity:
                                        name = "Crowd Density";
                                        valid = Enum.IsDefined(typeof(Enums.CrowdDensity), value);
                                        break;
                                    case (int)Enums.SettingsType.SubsurfaceScattering:
                                        name = "Subsurface Scattering";
                                        valid = Enum.IsDefined(typeof(Enums.SubsurfaceScattering), value);
                                        break;
                                    case (int)Enums.SettingsType.TeammateEffects:
                                        name = "Teammate Effects";
                                        valid = Enum.IsDefined(typeof(Enums.TeammateEffects), value);
                                        break;
                                    case (int)Enums.SettingsType.AnisotropicFiltering:
                                        name = "Anisotropic Filtering";
                                        valid = Enum.IsDefined(typeof(Enums.AnisotropicFiltering), value);
                                        break;
                                    default:
                                        name = "Unknown Setting (" + key.ToString() + ")";
                                        valid = false;
                                        break;
                                }
                                if (!valid)
                                {
                                    Console.WriteLine($"Invalid value {value} for setting {name} ({key})");
                                }
                                else
                                {
                                    Settings.Graphics.Change((SettingsType)key, value);
                                    Settings.Apply();
                                    Settings.ToReg();
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Wrong settings format. Not applying.");
                        }
                    }

                    if (o.Executable != null)
                    {
                        if (o.Args != null)
                        {
                            Process.Start(o.Executable.ToString(), o.Args.ToString());
                        } else
                        {
                            Process.Start(o.Executable.ToString());
                        }
                    }
                });
        }
    }
}
