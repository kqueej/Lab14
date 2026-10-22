using System.IO;
class Program
{
    static void Main()
    {
        void CopyFileManually(string sourcePath, string destinationPath)
        {
            using (StreamReader reader = new StreamReader(sourcePath))
            using (StreamWriter writer = new StreamWriter(destinationPath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }
        }

        File.WriteAllText("source.txt", "First line\nSecond line\nThird line");

        CopyFileManually("source.txt", "destination.txt");

        Console.WriteLine("Source file:");
        Console.WriteLine(File.ReadAllText("source.txt"));

        Console.WriteLine("Copied file:");
        Console.WriteLine(File.ReadAllText("destination.txt"));
    }
}
