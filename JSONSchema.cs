using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinConfigurator
{
    internal class JSONSchema
    {
        public class GraphicsSetting
        {
            public int key {  get; set; }
            public int value {  get; set; }
        }
        public class GraphicsData
        {
            public int currentVolatielGrade { get; set; }
            public IList<GraphicsSetting> customVolatileGrades { get; set; }
            public string volatileVersion {  get; set; }
        }
        public class MainJSON
        {
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
            public string graphicsData { get; set; }
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
            public bool _audioSuccessInit { get; set; }
            public bool motionBlur { get; set; }
            public bool gyroAiming { get; set; }
            public bool firstHDRSetting { get; set; }
            public double maxLuminosity { get; set; }
            public double uiPaperWhite { get; set; }
            public double scenePaperWhite { get; set; }
            public List<string> _overrideControllerMapKeyList { get; set; }
            public List<string> _overrideControllerMapValueList { get; set; }
            public int lastSeenPreDownloadTime { get; set; }
            public bool mtrCached { get; set; }
            public bool mtrIsOpen { get; set; }
            public int mtrMaxTTL { get; set; }
            public int mtrTimeOut { get; set; }
            public int mtrTraceCount { get; set; }
            public int mtrAbortTimeOutCount { get; set; }
            public int mtrAutoTraceInterval { get; set; }
            public int mtrTraceCDEachReason { get; set; }
        }
    }
}
