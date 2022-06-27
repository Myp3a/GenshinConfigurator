using System;
using System.Windows.Forms;

namespace GenshinConfigurator
{
    public partial class Recovery : Form
    {
        SettingsContainer Settings;
        ResolutionSettings Resolution;

        public Recovery()
        {
            InitializeComponent();
        }

        private void Recovery_Load(object sender, EventArgs e)
        {
            checkboxMainConfig.Checked = false;
            checkboxGraphics.Checked = false;
            checkboxControls.Checked = false;
            try
            {
                Settings = new SettingsContainer();
                Settings.Populate();
                Resolution = Settings.Resolution;
                textBoxRecovery.Text = Settings.Raw();
                checkboxMainConfig.Checked = true;
                if (Settings.graphicsLoaded) checkboxGraphics.Checked = true;
                if (Settings.controlsLoaded) checkboxControls.Checked = true;
                if (Settings.graphicsLoaded && Settings.controlsLoaded) StatusLabel.Text = "Everything is fine. You can close the recovery window.";
                else StatusLabel.Text = "Fix config file and press \"Save\"";
            } catch
            {
                textBoxRecovery.Text = RegistryContainer.Load();
                StatusLabel.Text = "Main config file is corrupted. Fix it and press \"Save\"";
                //buttonRecoverySave.Enabled = false;
            }
        }

        private void buttonRecoverySave_Click(object sender, EventArgs e)
        {
            bool fine = false;
            try
            {
                Settings.Parse(textBoxRecovery.Text);
                fine = true;
            }
            catch
            {
                fine = false;
            }
            if (fine)
            {
                Settings.ToReg();
                Recovery_Load(null, null);
            } 
            else
            {
                StatusLabel.Text = "Config file still broken. Not saving.";
            }
            
        }
    }
}
