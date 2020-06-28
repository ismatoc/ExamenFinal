using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Cliente
{
    public class ClienteModel
    {
        public int IdCliente { get; set; }
        public int Carnet { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Celular { get; set; }
        public int TelefonoCasa { get; set; }
        public string Direccion { get; set; }
    }
}
