using CHATBOT;
using MENSAGEM;

namespace INSTAGRAM
{
    public class Instagram
    {
         Random rand = new Random();
        string tipo;
        public Instagram(string usuario)
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
        public void mensagem()
        {
            Console.WriteLine("escolha o tipo de mensagem(ex: video, arquivo, imagem, texto): ");
            tipo = Console.ReadLine();
            Mensagem mensagem = new Mensagem(tipo);
        }
    }


















}