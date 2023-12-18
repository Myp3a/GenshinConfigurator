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
            ShowStatusText("Loaded config from registry.");
            InitializeComponent();
            this.DataContext = this;
        }

        public void SettingsApply()
        {
            Settings.Apply();
        }

        public void SettingsReset()
        {

        }

        public void ShowStatusText(string text)
        {
            StatusText = text;
            StatusTextTimer.Stop();
            StatusTextTimer.Start();
        }

        public void ResetStatusText(object sender, EventArgs e)
        {
            StatusText = "Ready.";
            StatusTextTimer.Stop();
            StatusLabel.GetBindingExpression(Label.ContentProperty).UpdateTarget();
        }
    }
}