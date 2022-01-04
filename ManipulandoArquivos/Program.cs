using System;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";

            FiledHelper helper = new FiledHelper();
            helper.ListarDiretorios(caminho);
        }
    }
}
            