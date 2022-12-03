using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer voz;
        List<VoiceInfo> listarvoces = new List<VoiceInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {

            voz = new SpeechSynthesizer();

            foreach(InstalledVoice x in voz.GetInstalledVoices())
            {
                listarvoces.Add(x.VoiceInfo);
                cbolistar.Items.Add(x.VoiceInfo.Name);
            }

            cbolistar.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voz = new SpeechSynthesizer();

            int ind;
            double volumen = trackbarvolumen.Value;
            double velocidad = trackbarvelocidad.Value;

            ind = cbolistar.SelectedIndex;
            string nombrevoces = listarvoces.ElementAt(ind).Name;
            voz.SelectVoice(nombrevoces);

            voz.Volume = (int)volumen;
            voz.Rate = (int)velocidad;
            voz.SpeakAsync(textBox1.Text);

            btnpausar.Text = "Pausar";
        }

        private void btnpausar_Click(object sender, EventArgs e)
        {
            if(voz != null)
            {
                if (voz.State == SynthesizerState.Speaking)
                {
                    voz.Pause(); btnpausar.Text = "Resumen";
                }
                else if (voz.State == SynthesizerState.Paused)
                {
                    voz.Resume(); btnpausar.Text = "Pausar";
                }
            }
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if(voz != null)
            {
                voz.Dispose();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                voz = new SpeechSynthesizer();
                using (SaveFileDialog vai =new SaveFileDialog())
                {
                    vai.Filter = "Wav files|*.wav";
                    if (vai.ShowDialog() == DialogResult.OK)
                    {
                        int ind;
                        double volumen = trackbarvolumen.Value;
                        double velocidad = trackbarvelocidad.Value;

                        ind = cbolistar.SelectedIndex;
                        String nombrevoces = listarvoces.ElementAt(ind).Name;
                        voz.SelectVoice(nombrevoces);

                        FileStream team = new FileStream(vai.FileName, FileMode.Create, FileAccess.Write);
                        voz.SetOutputToWaveStream(team);
                        voz.Speak(textBox1.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Intentar de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void btnacerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lector de texto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/
    }
}
