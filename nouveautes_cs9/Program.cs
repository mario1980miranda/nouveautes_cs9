using System;

namespace nouveautes_cs9
{
    /*
    record PersonneRecord
    {
        public string nom { get; init; }
        public int age { get; init; }

        public PersonneRecord(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public void Deconstruct(out string nom, out int age)
        {
            nom = this.nom;
            age = this.age;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + nom + " " + age + " ans.");
        }
    }
    */
    /* Immutable */
    record PersonneRecord(string nom, int age);

    record PersoneRecordAffichage    : PersonneRecord
    {
        public PersoneRecordAffichage(string nom, int age) : base(nom, age)
        {

        }

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
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new PersoneRecordAffichage("Mario", 20);
            var personne2 = personne1 with { nom = "Cristina" };

            var (nom, age) = personne1;

            personne1.Afficher();
            personne2.Afficher();

            Console.WriteLine(nom);
            Console.WriteLine(age);

            /*
             * Types simples (int, float, char...) -> Value Type (valuer)
             * structures -> Value Type (valeur = les valeurs des champs)
             * class -> Reference Type (valeur = adresse de l'objet)
             * List<string> -> Reference Type (valeur = adresse de l'objet)
             */

        }
    }
}
