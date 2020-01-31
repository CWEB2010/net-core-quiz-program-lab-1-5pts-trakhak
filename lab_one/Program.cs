using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
                string[] userChoices = new string[10];
                string userSelection;
                string[] questions =
                    { "What year was .NET Core was created?" ,
                 "What is the latest version of .NET Core?" ,
                "Who created.NET Core?", }
                    ;
                string[,] optionChoices = {
                                     { "A) 2007", "B) 2014", "C) 1994", "D) 2022" },
                                    { "A) 1.2", "B) 3.2", "C) 10", "D) 2.2"},
                                    { "A) Google", "B) FaceBook", "C) Microsoft", "D) Dunwoody"}
                                        };
                int primer;
                int EXIT = 2; //Sentinel Value
                int x, y;
                int totalCorrect = 0, totalCorrect = 0;

                Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions. ");
                Console.WriteLine("You must have 2 out of 3 correct to pass the quiz");
                Console.WriteLine("To get started, please enter 1 to start the program");
            }
    }
}
