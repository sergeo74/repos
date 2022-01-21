using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // 'Состояние’ объекта Саг
        public string petName;
        public int currSpeed;

        // Функциональность Саг.
        // Использовать синтаксис членов, сжатых до выражений, который появился в C# 6.
        public void PrintState() => 
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void SpeedUp(int delta) => 
            currSpeed =+delta;
    }
}
