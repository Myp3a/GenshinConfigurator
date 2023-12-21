using GenshinConfigurator;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GenshinConfiguratorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SettingsContainer Settings;
        ResolutionSettings Resolution;
        DispatcherTimer StatusTextTimer;
        string status_text;

        public string StatusText {
            get { return status_text; }
            private set { status_text = value; }
        }
        public MainWindow()
        {
            StatusTextTimer = new DispatcherTimer();
            StatusTextTimer.Interval = TimeSpan.FromSeconds(10);
            StatusTextTimer.Tick += new EventHandler(ResetStatusText);
            Settings = new SettingsContainer();
            Settings.Populate();
            Resolution = Settings.Resolution;
            InitializeComponent();
            ShowStatusText("Loaded config from registry.");
            this.DataContext = this;
        }

        public void SettingsApply(object sender, RoutedEventArgs e)
        {
            Settings.Apply();
            Settings.ToReg();
            ShowStatusText("Saved config to registry.");
        }

        public void SettingsReset(object sender, RoutedEventArgs e)
        {
            Settings.Populate();
            RefreshBoxes();
            ShowStatusText("Reloaded config from registry.");
        }

        public void RefreshBoxes()
        {
            this.DataContext = null;
            this.DataContext = this;
        }
        public void ShowStatusText(string text)
        {
            StatusText = text;
            StatusLabel.GetBindingExpression(Label.ContentProperty).UpdateTarget();
            StatusTextTimer.Stop();
            StatusTextTimer.Start();
        }

        public void ResetStatusText(object sender, EventArgs e)
        {
            StatusText = "Ready.";
            StatusTextTimer.Stop();
            StatusLabel.GetBindingExpression(Label.ContentProperty).UpdateTarget();
        }

        #region Graphics

        public void GraphicsLowestSettings()
        {
            GraphicsFPSIndex = 0;
            GraphicsVSync = 1;
            GraphicsRenderResolution = 1;
            GraphicsShadowQuality = 0;
            GraphicsVisualEffects = 0;
            GraphicsSFXQuality = 0;
            GraphicsEnvironmentDetail = 0;
            GraphicsAntialiasing = 0;
            GraphicsVolumetricFog = 0;
            GraphicsReflections = 0;
            GraphicsMotionBlur = 0;
            GraphicsBloom = 1;
            GraphicsCrowdDensity = 1;
            GraphicsSubsurfaceScattering = 0;
            GraphicsTeammateEffects = 0;
            GraphicsAnisotropicFiltering = 0;
        }

        public void GraphicsLowSettings()
        {
            GraphicsFPSIndex = 0;
            GraphicsVSync = 1;
            GraphicsRenderResolution = 2;
            GraphicsShadowQuality = 1;
            GraphicsVisualEffects = 1;
            GraphicsSFXQuality = 1;
            GraphicsEnvironmentDetail = 1;
            GraphicsAntialiasing = 2;
            GraphicsVolumetricFog = 0;
            GraphicsReflections = 0;
            GraphicsMotionBlur = 0;
            GraphicsBloom = 1;
            GraphicsCrowdDensity = 1;
            GraphicsSubsurfaceScattering = 1;
            GraphicsTeammateEffects = 0;
            GraphicsAnisotropicFiltering = 0;
        }

        public void GraphicsMediumSettings()
        {
            GraphicsFPSIndex = 1;
            GraphicsVSync = 1;
            GraphicsRenderResolution = 2;
            GraphicsShadowQuality = 2;
            GraphicsVisualEffects = 2;
            GraphicsSFXQuality = 2;
            GraphicsEnvironmentDetail = 2;
            GraphicsAntialiasing = 2;
            GraphicsVolumetricFog = 1;
            GraphicsReflections = 0;
            GraphicsMotionBlur = 2;
            GraphicsBloom = 1;
            GraphicsCrowdDensity = 1;
            GraphicsSubsurfaceScattering = 1;
            GraphicsTeammateEffects = 0;
            GraphicsAnisotropicFiltering = 0;
        }

        public void GraphicsHighSettings()
        {
            GraphicsFPSIndex = 1;
            GraphicsVSync = 1;
            GraphicsRenderResolution = 3;
            GraphicsShadowQuality = 3;
            GraphicsVisualEffects = 3;
            GraphicsSFXQuality = 3;
            GraphicsEnvironmentDetail = 3;
            GraphicsAntialiasing = 2;
            GraphicsVolumetricFog = 1;
            GraphicsReflections = 1;
            GraphicsMotionBlur = 3;
            GraphicsBloom = 1;
            GraphicsCrowdDensity = 1;
            GraphicsSubsurfaceScattering = 2;
            GraphicsTeammateEffects = 0;
            GraphicsAnisotropicFiltering = 0;
        }

        #endregion
    }
}