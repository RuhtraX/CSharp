using System;

namespace dd_stats
{
    class Program
    {
        static void saiMenor(int[][] plox) {
            int menor, pos1, pos2;
            for(int k = 0; k < 6; k++) {
                menor = plox[k][0];
                pos1 = k;
                pos2 = 0;
                for(int c = 1; c < 4; c++) {
                    if (plox[k][c] < menor) {
                        menor = plox[k][c];
                        pos1 = k;
                        pos2 = c;
                    }
                }
                // Remove o menor
                while (pos2 < 3) {
                    plox[pos1][pos2] = plox[pos1][++pos2];
                }
            }
        }
        static void Main()
        {
            int[][] stats = new int[6][];
            int[] sum = {0,0,0,0,0,0}; // Soma dos atributos
            bool critico;
            int localSum;
            Random rnd = new Random();
            Console.WriteLine("Números gerados:");
            for(int k = 0; k < 6; k++) {
                critico = false;
                localSum = 0;
                stats[k] = new int[4]; // 4 lançamentos para cada atributo
                for(int c = 0; c < 4; c++) {
                    stats[k][c] = rnd.Next() % 6 + 1;
                    Console.Write("{0} ", stats[k][c]);
                    localSum += stats[k][c];
                    if (c == 2 && localSum == 18) {
                        critico = true;
                    }
                }
                if (critico) {
                    stats[k][0] = 8;
                    stats[k][1] = 8;
                    stats[k][0] = 4;
                    stats[k][3] = 1;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            saiMenor(stats);
            // Console.WriteLine("Menores removidos:");
            for(int k = 0; k < 6; k++) {
                for(int c = 0; c < 3; c++) {
                    // Console.Write("{0} ", stats[k][c]);
                    sum[k] += stats[k][c];
                }
                Console.WriteLine("Atributo {0}: {1}", k+1, sum[k]);
            }
        }
    }
}
