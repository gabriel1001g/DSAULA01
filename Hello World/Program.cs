using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine(); //string variavel 

            Console.WriteLine($"Seu nome tem {nome.Length} caracteres."); //$ da a possibilidade de juntar as variaveis na mensagem {nome.Length transforma em numeros}
            
            Console.WriteLine("Digite a data do seu nascimento");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            int qtdDiasVividos = DateTime.Now.Subtract(dtNascimento).Days;
            Console.WriteLine("Os dias vividos ate hoje sao: " + qtdDiasVividos);

            Console.ReadKey(); //Encerrar
            
        }
    }
}