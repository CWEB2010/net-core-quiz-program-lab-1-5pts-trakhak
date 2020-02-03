using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] userChoices = new string[10];
            string userSelection;
            string[] questions =
                { "What year was .NET Core was created?" ,
                "What is the latest version of .NET Core?" ,
                "Who created.NET Core?",
                "What is .NET Core?",
                "What are two ways to create a new ASP.Net core project?",
                "What is ASP.NET Core?",
                "What is Kestral?",
                "What is WebListener?",
                "What is ASP.NET Core Module (ANCM)?",
                "What is a Host and what’s the importance of Host in ASP.NET Core application?"}
                ;
            string[,] optionChoices = {
                                    { "A) 2007", "B) 2014", "C) 1994", "D) 2022" },
                                    { "A) 1.2", "B) 3.2", "C) 10", "D) 2.2"},
                                    { "A) Google", "B) FaceBook", "C) Microsoft", "D) Dunwoody"},
                                    {"A) .Net Core is a cross platform application development framework", "B) .Net core is a bad application", "C) the right AnSwEr", "D) .net core has been used for decades" },
                                    {"A) Microsoft Doc", "B) Outlook", "C) Fortnite", "D) Visual Studio , Dotnet CLI" },
                                    {"A) ASP.NET Core 1.0 is the next version of ASP.NET. It is open source and cross-platform framework", "B) ASP.NET CORE 3.02", "C) ASP.NET closed source", "D) single-platefrom framework" },
                                    {"A) Kestrel is a cross-platform web server for ASP.NET Core based on libuv, a cross-platform asynchronous I/O library.", "B) Kettlebell", "C) GoDaddy", "D) Instagram" },
                                    {"A) ASP.NET Core doesnt do anything", "B) ASP.NET Core is amazing", "C) ASP.NET Core ships two server implementations Kestral and WebListener.", "D) DOTNET CORE is a real thing" },
                                    {"A) ASP.NET Core Module (ANCM) lets you run ASP.NET Core applications behind IIS and it works only with Kestrel; it isn’t compatible with WebListener.", "B) ASP.NET doesnt work with anything", "C) ASP.NET works on everhthing", "D) both B and C" },
                                    {"A) ASP.NET Core apps require a host in which to execute. The host is responsible for application startup and lifetime management.", "B) running goDaddy", "C) running NBA games", "D) both A and D" },
                                    };
            int primer;
            int EXIT = 2; //Sentinel Value

            int totalCorrect = 0, totalIncorrect = 0;
            //printed text
            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 10 questions. ");
            Console.WriteLine("You must have 7 out of 10 correct to pass the quiz");
            Console.WriteLine("To get started, please enter 1 to start the program");
            //press 1 to start the program
            primer = Convert.ToInt32(Console.ReadLine());
            //prints questions and choices
            while (primer != EXIT)
            {
                for (int x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);

                    for (int y = 0; y < optionChoices.GetLength(1); y++)
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }
                    // enter user choice
                    Console.WriteLine("Please enter your selection");
                    userSelection = Console.ReadLine();
                    //decide if correct or incorrect

                    if (userSelection.ToUpper() == answerKey[x])
                    {
                        totalCorrect++;
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("Incorrect");
                    }
                    //userSelection.ToUpper() == userChoices[x];

                }
                Console.WriteLine("The quiz has concluded, your results are listed below ");
                Console.WriteLine($"Total Correct : {totalCorrect}");
                Console.WriteLine($"Total Incorrect : {totalIncorrect}");

                if (totalCorrect >= 7)
                {
                    Console.WriteLine("You passed the quiz");
                }
                else
                {
                    Console.WriteLine("You failed");
                }
                //
                Console.WriteLine("To retake the quiz, press 1 \nto exit, press 2");
                primer = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Program has concluded. Thank you for taking the .NET Core Quiz");
        }
    }
}