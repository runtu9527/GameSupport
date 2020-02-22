using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL_Killer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            KillProcess();
        }

        public static void KillProcess()//关闭线程
        {
            Process[] processes = Process.GetProcesses();
            foreach (var p in processes)
            {
                if (p.ProcessName.ToLower().Contains("league"))
                {
                    Console.WriteLine(p.ProcessName);
                    if (p.ProcessName == "League of Legends")
                    {
                        try
                        {
                            p.Kill();
                            p.WaitForExit(); // possibly with a timeout
                        }
                        catch (Win32Exception e)
                        {
                            Console.WriteLine(e.Message.ToString());  // process was terminating or can't be terminated - deal with it
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message.ToString()); // process has already exited - might be able to let this one go
                        }
                    }
                }
            }
        }
    }
}