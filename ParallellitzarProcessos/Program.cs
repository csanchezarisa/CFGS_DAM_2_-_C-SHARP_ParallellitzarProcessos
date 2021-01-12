using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ParallellitzarProcessos
{
    static class Program
    {
        private static Persona[] personas;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            bool lectura_correcte = false;
            int read_intents = 0;

            do
            {
                // Lectura del fitxer
                try
                {
                    String fitxer_json = File.ReadAllText("people.json");
                    personas = JsonSerializer.Deserialize<Persona[]>(fitxer_json);
                    lectura_correcte = true;
                }
                catch (Exception)
                {
                    lectura_correcte = false;
                    read_intents++;
                }

            }
            while (!lectura_correcte && read_intents > 5);

            if (personas.Length <= 0)
            {
                
            }
        }
    }
}
