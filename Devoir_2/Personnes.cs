using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Personnes
{
    private string nom;
    private string prenom;
    private int age;
    private char sexe;
    private string adresse;
    private string telephone;

    // Constructeur par défaut
    public Personnes() => Console.WriteLine("Vous n'avez pas de nom, prenom, age, adresse, et meme un numero");

    // Constructeur avec tous les attributs en argument
    public Personnes(string nom, string prenom, int age, char sexe, string adresse, string telephone)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
        Sexe = sexe;
        Adresse = adresse;
        Telephone = telephone;
    }

    #region Constructors
    public Per

    // Méthodes Getter et Setter pour chaque attribut
    public string Nom
    {
        get { return nom; }
        set { nom = value.Trim()[..1].ToUpper()+value[1..].ToLower(); }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value.Trim()[..1].ToUpper() + value[1..].ToLower(); }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value <= 100)
                age = value;
            else
                Console.WriteLine("L'âge doit être compris entre 1 et 100.");
        }
    }

    public char Sexe
    {
        get { return sexe; }
        set { sexe = value; }
    }

    public string Adresse
    {
        get { return adresse; }
        set { adresse = value.Trim()[..1].ToUpper() + value[1..].ToLower(); }
    }

    public string Telephone
    {
        get { return telephone; }
        set { telephone = value; }
    }

    // Méthode pour afficher les informations de la personne
    public void Afficher()
    {
        Console.WriteLine($"{Nom} {Prenom} {Age} {Sexe} {Adresse} {Telephone}");

    }
}


