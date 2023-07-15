using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
        // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            string [] questions = {"The CERN Large Hadron Collider has discovered the existence of the Higgs boson particle.", "The Sistine Chapel in Vatican City was painted by Leonardo da Vinci.", "Mount Kilimanjaro, located in Tanzania, is the highest mountain in Africa.", "Marie Curie discovered the element radium.", "The Great Wall of China is visible from space."};
            bool [] answers = {true, false, true, true, false};
            bool [] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Length of question array does not equal to length of answer array");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;

            }

            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine(scoringIndex + 1 + $". Input: {response} | Answer: {answer}");

                if (responses[scoringIndex] == answers[scoringIndex])
                {
                    score++;
                }


                scoringIndex ++;
            }

            Console.WriteLine($"You got {score} out of 5 correct");
        
        }
    }
}

