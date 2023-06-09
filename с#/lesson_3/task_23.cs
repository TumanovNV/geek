// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System; // Подключаем пространство имен System

namespace CubesTable // Создаем новый namespace (пространство имен) с именем CubesTable
{
    class Program // Объявляем класс Program
    {
        static void Main(string[] args) // Объявляем метод Main, который будет выполняться при запуске программы
        {
            Console.Write("Введите число N: "); // Просим пользователя ввести число N
            int n = int.Parse(Console.ReadLine()); // Считываем введенное число и преобразуем его в тип int

            Console.WriteLine("Таблица кубов чисел от 1 до N:"); // Выводим заголовок таблицы

            for (int i = 1; i <= n; i++) // Создаем цикл от 1 до N включительно
            {
                int cube = i * i * i; // Вычисляем куб числа i
                Console.WriteLine($"{i}^3 = {cube}"); // Выводим результат на экран с помощью интерполяции строк
            }
        }
    }
}
