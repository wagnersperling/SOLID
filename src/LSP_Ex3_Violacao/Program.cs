using System;

namespace LSP_Ex3_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Passaro passaro1 = new Pato("Pato 1");
            passaro1.BotaOvos();
            passaro1.Comer();
            passaro1.Voar();

            Passaro passaro2 = new Pinguim("Pinguim 1");
            passaro2.BotaOvos();
            passaro2.Comer();
            passaro2.Voar();

            Console.ReadKey();
        }
    }
}
