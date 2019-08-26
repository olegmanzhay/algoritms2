/*
 1) Попробовать оптимизировать пузырьковую сортировку.
 Сравнить количество операций сравнения оптимизированной и неоптимизированной программы.
 Написать функции сортировки, которые возвращают количество операций.
 2) *Реализовать шейкерную сортировку.
 3)Реализовать бинарный алгоритм поиска в виде функции, которой передаётся отсортированный массив. 
 Функция возвращает индекс найденного элемента или –1, если элемент не найден.
 Олег Манжай
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Sort
    {
        static int countElement;    // количество элементов
        static int firstElement;    // начало диапазона
        static int lastElement;     // конец диапазона
        static int[] mass;          // массив элементов
        static int element;         // выбранный элемент для поиска

        public int CountElement
        {
            get
            {
                return countElement;
            }
            set
            {
                countElement = value;
            }
        }
        public int FirstElement
        {
            get
            {
                return firstElement;
            }
            set
            {
                firstElement = value;
            }
        }
        public int LastElement
        {
            get
            {
                return lastElement;
            }
            set
            {
                lastElement = value;
            }
        }

        public int Element
        {
            get
            {
                return element;
            }
            set
            {
                element = value;
            }
        }
        /// <summary>
        /// Конструктор, заполняющий массив рандомными элементами
        /// </summary>
        /// <param name="a">количество элементов в массиве</param>
        /// <param name="b">Начало диапазона</param>
        /// <param name="c">Конец диапазона</param>
        public Sort(int a, int b, int c)
        {
            CountElement = a; // количество элементов
            FirstElement = b; // начало диапазона
            LastElement = c;  //  конец диапазона
            Random rnd = new Random();
            mass = new int [CountElement];
            for (int i = 0; i < CountElement; i++)
            {
                mass[i] = rnd.Next(FirstElement, LastElement +1); // заполняется массив элеменами
            }
        }
        /// <summary>
        /// Возвращает массив в строквом виде
        /// </summary>
        /// <param name="A"></param>
        /// <returns>string</returns>
        public string PrintMassive(Sort A)
        {
           // int[] mass = new int[10] { 3, 7, 9, 3, 6, 1, 5, 7, 0, 2 };
            string result = string.Empty;
            for (int i = 0; i < A.CountElement; i++)
            {
                result += mass[i].ToString() + " ";
            }
            return result;
        }
        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="A"></param>
        /// <param name="operation">количество операция сравнения</param>
        /// <returns>string</returns>
        public string SortBubble(Sort A, out int operation)
        {
            //int[] mass = new int[10] { 3, 7, 9, 3, 6, 1, 5, 7, 0, 2 };
            operation = 0; // количество операций сравнений 
            string result = string.Empty;
            int temp;   // временная пересенная для swap
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < CountElement - 1; j++)
                {
                    operation++;
                    if (mass[j] > mass[j + 1])
                    {
                        
                        temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < A.CountElement; i++)
            {
                result += mass[i].ToString() + " ";
            }
            return result;
        }
        /// <summary>
        /// Оптимизированная сортировка Пузырьком
        /// </summary>
        /// <param name="A"></param>
        /// <param name="operation">количество операций сравнения</param>
        /// <returns>string</returns>
        public string SuperSortBubble(Sort A, out int operation)
        {
            //int[] mass = new int[10] {3,7,9,3,6,1,5,7,0,2}; 
            operation = 0;  //количество операций сравнения 
            string result = string.Empty;
            int temp;   // временная переменная для swap
            int k = 1;  //оптимизация, чтобы не доходило до провереных элементов 
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < CountElement-k; j++)
                {
                    operation++;
                    if (mass[j] > mass[j+1])
                    {
                        
                        temp = mass[j];
                        mass[j] = mass[j+1];
                        mass[j+1] = temp;
                        
                    }
                }
                k++;
            }

            for (int i = 0; i < A.CountElement; i++)
            {
                result += mass[i].ToString() + " ";
            }
            return result;
        }
        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="A"></param>
        /// <param name="operation">количество операций сравнения</param>
        /// <returns>string</returns>
        public string ShakerSort(Sort A,out int operation)
        {
           // int[] mass = new int[10] {3,7,9,3,6,1,5,7,0,2};
            operation = 0;  
            string result = string.Empty;
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                operation++;
                for (int j = 0; j < CountElement - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
                for (int j = countElement-1; j > 0; j--)
                {
                    if (mass[j] < mass[j -1])
                    {
                        temp = mass[j-1];
                        mass[j-1] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            operation *= 2;
            for (int i = 0; i < A.CountElement; i++)
            {
                result += mass[i].ToString() + " ";
            }
            return result;
        }
        /// <summary>
        /// Бинарный поиск
        /// </summary>
        /// <param name="A"></param>
        /// <returns>int</returns>
        public int BinarySearch(Sort A)
        {
            int L = 0, R = CountElement - 1;
            int m = L + (R - L) / 2;

            while (L <= R && mass[m]!=A.Element)
            {
                if (mass[m] < A.Element)
                    L = m + 1;
                else
                    R = m - 1;
                m = L + (R - L) / 2;
            }
            if (mass[m] == A.Element)
                return m;
            else
                return -1;
        }
    }
}
