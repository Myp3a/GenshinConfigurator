using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinConfigurator
{
    internal class Enums
    {
        public enum VoiceLanguage
        {
            None,
            Chinese,
            English,
            Japanese,
            Korean
        }

        public enum TextLanguage
        {
            SimplifiedChinese,
            TraditionalChinese,
            English,
            Korean,
            Japanese,
            Spanish,
            French,
            Russian,
            Thai,
            Vietnamese,
            German,
            Indonesian,
            Portugese
        }

        public enum ResolutionData
        {
            Width,
            Height,
            Fullscreen
        }
        public enum SettingsType
        {
            OverallQuality,
            VSync,
            RenderResolution,
            ShadowQuality,
            VisualEffects,
            SFXQuality,
            EnvironmentDetail,
            FPS,
            Antialiasing,
            VolumetricFog,
            Reflections,
            MotionBlur,
            Bloom,
            CrowdDensity,
            Empty,
            SubsurfaceScattering,
            TeammateEffects,
            AnisotropicFiltering
        }

        public enum OverallQuality
        {
            Lowest    = 1,
            Low       = 2,
            Medium    = 3,
            High      = 4,
            Custom    = -1
        }

        public enum VSync
        {
            None,
            Off,
            On
        }

        public enum RenderResolution
        {
            None,
            x0_6,
            x0_8,
            x1_0,
            x1_1,
            x1_2,
            x1_3,
            x1_4,
            x1_5
        }

        public enum ShadowQuality
        {
            None,
            Lowest,
            Low,
            Medium,
            High
        }

        public enum VisualEffects
        {
            None,
            Lowest,
            Low,
            Medium,
            High
        }

        public enum SFXQuality
        {
            None,
            Lowest,
            Low,
            Medium,
            High
        }
        
        public enum EnvironmentDetail
        {
            None,
            Lowest,
            Low,
            Medium,
            High,
            Highest
        }

        public enum FPS
        {
            None,
            f30,
            f60
        }

        public enum Antialiasing 
        {
            None,
            Off,
            TAA,
            SMAA
        }

        public enum VolumetricFog
        {
            None,
            Off,
            On
        }

        public enum Reflections
        {
            None,
            Off,
            On
        }

        public enum MotionBlur
        {
            None,
            Off,
            Low,
            High,
            Extreme
        }

        public enum Bloom
        {
            None,
            Off,
            On
        }

        public enum CrowdDensity
        {
            None,
            Low,
            High
        }

        public enum SubsurfaceScattering
        {
            None,
            Off,
            Medium,
            High
        }

        public enum TeammateEffects
        {
            None,
            On,
            Partially,
            Off
        }

        public enum AnisotropicFiltering
        {
            None,
            x1,
            x2,
            x4,
            x8,
            x16
        }
    }
}
