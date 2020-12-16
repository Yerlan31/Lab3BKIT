using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class SimpleStack<T>
    {
        T[] arr;
        int count;

        int Count
        {
            get { return count; }
            set { }
        }


        public SimpleStack(int size)
        {
            if (size < 1) size = 2;

            arr = new T[size];
        }


        public T this[int index] // перегрузка
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new Exception("index is incorrect");

                return arr[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new Exception("index is incorrect");

                arr[index] = value;
            }
        }
        public void Push(T value)
        {
            if (count == arr.Length)
                Resizee();

            arr[count] = value;
            count++;


        }

        public void Pop()
        {
            PRINT();
            Console.WriteLine("Выберите номер элемента, который вы хотите удалить");
            string entered = Console.ReadLine();
            int i = Convert.ToInt32(entered);
            if (i > arr.Length || i < 0) throw new Exception("Вы ввели неправильный индекс массива");
            for (int j = i; arr[j] != null; j++)
            { arr[j] = arr[j + 1]; }
        }

        private void Resizee()
        {
            int newCapacity = arr.Length * 2;
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
                newArray[i] = arr[i];

            arr = newArray;
        }

        public void PRINT()
        {
            for (int i = 0; arr[i] != null; i++)
            {
                Console.WriteLine(i + " " + arr[i].ToString());
            }
        }

    }
}
