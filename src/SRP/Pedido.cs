using System;

namespace SRP
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        private Ilogger infoLogger;

        private EnviarEmail enviaEmail;

        public Pedido()
        {
            enviaEmail = new EnviarEmail();
            infoLogger = new RegistraLog();
        }
        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo um pedido");
                enviaEmail.EMailFrom = "teste@teste.com";
                enviaEmail.EMailTo = "teste1@teste1.com";
                enviaEmail.EMailSubject = "SRP";
                enviaEmail.EMailBody = "Um";
                enviaEmail.Enviar();
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar email : " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                //Codigo para deletar o pedido gerado
                infoLogger.Info("Pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao deletar pedido " + ex.Message);
            }
        }
    }
}
