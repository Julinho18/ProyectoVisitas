using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVisitas.Client.Helpers
{
    public class UtilidadesString
    {
        public static string EnMayuscular(string valor) => valor.ToUpper();
        public static string Minimizar(string valor) => valor.ToLower();
    }
}
