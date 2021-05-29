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
    
    public partial class MainForm : Form
    {
        dbConnect dbconn = new dbConnect();
        fileHandler fhandler = new fileHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        private void serverSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open server settings dialog
            serverSettings srv = new serverSettings();
            srv.Owner = this;
            srv.Show();
            this.Enabled = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 940;
            this.Height = 700;

            // Update interval in hours
            int interval;
            if (Properties.Settings.Default.db_update_interval_hours == 0)
            {
                interval = 3600000;
            }
            else
            {
                interval = Properties.Settings.Default.db_update_interval_hours * 3600000;
            }
            

            this.lblServer.Text = "Current server: " + travian_maps.Properties.Settings.Default.travServer;
            updateTimer.Interval = interval;

        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open database settings dialog
            dbSettings dbsettings = new dbSettings();
            dbsettings.Owner = this;
            dbsettings.Show();
            this.Enabled = false;

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            dbconn.CreateDatabase();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Updating...";
            this.Enabled = false;

            if (Properties.Settings.Default.db_hostname == "")
            {
                lblStatus.Text = "Status: Missing database hostname";
            }

            if (Properties.Settings.Default.db_name == "")
            {
                lblStatus.Text = "Status: Missing database name";
            }
            else
            {
                lblStatus.Text = "Status: Creating database tables...";
                if (!dbconn.CreateDatabase())
                {
                    lblStatus.Text = "Status: Failed to create tables";
                }
                else
                {
                    // OK, download the map.sql file
                    lblStatus.Text = "Status: Downloading map file...";
                    fhandler.DownloadMapFile();
                    lblStatus.Text = "Status: Updating database...";
                    if (!dbconn.InsertToDatabase())
                    {
                        lblStatus.Text = "Status: Error inserting to database";
                    }
                    else
                    {
                        lblStatus.Text = "Status: Updated";
                    }
                }
            }

            this.Enabled = true;
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            // TODO: remove when not needed
            dbconn.SelectPlayer(437, "x_world");
        }
    }
}
