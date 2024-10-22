using System.Linq;

namespace LSP_Ex2_Violacao
{
    public class CalculaSoma
    {
        protected readonly int[] _numeros;

        public CalculaSoma(int[] numeros)
        {
            _numeros = numeros;
        }

        public int Calcular() => _numeros.Sum();
    }
}
