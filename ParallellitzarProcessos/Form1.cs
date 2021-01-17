using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallellitzarProcessos
{
    public partial class Form1 : Form
    {
        /** Emmagatzema la ruta d'accés al fitxer json */
        string filePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /** Intenta fer una lectura del fitxer seleccionat. Deserialitza les dades
         * del tipus json i ho passa a un array de la clase persona 
         Si hi ha cap error, el mostra per pantalla.
         Si tot ha anat bé, passa l'array de Persones al fil principal i tanca
         el formulari */
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            error.Clear();
            try
            {
                string json_content = File.ReadAllText(filePath);
                Persona[] personas = JsonSerializer.Deserialize<Persona[]>(json_content);
                Program.personas = personas;
                this.Close();
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                error.SetError(txtFilePath, message);
                filePath = null;
                txtFilePath.Text = null;
            }
        }

        /** Permet obrir un diàlog per seleccionar el fitxer json de
         * manera gràfica */
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            DialogResult result = openJsonFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = openJsonFileDialog.FileName;
                txtFilePath.Text = filePath;
            }
        }

        /** Comprova quan s'està modificant l'input de text que fa
         * referència a la ruta del fitxer. Per si es modifica a mà */
        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            filePath = txtFilePath.Text;
        }
    }
}
