using System;

namespace ListaExercicio.Views
{
    public class Exe03
    {
        public static void Renderizar()
        {
            Console.WriteLine("Informe um número inteiro: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe outro número inteiro: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            
            if (valor1 > valor2)
                Console.WriteLine($"{valor1} maior que {valor2}");
            else if (valor2 > valor1)
                Console.WriteLine($"{valor2} maior que {valor1}");
            else
                Console.WriteLine("Os valores são iguais!");
        }
    }
}