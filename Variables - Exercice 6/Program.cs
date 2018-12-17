using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, prenom;
            int annee;

            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            prenom = Console.ReadLine();
            Console.WriteLine("Quelle est votre année de naissance ?");
            annee = int.Parse(Console.ReadLine());

            Console.WriteLine("Fiche de renseignements:" + Environment.NewLine + "Nom: " + nom + Environment.NewLine +
                "Prénom: " + prenom + Environment.NewLine + "Age: " + (DateTime.Now.Year - annee));
        }
    }
}
