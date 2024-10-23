using System;

namespace ISP
{
    class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }

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
