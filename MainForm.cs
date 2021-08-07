#define USE_AX_PLAYER

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;
using AxWMPLib;


namespace BinauralBeatsv1
{

    
    public partial class MainForm : Form
    {
        protected string FileToPlay = "";
        MediaPlayer player = new MediaPlayer();
        TimeSpan playTimeSpan = new TimeSpan();
        TimeSpan currentTimeSpan = new TimeSpan();
        Stopwatch sw = null;
        
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ArrayList arrPatterns = new ArrayList();
            arrPatterns.Add(
                new Pattern(
                    1,
                    "Alpha",
                    "Binaural beats in the alpha pattern are at a frequency of 7–13 Hz and may encourage relaxation.\r\nRight: 440 Hz, Left: 430 Hz",
                    "BB alpha pattern 440-430.wav"));
            arrPatterns.Add(
                new Pattern(
                    1,
                    "Beta",
                    "Binaural beats in the beta pattern are at a frequency of 13–30 Hz. This frequency range may help promote concentration and alertness. However, it can also increase anxiety at the higher end of the range.\r\nRight: 440 Hz, Left: 424 Hz",
                    "BB beta pattern 440-424.wav"));
            arrPatterns.Add(
                new Pattern(
                    1,
                    "Delta",
                    "Binaural beats in the delta pattern operate at a frequency of 0.5–4 Hz with links to a dreamless sleep. In the study, people who received a delta pattern frequency during sleep entered a deeper stage of sleep, according to electroencephalogram (EEG) brain scan results.",
                    "BB delta pattern 440-438.wav"));
            arrPatterns.Add(
                new Pattern(
                    1,
                    "Gamma",
                    "This frequency pattern accounts for a range of 30–50 Hz. The study authors suggest that these frequencies promote maintenance of arousal while a person is awake.\r\nRight: 440 Hz, Left: 400 Hz",
                    "BB gamma pattern 440-400.wav"));
            arrPatterns.Add(
                new Pattern(
                    1,
                    "Theta",
                    "Practitioners set binaural beats in the theta pattern to a frequency of 4–7 Hz. Theta patterns contribute to improved meditation, creativity, and sleep in the rapid eye movement (REM) phase.\r\nRight: 440 Hz, Left: 434 Hz",
                    "BB theta pattern 440-434.wav"));

            lbPattern.DataSource = arrPatterns.ToArray(typeof(Pattern));
            
            lbPattern.ValueMember = "Id";
            lbPattern.DisplayMember = "Text";


            player.MediaEnded += Player_MediaEnded;
            player.MediaOpened += Player_MediaOpened;
            player.MediaFailed += Player_MediaFailed;

            lbPattern.SelectedIndex = 0;

        }

        private void Player_MediaFailed(object sender, ExceptionEventArgs e)
        {
            lError.Text = e.ErrorException.Message + "\r\n" + FileToPlay;
        }

        private void Player_MediaOpened(object sender, EventArgs e)
        {
            sw = Stopwatch.StartNew();
            bStop.Enabled = true;
            bPlay.Enabled = false;
            player.Play();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            player.Close();
            bStop.Enabled = false;
            bPlay.Enabled = true;

        }

        private void lbPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            lDescription.Text =((Pattern)lbPattern.SelectedItem).Description;
            FileToPlay = Application.StartupPath + "\\beats\\" + ((Pattern)lbPattern.SelectedItem).Filename;
            lError.Text = FileToPlay;
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            lError.Text = FileToPlay;
            int volume = tVolume.Value;
            playTimeSpan = timePicker.Value.TimeOfDay;


            Uri uri = new Uri(FileToPlay);
            player.Volume = (double)volume/100;
            player.Open(uri);

            bStop.Enabled = true;

        }

        private void Player_MediaEnded(object sender, EventArgs e)
        {
            currentTimeSpan = sw.Elapsed;
            if(currentTimeSpan < playTimeSpan)
            {
                player.Position = new TimeSpan(0);
                player.Play();
            }
            else
            {
                player.Stop();
                player.Close();
                sw.Stop();
                bStop.Enabled = false;
                bPlay.Enabled = true;
            }
        }

        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
        }

        private void axWindowsMediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            lError.Text = e.ToString() + "\r\n" + FileToPlay;
        }

        private void tVolume_Scroll(object sender, EventArgs e)
        {

            player.Volume = (double)tVolume.Value/100;
        }

        private void linkLabelTutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ilvyanyatka.com/binaural-beats-application/");
        }

        private void linkLabelC_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ilvyanyatka.com");
        }
    }
}
