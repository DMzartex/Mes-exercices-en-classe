using System;

namespace CategorieSelonLage
{
    class Program
    {


        static void CategorieSportive(int age, out string categorie)
        {


            

            if(age > 0 && age < 130)
            {
                if(age == 6 || age == 7)
                {
                    categorie = " Vous êtes en Poussin !";
                }
                else if(age == 8 || age == 9 )
                {
                    categorie = " Vous êtes en Pupille !";
                }else if(age == 10 || age == 11)
                {
                    categorie = "Vous êtes en Minime !";
                }else if(age >= 12 && age <= 14)
                {
                    categorie = "Vous êtes en Cadet !";
                }
                else
                {
                    categorie = "Aucune categorie !";
                }
            }
            else
            {
                categorie = "Vous n'avez pas l'age";
            }
           
        }

        static void Main(string[] args)
        {
            int age=0;
            string categorie;

            
            Console.WriteLine("Entrez votre age svp : ");
            age = int.Parse(Console.ReadLine());
            CategorieSportive(age, out categorie);
            Console.WriteLine(categorie);

            Console.ReadLine();
        }

       
    }
}
