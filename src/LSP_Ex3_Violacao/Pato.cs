using System;

namespace LSP_Ex3_Violacao
{
    public class Pato : Passaro
    {
        public Pato(string nome) : base(nome)
        { }

        public override void Comer()
        {
            Console.WriteLine($"\n{Nome} come milho...");
        }
        public override void BotaOvos()
        {
            Console.WriteLine($"\n{Nome} bota 6 ovos...");
        }
        public override void Voar()
        {
            Console.WriteLine($"\n{Nome} voa baixo...");
        }
    }
}
