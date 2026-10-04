using System;
using System.Windows.Forms;

namespace ROV_CONTROLLER1
{

    public partial class rov_ui : Form
    {
        string pi_ip = "192.168.10.2";
        string laptop_ip = "192.168.10.1";
        string video_stream_port = "8889";
        string stream_name = "spuds_cam";
        // The Pi's address, MediaMTX's WebRTC port, and the stream name
        private const string VideoUrl = "http://192.168.10.2:8889/spuds_cam";

        public rov_ui()
        {
            InitializeComponent();
            Load += rov_ui_load;
        }

        private async void rov_ui_load(object sender, EventArgs e)
        {
            await ROV_Cam.EnsureCoreWebView2Async();   // start the embedded browser engine
            ROV_Cam.Source = new Uri(VideoUrl);         // open the WebRTC viewer page
        }

    }
}