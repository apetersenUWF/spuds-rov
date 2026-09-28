using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Windows.Forms;
namespace ROV_CONTROLLER1
{

    public partial class rov_ui : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        public rov_ui()
        {
            InitializeComponent();
            Load += rov_ui_load;
            FormClosing += rov_ui_closeform;
        }
        private void rov_ui_load(object sender, EventArgs e)
        {
            initialize_video();
            begin_video_stream("udp://@:5696"); // start listening on UDP port 5000
        }
        private void rov_ui_closeform(object sender, FormClosingEventArgs e)
        {
            shutdown_video();
        }
        private void initialize_video()
        {
            Core.Initialize();                          //loads VLC
            _libVLC = new LibVLC(true,                      // Creates the VLC engine object
                "--network-caching=200",                // latency (higher adds latency but may make video smoother)
                "--clock-jitter=0",                     // tells the player to show frames immediately
                "--clock-synchro=0");                   // dont sync the pi and vlc media player clocks
            _mediaPlayer = new MediaPlayer(_libVLC);    // creates a video player that uses this engine
            ROV_Cam.MediaPlayer = _mediaPlayer;      // directs the media player to the video box on the form
        }
        private void begin_video_stream(string videoURL)
        {
            using (var media = new Media(_libVLC, videoURL, FromType.FromLocation)) // describes what to play; FromLocation = network address
            {                                                                       // "using" disposes media at the closing brace
                media.AddOption(":network-caching=1000");// assigns network cachning value to the stream directly
                media.AddOption(":demux=ts");   // stream is MPEG-TS; skip format detection
                _mediaPlayer.Play(media);               // starts listening and plays video as soon as packets arrive
            }                                       
        }
        private void stop_stream()
        {
            _mediaPlayer.Stop(); //stop recieving
        }
        private void shutdown_video()
        {
            if (_mediaPlayer != null)                   // Only if the player was created
            {
                _mediaPlayer.Stop();                    // Stop playback first
            }
            ROV_Cam.MediaPlayer = null;              // Disconnect the player from the video box
            if (_mediaPlayer != null)                   // Only if the player was created
            {
                _mediaPlayer.Dispose();                 // Release the player's native resources
            }
            if (_libVLC != null)                        // Only if the engine was created
            {
                _libVLC.Dispose();                      // Release the engine's native resources (last, since the player used it)
            }
        }
    }
}
