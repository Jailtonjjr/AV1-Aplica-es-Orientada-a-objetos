using CHATBOT;
using MENSAGEM;

namespace INSTAGRAM
{
    public class Instagram
    {

        public Instagram(string usuario)
        {
            mensagem();
        }

        public void pesquisainstagram(string usuario)
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