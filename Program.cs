using System;
using System.Linq;
using System.IO;

namespace C_
{
    class Program
    {
        
      static void Main(string[] args) 
        {
          string fileName = "example.txt" // Existing text.
          // Menu prompt.
          Console.WriteLine("Please Enter 1 or 2 for options, 3 for termination:");
          option = Console.WriteLine;

          if (option == 1) {
            Console.WriteLine("Please Enter a file name:");
            string userFile = Console.WriteLine;
            file.WriteAllText(fileName, userFile) // Store added file name.

          } else if (option == 2 && File.Exists(fileName) ) {
            Console.WriteLine("Please Enter a string:");
            string userString = Console.ReadLine();

            string[] userStringArray = userString.Split(" ");
            for (int pos = 0; pos < userStringArray.Length; pos++)
            {
                File.WriteAllText(fileName, userStringArray[pos]);
                Console.WriteLine(userStringArray[pos]);

            } else { // If file name doen't match prompts "File does not exist!".
              Console.WriteLine("File does not exist!");
            }
            else if ( option == 3) {
              Console.WriteLine("Program end!");
              return;  // Terminates the loop.
            }
            while (userChoice != "3"); // While loop.
          }
        }
        
    }
}
