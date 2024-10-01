using Tyuiu.SafonovRV.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SafonovRV.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Сафонов Р.В | АСОиУБ-24-1";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Получение результата из switch                                       *");
            Console.WriteLine("* Таск #6                                                                    *");
            Console.WriteLine("* Вариант #14                                                                *");
            Console.WriteLine("* Выполнила: Сафонов Руслан Васильевич | АСОиУБ-24-1                         *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели          *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й день *");
            Console.WriteLine("* не високосного года, в котором 1 января d-й день недели (если 1 января -   *");
            Console.WriteLine("* понедельник, то d = 1 , если вторник — d = 2 ,…, если воскресенье — d = 7) *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите число от 1 до 365:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число от 1 до 7:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");


            try
            {
                string day = ds.FindDayName(k, d);
                Console.WriteLine(day);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
