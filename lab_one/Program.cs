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
                                {"A) .Net Core is a cross platform application development framework", "B) ", "C) ", "D) " },
                                {"A) ", "B) ", "C) ", "D) Visual Studio , Dotnet CLI" },
                                {"A) ASP.NET Core 1.0 is the next version of ASP.NET. It is open source and cross-platform framework", "B) ", "C) ", "D) " },
                                {"A) Kestrel is a cross-platform web server for ASP.NET Core based on libuv, a cross-platform asynchronous I/O library.", "B) ", "C) ", "D) " },
                                {"A) ", "B) ", "C) ASP.NET Core ships two server implementations Kestral and WebListener.", "D) " },
                                {"A) ASP.NET Core Module (ANCM) lets you run ASP.NET Core applications behind IIS and it works only with Kestrel; it isn’t compatible with WebListener.", "B) ", "C) ", "D) " },
                                {"A) ASP.NET Core apps require a host in which to execute. The host is responsible for application startup and lifetime management.", "B) ", "C) ", "D) " },
                                    };
            int primer;
            int EXIT = 2; //Sentinel Value

            int totalCorrect = 0, totalIncorrect = 0;

            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions. ");
            Console.WriteLine("You must have 2 out of 3 correct to pass the quiz");
            Console.WriteLine("To get started, please enter 1 to start the program");

            primer = Convert.ToInt32(Console.ReadLine());
            while (primer != EXIT)
            {
                for (int x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);
                    for (int y = 0; y < optionChoices.Length; y++)
                    {
                        Console.WriteLine(optionChoices[x,y]);
                    }
                    Console.WriteLine("Please enter your selection");
                    userSelection = Console.ReadLine();
                    if (userSelection == answerKey[x])
                    {
                        totalCorrect++;
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("Incorrect");
                    }
                    userChoices[x] = userSelection;
                }
                Console.WriteLine("The quiz has concluded, your results are listed below");
                Console.WriteLine($"Total Correct :", totalCorrect);
                Console.WriteLine($"Total Incorrect :", totalIncorrect);

                if (totalCorrect >= 7)
                {
                    Console.WriteLine("You passed the quiz");
                }
                else
                {
                    Console.WriteLine("Sorry you failed");
                }

                Console.WriteLine("To retake the quiz, press 1 - To exit, press 2");
                primer = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Program has concluded. Thank you for taking the .NET Core Quiz");
        }
    }
}