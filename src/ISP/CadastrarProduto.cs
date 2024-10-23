using System;

namespace ISP
{
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDatabase()
        {
            Console.WriteLine("Salva dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida dados");
        }
    }
}
