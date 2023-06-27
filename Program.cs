using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Создание перменных и их вывод

            string fullName = "Талаев Роман Алексеевич";
            int age = 24;
            string email = "talaevroma@gmail.com";
            double mathScores = 98.2;
            double programmingScores = 100;
            double physicsScores = 80.6;


            string pattern = "Имя: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по математике: {3} \nБаллы по программированию: {4} \nБаллы по физике: {5}";

            Console.WriteLine(pattern, fullName, age, email, mathScores, programmingScores, physicsScores);
            Console.ReadKey();

            // Задание 2: Реализация подсчёта количества баллов по всем предметам

            double sumAllScores = mathScores + programmingScores + physicsScores;
            double totalNumber = 3;
            double averageScore = sumAllScores / totalNumber;

            Console.WriteLine($"\nСредний балл по всем предметам равен:{averageScore}");

            Console.ReadKey();
        }
    }
}
