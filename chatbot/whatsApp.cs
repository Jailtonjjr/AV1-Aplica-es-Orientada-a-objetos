using CHATBOT;
using MENSAGEM;

namespace WHATSAPP
{
    
    public class whatsApp
    {
        Random rand = new Random();
        string tipo = "";
        public int Numero { get; private set; }
        public int DDD { get; private set; }

        public whatsApp(int ddd, int numerotelefone)
        {

            int dia = rand.Next(1, 31);
            int mes = rand.Next(1, 12);
            Numero = numerotelefone;
            DDD = ddd;
            Console.WriteLine($"o telefone que você digitou é: {ddd} {numerotelefone}");
            mensagem();
            Console.WriteLine($"{tipo} enviado para {ddd} {numerotelefone}");
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