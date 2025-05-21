using CHATBOT;
using MENSAGEM;


namespace TELEGRAM

{


    public class Telegram
    {
        public Telegram(string usuario)
        {
            mensagem();
        }


        public void pesquisatelegram(string usuario, int numerocelular)
        {

        }
        public void mensagem()
        {
            Console.WriteLine("escolha o tipo de mensagem(ex: video, arquivo, imagem, texto): ");
            string tipo = Console.ReadLine();
            Mensagem mensagem = new Mensagem(tipo);
        }
    }
















}