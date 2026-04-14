using Tyuiu.KlochenokVA.Sprint3.Task2.V22.Lib;
namespace Tyuiu.KlochenokVA.Sprint3.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a;
            int st, en;
            Console.WriteLine("Введите a,start,end");
            a = Convert.ToInt32(Console.ReadLine());
            st = Convert.ToInt32(Console.ReadLine());
            en = Convert.ToInt32(Console.ReadLine());
            Console.Title = "Спринт #3 | Выполнил: Клоченок В.А. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Клоченок Владимир Алексеевич  | ИСПб-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = " + a);
            Console.WriteLine("* st = " + st);
            Console.WriteLine("* en = " + en);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMultiplySeries(a, st, en));
        }
    }
}