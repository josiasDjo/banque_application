using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLs
{
    internal class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "chemin\\vers\\lc.exe",
                        Arguments = "arg1 arg2",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = Process.Start(startInfo))
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        Console.WriteLine($"Output: {output}");
                        Console.WriteLine($"Error: {error}");
                        Console.WriteLine($"Exit Code: {process.ExitCode}");

                        if (process.ExitCode != 0)
                        {
                            // Log or handle the error
                            throw new Exception($"lc.exe a échoué avec le code de sortie {process.ExitCode}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Une erreur est survenue : {ex.Message}");
                }          
        }
    }
}
