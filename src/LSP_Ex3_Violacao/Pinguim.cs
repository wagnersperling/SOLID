using System;

namespace LSP_Ex3_Violacao
{
    public class Pinguim : Passaro
    {
        public Pinguim(string nome) : base(nome)
        {
        }
        public override void Comer()
        {
            Console.WriteLine($"\n{Nome} come peixes...");
        }
        public override void BotaOvos()
        {
            Console.WriteLine($"\n{Nome} bota 2 ovos...");
        }

        public override void Voar()
        {
            throw new Exception("Pinguin não voa");
        }
    }
}
