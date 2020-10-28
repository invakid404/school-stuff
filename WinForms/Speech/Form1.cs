using System;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace KIUR
{
    public partial class Form1 : Form
    {
        private readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            var msg = "Hello my friend!";

            synthesizer.SpeakAsync(msg);
            MessageBox.Show(msg);
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            synthesizer.Speak("Goodbye my friend!");

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var word = "AWR";
            var amt = 100;

            var awr = new StringBuilder(amt * word.Length);
            for (var i = 0; i < amt; ++i) awr.Append(word);

            synthesizer.Speak(awr.ToString());
        }
    }
}