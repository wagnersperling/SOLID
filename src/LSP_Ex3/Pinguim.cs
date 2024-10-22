using System;

namespace LSP_Ex3
{
    public class Pinguim : Passaro
    {
        public Pinguim(string nome) : base(nome)
        { }

        public override void Comer()
        {
            Console.WriteLine($"\n{Nome} come peixes...");
        }
        public override void BotaOvos()
        {
            Console.WriteLine($"\n{Nome} bota 2 ovos...");
        }
    }
}
