using CHATBOT;
using MENSAGEM;
using System;

namespace TELEGRAM
{    public class Telegram
    {
        
        Random rand = new Random();
        string tipo;
        string usuario;
        string entradaddd;
        int ddd;
        int numerocelular;

        public Telegram(string entrada)
        {
            
            if (int.TryParse(entrada, out numerocelular))
            {
                Console.WriteLine("digite o numero de DDD: ");
                entradaddd = Console.ReadLine();
                int.TryParse(entradaddd, out ddd);
                buscanumero();
            }
            else
            {
                usuario = entrada;
                buscausuario();
            }
            
        }
        public void buscausuario()
        {
            mensagem();

            Console.WriteLine($"{tipo} enviado para {usuario}");
        } 
        public void buscanumero()
        {
            int dia = rand.Next(1, 31);
            int mes = rand.Next(1, 12);
            mensagem();
            Console.WriteLine($"{tipo} enviado para {ddd} {numerocelular}");

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