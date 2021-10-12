using System;
// Пространство имен.
namespace ConsoleSettings
{
    // Класс программы.
    class Program
    {
        // Метод Main — точка начала выполнения программы.
        static void Main(string[] args)
        {
            Console.Title = "Информационное табло";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Информация о системе:");

            // Вывод свойств класса Environment.
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.UserDomainName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.Version);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.CurrentManagedThreadId);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.Is64BitProcess);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
        }
    }
}

