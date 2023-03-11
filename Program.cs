using System;
using System.Collections.Generic;

namespace CollectionsList
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<string> characters = new List<string> { "Harry Potter", "Hermione Granger", "Neville Longbottom", "Ron Weasley", "Ginny Weasley" };

            Console.WriteLine($"There are {characters.Count} characters on the list. Let's see the list before we revise it: ");
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine(characters[i]);
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Let's add a few more characters to the list.");
            string[] charArray = new string[] { "Professor Dumbledore", "Arthur Weasley", "Sirius Black" };
            characters.AddRange( charArray );
            Console.WriteLine($"There are {characters.Count} characters on the list now: ");
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine(characters[i]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Let's organize the list in alphabetical order: ");
            characters.Sort();
            foreach (string c in characters)
            {
                Console.WriteLine(c);
            }
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Let's remove Harry and see who is left: ");
            characters.Remove(characters[2]);
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine(characters[i]);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Let's see the list in reverse: ");
            characters.Reverse();
            foreach (string c in characters)
            {
                Console.WriteLine(c);
            }
        }
    }
}