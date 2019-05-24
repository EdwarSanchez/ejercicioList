using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_List
{
    class Gato
    {
        //Propiedades
        private int id;
        private string nombre;
        private string color;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        //Constructor 
        public Gato()
        {
            Id = 0;
            Nombre = "";
            Color = "";
        }
    }
}
