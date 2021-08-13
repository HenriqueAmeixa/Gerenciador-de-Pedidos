using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace Bibliotecas.Estruturas
{
    class CadFornecedor
    {
        public class Fornecedores
        {
            public int Codigo { get; set; }
            public string CNPJ { get; set; }
            public string IE { get; set; }
            public float Comissao { get; set; }
            public string NomeReduzido { get; set; }
            public string Contato { get; set; }
            public string Celular { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public string CEP { get; set; }
            public string Cidade { get; set; }
            public string Bairro { get; set; }
            public string Rua { get; set; }
            public string UF { get; set; }
        }
        public static void SerializedClassFornecedor(Fornecedores forn)
        {
            string Json = JsonConvert.SerializeObject(forn, Formatting.Indented);
            string path = Directory.GetCurrentDirectory();
            string nome = "/teste.json";

            using (StreamWriter writer = new StreamWriter(path + nome, true))
            {
                writer.WriteLine(Json);
            }
        }
    }

}
