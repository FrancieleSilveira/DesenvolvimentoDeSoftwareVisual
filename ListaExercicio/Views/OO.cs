using System;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class OO
    {
        public static void Renderizar()
        {
            Produto produto = new Produto();
            produto.Nome =  "Bolacha";
            Console.WriteLine($"Nome do produto: { produto.Nome }");
        }
    }
}