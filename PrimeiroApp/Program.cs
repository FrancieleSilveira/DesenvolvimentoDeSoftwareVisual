using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO AULA
            // Console.Clear();
            // Console.WriteLine("Meu primeiro App em C#\n");
            // Console.WriteLine("Digite o seu nome: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Digite a sua idade: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Nome: {name} e idade: {age}");
            

            //EXERCÍCIO 1
            // Console.WriteLine("Informe a altura do retangulo (m): ");
            // double altura = Convert.ToDouble(Console.ReadLine());
            
            // Console.WriteLine("Informe a largura do retangulo (m): ");
            // double largura = Convert.ToDouble(Console.ReadLine());
            
            // double area = altura * largura;

            // Console.WriteLine($"A area do retangulo é: {area}m2");


            //EXERCÍCIO 2   
            // double valorDolar = 5.17, valorEuro = 6.14, valorPeso = 0.05;
            
            // Console.WriteLine("Valor em real (R$): ");
            // double real = Convert.ToDouble(Console.ReadLine());
            
            // double dolar = real / valorDolar;
            // double euro = real / valorEuro;
            // double peso = real / valorPeso;
            
            // Console.WriteLine($"Dólar: {dolar}");
            // Console.WriteLine($"Euro: {euro}");
            // Console.WriteLine($"Peso: {peso}");


            //EXERCICIO 3
            // Console.WriteLine("Informe um número inteiro: ");
            // int valor1 = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine("Informe outro número inteiro: ");
            // int valor2 = Convert.ToInt32(Console.ReadLine());
            
            // if (valor1 > valor2)
            //     Console.WriteLine($"{valor1} maior que {valor2}");
            // else if (valor2 > valor1)
            //     Console.WriteLine($"{valor2} maior que {valor1}");
            // else
            //     Console.WriteLine("Os valore são iguais!");

            
            //EXERCÍCIO 4
            // Console.WriteLine("Informe a idade: ");
            // int idade = Convert.ToInt32(Console.ReadLine());
            // string tipo = null;
            // if(idade <= 13)
            //     tipo = "Criança";
            // else if(idade <= 18)
            //     tipo = "Adolescente";
            // else if(idade <= 60)
            //     tipo = "Adulto";
            // else
            //     tipo = "idoso";
                
            // Console.WriteLine($"{tipo}");


            //EXERCÍCIO 5
            // int atual = 0, proximo = 1, aux;
            
            // Console.WriteLine("Informe o limite da sequencia Fibonacci: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            
            // do
            // {
            //     Console.Write($"{atual}, ");
            //     aux = atual;
            //     atual = atual + proximo;
            //     proximo = aux;
                
            // }while(atual <= num);


            //EXERCICIO 6A
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
            
            // int cont = 0, pronto = n, aux;
            
            // do 
            // {
            //     pronto--;
            //     for(int i = 0; i < pronto; i++) 
            //     {
            //         if(numeros[i] > numeros[i + 1])
            //         {
            //             aux = numeros[i];
            //             numeros[i] = numeros[i + 1];
            //             numeros[i + 1] = aux;	
            //             cont++;	
            //         }
            //     }
            // } while (pronto != 0);
            
            // Console.WriteLine("\n\nNúmeros ordenados: ");
            
            // for(int i = 0; i < n; i++)
            // {
            //     Console.WriteLine($"{numeros[i]} ");
            // }
            // Console.WriteLine($"\n\nNúmero de trocas = {cont}");


            //EXERCÍCIO 6B
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
