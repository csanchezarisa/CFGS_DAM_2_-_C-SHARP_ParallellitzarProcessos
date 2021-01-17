using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ParallellitzarProcessos
{
    static class Program
    {
        public static Persona[] personas;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
