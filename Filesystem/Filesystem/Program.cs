using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to: Read From a Text File

            // Example #1
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"E:\Lab\Microsoft\DotNet\Git\Filesystem\Filesystem\Filesystem\test.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of test.txt = {0}\n", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"E:\Lab\Microsoft\DotNet\Git\Filesystem\Filesystem\Filesystem\test.txt");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Contents of test2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
