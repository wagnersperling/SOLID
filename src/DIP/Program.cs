namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var recuperarSenhaMySql = new RecuperarSenha(new MySqlConnection());
            var recuperarSenhaSqlServer = new RecuperarSenha(new SqlServerConnection());
        }
    }
}
