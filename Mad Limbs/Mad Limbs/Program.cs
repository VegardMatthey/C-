using System;
using System.Threading.Tasks.Dataflow;

namespace Mad_Limbs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Are you ready for a game of Mad Libs? : ");
            Console.ReadLine();
            Console.WriteLine("\nStart!");
            

            Console.Write("Write an adjective : ");
            string Adjective1 = Console.ReadLine();

            Console.Write("Write a noun : ");
            string Noun1 = Console.ReadLine();

            Console.Write("Write plural noun : ");
            string PluralNoun1 = Console.ReadLine();

            Console.Write("Write a female name : ");
            string FemaleName1 = Console.ReadLine();

            Console.Write("Write an adjective : ");
            string Adjective2 = Console.ReadLine();

            Console.Write("Write a article of clothing : ");
            string ArticleOfClothing1 = Console.ReadLine();

            Console.Write("Write a noun : ");
            string Noun2 = Console.ReadLine();

            Console.Write("Write a city : ");
            string City1 = Console.ReadLine();

            Console.Write("Write a plural noun : ");
            string PluralNoun2 = Console.ReadLine();

            Console.Write("Write an adjective : ");
            string Adjective3 = Console.ReadLine();

            Console.Write("Write a part of the body : ");
            string BodyPart1 = Console.ReadLine();

            Console.Write("Write a letter of the alphabet : ");
            string Letter1 = Console.ReadLine();

            Console.Write("Write a celebrity : ");
            string Celebrity1 = Console.ReadLine();

            Console.Write("Write a plural noun : ");
            string PluralNoun3 = Console.ReadLine();

            Console.Write("Write an adjective : ");
            string Adjective4 = Console.ReadLine();

            Console.Write("Write a place : ");
            string Place1 = Console.ReadLine();

            Console.Write("Write a part of the body : ");
            string BodyPart2 = Console.ReadLine();

            Console.Write("Write an adjective : ");
            string Adjective5 = Console.ReadLine();

            Console.Write("Write an adjective : ");
            string Adjective6 = Console.ReadLine();

            Console.Write("Write a verb : ");
            string Verb1 = Console.ReadLine();

            Console.Write("Write a plural Noun : ");
            string PluralNoun4 = Console.ReadLine();

            Console.Write("Write an number : ");
            string Num1 = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("There are many " + Adjective1 + " ways to choose a/an " + Noun1 + " to read");
            Console.WriteLine("First you could ask for recommendations from your friends and " + PluralNoun1 + ".");
            Console.WriteLine("Just Do'nt ask Aunt " + FemaleName1 + " she only reads " + Adjective2 + " books with " + ArticleOfClothing1 + "-ripping goddesses on the cover.");
            Console.WriteLine("If your friends and family are no help, try checking out the " + Noun2 + "  Review in The " + City1 + " Times.");
            Console.WriteLine("If the " + PluralNoun2 + " featured there are too " + Adjective3 + " for your taste, try something a little more low-" + BodyPart1 + ", like " + Letter1 + ": The " + Celebrity1 + " Magazine, or " + PluralNoun3 + " Magazine.");
            Console.WriteLine("You could also choose a book the " + Adjective4 + "-fashioned way.");
            Console.WriteLine("Head to your local Library or " + Place1 + " and browse the shelves until something cathches your " + BodyPart2 + ".");
            Console.WriteLine("Or, you could save yourself a whole lot of " + Adjective5 + " trouble and log on www.bookish.com, the " + Adjective6 + " new website to " + Verb1 + " for books!");
            Console.WriteLine("With all the time you'll save not having to serch for " + PluralNoun4 + ", you can read " + Num1 + " more books!");
           

            Console.ReadLine();

        }
    }
}
