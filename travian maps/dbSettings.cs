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
    public partial class dbSettings : Form
    {
        public dbSettings()
        {
            InitializeComponent();
        }

        private void dbSettings_Load(object sender, EventArgs e)
        {
            string updateinterval = travian_maps.Properties.Settings.Default.db_update_interval_hours.ToString();
            txtDBHostname.Text = travian_maps.Properties.Settings.Default.db_hostname;
            txtDBName.Text = travian_maps.Properties.Settings.Default.db_name;
            txtUsername.Text = travian_maps.Properties.Settings.Default.db_username;
            txtPassword.Text = travian_maps.Properties.Settings.Default.db_password;
            txtUpdateInterval.Text = updateinterval;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int updateinterval;
            int.TryParse(txtUpdateInterval.Text, out updateinterval);
            Properties.Settings.Default.db_hostname = txtDBHostname.Text;
            Properties.Settings.Default.db_name = txtDBName.Text;
            Properties.Settings.Default.db_username = txtUsername.Text;
            Properties.Settings.Default.db_password = txtPassword.Text;
            Properties.Settings.Default.db_update_interval_hours = updateinterval;
            Properties.Settings.Default.Save();



        }
    }
}
