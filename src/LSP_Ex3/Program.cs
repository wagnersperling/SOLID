using System;

namespace LSP_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            PassarosVoadores passaro1 = new Pato("passaro 1");
            passaro1.BotaOvos();
            passaro1.Comer();
            passaro1.Voar();

            Passaro passaro2 = new Pinguim("passaro 2");
            passaro2.BotaOvos();
            passaro2.Comer();

            Console.ReadKey();
        }
    }
}
