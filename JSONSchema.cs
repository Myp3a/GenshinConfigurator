using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace GenshinConfigurator
{
    internal class JSONSchema
    {
        public class GraphicsSetting
        {
            public int key { get; set; }
            public int value { get; set; }
        }
        public class GraphicsData
        {
            public int currentVolatielGrade { get; set; }
            public IList<GraphicsSetting> customVolatileGrades { get; set; }
            public string volatileVersion { get; set; }
        }
        public class perfItem
        {
            public int entryType { get; set; }
            public int index { get; set; }
            public string itemVersion { get; set; }
        }
        public class globalPerfData
        {
            public IList<perfItem> saveItems { get; set; }
            public bool truePortedFromGraphicData { get; set; }
            public string portedVersion { get; set; }
            public bool portedFromGraphicData { get; set; }
        }
        public class MainJSON
        {
            [OnSerializing]
            internal void dumpJSON(StreamingContext context)
            {
                if (__graphicsLoaded)
                {
                    _graphicsData = JsonConvert.SerializeObject(graphicsData);
                    _globalPerfData = JsonConvert.SerializeObject(globalPerfData);
                }
                if (__controlsLoaded)
                {
                    __overrideControllerMapValueList = new List<string>();
                    foreach (Controller cntrl in _overrideControllerMapValueList.List())
                    {
                        string xml_string = cntrl.DumpToString(false);
                        __overrideControllerMapValueList.Add(xml_string);
                    }
                }
            }

            [OnDeserialized]
            internal void loadJSON(StreamingContext context)
            {
                try
                {
                    graphicsData = JsonConvert.DeserializeObject<GraphicsData>(_graphicsData);
                    globalPerfData = JsonConvert.DeserializeObject<globalPerfData>(_globalPerfData);
                } catch
                {
                    __graphicsLoaded = false;
                }
                if (__graphicsLoaded)
                {
                    __graphicsInRange = true;
                    foreach (GraphicsSetting setting in graphicsData.customVolatileGrades)
                    {
                        __graphicsInRange &= GraphicsSettings.Check(setting.key, setting.value);
                    }
                }
                Controllers controllers = new Controllers();
                _overrideControllerMapValueList = controllers;
                try
                {
                    foreach (string xml_string in __overrideControllerMapValueList)
                    {
                        XDocument xml_doc = XDocument.Parse(xml_string);
                        XNamespace ns = "http://guavaman.com/rewired";
                        if (xml_doc.Root.Name == (ns + "KeyboardMap"))
                        {
                            KeyboardController kbd = new KeyboardController();
                            kbd.LoadFromString(xml_string);
                            controllers.Add(kbd);
                        }
                        else if (xml_doc.Root.Name == (ns + "MouseMap"))
                        {
                            MouseController mouse = new MouseController();
                            mouse.LoadFromString(xml_string);
                            controllers.Add(mouse);

                        }
                        else if (xml_doc.Root.Name == (ns + "JoystickMap"))
                        {
                            if (xml_doc.Descendants(ns + "hardwareGuid").First().Value == "d74a350e-fe8b-4e9e-bbcd-efff16d34115")
                            {
                                XBoxController xbc = new XBoxController();
                                xbc.LoadFromString(xml_string);
                                controllers.Add(xbc);
                            }
                        }
                    }
                } catch
                {
                    __controlsLoaded = false;
                }
            }
            [JsonIgnore]
            public bool __controlsLoaded { get; set; } = true;
            [JsonIgnore]
            public bool __graphicsLoaded { get; set; } = true;
            [JsonIgnore]
            public bool __graphicsInRange { get; set; } = false;
            public string deviceUUID { get; set; }
            public string userLocalDataVersionId { get; set; }
            public int deviceLanguageType { get; set; }
            public int deviceVoiceLanguageType { get; set; }
            public string selectedServerName { get; set; }
            public int localLevelIndex { get; set; }
            public string deviceID { get; set; }
            public string targetUID { get; set; }
            public string curAccountName { get; set; }
            public string uiSaveData { get; set; }
            public string inputData { get; set; }

            [JsonProperty(PropertyName = "graphicsData")]
            public string _graphicsData { get; set; }

            [JsonIgnore]
            public GraphicsData graphicsData { get; set; }

            [JsonProperty(PropertyName = "globalPerfData")]
            public string _globalPerfData { get; set; }

            [JsonIgnore]
            public globalPerfData globalPerfData { get; set; }
            public int miniMapConfig { get; set; }
            public bool enableCameraSlope { get; set; }
            public bool enableCameraCombatLock { get; set; }
            public bool completionPkg { get; set; }
            public bool completionPlayGoPkg { get; set; }
            public bool onlyPlayWithPSPlayer { get; set; }
            public bool needPlayGoFullPkgPatch { get; set; }
            public bool resinNotification { get; set; }
            public bool exploreNotification { get; set; }
            public int volumeGlobal { get; set; }
            public int volumeSFX { get; set; }
            public int volumeMusic { get; set; }
            public int volumeVoice { get; set; }
            public int audioAPI { get; set; }
            public int audioDynamicRange { get; set; }
            public int audioOutput { get; set; }
            public bool _audioSuccessInit { get; set; }
            public bool enableAudioChangeAndroidMinimumBufferCapacity { get; set; }
            public int audioAndroidMiniumBufferCapacity { get; set; }
            public bool motionBlur { get; set; }
            public bool gyroAiming { get; set; }
            public bool firstHDRSetting { get; set; }
            public double maxLuminosity { get; set; }
            public double uiPaperWhite { get; set; }
            public double scenePaperWhite { get; set; }
            public double gammaValue { get; set; }
            public List<string> _overrideControllerMapKeyList { get; set; }

            [JsonProperty(PropertyName = "_overrideControllerMapValueList")]
            public List<string> __overrideControllerMapValueList { get; set; }

            [JsonIgnore]
            public Controllers _overrideControllerMapValueList { get; set; }
            public bool rewiredDisableKeyboard { get; set; }
            public bool disableRewiredDelayInit { get; set; }
            public int lastSeenPreDownloadTime { get; set; }
            public bool mtrCached { get; set; }
            public bool mtrIsOpen { get; set; }
            public int mtrMaxTTL { get; set; }
            public int mtrTimeOut { get; set; }
            public int mtrTraceCount { get; set; }
            public int mtrAbortTimeOutCount { get; set; }
            public int mtrAutoTraceInterval { get; set; }
            public int mtrTraceCDEachReason { get; set; }
            public List<string> _customDataKeyList { get; set; }
            public List<string> _customDataValueList { get; set; }
        }

        public class ResolutionConfig
        {
            public int Width { get; set; }
            public int Height {  get; set; }
            public bool Fullscreen { get; set; }
        }

        public class AudioConfig
        {
            public int? Main { get; set; }
            public int? Music { get; set; }
            public int? SFX { get; set; }
            public int? Voice { get; set; }
            public int? DynamicRange { get; set; }
            public int? OutputFormat { get; set; }
        }

        public class LanguageConfig
        {
            public int? Text { get; set; }
            public int? Voice { get; set; }
        }

        public class GraphicsConfig
        {
            public int? preset { get; set; }
            public Dictionary<int,int> custom { get; set; }
            public double? gamma { get; set; }
        }

        public class ConfigFile { 
            public ResolutionConfig Resolution { get; set; }
            public GraphicsConfig Graphics { get; set; }
            public AudioConfig Audio { get; set; }
            public LanguageConfig Language { get; set; }
        }
    }
}
