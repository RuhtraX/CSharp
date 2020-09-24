using System;

namespace sorteio
{
    class Program
    {
        static void Main()
        {
            int c, l, cs, ls, ts; // Total de colunas, total de linhas, coluna sorteada, linha sorteada, total a ser sorteado
            Random rnd = new Random();
            Console.Write("Número de colunas: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de Linhas: ");
            l = Convert.ToInt32(Console.ReadLine());
            bool[][] m = new bool[l][]; // Matriz dos números sorteados

            int n = 1;
            Console.WriteLine("Matriz do Jogo:");
            int cc, cl; // Contador coluna, contador linha
            for (cl = 0; cl < l; cl++) {
                for (cc = 0; cc < c; cc++)
                {
                    Console.Write("{0,5}",n++);
                }
                m[cl] = new bool[c]; // Adiciona colunas na linha da Matriz
                Console.WriteLine();
            }
            while(true)
            {
                Console.Write("Quantos números serão sorteados? ");
                ts = Convert.ToInt32(Console.ReadLine());
                if (ts < c * l) break;
            }
            int ns = 0; // Total de números sorteados
            Console.WriteLine("Números sorteados:");
            while(ns<ts)
            {
                cs = rnd.Next() % c;
                ls = rnd.Next() % l;
                if (!m[ls][cs])
                {
                    m[ls][cs] = true;
                    n = cs + 1 + ls * c;
                    Console.Write("{0,3}", n);
                    ns++;
                }
            }
            Console.WriteLine("\nMatriz do Jogo:");
            n = 1;
            ns = 0;
            int[] nsc = new int[ts]; // Matriz para números sorteados em ordem crescente
            for (cl=0; cl<l; cl++)
            {
                for (cc=0; cc<c; cc++)
                {
                    if (m[cl][cc])
                    {
                        Console.Write("{0,5}", "X");
                        nsc[ns] = n;
                        ns++;
                    } else
                    {
                        Console.Write("{0,5}", n);
                    }

                    n++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Números sorteados em ordem:");
            foreach(int i in nsc)
            {
                Console.Write("{0,3}", i);
            }
        }
    }
}
