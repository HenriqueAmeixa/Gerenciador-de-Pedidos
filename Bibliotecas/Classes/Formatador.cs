using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas.Classes
{
    public static class Formatador
    {
        public static string Formatar(string texto)
        {
            byte[] bytes = Encoding.Default.GetBytes(texto);
            texto = Encoding.UTF8.GetString(bytes);
            return texto;
        }
    }
}
