using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallellitzarProcessos
{
    class Persona
    {
        public String dni { get; set; }
        public String Name { get; set; }
        public String email { get; set; }

        public bool comprova_dni()
        {
            bool response = false;

            if (this.dni.Length == 9)
            {
                int numeric_dni;
                bool is_numeric = int.TryParse(this.dni.Substring(0, 8), out numeric_dni);

                if (is_numeric)
                {
                    char lletra_calculada = calcula_lletra(this.dni);

                    if (lletra_calculada != ' ' && lletra_calculada == Convert.ToChar(this.dni.Substring(8, 1)))
                    {
                        response = true;
                    }
                }

            }

            return response;
        }

        public bool comprova_mail()
        {
            bool response = true;

            int first_index = this.Name.IndexOf('@');
            int last_index = this.Name.LastIndexOf('@');

            if (first_index != last_index || 
                first_index == 0 || 
                last_index == 0 ||
                first_index == (this.Name.Length - 1) ||
                last_index == (this.Name.Length - 1))
            {
                response = false;
            }

            return response;
        }

        public bool comprova_nom()
        {
            bool response = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                response = false;
            }

            return response;
        }

        private char calcula_lletra(String dni)
        {
            char lletra_dni = ' ';

        }
    }
}
