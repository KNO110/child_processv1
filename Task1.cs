using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "\"C:\\Users\\2007n\\Desktop\\Crowbar.exe\"";  ///путь к exe-шнику

        using (Process process = Process.Start(startInfo))
        {
            process.WaitForExit();
            int exitCode = process.ExitCode;
            Console.WriteLine($"Дочерний процесс закончился с кодом: {exitCode}");
        }
    }
}
