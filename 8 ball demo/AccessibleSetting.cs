using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _8ball.Properties;

namespace _8ball
{
    public partial class AccessibleSetting : Form
    {
        public AccessibleSetting()
        {
            InitializeComponent();
            Shaketoggle.Checked = Settingsconfig.Default.AccessibleShakeDisable;
        }

        private void Shaketoggle_CheckedChanged(object sender, EventArgs e)
        {
            Settingsconfig.Default.AccessibleShakeDisable = Shaketoggle.Checked;
            Settingsconfig.Default.Save(); //Dear future self, don't forget to implement this -.-
        }
    }
}
