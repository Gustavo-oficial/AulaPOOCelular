using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular smartphone = new Celular();

        // Utilizado como um botao para ligar//
        Console.WriteLine("Se deseja ligar o dispositivo aperte 1, e 2 para desliagar:");
        smartphone.on = int.Parse(Console.ReadLine());
            
        switch (smartphone.on)
        {

            case 1:Console.WriteLine("Celular ligado");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite a cor de seu celular:");
            smartphone.cor  = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Digite o modelo do seu celular:");
            smartphone.modelo  = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-------------------------------");


            Console.WriteLine("Qual o tamanho do seu celular?");
            smartphone.tamanho  = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Digite a mensagem desejada:");
            smartphone.mensagem  = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Mensagem enviada!!!");

            Console.WriteLine("Disque o numero em que deseja ligar:");
            smartphone.ligar = int.Parse(Console.ReadLine());
            Console.WriteLine("Ligação realizada!!!");
            Console.WriteLine("-------------------------------");
    
            break;

            case 2:Console.WriteLine("Celular desligado");
            break;
            
            
        }

           } 
    }
}
