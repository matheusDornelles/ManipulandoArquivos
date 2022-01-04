using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExemploPOO.Helper
{
    public class FiledHelper
    {
        public void ListarDiretorios(string Caminho)
        {
            var retornoCaminho = Directory.GetDirectories(Caminho);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
    }
}