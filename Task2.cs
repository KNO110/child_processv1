using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выбирай:");
        Console.WriteLine("1. Подождать завершения программы");
        Console.WriteLine("2. Принудительно закрыть программу");

        int choice = int.Parse(Console.ReadLine());

        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Users\\2007n\\Desktop\\Crowbar.exe\""; /// путь к exe-шнику

        if (choice == 1)            ////Ждём когда ты сам закроешь прогу
        {
            process.Start();
            process.WaitForExit();
            Console.WriteLine($"Дочерний процесс завершился с кодом: {process.ExitCode}");
        }
        else if (choice == 2)           ///Принудительно закроет прогу
        {
            process.Start();
            Thread.Sleep(5000);
            process.Kill();
            Console.WriteLine("Дочерний процесс принудительно резанули.");
        }
        else
        {
            Console.WriteLine("Неправильный выбор.");
        }
    }
}
