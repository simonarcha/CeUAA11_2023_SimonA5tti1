using System;
using System.Collections.Generic;
using System.Text;

namespace CeUAA11_2023_SimonA5tti1
{
    public struct MesOutils
    {
        public void matVigenere(String[] args)
        {

            string matVigenere = new string[4, phClaire.Length];
            int j;
            int[] phClaire;
            int[] phClef;
            j = 0;
            for (int i = 0; i <= phClaire.Length - 1; i += (1))
            {
                matVigenere[0, 1] = phClaire[i];
                if (phClef.GetLength())
                {
                    j = 0;
                }
                matVigenere[1, i] = phClef[j];
                matVigenere[2, i] = ((int)phClef[j]) - 65.ToString();
                if ((int)phClaire[i] + int.Parse(matVigenere[2, 1]) <= 90)
                {
                    codeAscii = (int)char.Parse(matVigenere[0, i]) + int.Parse(matVigenere[2, i]);
                }
                else
                {
                    codeAscii = (int)char.Parse(matVigenere[0, i]) + int.Parse(matVigenere[2, i]) - 26;
                }
                matVigenere[3, i] = Convert.ToChar(code.Ascii).ToString();
                j = j + 1;
            }
        }

        public static void matAffine(String[] args out)
        {

            int[,] matAffine = new int;
            string a;
            string b;
            int[,] phClaire;
            matAffine = new string[4, phClaire.GetLength()];
            for (int i = 0; i <= phClaire.GetLength() - 1; i += (1))
            {
             matAffine[0, 1] = phClaire[i];

             int x = phClaire[i] - 65;
             matAffine[1, i] = x;

             int y = (a * x + b) % 26;
             matAffine[2, 1] = y;
             matAffine[3, 1] = y + 65;
            }
        }
    }
}