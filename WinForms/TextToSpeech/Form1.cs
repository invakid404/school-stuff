using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            if (message.Length <= 0)
            {
                MessageBox.Show("Please input a message!");
                return;
            }

            Cancel();
            synthesizer.SpeakAsync(txtMessage.Text);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            synthesizer.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            synthesizer.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            synthesizer.SpeakAsyncCancelAll();
        }
    }
}