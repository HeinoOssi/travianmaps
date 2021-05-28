using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Threading.Tasks;

namespace travian_maps
{
    class fileHandler
    {
        public void DownloadMapFile()
        {
            var systempath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var mapFile = Path.Combine(systempath, "mapfiles");

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(Properties.Settings.Default.travServer + "/map.sql", mapFile + ".sql");
            }
        }

    }
}
