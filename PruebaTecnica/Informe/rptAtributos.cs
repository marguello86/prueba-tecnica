using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Informe
{
    internal class rptAtributos
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double CostoUnitario { get; set; }
        public double Total { get; set; }
        public string Transaccion { get; set; }
    }
}
