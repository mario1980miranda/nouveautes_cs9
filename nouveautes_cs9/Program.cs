using System;

namespace nouveautes_cs9
{
    class Personne
    {
        public string nom;
        public int age;

        public void Afficher()
        {
            Console.WriteLine("Nom : " + nom + " " + age + " ans.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne() { nom = "Mario", age = 40 };

            personne1.nom = "Maria";
            personne1.Afficher();

            /*
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            */
        }
    }
}
