using System;
using System.Collections.Specialized;
using System.Threading;
using System.Net;
using System.Diagnostics;

class UsingBuildInDotNetClasses
{
    static void Main()
    {

        ////Static .NET classes
        //DateTime today = DateTime.Now;
        //Console.WriteLine("Today is: " + today);
        //DateTime tomorrow = today.AddDays(1);
        //Console.WriteLine("Tomorrow is: " + tomorrow);
        //const string DateFormat = "dd.MM.yyyy г.";
        //Console.WriteLine(today.ToString(DateFormat));

        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //Console.BackgroundColor = ConsoleColor.White;
        //Console.WriteLine();

        //double angleDegrees = 60;
        //double angleRadians = angleDegrees * Math.PI / 180;
        //Console.WriteLine("Cos(60 degrees): " + Math.Cos(angleRadians));
        //Console.WriteLine();

        ////Non-static .NET classes
        //Random rnd = new Random();
        //int randomNumber = rnd.Next(1, 100);
        //Console.WriteLine("Randon number for you: " + randomNumber);
        //Console.WriteLine();

        ////Downloading a PDF file from Internet (System.Net.Webclient)
        //// It will give exception if the file already exist
        //string url = "http://www.introprogramming.info/wp-content/uploads/2013/07/Books/CSharpEn/Fundamentals-of-Computer-Programming-with-CSharp-Nakov-eBook-v2013.pdf";
        //string localFileName = "CSharp-Book-Nakov.pdf";
        //Console.WriteLine("Downloading {0}...", url);
        //WebClient webClient = new WebClient();
        //webClient.DownloadFile(url , localFileName);

        ////Opeh the downloaded PDF file (System.Diagnostics.Process)
        //Process.Start(localFileName);


        Random rnd = new Random();
        Thread.Sleep(1000);
        Random rnd2 = new Random();
        Console.WriteLine("First number - {0}\nSecond Number - {1}"
        , rnd.Next(1 , 99), rnd2.Next(1 , 99));

        string str = new string('a', 2);
        Console.WriteLine(str);


    }
}