using System;

namespace nouveautes_cs9
{
    record PersonneRecord
    {
        public string nom { get; set; }
        public int age { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + nom + " " + age + " ans.");
        }
    }
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

        public override bool Equals(object obj)
        {
            PersonneClass objetAComparer = (PersonneClass)obj;

            if (nom == objetAComparer.nom && age == objetAComparer.age) return true;
            return false;
            //return base.Equals(obj);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new PersonneRecord() { nom = "Mario", age = 40 };
            var personne2 = personne1 with { nom = "Cristina" };

            //personne1.nom = "Maria";
            personne1.Afficher();
            personne2.Afficher();

            Console.WriteLine(personne1.Equals(personne2));

            /*
             * Types simples (int, float, char...) -> Value Type (valuer)
             * structures -> Value Type (valeur = les valeurs des champs)
             * class -> Reference Type (valeur = adresse de l'objet)
             *
             */

        }
    }
}
