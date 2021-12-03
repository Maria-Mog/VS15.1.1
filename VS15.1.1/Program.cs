using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS15._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(2);
            arithProgression.setStart(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число {0}", arithProgression.getNext());
            }            
            arithProgression.reset();
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression(3);
            geomProgression.setStart(1);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Следующее число {0}", geomProgression.getNext());
            }
            geomProgression.reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {               
        void setStart(int x); //устанавливает начальное значение
        int getNext(); //возвращает следующее число ряда
        void reset(); //выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        public int step { get; set; } // шаг прогрессии
        public int start { get; set; }
        public int result { get; set; }
        public ArithProgression(int step)
        {
            this.step = step;
        }
        public void setStart(int x)
        {
            start = x;
            result = start;
            Console.WriteLine("Начальное значение {0} ", result);
        }

        public int getNext()

        {
            result += step;
            return result;
        }

        public void reset()
        {
            result = start;
            Console.WriteLine("Сбросить.\nНачальное значение {0} ", result);
        }
    }
    class GeomProgression : ISeries
    {
        public int step { get; set; } // шаг прогрессии
        public int start { get; set; }
        public int result { get; set; }
        public GeomProgression (int step)
        {
            this.step = step;
        }
        public void setStart(int x)
        {
            start = x;
            result = start;
            Console.WriteLine("Начальное значение {0} ", result);
        }
        public int getNext()

        {
            result *= step;
            return result;
        }
        public void reset()
        {
            result = start;
            Console.WriteLine("Сбросить.\nНачальное значение {0} ", result);
        }
    }
}
