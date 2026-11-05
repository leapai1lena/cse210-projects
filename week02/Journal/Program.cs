// Exceeded requirements:

// Added additional custom prompts beyond the required five prompts to enhance the variety of prompts.

// This provides more variety and improves the journal  experience.
 
using System;
 
class Program

{

    static void Main(string[] args)

    {

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();
 
        int choice = 0;
 
        while (choice != 5)

        {

            Console.WriteLine();

            Console.WriteLine("Menu Options:");

            Console.WriteLine("1. Write");

            Console.WriteLine("2. Display");

            Console.WriteLine("3. Load");

            Console.WriteLine("4. Save");

            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
 
            choice = int.Parse(Console.ReadLine());
 
            if (choice == 1)

            {

                string prompt = promptGenerator.GetRandomPrompt();
 
                Console.WriteLine(prompt);

                Console.Write("> ");

                string response = Console.ReadLine();
 
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                entry._promptText = prompt;

                entry._entryText = response;
 
                journal.AddEntry(entry);

            }

            else if (choice == 2)

            {

                journal.DisplayAll();

            }

            else if (choice == 3)

            {

                Console.Write("Enter filename: ");

                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

            }

            else if (choice == 4)

            {

                Console.Write("Enter filename: ");

                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

            }

        }

    }

}
 
