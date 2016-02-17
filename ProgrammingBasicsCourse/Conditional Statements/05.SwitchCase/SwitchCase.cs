using System;

class SwitchCase
{
    static void Main()
    {
        //Console.WriteLine("Enter a character:");
        //char ch = (char)Console.Read();

        //switch(ch)
        //{
        //    case 'A':
        //    case 'a':
        //        Console.WriteLine("Vowel [ei]");
        //        break;
        //    case 'E':
        //    case 'e':
        //        Console.WriteLine("Vowel [i:]");
        //        break;
        //    case 'I':
        //    case 'i':
        //        Console.WriteLine("Vowel [ai]");
        //        break;
        //    case 'O':
        //    case 'o':
        //        Console.WriteLine("Vowel [ou]");
        //        break;
        //    //its working with brackets too
        //    case 'U':
        //    case 'u':
        //        {
        //            Console.WriteLine("Vowel [ju]");
        //            break;
        //        }
        //    default:
        //        {
        //            Console.WriteLine("Consonant.");
        //            break;
        //        }
        //}

        Console.WriteLine("Please enter an animal: ");
        string animal = Console.ReadLine();

        switch (animal)
        {
            case "dog":
            case "cat":
            case "cow":
                Console.WriteLine("Mammal.");
                break;
            case "crocodile":
            case "snake":
                Console.WriteLine("Reptile.");
                break;
            case "tortoise":
                Console.WriteLine("Amphibian.");
                break;
            case "hawk":
            case "sparrow":
            case "dove":
                Console.WriteLine("Bird.");
                break;
            case null:
                Console.WriteLine("null ?");
                break;
            default:
                Console.WriteLine("No such animal is listed here." +
                    "Try with dog, cat, cow, crocodile, snake, " +
                    "tortoise, hawk, sparrow or dove.");
                break;
        }
    }
}