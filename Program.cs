using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista(10);
            List<Char> list = new List<Char>();
            list.Add('W');
            lista.Inserir('W');
            list.Add('a');
            lista.Inserir('a');
            list.Add('y');
            lista.Inserir('y');
            list.Add('r');
            lista.Inserir('r');
            list.Add('o');
            lista.Inserir('o');
            list.Add('n');
            lista.Inserir('n');
            list.Insert(2, 'e');
            lista.InserirNaPosicao(2, 'e');
            list.RemoveAt(2);
            lista.Remover(3);
            lista.Exibir();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
