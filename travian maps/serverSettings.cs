using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travian_maps
{
    public partial class serverSettings : Form
    {
        public serverSettings()
        {
            InitializeComponent();
        }

        private void serverSettings_Load(object sender, EventArgs e)
        {
            if (travian_maps.Properties.Settings.Default.travServer == "")
            {
                txtAddress.Text = ("https://ts50.x5.america.travian.com");

            }
            else
            {
                txtAddress.Text = travian_maps.Properties.Settings.Default.travServer;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
