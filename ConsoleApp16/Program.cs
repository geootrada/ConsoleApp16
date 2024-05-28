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

            string trainingMonday = "силовая тренировка бицепс+пресс+ноги";
            string trainingTuesday = "силовая тренировка трицепс+спина+грудь";
            string trainingWedesnday = "силовая тренировка на плечи+ноги";
            string trainingThursday = "круговая тренировка на рельеф";
            string trainingFriday = "силовая тренировка бицепс+спина";
            string trainingSaturday = "силовая тренировка трицепс+грудь";
            string userSelection;
            bool isProgress = true;
            
            Random random = new Random();
            int value = random.Next(Convert.ToInt32(CommandShowTimetableMonday), Convert.ToInt32(CommandShowRandomSelection));

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
            
            while(isProgress)
            {         
                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case CommandShowTimetableMonday:
                        Console.WriteLine(trainingMonday);
                        break;

                    case CommandShowTimetableTuesday:
                        Console.WriteLine(trainingTuesday);
                        break;

                    case CommandShowTimetableWedesnday:
                        Console.WriteLine(trainingWedesnday);
                        break;

                    case CommandShowTimetableThursday:
                        Console.WriteLine(trainingThursday);
                        break;

                    case CommandShowTimetableFriday:
                        Console.WriteLine(trainingFriday);
                        break;

                    case CommandShowTimetableSaturday:
                        Console.WriteLine(trainingSaturday);
                        break;

                    case CommandShowRandomSelection:
                        Console.WriteLine($"Вам выпала тренировка номер {value}, введите цифру с новой строки");
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break;

                    case CommandExit:
                        isProgress = false;
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
