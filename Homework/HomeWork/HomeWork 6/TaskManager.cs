using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
   public class TaskManager
    {
     

        static void Processes()
        {
            Process[] processes = Process.GetProcesses();
            WriteProcessConsoleData("ID Процесса", "Имя процесса");
            string processid;
            string processname;
            foreach (var process in processes)
            {
                processid = Convert.ToString(process.Id);
                processname = process.ProcessName;
                process.Refresh();
                WriteProcessConsoleData(processid, processname);
            }
        }

        static void WriteProcessConsoleData(string firstColumn, string secondColumn)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(firstColumn);
            Console.SetCursorPosition(20, Console.CursorTop);
            Console.Write(secondColumn);
            Console.SetCursorPosition(60, Console.CursorTop);
            Console.WriteLine();
        }
        public void ProcessKill()
        {
            bool a = true;
            string command = string.Empty;
            while (command != "exit")
            {
                Processes();
                a = true;
                Console.WriteLine("Данная программа позволит вам остановить процесс");
                Console.WriteLine("Введите команду id если хотите остановить процесс используя его ID");
                Console.WriteLine("Введите команду name если хотите остановить процесс используя его Имя");
                Console.WriteLine("Введите команду exit eсли хотите выйти");
                while (a == true)
                {
                    command = Console.ReadLine();
                    switch (command)
                    {

                        case "name":
                            try
                            {
                                Console.WriteLine("Введите имя процесса");
                                string name = Console.ReadLine();
                                Process[] Procname = Process.GetProcessesByName(name);
                                foreach (Process proc in Procname)
                                {
                                    proc.Kill();
                                    proc.Refresh();

                                }

                            }
                            catch (Exception error)
                            {

                                Console.WriteLine(error.ToString());
                            }

                            break;
                        case "id":
                            try
                            {
                                Console.WriteLine("Введите ID процесса");
                                int procid = Convert.ToInt32(Console.ReadLine());
                                Process KillProcId = Process.GetProcessById(procid);
                                KillProcId.Kill();
                            }
                            catch (Exception error)
                            {
                                Console.WriteLine(error.ToString());
                            }
                            break;
                        case "exit":
                            break;

                        default:
                            Console.WriteLine("Введена неправильная команда ");
                            break;
                    }
                    if (command == "exit" || command == "name" || command == "id")
                    {
                        a = false;
                        continue;
                    }
                }

            }
        }
    }
}
