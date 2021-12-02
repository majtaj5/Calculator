using System;
using System.IO;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MainMenuOutPut.ShowMenuOptions();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("0"):
                    //operations.GetCalculationType();
                    Console.WriteLine("menu-Calculator");
                    break;
                case ("1"):
                    Console.WriteLine("menu-SimpleAlgoritms");
                    break;
                case ("2"):
                    Console.WriteLine("menu-working with text");
                    Console.Write("\nWhat operation on the text file you want to perform: ");
                    string selectFileOperation = Console.ReadLine();
                    switch (selectFileOperation)
                    {
                        case "1":
                            WorkingWithFiles workingWithFiles = new WorkingWithFiles();
                            Console.Write("Enter the path of the file to read: ");
                            string pathOfFile = Console.ReadLine();
                            Console.Write("Which line would you like to read ? ");
                            int enterTheLineNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine(workingWithFiles.ReadOneLineOfTextFile(pathOfFile, enterTheLineNumber));
                            break;
                        default:
                            Console.WriteLine("You entered wrrong number.");
                            break;
                    }
                    break;
            }       
        }
    }
}
