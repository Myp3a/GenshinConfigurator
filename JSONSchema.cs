using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace GenshinConfigurator
{
    internal class JSONSchema
    {
        public class InputData
        {
            public string scriptVersion { get; set; }
            public double mouseSensitivity { get; set; }
            public int joypadSenseIndex { get; set; }
            public int joypadFocusSenseIndex { get; set; }
            public bool joypadInvertCameraX { get; set; }
            public bool joypadInvertCameraY { get; set; }
            public bool joypadInvertFocusCameraX { get; set; }
            public bool joypadInvertFocusCameraY { get; set; }
            public int mouseSenseIndex { get; set; }
            public int mouseFocusSenseIndex { get; set; }
            public int touchpadSenseIndex { get; set; }
            public int touchpadFocusSenseIndex { get; set; }
            public bool enableTouchpadFocusAcceleration { get; set; }
            public double lastJoypadDefaultScale { get; set; }
            public double lastJoypadFocusScale { get; set; }
            public double lastPCDefaultScale { get; set; }
            public double lastPCFocusScale { get; set; }
            public double lastTouchDefaultScale { get; set; }
            public double lastTouchFcousScale { get; set; }
            public bool switchWalkRunByBtn { get; set; }
            public bool skiffCameraAutoFix { get; set; }
            public bool skiffCameraAutoFixInCombat { get; set; }
            public double cameraDistanceRatio { get; set; }
            public bool wwiseVibration { get; set; }
            public bool isYInited { get; set; }
            public int joypadSenseIndexY { get; set; }
            public int joypadFocusSenseIndexY { get; set; }
            public int mouseSenseIndexY { get; set; }
            public int mouseFocusSenseIndexY { get; set; }
            public int touchpadSenseIndexY { get; set; }
            public int touchpadFocusSenseIndexY { get; set; }
            public double lastJoypadDefaultScaleY { get; set; }
            public double lastJoypadFocusScaleY { get; set; }
            public double lastPCDefaultScaleY { get; set; }
            public double lastPCFocusScaleY { get; set; }
            public double lastTouchDefaultScaleY { get; set; }
            public double lastTouchFcousScaleY { get; set; }
        }
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
                    _inputData = JsonConvert.SerializeObject(inputData);
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
                try
                {
                    inputData = JsonConvert.DeserializeObject<InputData>(_inputData);
                } catch
                {
                    __inputLoaded = false;
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
                            // GUID is tied to controller type.
                            // Probably, configuration is same for all controllers of same type.
                            // Controller type is detected by GUID.
                            // Mouse + kbd + unknown controllers doesn't have a GUID.
                            // Name is populated only sometimes.
                            if (xml_doc.Descendants(ns + "hardwareGuid").First().Value == "d74a350e-fe8b-4e9e-bbcd-efff16d34115")
                            {
                                XBoxController xbc = new XBoxController();
                                xbc.LoadFromString(xml_string);
                                controllers.Add(xbc);
                            }
                            else if (xml_doc.Descendants(ns + "hardwareGuid").First().Value == "cd9718bf-a87a-44bc-8716-60a0def28a9f")
                            {
                                DS4Controller ds4c = new DS4Controller();
                                ds4c.LoadFromString(xml_string);
                                controllers.Add(ds4c);
                            }
                            else if (xml_doc.Root.Attribute("hardwareName") != null && xml_doc.Root.Attribute("hardwareName").Value == "Wireless Controller" && xml_doc.Descendants(ns + "hardwareGuid").First().Value == "00000000-0000-0000-0000-000000000000")
                            {
                                DualSenseController dsc = new DualSenseController();
                                dsc.LoadFromString(xml_string);
                                controllers.Add(dsc);
                            }
                            else
                            {
                                UnknownController c = new UnknownController();
                                c.LoadFromString(xml_string);
                                controllers.Add(c);
                            }
                        }
                    }
                } catch
                {
                    __controlsLoaded = false;
                }
            }
            [JsonIgnore]
            public bool __inputLoaded { get; set; } = true;
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
            [JsonProperty(PropertyName = "inputData")]
            public string _inputData { get; set; }
            [JsonIgnore]
            public InputData inputData { get; set; }

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
            public int vibrationLevel { get; set; }
            public int vibrationIntensity { get; set; }
            public bool usingNewVibrationSetting { get; set; }
            public bool motionBlur { get; set; }
            public bool gyroAiming { get; set; }
            public int gyroHorMoveSpeedIndex { get; set; }
            public int gyroVerMoveSpeedIndex { get; set; }
            public bool gyroHorReverse { get; set; }
            public bool gyrVerReverse { get; set; }
            public int gyroRotateType { get; set; }
            public bool gyroExcludeRightStickVerInput { get; set; }
            public bool firstHDRSetting { get; set; }
            public double maxLuminosity { get; set; }
            public double uiPaperWhite { get; set; }
            public double scenePaperWhite { get; set; }
            public double gammaValue { get; set; }
            public bool enableHDR { get; set; }
            public List<string> _overrideControllerMapKeyList { get; set; }

            [JsonProperty(PropertyName = "_overrideControllerMapValueList")]
            public List<string> __overrideControllerMapValueList { get; set; }

            [JsonIgnore]
            public Controllers _overrideControllerMapValueList { get; set; }
            public bool rewiredDisableKeyboard { get; set; }
            public bool rewiredEnableKeyboard { get; set; }
            public bool rewiredEnableEDS { get; set; }
            public bool disableRewiredDelayInit { get; set; }
            public bool disableRewiredInitProtection { get; set; }
            public List<string> conflictKeyBindingElementId { get; set; }
            public List<string> conflictKeyBindingActionId { get; set; }
            public int lastSeenPreDownloadTime { get; set; }
            public string lastSeenSettingResourceTabScriptVersion { get; set; }
            public bool enableEffectAssembleInEditor { get; set; }
            public bool forceDisableQuestResourceManagement { get; set; }
            public bool needReportQuestResourceDeleteStatusFiles { get; set; }
            public bool disableTeamPageBackgroundSwitch { get; set; }
            public bool mtrCached { get; set; }
            public bool mtrIsOpen { get; set; }
            public int mtrMaxTTL { get; set; }
            public int mtrTimeOut { get; set; }
            public int mtrTraceCount { get; set; }
            public int mtrAbortTimeOutCount { get; set; }
            public int mtrAutoTraceInterval { get; set; }
            public int mtrTraceCDEachReason { get; set; }
            public int mtrTimeInterval { get; set; }
            public List<object> mtrBanReasons { get; set; }
            public bool gcgInLevelDefaultShowUIDetail { get; set; }
            public List<string> _customDataKeyList { get; set; }
            public List<string> _customDataValueList { get; set; }
            public List<int> _serializedCodeSwitches { get; set; }
            public bool urlCheckCached { get; set; }
            public bool urlCheckIsOpen { get; set; }
            public bool urlCheckAllIP { get; set; }
            public int urlCheckTimeOut { get; set; }
            public int urlCheckSueecssTraceCount { get; set; }
            public int urlCheckErrorTraceCount { get; set; }
            public int urlCheckAbortTimeOutCount { get; set; }
            public int urlCheckTimeInterval { get; set; }
            public int urlCheckCDEachReason { get; set; }
            public List<object> urlCheckBanReasons { get; set; }
            public bool mtrUseOldWinVersion { get; set; }
            public string greyTestDeviceUniqueId { get; set; }
            public bool muteAudioOnAppMinimized { get; set; }
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

        public class ControlsKeyboardConfig
        {
            public int? VerticalSensitivity { get; set; }
            public int? HorizontalSensitivity { get; set; }
            public int? VerticalSensitivityAiming { get; set; }
            public int? HorizontalSensitivityAiming { get; set; }
            public bool? AutomaticViewHeight { get; set; }
            public bool? SmartCombatCamera { get; set; }
            public double? DefaultCameraHeight { get; set; }
            public int? AutomaticBoatCameraAngleCorrection { get; set; }
        }

        public class ConfigFile { 
            public ResolutionConfig Resolution { get; set; }
            public GraphicsConfig Graphics { get; set; }
            public AudioConfig Audio { get; set; }
            public LanguageConfig Language { get; set; }
            public ControlsKeyboardConfig ControlsKeyboard { get; set; }
        }
    }
}
