﻿using GenshinConfigurator;
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
                        TextBox tb = new TextBox();
                        tb.MaxHeight = 25;
                        tb.Width = 120;
                        tb.Text = Keycodes.keynames[kb.elementIdentifierId];
                        tb.HorizontalAlignment = HorizontalAlignment.Right;
                        Grid.SetColumn(tb, 1);
                        Grid.SetRow(tb, 0);
                        tb.Tag = kb;
                        container.Children.Add(tb);
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
                    ComboBox cb = new();
                    cb.MaxHeight = 25;
                    cb.Width = 120;
                    cb.ItemsSource = Keycodes.gamepad_axes;
                    cb.SelectedIndex = ax.elementIdentifierId;
                    cb.HorizontalAlignment = HorizontalAlignment.Right;
                    cb.SelectionChanged += new SelectionChangedEventHandler(InputEditGamepadAxis);
                    Grid.SetColumn(cb, 1);
                    Grid.SetRow(cb, 0);
                    cb.Tag = ax;
                    container.Children.Add(cb);
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