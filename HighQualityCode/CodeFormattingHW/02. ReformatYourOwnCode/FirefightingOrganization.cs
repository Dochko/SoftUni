//using System;

//class FirefightingOrganization
//{
//    static void Main()
//    {
//        int fireFighter = int.Parse(Console.ReadLine());
//        int kidsSaved = 0;
//        int seniorSaved = 0;
//        int adultsSaved = 0;
//        int fireFightersLeft = fireFighter;

//        for (int i = 0; i < 50; i++)
//        {
//            string pplToSave = Console.ReadLine();

//            if (pplToSave == "rain")
//            {
//                break;
//            }


//            for (int j = 0; j < pplToSave.Length; j++)
//            {
//                if (pplToSave[j] == 'K')
//                {
//                    if (fireFightersLeft == 0)
//                    {
//                        break;
//                    }
//                    kidsSaved++;
//                    fireFightersLeft--;
//                }
//            }

//            if (fireFightersLeft > 0)
//            {


//                for (int j = 0; j < pplToSave.Length; j++)
//                {
//                    if (pplToSave[j] == 'A')
//                    {
//                        if (fireFightersLeft == 0)
//                        {
//                            break;
//                        }
//                        adultsSaved++;
//                        fireFightersLeft--;
//                    }
//                }
//            }

//            if (fireFightersLeft > 0)
//            {
//                for (int j = 0; j < pplToSave.Length; j++)
//                {
//                    if (pplToSave[j] == 'S')
//                    {
//                        if (fireFightersLeft == 0)
//                        {
//                            break;
//                        }
//                        seniorSaved++;
//                        fireFightersLeft--;
//                    }
//                }
//            }

//            fireFightersLeft = fireFighter;
//        }

//        Console.WriteLine("Kids: {0}", kidsSaved);
//        Console.WriteLine("Adults: {0}", adultsSaved);
//        Console.WriteLine("Seniors: {0}", seniorSaved);
//    }
//}