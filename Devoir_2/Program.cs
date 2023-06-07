
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Création du tableau pour stocker les objets de type "Personne"
                Personnes[] personnes = new Personnes[2];

            for (int i = 0; i < personnes.Length; i++)
            {
                Console.WriteLine("Entrez les informations pour la personne {0} :", i + 1);
                Console.Write("Nom: ");
                string nom = Console.ReadLine();
                Console.Write("Prénom: ");
                string prenom = Console.ReadLine();


                string age = Convert.ToString(Age());


                Console.Write("Sexe: ");
                char sexe = char.Parse(Console.ReadLine());
                Console.Write("Adresse: ");
                string adresse = Console.ReadLine();
                Console.Write("Téléphone: ");
                string telephone = Console.ReadLine();


                Personnes p = new Personnes(nom, prenom, Convert.ToInt16(age), sexe, adresse, telephone);


                personnes[i] = p;
            }

            // Persistez le tableau d'objets dans un fichier "personnes.txt"
            using (StreamWriter writer = new StreamWriter("personnes.txt"))
            {
                foreach (Personnes p in personnes)
                {
                    writer.WriteLine("{0};{1};{2};{3};{4};{5}", p.Nom, p.Prenom, p.Age, p.Sexe, p.Adresse, p.Telephone);
                }
            }

            // Lire le contenu du fichier et l'afficher sur la Console
            using (StreamReader reader = new StreamReader("personnes.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Personnes p = new Personnes(parts[0], parts[1], int.Parse(parts[2]), char.Parse(parts[3]), parts[4], parts[5]);
                    Console.WriteLine();

                    p.Afficher();
                }
            }

            // Ajout de deux personnes supplémentaires dans le fichier sans effacer les informations existantes.
            Console.WriteLine("\nAjout de deux personnes supplémentaires : ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Nom {i + 1}: ");
                string nom = Console.ReadLine();
                Console.Write($"Prénom {i + 1}: ");
                string prenom = Console.ReadLine();
                Console.Write($"Âge {i + 1}: ");
                int age = Age();
                Console.Write($"Sexe {i + 1}: ");
                char sexe = char.Parse(Console.ReadLine());
                Console.Write($"Adresse {i + 1}: ");
                string adresse = Console.ReadLine();
                Console.Write($"Téléphone {i + 1}: ");
                string telephone = Console.ReadLine();


                Personnes p = new Personnes(nom, prenom, age, sexe, adresse, telephone);

                // Ajout de l'objet "Personne" dans le fichier
                using (StreamWriter writer = new StreamWriter("personnes.txt", true))
                {
                    writer.WriteLine($"{p.Nom};{p.Prenom};{p.Age};{p.Sexe};{p.Adresse};{p.Telephone}");
                }
            }

            Console.WriteLine();


            // Lire à nouveau le contenu du fichier et l'afficher sur la Console
            Console.WriteLine("\nContenu du fichier après ajout de deux personnes supplémentaires : \n");
            using (StreamReader reader = new StreamReader("personnes.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] listValues = line.Split(';');
                    Personnes p = new(listValues[0], listValues[1], int.Parse(listValues[2]), char.Parse(listValues[3]), listValues[4], listValues[5]);
                    p.Afficher();
                }
            }

            Console.ReadKey();
        }


        public static int Age()
        {
            Console.Write("Âge: ");
            int age = int.Parse(Console.ReadLine());
            while (true)
            {
                if (age < 0 || age > 100)
                {
                    Console.Write("Âge: ");
                    age = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            return age;



        }






    }



}