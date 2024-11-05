using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public class ArrayHandler
    {
        // Закрите поле для зберігання масиву
        private int[] array;

        // Конструктор, який ініціалізує масив випадковими числами
        public ArrayHandler(int size)
        {
            array = new int[size];
            Random rand = new Random();

            // Заповнюємо масив випадковими числами від 0 до 100
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 101);
            }
        }

        // Властивість для отримання розміру масиву
        public int Length
        {
            get { return array.Length; }
        }

        // Індексатор для доступу до елементів масиву за індексом
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        // Метод для обчислення суми елементів між мінімальним та максимальним значеннями
        public int SumBetweenMinMax()
        {
            int minIndex = 0, maxIndex = 0;

            // Знаходимо індекси мінімального та максимального елементів
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            // Визначаємо межі між мінімальним і максимальним індексами
            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex);

            // Обчислюємо суму елементів між мінімальним та максимальним
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        // Метод для виведення масиву
        public void PrintArray()
        {
            Console.WriteLine("Array: [" + string.Join(", ", array) + "]");
        }
    }

    class Program
    {
        static void Main()
        {
            // Створюємо екземпляр класу ArrayHandler з масивом із 100 елементів
            ArrayHandler arrayHandler = new ArrayHandler(100);

            // Виводимо масив
            arrayHandler.PrintArray();

            // Обчислюємо та виводимо суму елементів між мінімальним і максимальним значеннями
            int sum = arrayHandler.SumBetweenMinMax();
            Console.WriteLine("Sum between min and max values: " + sum);
        }
    }

}
