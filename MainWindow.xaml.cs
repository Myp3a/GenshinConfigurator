using GenshinConfigurator;
using System.ComponentModel;
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

namespace GenshinConfigurator
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

        #region Input
        private void InputPreventInput(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void InputEditKeyboardKey(object sender, KeyEventArgs e)
        {
            if (Keycodes.keyboard.ContainsKey(e.Key)) //Valid key
            {
                ((sender as TextBox).Tag as KeyboardKeybind).elementIdentifierId = Keycodes.keyboard[e.Key];
            }
            InputDeviceComboBox.Focus();
        }

        private void InputKeyboardToggleEdit(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.IsFocused)
            {
                tb.Text = "Press desired key...";
            } else
            {
                tb.Text = Keycodes.keynames[(tb.Tag as KeyboardKeybind).elementIdentifierId];
            }
        }

        private void InputCheckAxisInvert(object sender, EventArgs e)
        {
            ((sender as CheckBox).Tag as GamepadAxis).invert = (bool)(sender as CheckBox).IsChecked;
        }

        private void InputCheckCtrl(object sender, EventArgs e)
        {
            ((sender as CheckBox).Tag as KeyboardKeybind).ctrl = (bool)(sender as CheckBox).IsChecked;
        }

        private void InputCheckAlt(object sender, EventArgs e)
        {
            ((sender as CheckBox).Tag as KeyboardKeybind).alt = (bool)(sender as CheckBox).IsChecked;
        }

        private void InputCheckShift(object sender, EventArgs e)
        {
            ((sender as CheckBox).Tag as KeyboardKeybind).shift = (bool)(sender as CheckBox).IsChecked;
        }

        private void InputControllerChange(object sender, SelectionChangedEventArgs e)
        {
            bool devmode = false;
            InputContainer.Children.Clear();
            Controller? c = InputDeviceComboBox.SelectedItem as Controller;
            if (c != null)
            {
                foreach (Keybind kb in c.keybinds)
                {
                    string action;
                    try
                    {
                        action = Keycodes.actions[kb.actionId];
                    }
                    catch
                    {
                        action = "?";
                    }
                    if (action.Contains("?") && !devmode) continue;
                    Grid container = new Grid();
                    container.ColumnDefinitions.Add(new ColumnDefinition());
                    container.ColumnDefinitions.Add(new ColumnDefinition());
                    Label l = new();
                    l.Content = action;
                    Grid.SetColumn(l, 0);
                    Grid.SetRow(l, 0);
                    container.Children.Add(l);
                    if (c is KeyboardController)
                    {
                        KeyboardKeybind k = (kb as KeyboardKeybind);
                        StackPanel p = new StackPanel();
                        p.Orientation = Orientation.Horizontal;
                        CheckBox ctrl = new CheckBox();
                        ctrl.Content = "Ctrl";
                        ctrl.IsChecked = k.ctrl;
                        ctrl.Checked += new RoutedEventHandler(InputCheckCtrl);
                        ctrl.Tag = kb;
                        ctrl.VerticalAlignment = VerticalAlignment.Center;
                        ctrl.Padding = new Thickness(0, 0, 10, 0);
                        CheckBox alt = new CheckBox();
                        alt.Content = "Alt";
                        alt.IsChecked = k.alt;
                        alt.Checked += new RoutedEventHandler(InputCheckAlt);
                        alt.Tag = kb;
                        alt.VerticalAlignment = VerticalAlignment.Center;
                        alt.Padding = new Thickness(0, 0, 10, 0);
                        CheckBox shift = new CheckBox();
                        shift.Content = "Shift";
                        shift.IsChecked = k.shift;
                        shift.Checked += new RoutedEventHandler(InputCheckShift);
                        shift.Tag = kb;
                        shift.VerticalAlignment = VerticalAlignment.Center;
                        shift.Padding = new Thickness(0, 0, 10, 0);
                        TextBox tb = new TextBox();
                        tb.MaxHeight = 25;
                        tb.Width = 120;
                        tb.Text = Keycodes.keynames[kb.elementIdentifierId];
                        tb.Tag = kb;
                        tb.KeyDown += new KeyEventHandler(InputPreventInput);
                        tb.PreviewKeyDown += new KeyEventHandler(InputEditKeyboardKey);
                        tb.GotFocus += new RoutedEventHandler(InputKeyboardToggleEdit);
                        tb.LostFocus += new RoutedEventHandler(InputKeyboardToggleEdit);
                        p.Children.Add(ctrl);
                        p.Children.Add(alt);
                        p.Children.Add(shift);
                        p.Children.Add(tb);
                        p.HorizontalAlignment = HorizontalAlignment.Right;
                        Grid.SetColumn(p, 1);
                        Grid.SetRow(p, 0);
                        container.Children.Add(p);
                    } else
                    {
                        ComboBox cb = new();
                        cb.MaxHeight = 25;
                        cb.Width = 120;
                        cb.ItemsSource = Keycodes.xbox_gamepad_Key;
                        cb.SelectedIndex = kb.elementIdentifierId - Keycodes.AXIS_COUNT;
                        cb.HorizontalAlignment = HorizontalAlignment.Right;
                        Grid.SetColumn(cb, 1);
                        Grid.SetRow(cb, 0);
                        cb.Tag = kb;
                        cb.SelectionChanged += new SelectionChangedEventHandler(InputEditGamepadButton);
                        container.Children.Add(cb);
                    }
                    InputContainer.Children.Add(container);
                }

                foreach (GamepadAxis ax in c.axes)
                {
                    string action;
                    try
                    {
                        action = Keycodes.actions[ax.actionId];
                    }
                    catch
                    {
                        action = "?";
                    }
                    if (action.Contains("?") && !devmode) continue;
                    Grid container = new Grid();
                    container.ColumnDefinitions.Add(new ColumnDefinition());
                    container.ColumnDefinitions.Add(new ColumnDefinition());
                    
                    Label l = new();
                    l.Content = action;
                    Grid.SetColumn(l, 0);
                    Grid.SetRow(l, 0);
                    container.Children.Add(l);
                    StackPanel p = new StackPanel();
                    p.Orientation = Orientation.Horizontal;
                    CheckBox inv = new CheckBox();
                    inv.Content = "Invert";
                    inv.IsChecked = ax.invert;
                    inv.Checked += new RoutedEventHandler(InputCheckAxisInvert);
                    inv.Tag = ax;
                    inv.VerticalAlignment = VerticalAlignment.Center;
                    inv.Padding = new Thickness(0, 0, 10, 0);
                    ComboBox cb = new();
                    cb.MaxHeight = 25;
                    cb.Width = 120;
                    cb.ItemsSource = Keycodes.gamepad_axes;
                    cb.SelectedIndex = ax.elementIdentifierId;
                    cb.SelectionChanged += new SelectionChangedEventHandler(InputEditGamepadAxis);
                    cb.Tag = ax;
                    p.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetColumn(p, 1);
                    Grid.SetRow(p, 0);
                    p.Children.Add(inv);
                    p.Children.Add(cb);
                    container.Children.Add(p);
                    InputContainer.Children.Add(container);
                }
            }
        }

        private void InputEditGamepadAxis(object sender, EventArgs e)
        {
            ((sender as ComboBox).Tag as GamepadAxis).elementIdentifierId = (sender as ComboBox).SelectedIndex;
        }

        private void InputEditGamepadButton(object sender, EventArgs e)
        {
            ((sender as ComboBox).Tag as GamepadKeybind).elementIdentifierId = (sender as ComboBox).SelectedIndex + Keycodes.AXIS_COUNT;
        }
        #endregion
    }
}