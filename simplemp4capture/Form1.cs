using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;

namespace simplemp4capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set screen capture with full screen enabled
            videoCapture1.Screen_Capture_Source = new VisioForge.Types.Sources.ScreenCaptureSourceSettings()
            {
                FullScreen = true
            };

            // disable audio playback and recording
            videoCapture1.Audio_PlayAudio = videoCapture1.Audio_PlayAudio = false;

            // set output filename, output format and screen capture mode
            videoCapture1.Output_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\output.mp4";
            videoCapture1.Output_Format = new VFMP4v11Output();
            videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.ScreenCapture;

            videoCapture1.Start();
        }//endof button1_Click

        private void btStop_Click(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }
    }
}
