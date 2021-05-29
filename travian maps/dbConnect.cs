using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace travian_maps
{
    class dbConnect
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string user;
        private string password;

        // Constructor
        public dbConnect()
        {
            Initialize();

        }

        // Initialize connection
        private void Initialize()
        {
            // Values has been set in application properties
            server = travian_maps.Properties.Settings.Default.db_hostname;
            database = travian_maps.Properties.Settings.Default.db_name;
            user = travian_maps.Properties.Settings.Default.db_username;
            password = travian_maps.Properties.Settings.Default.db_password;

            // Connection string
            string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(connString);

        }

        // Open connection to database
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }catch(MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        // Cannot connect to server
                        break;
                    case 1045:
                        // Invalid username or password;
                        break;
                }
            }
            return false;
        }

        // Close connection
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                // TODO: e.message
                return false;
            }
        }

        public bool InsertToDatabase()
        {
            // Path to downloaded map file.
            var systempath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var mapFile = Path.Combine(systempath, "mapfiles.sql");

            StreamReader sr = new StreamReader(mapFile);
            string line;
            if (this.OpenConnection() == true)
            {
                // Loop through all the lines in the file
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(line, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                this.CloseConnection();
                return true;
            }


            return false;
        }

        // Create database
        public bool CreateDatabase()
        {
            // First, drop the old database if it exists
            // TODO: copy the old database, compare the old and new one
            // for population changes etc. for inactive searching
            string query = "DROP TABLE IF EXISTS "+ Properties.Settings.Default.db_name +".`x_world`";
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

            // Second, create it again
            query = "CREATE TABLE "+Properties.Settings.Default.db_name +".`x_world`(" +
                "id int NULL," +                    // Field number
                "x smallint NULL, " +               // X-coordinate for the village
                "y smallint NULL, " +               // Y-coordinate for the village
                "tid tinyint NULL, " +              // Tribe ID, 1=roman, 2=teuton, 3=gaul,4=nature, 5=natars
                "vid int NULL, " +                  // Unique village ID
                "village nvarchar(50) NULL,	" +     // Village name
                "uid int NULL, " +                  // Players user ID
                "player nvarchar(50) NULL,	" +     // Player name
                "aid int NULL, " +                  // Alliance ID
                "alliance nvarchar(20) NULL, " +    // Alliance name
                "population smallint NULL, " +      // Village population
                "worldid tinyint NULL)";

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
            }
            return false;
        }

        // Select uid items
        public bool SelectPlayer(int userid, string tablename)
        {
            string query = "SELECT * FROM " + tablename + " WHERE uid=" + userid;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    // TODO
                    Console.WriteLine("Field number:" + rdr[0] + ", X" + rdr[1] + ", Y" +rdr[2]);

                }
                rdr.Close();
            } catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
                
            }
            conn.Close();
            return false;
        }
    }
}
