using System;

namespace ListaExercicio.Views
{
    public class Exe06
    {
        public static void Renderizar()
        {
            const int TAMANHO_VETOR = 100;
            const int LIMITE_NUMEROS = 1001;

            Random random = new Random();
            int[] numeros = new int[TAMANHO_VETOR];

            for (int i = 0; i < TAMANHO_VETOR; i++)
            {
                numeros[i] = random.Next(LIMITE_NUMEROS);
            }
            
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }

            //Ordenação automática c#
            // Array.Sort(numeros);
            Console.WriteLine("\n\n");
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }
            
            //Ordenação Bubble Sort
            bool troca = false;
            do 
            {
                troca = false;
                for(int i = 0; i < TAMANHO_VETOR -1; i++) 
                {
                    if(numeros[i] > numeros[i + 1])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                        troca = true;
                    }
                }
            } while (troca);
            
            // Console.WriteLine("\n\nNúmeros ordenados: ");
            
            // for(int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{numeros[i]} ");
            // }
            // Console.WriteLine($"\n\nNúmero de trocas = {cont}");


            // EXERCÍCIO 6B
            // int n = 5;
            // int[] numeros = new int[n];
            
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"Informe o número {i+1}/{n}: ");
            //     numeros[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.WriteLine();
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{numeros[i]} ");
            // }
            
            // Array.Sort(numeros);
            
            // Console.WriteLine("\n\nNúmeros ordenados: ");
                    
            // for(int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{numeros[i]} ");
            // }
        }
    }
}