using WHATSAPP;
using TELEGRAM;
using INSTAGRAM;
using FACEBOOK;
using System;

namespace CHATBOT
{
    public class Chatbot
    {
        public Chatbot(string canal)
        {
            switch (canal)
            {
                case "whatsApp":
                    Console.WriteLine("digite o numero de DDD: ");
                    string entradaddd = Console.ReadLine();
                    Console.WriteLine("digite o numero de telefone: ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int numerotelefone) && int.TryParse(entradaddd, out int ddd))
                    {
                        whatsApp whats = new whatsApp(ddd, numerotelefone);
                    }
                    else
                    {
                        Console.WriteLine("Numero invalido inválida.");
                    }
                    break;
                case "telegram":
                    Console.WriteLine("digite o nome do usuario: ");
                    string entradanome = Console.ReadLine();
                    Console.WriteLine($"o usuario que você digitou é {entradanome}");
                    Telegram telegram = new Telegram(entradanome);
                    
                    break;
                case "facebook":
                    Console.WriteLine("digite o nome do usuario: ");
                    string entradanomeusuario = Console.ReadLine();
                    Console.WriteLine($"o usuario que você digitou é {entradanomeusuario}");
                    Facebook facebook = new Facebook(entradanomeusuario);
                    
                    break;
                case "instagram":
                    Console.WriteLine("digite o nome do usuario: ");
                    string entradanomeinstagram = Console.ReadLine();
                    Console.WriteLine($"o usuario que você digitou é {entradanomeinstagram}");
                    Instagram instagram = new Instagram(entradanomeinstagram);
                    
                    break;

            }  
                     
            
        }

    }




























}