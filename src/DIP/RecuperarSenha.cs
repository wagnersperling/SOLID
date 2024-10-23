using System;

namespace DIP
{
    class RecuperarSenha
    {
        private IDataBaseConnection _conexaoBanco;
        public RecuperarSenha(IDataBaseConnection conexao)
        {
            _conexaoBanco = conexao;
        }
    }
}
