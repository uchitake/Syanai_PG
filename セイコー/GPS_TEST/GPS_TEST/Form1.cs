using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace GPS_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            GeoCoordinateWatcher gcw;

            // インスタンスを作成
            gcw = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

            gcw.Start();

            GPSval_txt.Text = gcw.Position.Location.Latitude.ToString() + " : " + gcw.Position.Location.Longitude.ToString();
        }
    }
}
