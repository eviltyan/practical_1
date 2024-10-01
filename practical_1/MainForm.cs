using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_1
{
    public class MainForm
    {
        public static List<FileDescription> Fill()
        {
            List<FileDescription> list = new List<FileDescription>();

            FileDescription obj = new FileDescription("AMD.txt", 10, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("BIOS.os", 21, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("centralfile.png", 1, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("daily_shedule", 11, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("fold", 0, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("eagle.jpg", 6, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("gorilla.mp4", 19, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("home", 2, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("IIftool.exe", 26, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("kittyo.png", 1, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("loving_song.mp3", 2, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("mom.jpg", 10, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("NuGet", 39, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("Opera", 25, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("Opera Software", 50, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("Packages", 47, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("roblox", 19, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("smth", 13, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("temp", 14, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("Users", 45, DateTime.UtcNow, "");
            list.Add(obj);
            obj = new FileDescription("Windows", 32, DateTime.UtcNow, "");
            list.Add(obj);

            return list;
        }
        public static void Interface()
        {
            int iterator = 0;
            Console.Title = "Console";
            Console.SetWindowSize(80, 22);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            List<FileDescription> list = Fill();

            Console.Write("\u2554");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2564");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2564");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2557");
            Console.Write("\u2554");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2564");
            Console.Write(new string('\u2550', 9));
            Console.Write("\u2564");
            Console.Write(new string('\u2550', 8));
            Console.Write("\u2564");
            Console.Write(new string('\u2550', 6));
            Console.Write("\u2557\n");

            Console.Write("\u2551 C: Имя     \u2502    Имя     \u2502    Имя     \u2551\u2551 С: Имя     \u2502  Размер \u2502  Дата  \u2502Объект\u2551\n");
            int i = 0, j = 19, k = 38, l = 0;
            int num;
            string day, month;

            while (iterator < 19)
            {
                Console.Write("\u2551");
                if (list.Count > 0) //0-18
                {
                    if (i < list.Count)
                    {
                        if (list[i].Name.Length < 12)
                        {
                            Console.Write(list[i].Name);
                            num = 12 - list[i].Name.Length;
                            Console.Write(new string(' ', num));
                        }
                        else
                        {
                            Console.Write(list[i].Name.Substring(0, 11) + '-');
                        }
                    }
                    else
                        Console.Write(new string(' ', 12));
                    i += 1;
                    Console.Write("\u2502");
                }
                if (list.Count >= 19) //19-37
                {
                    if (j < list.Count)
                    {
                        if (list[j].Name.Length < 12)
                        {
                            Console.Write(list[j].Name);
                            num = 12 - list[j].Name.Length;
                            Console.Write(new string(' ', num));
                        }
                        else
                        {
                            Console.Write(list[j].Name.Substring(0, 11) + '-');
                        }
                    }
                    else
                        Console.Write(new string(' ', 12));
                    j += 1;
                    Console.Write("\u2502");
                }
                else
                {
                    Console.Write(new string(' ', 12));
                    Console.Write("\u2502");
                }
                if (list.Count >= 38) //38-56
                {
                    if (k < list.Count)
                    {
                        if (list[k].Name.Length < 12)
                        {
                            Console.Write(list[k].Name);
                            num = 12 - list[k].Name.Length;
                            Console.Write(new string(' ', num));
                        }
                        else
                        {
                            Console.Write(list[k].Name.Substring(0, 11) + '-');
                        }
                    }
                    else
                        Console.Write(new string(' ', 12));
                    k += 1;
                    Console.Write("\u2502");
                }
                else
                {
                    Console.Write(new string(' ', 12));
                    Console.Write("\u2551");
                }


                Console.Write("\u2551");
                if (list.Count > 0) //0-18
                {
                    if (l < list.Count)
                    {
                        if (list[l].Name.Length < 12)
                        {
                            Console.Write(list[l].Name);
                            num = 12 - list[l].Name.Length;
                            Console.Write(new string(' ', num));
                        }
                        else
                        {
                            Console.Write(list[l].Name.Substring(0, 11) + '-');
                        }
                        Console.Write("\u2502");

                        num = 9 - list[l].Size.ToString().Length;
                        Console.Write(new string(' ', num) + list[l].Size + "\u2502");

                        if (list[l].DateTimeModification.Day.ToString().Length == 1)
                            day = "0" + list[l].DateTimeModification.Day.ToString();
                        else
                            day = list[l].DateTimeModification.Day.ToString();
                        if (list[l].DateTimeModification.Month.ToString().Length == 1)
                            month = "0" + list[l].DateTimeModification.Month.ToString();
                        else
                            month = list[l].DateTimeModification.Month.ToString();
                        
                        Console.Write($"{day}.{month}.{list[l].DateTimeModification.Year.ToString().Substring(2)}\u2502");

                        if (list[l].isDirectory == "file")
                            Console.Write(list[l].isDirectory + "  \u2551");
                        else
                            Console.Write(list[l].isDirectory + "\u2551");
                    }
                    else
                        Console.Write(new string(' ', 12) + "\u2502" + new string(' ', 9) + "\u2502" + new string(' ', 8) + "\u2502" + new string(' ', 6) + "\u2551");


                    l += 1;



                }
                Console.Write("\n");
                iterator++;

            }

            Console.Write("\u255A");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2567");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2567");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u255D");
            Console.Write("\u255A");
            Console.Write(new string('\u2550', 12));
            Console.Write("\u2567");
            Console.Write(new string('\u2550', 9));
            Console.Write("\u2567");
            Console.Write(new string('\u2550', 8));
            Console.Write("\u2567");
            Console.Write(new string('\u2550', 6));
            Console.Write("\u255D");
        }
    }
}
