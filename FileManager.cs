namespace Class02File
{
    public class FileManager
    {
        public void Write(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, true);

            Console.WriteLine("Enter a course");
            var course = Console.ReadLine();

            Console.WriteLine("Enter a grade");
            var grade = Console.ReadLine();

            sw.WriteLine($"{course}|{grade}");

            sw.Close();

        }

        public void Read(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);

                sr.ReadLine();
                while (sr.EndOfStream != true)
                {
                    var line = sr.ReadLine();
                    Console.WriteLine($"Your line is {line}");

                    // parse the line to retrieve the grade
                    var lineArray = line.Split('|');

                    Console.WriteLine($"Course: {lineArray[0]}, Grade: {lineArray[1]}");
                }
            }
        }
    }
}