using CHATBOT;
using TELEGRAM;
namespace MENSAGEM
{
    public class Mensagem
    {
        Random rand = new Random();

        public Mensagem(string tipo)
        {
            switch (tipo)
            {
                case "texto":
                    Console.WriteLine("Digite a sua mensagem aqui:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"{nome}");
                    break;

                case "video":
                    Console.WriteLine("Digite a Mensagem que gostaria de enviar junto com o video: ");
                    string Mensagem_video = Console.ReadLine();
                    Console.WriteLine("estamos com uma tecnologia diferente hoje, só de você digitar o nome do arquivo localizaremos ele em sua pasta, agora digite o nome do video: ");
                    string nome_video = Console.ReadLine();
                    Console.WriteLine("Para podermos continuar a busca, Por Favor digite o formato do video:");
                    string formato_video = Console.ReadLine();
                    int duracao = rand.Next(0, 59);
                    int segundo = rand.Next(0, 59);
                    Console.WriteLine($"video enviado com duração de {duracao} minutos e {segundo} segundos.");
                    break;

                case "imagem":
                    Console.WriteLine("Digite a Mensagem que gostaria de enviar junto com a imagem: ");
                    string Mensagem_imagem = Console.ReadLine();
                    Console.WriteLine("estamos com uma tecnologia diferente hoje, só de você digitar o nome do arquivo localizaremos ele em sua pasta, agora digite o nome da imagem: ");
                    string nome_imagem = Console.ReadLine();
                    Console.WriteLine("Para podermos continuar a busca, Por Favor digite o formato da imagem:");
                    string formato_imagem = Console.ReadLine();
                    break;

                case "arquivo":
                    Console.WriteLine("Digite a Mensagem que gostaria de enviar junto com o arquivo: ");
                    string Mensagem_arquivo = Console.ReadLine();
                    Console.WriteLine("estamos com uma tecnologia diferente hoje, só de você digitar o nome do arquivo localizaremos ele em sua pasta, agora digite o nome do arquivo: ");
                    string nome_arquivo = Console.ReadLine();
                    Console.WriteLine("Para podermos continuar a busca, Por Favor digite o formato do arquivo:");
                    string formato_arquivo = Console.ReadLine();
                    break;

            }

        }












    }











}