using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<string> StringQueue = new Queue<string>();
            Queue<int>.Owner owner = new Queue<int>.Owner(111, "Artem", "BSTU");
            Queue<int>.Date date = new Queue<int>.Date();
            //Console.WriteLine(date.DataOfCreation.DayOfWeek);

            Print(" Создать заданный в варианте класс. Определить в классе необходимые методы, конструкторы, индексаторы и заданные перегруженные операции.");

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Print();

            Console.WriteLine($"Size: {queue.Size}");

            int a = queue.Dequeue();
            Console.WriteLine(a);
            queue.Print();
            Console.WriteLine(queue.Peek());
            queue.Print();

            int value = 544;
            queue = queue / value;
            queue.Print();
            queue++;
            queue.Print();

            int resolt = (int)queue;
            Console.WriteLine(resolt);

            if (queue)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            Print("Написать программу тестирования, в которой проверяется использование перегруженных операций. ");
            TestForQueueAndOpretors(queue);

            void TestForQueueAndOpretors(Queue<int> TestQueue)
            {
                int helpCounter = 0;
                int testCounter;
                bool boolTestValue;
                bool boolHelpValue = false;
                Queue<int> helpQueue = new Queue<int>(/*111, "Artem", "BSTU"*/);
                helpQueue = TestQueue;

                TestQueue = TestQueue / 55;
                helpQueue.Enqueue(55);
                Console.Write("\nТест на  / - добавить элемент: ");

                if (TestQueue == helpQueue && TestQueue.Size == helpQueue.Size)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(false);
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                TestQueue++;
                helpQueue.Dequeue();
                Console.Write("\nТест на  ++ - извлечь элемент: ");

                if (TestQueue == helpQueue && TestQueue.Size == helpQueue.Size)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(false);
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                if (TestQueue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    boolTestValue = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    boolTestValue = false;
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                for (int i = 0; i < helpQueue.Size; i++)
                {
                    if (helpQueue.MasOfValue[i] % 2 == 0)
                    {
                        boolHelpValue = true;
                    }
                }

                Console.Write("\nТест на  false - проверка, на содержание четных элементов в очереди: ");
                if (boolHelpValue == boolTestValue)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(false);
                }
                Console.ForegroundColor = ConsoleColor.Gray;

                testCounter = (int)TestQueue;

                for (int i = 0; i < helpQueue.Size; i++)
                {
                    if (helpQueue.MasOfValue[i] > 0)
                    {
                        helpCounter++;
                    }
                }

                Console.Write("\nТест на  явный int() количество положительных элементов в очереди: ");

                if (testCounter == helpCounter)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(true);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(false);
                }
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();
            }

            Print(" Создайте статический класс MathOperation, содержащий 3 метода для работы с вашим классом (по варианту п.1): поиск максимального, минимального, подсчет количества элементов. ");
            Console.WriteLine(MathOperation.FindMax(queue));
            Console.WriteLine(MathOperation.FindMin(queue));
            Console.WriteLine(MathOperation.Size(queue));

            Print("Добавьте к классу MathOperation методы расширения для типа string и  вашего типа из задания№1. См. задание по вариантам.");

            StringQueue.Enqueue("df123dfs");
            int number =StringQueue.Peek().TheFirstNumberInTheString();
            Console.WriteLine($"{StringQueue.Peek()} \nПервое число: {number}\n\n");

            queue = queue / -23;
            queue = queue / -75;
            queue.Print();
            queue.ZeroingOfNegativeItemsInTheQueue();
            queue.Print();

            void Print(string str)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine('\n'+str);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }

    }
}
