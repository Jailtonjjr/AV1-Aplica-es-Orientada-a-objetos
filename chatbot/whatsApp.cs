using CHATBOT;
using MENSAGEM;

namespace WHATSAPP
{
    
    public class whatsApp
    {
        string tipo = "";
        public int Numero { get; private set; }
        public int DDD { get; private set; }

        public whatsApp(int ddd, int numerotelefone)
        {
            Numero = numerotelefone;
            DDD = ddd;
            Console.WriteLine($"o telefone que você digitou é {ddd} {numerotelefone}");
            pesquisawhatsApp();
            mensagem();
            Console.WriteLine($"{tipo} enviado para {ddd} {numerotelefone}");
            
        }
        public void pesquisawhatsApp()
        {
            
            Console.WriteLine($"oi Numero {Numero}");
        }
        public void mensagem()
        {
            Console.WriteLine("escolha o tipo de mensagem(ex: video, arquivo, imagem, texto): ");
            tipo = Console.ReadLine();
            Mensagem mensagem = new Mensagem(tipo);
        }
        
    }


















    
}