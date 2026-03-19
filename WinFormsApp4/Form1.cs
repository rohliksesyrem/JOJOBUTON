using System.Windows.Media;

namespace WinFormsApp4;

public partial class Form1 : Form
{  MediaPlayer jojo = new MediaPlayer();

    public Form1()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
       
        jojo.Open(new Uri("rero-rero-rero.mp3",UriKind.Relative));
        jojo.Play();
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
       
        jojo.Open(new Uri("-jojo-nigerundayo.mp3", UriKind.Relative));
        jojo.Play();
      
    }

    private void button3_Click(object sender, EventArgs e)
    {
        jojo.Open(new Uri("doppio-ringing.mp3", UriKind.Relative));
        jojo.Play();
       
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        jojo.Volume = trackBar1.Value / 100.0;
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
        jojo.SpeedRatio = trackBar2.Value / 100.0;
    }
}