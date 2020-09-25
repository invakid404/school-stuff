using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private void btnStart_Click(object sender, EventArgs e)
        {
            var message = this.txtMessage.Text;
            if (message.Length <= 0)
            {
                MessageBox.Show("Please input a message!");
                return;
            }

            this.Cancel();
            this.synthesizer.SpeakAsync(this.txtMessage.Text);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.synthesizer.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            this.synthesizer.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        private void Cancel()
        {
            this.synthesizer.SpeakAsyncCancelAll();
        }
    }
}
