using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleDumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name process: ");
            string prname = Console.ReadLine();
            Process proc = Process.GetProcessesByName(prname)[0];
            ProcessModuleCollection modules = proc.Modules;

            foreach (ProcessModule module in modules)
            {
                File.AppendAllText(Application.StartupPath.ToString() + $"\\{prname}Dump.log", $"Name: {module.ModuleName}\nMemorySize: {module.ModuleMemorySize}\nBaseAddress: {module.BaseAddress}\nEntryPointAddress: {module.EntryPointAddress}\n------------------\n");
            }
        }
    }
}
