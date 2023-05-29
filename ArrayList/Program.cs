using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class MyCollection
    {
        public static ArrayList NewCollection(int i)
        {
            Random ran = new Random();
            ArrayList arr = new ArrayList();
            for (int j = 0; j < i; j++)
                arr.Add(ran.Next(1, 50));
            return arr;
        }
        public static ArrayList RemoveEvenElementMyCollection(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; ++i)
            {
                if (Convert.ToInt32(arr[i]) % 2 == 0)
                {
                    arr.RemoveAt(i);
                    i--;
                }    
            }
            return arr;
        }
        public static void AddElementInMyCollection(int i, ref ArrayList arr)
        {
            Random ran = new Random();
            for (int j = 0; j < i; j++)
                arr.Add(ran.Next(1, 50));
        }
        public static void WriteMyCollection(ArrayList arr)
        {
            foreach (int a in arr)
                Console.Write("{0}\t", a);
            Console.WriteLine("\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создадим новую коллекцию чисел длиной 4
            ArrayList Coll = MyCollection.NewCollection(4);
            Console.WriteLine("Исходная коллекция чисел: ");
            MyCollection.WriteMyCollection(Coll);


            // Добавим k-тое кол-во элементов
            Console.WriteLine("Какое кол-во элементов добавить?");
            int k = Convert.ToInt32(Console.ReadLine());
            MyCollection.AddElementInMyCollection(k, ref Coll);
            Console.WriteLine("Добавили K-тое кол-во элементов: ");
            MyCollection.WriteMyCollection(Coll);

            // Сортировка коллекции по убыванию
            Coll.Sort();
            Coll.Reverse();
            Console.WriteLine("Коллекция отсортированная по убыванию: ");
            MyCollection.WriteMyCollection(Coll);

            // Удалениие четных элементов
            Coll = MyCollection.RemoveEvenElementMyCollection(Coll);
            Console.WriteLine("Коллекция после удаления четных элементов: ");
            MyCollection.WriteMyCollection(Coll);

            Console.ReadLine();
        }
    }
}
