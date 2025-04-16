using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed
{
    public class Lista
    {
        char[] Elementos;
        int Tamanho;
        int Capacidade;
        public Lista(int capacidade) {
            this.Capacidade = capacidade;
            Elementos = new char[Capacidade];
            Tamanho = 0;
        }

        public void Inserir(char valor)
        {
            if (Tamanho >= Capacidade) throw new ArgumentException("Lista cheia");

            Elementos[Tamanho++] = valor;
        }

        public void InserirNaPosicao(int pos, char valor)
        {
            if (Tamanho >= Capacidade) throw new ArgumentException("Lista cheia");
            if (pos < 0 || pos > Tamanho) throw new ArgumentException("Posição inválida.");

            for(int i = Tamanho; i > pos; i--)
            {
                Elementos[i] = Elementos[i - 1];
            }
            Elementos[pos] = valor;
            Tamanho++;
        }

        public void Remover(int pos)
        {
            if (pos < 0 || pos >= Tamanho) throw new ArgumentException("Posição inválida.");
            for (int i = pos -1; i < Tamanho-1; i++)
            {
                Elementos[i] = Elementos[i + 1];
            }

            Tamanho--;
        }

        public void Exibir()
        {
            if (Tamanho == 0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }
            Console.WriteLine("Lista: ");
            foreach (var item in Elementos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();  
        }
    }
}
