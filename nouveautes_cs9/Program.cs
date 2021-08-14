using System;

namespace nouveautes_cs9
{
    class Personne
    {
        public string nom { get; init; }
        public int age { get; set; }

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

            //personne1.nom = "Maria";
            personne1.Afficher();

            Console.WriteLine(
                    "Le nom de la personne est : " +
                    personne1.nom
                );

            /*
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            */
        }
    }
}
