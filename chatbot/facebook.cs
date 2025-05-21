using CHATBOT;
using MENSAGEM;

namespace FACEBOOK
{

    public class Facebook
    {
        public Facebook(string usuario)
        {
            mensagem();
        }
        public void pesquisafacebook()
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