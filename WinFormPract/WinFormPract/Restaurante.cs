using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPract
{
    public class Restaurante
    {
        public int? Id { get; set; }

        public string nombre { get; set; }

        public DateTime fechaApertura { get; set; }

        public string calle { get; set; }

        public int numero { get; set; }

        public string opinion { get; set; }
    }
}
