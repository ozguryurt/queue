using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1;
            Queue q1 = new Queue();
            q1.Enqueue(0);
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            arr1 = q1.GetQueue();
            for(int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            q1.Dequeue();
            arr1 = q1.GetQueue();
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            q1.EnqueueFirst(17);
            q1.Enqueue(145);
            arr1 = q1.GetQueue();
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            q1.DequeueLast();
            arr1 = q1.GetQueue();
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
        }
    }

    class Queue
    {
        // (Front) _ _ _ _ (Rear)
        public int index = -1;
        public int capacity = 5;
        public int[] arr;

        public Queue()
        {
            arr = new int[capacity];
        }

        public void Enqueue(int val)
        {
            if(!IsFull())
            {
                index++;
                arr[index] = val;
            }
            else
            {
                throw new Exception("queue full");
            }
        }

        public void EnqueueFirst(int val)
        {
            if(!IsFull())
            {
                for(int i = index; i >= 0; i--)
                {
                    arr[i + 1] = arr[i];
                }
                arr[0] = val;
            }
            else
            {
                throw new Exception("queue full");
            }
        }

        public void Dequeue()
        {
            if(!IsEmpty())
            {
                for (int i = 0; i < index; i++)
                {
                    arr[i] = arr[i + 1];
                }
                index--;
            }
            else
            {
                throw new Exception("queue empty");
            }
        }

        public void DequeueLast()
        {
            index--;
        }

        public bool IsFull()
        {
            bool sonuc = false;
            if (index + 1 == capacity)
                sonuc = true;
            return sonuc;
        }

        public bool IsEmpty()
        {
            bool sonuc = false;
            if (index == -1)
                sonuc = true;
            return sonuc;
        }

        public int[] GetQueue()
        {
            int[] tempArr = new int[index + 1];
            for (int i = 0; i <= index; i++)
                tempArr[i] = arr[i];
            return tempArr;
        }
    }


}
