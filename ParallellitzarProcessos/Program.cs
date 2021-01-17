﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ParallellitzarProcessos
{
    static class Program
    {
        /** Variable que emmagatzema el llistat amb la informació de les persones carregades des del JSON */
        public static Persona[] personas;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Formulari per obrir el fitxer
            Application.Run(new Form1());

            // Formulari per fer els càlculs
            Application.Run(new Form2());

        }
    }
}
