using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinConfigurator
{
    public partial class Recovery : Form
    {
        SettingsContainer Settings;
        GraphicsSettings Graphics;
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
                Graphics = Settings.Graphics;
                Resolution = Settings.Resolution;
                textBoxRecovery.Text = Graphics.GetJSON(true);
                checkboxMainConfig.Checked = true;
                if (Graphics.settings_json.__graphicsLoaded) checkboxGraphics.Checked = true;
                if (Graphics.settings_json.__controlsLoaded) checkboxControls.Checked = true;
                if (Graphics.settings_json.__graphicsLoaded && Graphics.settings_json.__controlsLoaded) StatusLabel.Text = "Everything is fine. You can close the recovery window.";
                else StatusLabel.Text = "Fix config file and press \"Save\"";
            } catch
            {
                textBoxRecovery.Text = GraphicsSettings.Raw();
                StatusLabel.Text = "Main config file is corrupted. Fix it and press \"Save\"";
                //buttonRecoverySave.Enabled = false;
            }
        }

        private void buttonRecoverySave_Click(object sender, EventArgs e)
        {
            bool fine = false;
            if (!checkboxMainConfig.Checked)
            {
                try
                {
                    Graphics = new GraphicsSettings(textBoxRecovery.Text);
                    fine = true;
                }
                catch
                {
                    fine = false;
                }
            }
            if (fine)
            {
                Graphics.Write(textBoxRecovery.Text);
                Recovery_Load(null, null);
            } 
            else
            {
                StatusLabel.Text = "Config file still broken. Not saving.";
            }
            
        }
    }
}
