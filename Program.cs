using System.IO;

namespace Class02File
{
    public class Program
    {
        public static void Main()
        {
            FileManager dataManager = new FileManager();
           
            string filename = "grades.txt";

            // menu
            string menu;
            do
            {
                Console.WriteLine("1. Write data to file");
                Console.WriteLine("2. Read data from file");
                Console.WriteLine("3. Exit");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    dataManager.Write(filename);
                }
                else if (menu == "2")
                {
                    dataManager.Read(filename);
                }

            } while (menu != "3");
        }
    }
}