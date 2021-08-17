using System;

namespace ListaExercicio.Views
{
    public class Exe02
    {
        public static void Renderizar()
        {
            const double VALOR_ATUAL_DOLAR = 5.17, 
                         VALOR_ATUAL_EURO = 6.14, 
                         VALOR_ATUAL_PESO = 0.05;
            
            Console.WriteLine("Valor em real (R$): ");
            double real = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Dólar: { (real / VALOR_ATUAL_DOLAR).ToString("F2") }");
            Console.WriteLine($"Euro: { (real / VALOR_ATUAL_EURO).ToString("F2") }");
            Console.WriteLine($"Peso: { (real / VALOR_ATUAL_PESO).ToString("F2") }");
        }
    }
}