using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandShowTimetableMonday = "1";
            const string CommandShowTimetableTuesday = "2";
            const string CommandShowTimetableWedesnday = "3";
            const string CommandShowTimetableThursday = "4";
            const string CommandShowTimetableFriday = "5";
            const string CommandShowTimetableSaturday = "6";
            const string CommandShowRandomSelection = "7";
            const string CommandClearConsole = "8";
            const string CommandExit = "9";

            string monday = "силовая тренировка бицепс+пресс+ноги";
            string tuesday = "силовая тренировка трицепс+спина+грудь";
            string Wedesnday = "силовая тренировка на плечи+ноги";
            string Thursday = "круговая тренировка на рельеф";
            string Friday = "силовая тренировка бицепс+спина";
            string Saturday = "силовая тренировка трицепс+грудь";
            string userSelection;
            bool programProgress = true;
            
            Random random = new Random();
            int value = random.Next(1,7);

            Console.WriteLine("Здравствуйте! Предлагаем вам программу-расписание тренировок по бодибилдингу");
            Console.WriteLine("Тренировки распределены по дням недели с понедельника по субботу, воскресенье - выыходной!");
            Console.WriteLine("Вам нужно выбрать цифру соответственно дням недели");
            Console.WriteLine($"Цифра {CommandShowTimetableMonday} - понедельник");
            Console.WriteLine($"Цифра {CommandShowTimetableTuesday} - вторник");
            Console.WriteLine($"Цифра {CommandShowTimetableWedesnday} - среда");
            Console.WriteLine($"Цифра {CommandShowTimetableThursday} - четверг");
            Console.WriteLine($"Цифра {CommandShowTimetableFriday} - пятница");
            Console.WriteLine($"Цифра {CommandShowTimetableSaturday} - суббота");
            Console.WriteLine($"Цифра {CommandShowRandomSelection} - случайный выбор тренировки");
            Console.WriteLine($"Цифра {CommandClearConsole} - очистка консоли");
            Console.WriteLine($"Цифра {CommandExit} - выход из программы");
            
            while(programProgress)
            {         
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case CommandShowTimetableMonday:
                        Console.WriteLine(monday);
                        break;

                    case CommandShowTimetableTuesday:
                        Console.WriteLine(tuesday);
                        break;

                    case CommandShowTimetableWedesnday:
                        Console.WriteLine(Wedesnday);
                        break;

                    case CommandShowTimetableThursday:
                        Console.WriteLine(Thursday);
                        break;

                    case CommandShowTimetableFriday:
                        Console.WriteLine(Friday);
                        break;

                    case CommandShowTimetableSaturday:
                        Console.WriteLine(Saturday);
                        break;

                    case CommandShowRandomSelection:
                        Console.WriteLine($"Вам выпала тренировка номер {value}, введите цифру с новой строки");
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break;

                    case CommandExit:
                        programProgress = false;
                        Console.WriteLine("Программа завершена");
                        break;

                    default:
                        Console.WriteLine("Данной команды не существует.");
                        break;
                }
            }
            Console.ReadKey();       
        }
    }
}
