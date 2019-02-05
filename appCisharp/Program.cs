using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {

    class Program {

        static void Main(string[] args) {

            char[] array1 = { 's', 'a', 'm' };
            char[] array2 = new char[] { 's', 'a', 'm' };
            char[] array3 = new char[3];
            array3[0] = 's';
            array3[1] = 'a';
            array3[2] = 'm';
            Console.WriteLine(array1.Length + array2.Length + array3.Length);

            int addition = 2 + 8;
            Console.WriteLine(addition);

            //Je lui donne la ville où je travaille
            string codePostal = "69500";
            string ville = "Bron";
            string adresse = codePostal + " " + ville; // Concaténation de mes deux variables.
            Console.WriteLine(adresse);

            //Je calcule pour arriver à mon âge
            int age1 = 5;
            int age2 = 5;
            int moyenne = (age1 + age2) * 2 + 3; 
            // J'additionne deux chiffres, je multi le résultats par 2 et j'ajoute 3.
            Console.WriteLine(moyenne);

            //Phrase de présentation
            string presentation = "Mon prénom est \"Faresse\"";
            Console.WriteLine(presentation);

            //Permet de créer des tabulations
            string list = "Liste de mes courses:";
            Console.WriteLine(list);
            Console.WriteLine("\t - Tomates");
            Console.WriteLine("\t - Pommes");

            //Permet d'afficher ce caractère "\"
            string fichier = "C:\\Users\\FaresseT\\Documents\\AppliConsole\\ConsoleApp\\ConsoleApp";
            Console.WriteLine(fichier);

            int i = 10 * 2;
            i++;
            i = i / 2;
            Console.WriteLine(i);
            
            // Vérification du compte
            decimal compteEnBanque = 300;
            bool estCrediteur = (compteEnBanque >= 0);
            if (estCrediteur)
                Console.WriteLine("Votre compte est créditeur");
            else
                Console.WriteLine("Votre compte est débiteur");
        }
    }
}
