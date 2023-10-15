using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IvashkinaKE.Sprint2.Task5.V1.Lib;

namespace Tyuiu.IvashkinaKE.Sprint2.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Ивашкина К.Э. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Оператор switch                                                             *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #1                                                                        *");
            Console.WriteLine("* Выполнила: Ивашкина Кристина Эдуардовна | АСОиУб-23-1                             *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет                  *");
            Console.WriteLine("* требуемое значение и возвращает результат.                                        *");
            Console.WriteLine("* Условие:                                                                          *");
            Console.WriteLine("* По данному номеру месяца, определите количество дней в этом месяце.               *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int value;

            Console.WriteLine("Введите номер месяца: ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Резултьтат: " + ds.FindMonthDaysCount(value));
            Console.ReadKey();
        }
    }
}
