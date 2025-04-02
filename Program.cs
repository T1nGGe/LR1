using System;

namespace StudentApp
{
    class Student
    {

        public string FIO;
        public int Ocenka1;
        public int Ocenka2;


        public void ShowData()
        {
            Console.WriteLine("ФИО: " + FIO);
            Console.WriteLine("Оценка 1: " + Ocenka1);
            Console.WriteLine("Оценка 2: " + Ocenka2);
        }
        public float SredOcenka()
        {
            return (float)(Ocenka1 + Ocenka2) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();


            student1.FIO = "Иванов";
            student1.Ocenka1 = 3;
            student1.Ocenka2 = 5;


            student2.FIO = "Петров";
            student2.Ocenka1 = 4;
            student2.Ocenka2 = 4;


            student3.FIO = "Сидоров";
            student3.Ocenka1 = 5;
            student3.Ocenka2 = 5;


            Console.WriteLine("Данные о студенте 1:");
            student1.ShowData();
            Console.WriteLine();

            Console.WriteLine("Данные о студенте 2:");
            student2.ShowData();
            Console.WriteLine();

            Console.WriteLine("Данные о студенте 3:");
            student3.ShowData();
            Console.WriteLine();


            float sredOcenka1 = student1.SredOcenka();
            Console.WriteLine("Средняя оценка студента 1: " + sredOcenka1);
            Console.WriteLine();

            float sredOcenka2 = student2.SredOcenka();
            Console.WriteLine("Средняя оценка студента 2: " + sredOcenka2);
            Console.WriteLine();

            float sredOcenka3 = student3.SredOcenka();
            Console.WriteLine("Средняя оценка студента 3: " + sredOcenka3);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
