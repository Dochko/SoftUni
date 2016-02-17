using System;

namespace HTMLDispatcher
{
    class DispatcherRun
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine(HTMLDispatcher.CreateImage("https://softuni.bg/Content/images/software-university-logo.png",
                "SoftUni Logo", "THIS ... IS ... SOFTWARE UNIVERSITYYYYYY !!!!"));
            Console.WriteLine();

            string url = HTMLDispatcher.CreateURL("https://softuni.bg/", "SoftUni website", "Welcome to SoftUni");
            Console.WriteLine(url);
            Console.WriteLine();

            Console.WriteLine(HTMLDispatcher.CreateInput("comment", "StudentComment", "Enter your comment here"));
        }
    }
}