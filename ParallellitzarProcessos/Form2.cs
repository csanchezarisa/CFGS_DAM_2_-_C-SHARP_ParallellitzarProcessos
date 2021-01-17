using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace ParallellitzarProcessos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /** Fa la comprovació de manera seqüencial i mostra el temps trigat */
        private void btnSeq_Click(object sender, EventArgs e)
        {

            progressSeq.Maximum = Program.personas.Length;
            int index = 0;
            Stopwatch clock = new Stopwatch();
            clock.Start();

            foreach (Persona persona in Program.personas)
            {

                persona.comprova_dni();
                persona.comprova_mail();
                persona.comprova_nom();
                index++;
                progressSeq.Value = index;
            }

            clock.Stop();
            long time_lapse = clock.ElapsedMilliseconds;
            txtSeq.Text = "Temps: " + time_lapse + "ms";

        }

        /** Fa la comprovació de manera paral·lela i mostra el temps trigat */
        private void btnPar_Click(object sender, EventArgs e)
        {

            progressPar.Maximum = Program.personas.Length;
            Stopwatch clock = new Stopwatch();
            clock.Start();

            Parallel.Invoke(comprovarPersonaPar);

            clock.Stop();
            long time_lapse = clock.ElapsedMilliseconds;
            txtPar.Text = "Temps: " + time_lapse + "ms";

        }

        private void comprovarPersonaPar()
        {
            int index = 0;
            foreach (Persona persona in Program.personas)
            {
                persona.comprova_dni();
                persona.comprova_mail();
                persona.comprova_nom();
                index++;
                progressPar.Value = index;
            }
        }
    }
}
