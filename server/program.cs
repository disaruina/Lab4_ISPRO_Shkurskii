using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Показать ФИО");
            Console.WriteLine("2 - Показать группу");
            Console.WriteLine("3 - Показать дату");
            Console.WriteLine("4 - Выход");
            
            Console.Write("Введите цифру: ");
            string number = Console.ReadLine();

            if (number == "1")
            {
                Console.WriteLine("\n[ФИО]: Шкурский Максим Витальевич");
            }
            else if (number == "2")
            {
                Console.WriteLine("\n[Группа]: ИСП-242");
            }
            else if (number == "3")
            {
                Console.WriteLine("\n[Дата]: 02.10.2026");
            }
            else if (number == "4")
            {
                Console.WriteLine("\nВыход из программы");
                running = false; 
            }
            else
            {
                Console.WriteLine("\nНеверный ввод, выберите цифру от 1 до 4");
            }
        }
    }
}
