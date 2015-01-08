using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace BiblioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessManager bm = new BusinessManager();
            String choix;
            do
            {
                Console.WriteLine("Tapez le code voulu :");
                Console.WriteLine("1 - Affichez la liste des auteurs.");
                Console.WriteLine("2 - Affichez la liste des emprunts en cours.");
                Console.WriteLine("3 - Affichez la liste des auteurs ayant un prix Goncourt.");
                Console.WriteLine("4 - Affichez la liste des livres ayant une note supérieure à 5.");
                Console.WriteLine("5 - Affichez la liste des livres dont l'auteur a eu un prix Goncourt et dont la note est supérieure à 5.");
                Console.WriteLine("0 - Quittez.");
                Console.Write("Votre choix : ");
                choix = Console.ReadLine();
                while (choix != "0" && choix != "1" && choix != "2" && choix != "3" && choix != "4" && choix != "5")
                {
                    Console.Write("Votre choix n'est pas correct ; réitérez : ");
                    choix = Console.ReadLine();
                }

                Console.WriteLine();

                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Résultat : ");
                        foreach(String auteur in bm.getAllAuteurs())
                        {
                            Console.WriteLine(auteur);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Résultat : ");
                        foreach (String emprunt in bm.empruntsEnCours())
                        {
                            Console.WriteLine(emprunt);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Résultat : ");
                        foreach(String auteur in bm.auteursPrixGoncourt())
                        {
                            Console.WriteLine(auteur);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Résultat : ");
                        foreach (String livre in bm.livresNoteSup5())
                        {
                            Console.WriteLine(livre);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Résultat : ");
                        foreach (String livre in bm.livresPrixNoteSup5())
                        {
                            Console.WriteLine(livre);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                }

            } while (choix != "0");
        }
    }
}
