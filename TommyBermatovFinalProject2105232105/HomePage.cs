using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4InARow
{
    public partial class HomePage : Form
    {
        public Settings settings;
        public SettingsForm2 settingsForm2;

        public HomePage()
        {
            InitializeComponent();
            settings = new Settings();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// import settings and show settingsForm2
        /// </summary>
        private void btn_settings_Click(object sender, EventArgs e)
        {
            settingsForm2 = new SettingsForm2(settings);
            settingsForm2.Show();
        }
    }
}
