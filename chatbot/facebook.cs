using CHATBOT;
using MENSAGEM;

namespace FACEBOOK
{

    public class Facebook
    {
        Random rand = new Random();
        string tipo;
        public Facebook(string usuario)
        {
            int dia = rand.Next(1, 31);
            int mes = rand.Next(1, 12);
            mensagem();
            Console.WriteLine($"{tipo} enviado para {usuario}");

            if (tipo == "texto")
            {
                Console.WriteLine($"Data de envio da mensagem {dia}/{mes}/2025");
            }
        }
        public void pesquisafacebook()
        {


        }
        public void mensagem()
        {
            Console.WriteLine("escolha o tipo de mensagem(ex: video, arquivo, imagem, texto): ");
             tipo = Console.ReadLine();
            Mensagem mensagem = new Mensagem(tipo);
        }
    }


















}