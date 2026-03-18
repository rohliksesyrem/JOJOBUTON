using System.Windows.Media;

namespace WinFormsApp4;

public partial class Form1 : Form
{
    public Form1()
    {
        MediaPlayer jojo = new MediaPlayer();

        jojo.Open(new Uri("rero-rero-rero.mp3",UriKind.Relative));
        jojo.Play();
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MediaPlayer jojo = new MediaPlayer();
    }
}