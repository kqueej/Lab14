using System.IO;
class Program
{
    static void Main()
    {
        string filePath = "attendance.csv";
        string choice;

        do
        {
            Console.WriteLine("1 - Mark student attendance");
            Console.WriteLine("2 - Show student statistics");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");

            choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    Console.Write("Enter student full name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Was the student present? (Yes/No): ");
                    string status = Console.ReadLine() ?? "";

                    string date = DateTime.Now.ToString("dd.MM.yyyy");

                    File.AppendAllText(filePath, $"{name},{date},{status}\n");
                    break;

                case "2":
                    Console.Write("Enter student full name: ");
                    string studentName = Console.ReadLine() ?? "";

                    int present = 0;
                    int absent = 0;
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);

                        foreach (string line in lines)
                        {
                            string[] data = line.Split(',');

                            if (data[0] == studentName)
                            {
                                if (data[2] == "Yes")
                                {
                                    present++;
                                }
                                else if (data[2] == "No")
                                {
                                    absent++;
                                }
                            }
                        }
                        Console.WriteLine($"Present: {present}");
                        Console.WriteLine($"Absent: {absent}");
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("No records yet");
                    }
                    break;

                case "0":
                    break;
            }
            Console.WriteLine();
        }
        while (choice != "0");
    }
}
