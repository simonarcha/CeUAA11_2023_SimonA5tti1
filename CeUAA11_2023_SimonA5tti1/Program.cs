using System;

namespace CeUAA11_2023_SimonA5tti1
{
    class Program
    {
        static void Main(string[] args)
        {
            MesOutils MesOutils = new MesOutils();
            bool suivi = true;
            while (suivi)
            {
                Console.WriteLine("Bienvenue dans mon programme de Matrice !");
                Console.WriteLine("Tapez 1 pour crypter une matrice avec la manière de Vigenère");
                Console.WriteLine("Tapez 2 pour crypter une matrice avec la méthode du chiffre affine");
                Console.WriteLine("Tapez 3 pour quitter");
                String choix = Console.ReadLine();
                {
                    case "1":            
                        string matVigenere;
                        int j;
                        int[] phClaire;
                        int[] phClef;
                        Console.Write("Veuillez saisir une phrase a crypter");
                        int phClaire = Console.ReadLine();
                        Console.WriteLine(phClaire);
                    OutOfMemoryException matVigenere;
                    break;
                    case "2":
                        String a = "";
                        String b = "";
                        int[,] x;
                        int[,] y;
                        int[,] phClaire;
                        Console.Write("Veuillez saisir un chiffre impaire entre 0 et 25 (13 exclu)");
                        String a = Console.ReadLine();
                        Console.WriteLine(a);
                        Console.Write("Veuillez saisir un chiffre entre 0 et 25");
                        String b = Console.ReadLine();
                        Console.WriteLine(b);
                        MesOutils.matAffine(String[] args out);
                        break;
                    case "3":
                        suivi = false;
                        break;
                    default:
                        Console.WriteLine("Option non valide");
                        break;
                }
            }
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
