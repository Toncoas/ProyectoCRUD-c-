using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Entidades
    {
        public class Autobus
        {
            public int Id { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Placa { get; set; }
            public string Color { get; set; }
            public int Año { get; set; }
        }

    }
}
