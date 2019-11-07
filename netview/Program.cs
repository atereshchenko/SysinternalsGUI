using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace netview
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                if (args.Length == 0)
                {
                    System.Console.WriteLine("Enter the ip address of the remote computer or enter /?");
                    return;
                }
                else
                {
                    switch (args[0])
                    {
                        case "/?":
                            System.Console.WriteLine(Environment.NewLine);
                            System.Console.WriteLine(String.Format("Copyright (c) 2016 Alexey Tereshchenko"));
                            System.Console.WriteLine(String.Format("Description:"));
                            System.Console.WriteLine(String.Format("\tOverloaded method OPENFILES built-in to connect to a remote computer"));
                            System.Console.WriteLine(String.Format("List of options:"));
                            System.Console.WriteLine(String.Format("\tnetview.exe [<\\ip|\\name of the remote computer>]"));
                            break;
                        default:
                            //System.Console.WriteLine("Enter the ip address of the remote computer");
                            Console.WriteLine(ExecuteCommand("net view " + args[0]));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static string ExecuteCommand(string command)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }
    }
}
