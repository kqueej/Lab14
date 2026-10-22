// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         string diaryPath = "diary.txt";
//         string choice;

//         do
//         {
//             Console.WriteLine();
//             Console.WriteLine("1 - Add an entry");
//             Console.WriteLine("2 - Show all entries");
//             Console.WriteLine("3 - Clear diary");
//             Console.WriteLine("0 - Exit");
//             Console.Write("Choose an option: ");

//             choice = Console.ReadLine() ?? "";

//             try
//             {
//                 switch (choice)
//                 {
//                     case "1":
//                         Console.Write("Enter your entry: ");
//                         string entry = Console.ReadLine() ?? "";

//                         using (StreamWriter writer = new StreamWriter(diaryPath, true))
//                         {
//                             writer.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm}] {entry}");
//                         }

//                         break;

//                     case "2":
//                         if (File.Exists(diaryPath))
//                         {
//                             using (StreamReader reader = new StreamReader(diaryPath))
//                             {
//                                 string? line;
//                                 int number = 1;

//                                 while ((line = reader.ReadLine()) != null)
//                                 {
//                                     Console.WriteLine($"{number}. {line}");
//                                     number++;
//                                 }
//                             }
//                         }
//                         else
//                         {
//                             Console.WriteLine("The diary is empty");
//                         }

//                         break;

//                     case "3":
//                         if (File.Exists(diaryPath))
//                         {
//                             File.Delete(diaryPath);
//                         }

//                         Console.WriteLine("The diary has been cleared");
//                         break;
//                 }
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"File operation error: {ex.Message}");
//             }
//         }
//         while (choice != "0");
//     }
// }