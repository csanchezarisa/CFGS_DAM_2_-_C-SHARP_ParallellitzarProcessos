using System;
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
            // Reseteja la barra de progrés
            progressSeq.Maximum = Program.personas.Length;
            progressSeq.Value = 0;

            // Crea un cronòmetre
            Stopwatch clock = new Stopwatch();
            clock.Start();

            // Bucla fent les funcions pertinents de manera seqüencial
            foreach (Persona persona in Program.personas)
            {

                persona.comprova_dni();
                persona.comprova_mail();
                persona.comprova_nom();
            }

            // Mostra la barra de progrés finalitzada
            progressSeq.Value = Program.personas.Length;

            // Para el cronòmetre i mostra el temps per pantalla
            clock.Stop();
            long time_lapse = clock.ElapsedMilliseconds;
            txtSeq.Text = "Temps: " + time_lapse + "ms";

        }

        /** Fa la comprovació de manera paral·lela i mostra el temps trigat */
        private void btnPar_Click(object sender, EventArgs e)
        {
            // Reseteja la barra de progrés
            progressPar.Maximum = Program.personas.Length;
            progressPar.Value = 0;

            // Crea un cronòmetre
            Stopwatch clock = new Stopwatch();
            clock.Start();

            // Bucla fent les funcions pertinents de manera seqüencial
            Parallel.ForEach(Program.personas, persona =>
            {
                persona.comprova_dni();
                persona.comprova_mail();
                persona.comprova_nom();
            });

            // Mostra la barra de progrés finalitzada
            progressPar.Value = Program.personas.Length;

            // Para el cronòmetre i mostra el temps per pantalla
            clock.Stop();
            long time_lapse = clock.ElapsedMilliseconds;
            txtPar.Text = "Temps: " + time_lapse + "ms";

        }

        /** Fa la comprovació de manera paral·lela amb el mètode Invoke i mostra el temps trigat */
        private void btnInvoke_Click(object sender, EventArgs e)
        {
            // Reseteja la barra de progrés
            progressInvoke.Maximum = Program.personas.Length;
            progressInvoke.Value = 0;

            // Crea un cronòmetre
            Stopwatch clock = new Stopwatch();
            clock.Start();

            // Bucla fent les funcions pertinents de manera seqüencial
            Parallel.Invoke(
            () => 
            {
                foreach (Persona persona in Program.personas)
                {
                    persona.comprova_dni();
                }
            },
            
            () =>
            {
                foreach (Persona persona in Program.personas)
                {
                    persona.comprova_mail();
                }
            },
            
            () =>
            {
                foreach (Persona persona in Program.personas)
                {
                    persona.comprova_nom();
                }
            });

            // Mostra la barra de progrés finalitzada
            progressInvoke.Value = Program.personas.Length;

            // Para el cronòmetre i mostra el temps per pantalla
            clock.Stop();
            long time_lapse = clock.ElapsedMilliseconds;
            txtInvoke.Text = "Temps: " + time_lapse + "ms";
        }
    }
}
