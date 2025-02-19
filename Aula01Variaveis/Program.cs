using System;

namespace Aula01Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
        //Juntar metodo na main 
          VerificarMedias();
          //ConcatenarPalavras();
          //VerificarAulaEtec();
        }


        public static void VerificarMedias()
        {
            Console.WriteLine("Digite a primeira nota :");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 + nota2) / 2;
            Console.WriteLine($"A média é {media}");
            

            if(media>7)
                Console.WriteLine("Aprovado");

                else if(media<7 && media >=4 )
                Console.WriteLine("Recuperação");

                else
                Console.WriteLine("Reprovado");

        }

        //Criar metodo
        public static void VerificarAulaEtec()
        {
            Console.WriteLine("Digite a data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if(data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana! Hoje nao tem aula! Revisarei exercicios");
            }
            else{
                Console.WriteLine("Dia da semana! Bora para a ETEC!!!!");
            }
        }


        //Criar metodo

        public static void ConcatenarPalavras()
        {
           Console.WriteLine("Digite seu nome: ");
           string nome = Console.ReadLine();

           string frase1 = $" Óla {nome}, hoje é {DateTime.Now}";
           Console.WriteLine (frase1);
           Console.WriteLine(" ");

           Console.WriteLine("Quanto custa o dolar em reais");
           decimal valorDolarReais= decimal.Parse(Console.ReadLine());
           string frase2 = string.Format("Hoje é {0:dddd}, o dolar está custando {1:c2}", DateTime.Now, valorDolarReais);
           Console.WriteLine(frase2);


           Console.WriteLine(" ");
           string cabecalho = string.Format("{0:dddd}, {0:dd} de {0:MMMM} de {0:yyyy} = {0:HH:mm:ss}", DateTime.Now);
           Console.WriteLine(cabecalho.ToUpper());
        }


    }
}