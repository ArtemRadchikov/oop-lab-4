using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    /*Класс - очередь Queue. 
     * Дополнительно перегрузить следующие операции: 
     * / - добавить элемент; ++ - извлечь элемент; false - проверка, на содержание четных элементов в очереди;
     * явный int() количество положительных элементов в очереди 
     * Методы расширения: 
1) Выделение первого числа, содержащегося в строке  
2) Обнуление отрицательных элементов очереди */
    public class Queue<T>
    {
        private int size = 0;
        private T[] masOfValue;

        public class Owner
        {
            private int id;
            private string name;
            private string organization;

            public Owner(int id, string name, string organization)
            {
                this.Id = id;
                this.Name = name;
                this.Organization = organization;
            }
            public string Organization { get => organization; set => organization = value; }
            public string Name { get => name; set => name = value; }
            public int Id { get => id; set => id = value; }
        }

        public class Date
        {
            private readonly DateTime dataOfCreation = new DateTime();

            public Date()
            {
                dataOfCreation = DateTime.Now;
            }

            public DateTime DataOfCreation => dataOfCreation;
        }
        //public Queue(int id, string name,string organization)
        //{
        //    Owner owner = new Owner(id, name, organization);
        //}

        //dequeue: извлекает и возвращает первый элемент очереди
        public T Dequeue()
        {
            var value = MasOfValue[0];
            for (int i = 0; i < size - 1; i++)
            {
                MasOfValue[i] = MasOfValue[i + 1];
            }
            Array.Resize(ref masOfValue, --size);
            return value;
        }

        //enqueue: добавляет элемент в конец очереди
        public void Enqueue(T value)
        {
            Array.Resize(ref masOfValue, ++size);
            MasOfValue[size - 1] = value;
        }

        //peek: просто возвращает первый элемент из начала очереди без его удаления
        public T Peek()
        {
            var value = MasOfValue[0];
            return value;
        }

        public void Print()
        {
            foreach (var i in masOfValue)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //   / - добавить элемент;
        public static Queue<T> operator /(Queue<T> queue, T value)
        {
            queue.Enqueue(value);
            return queue;
        }

        //  ++ - извлечь элемент
        public static Queue<T> operator ++(Queue<T> queue)
        {
            queue.Dequeue();
            return queue;
        }

        public static explicit operator int(Queue<T> queue)
        {
            int counter = 0;
            for (int i = 0; i < queue.Size; i++)
            {
                if (queue.MasOfValue[i].GetType() == counter.GetType())
                {
                    if (Convert.ToInt32(queue.MasOfValue[i]) > 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        //false - проверка, на содержание четных элементов в очереди;
        public static bool operator true(Queue<T> queue)
        {
            for (int i = 0; i < queue.Size; i++)
            {
                if (queue.MasOfValue[i].GetType() == typeof(int))
                {
                    if (Convert.ToInt32(queue.MasOfValue[i]) % 2 == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Queue<T> queue)
        {
            for (int i = 0; i < queue.Size; i++)
            {
                if (queue.MasOfValue[i].GetType() == typeof(int))
                {
                    if (Convert.ToInt32(queue.MasOfValue[i]) % 2 != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int Size { get => size; set => size = value; }
        public T[] MasOfValue { get => masOfValue; set => masOfValue = value; }
    }
}