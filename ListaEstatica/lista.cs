using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstatica
{
    class lista
    {

        string[] valores;
        int limite, inicio, final;

        public lista(int tamanho)
        {

            valores = new string[tamanho];
            limite = tamanho - 1;
            inicio = -1;
            final = -1;

        }
        
        public void inserir(string valor)
        {

            if (final < limite)
            {

                final++;
                valores[final] = valor;

            }
            else
            {

                Console.WriteLine("Lista cheia!");

            }

        }

        public void inserir(string valor, int posicao)
        {

            if (final < limite)
            {

                if ((posicao >= 0) && (posicao <= limite))
                {

                    final++;

                    for (int i = 0; i < (final - posicao); i++)
                    {

                        valores[(final + 1) - i] = valores[final - i];

                    }

                    valores[posicao] = valor;

                }
                else
                {

                    Console.WriteLine("Posição fora da lista!");

                }

            }
            else
            {

                Console.WriteLine("A lista está cheia!");

            }

        }

        public void imprimir()
        {

            for (int i = 0; i <= final; i++)
            {

                Console.WriteLine(valores[i]);

            }


        }


    }
}
