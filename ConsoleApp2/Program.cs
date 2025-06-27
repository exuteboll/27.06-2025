using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Перечисление - это определяемый польвозателем цикличный набор допустимых значений 
        /// и назначает каждому понятное имя 
        /// Цикл с  параметром используется для выполнения блока кода заданное количество раз
        /// </summary>
        enum Days
        { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентярбрь, Октябрь, Ноябрь, Декабрь }

        static void Main(string[] args)
        {

            Days i;
            for(i = Days.Январь; i <= Days.Декабрь; i++)
            {
                Console.WriteLine($"{(int)i} \t {i} ");
            }
            Console.ReadKey();
        }
    }
}
