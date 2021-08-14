using System;

namespace nouveautes_cs9
{
    struct PersonneStruct
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + nom + " " + age + " ans.");
        }
    }
    class PersonneClass
    {
        public string nom { get; set; }
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
            var personne1 = new PersonneStruct() { nom = "Mario", age = 40 };
            var personne2 = personne1;

            personne1.nom = "Cristina";

            //personne1.nom = "Maria";
            personne1.Afficher();
            personne2.Afficher();

        }
    }
}
