using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double compositionAB = 1;
            double sumA = 0;
            double sumB = 0;
            Random random = new Random();
            Console.WriteLine("Инициализация массива А числами:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
                compositionAB *= A[i];
                if (i % 2 == 0)
                {
                    sumA += A[i];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.Next(1, 4);
                    compositionAB *= B[i, j];
                    if (j % 2 != 0)
                    {
                        sumB += B[i, j];
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальный элемент массива А = " + A.Max());
            Console.WriteLine("Максимальный элемент массива B = " + B.Cast<double>().Max());
            if (B.Cast<double>().Contains(A.Max()))
            {
                Console.WriteLine("Максимальный общий элемент в массивах =" + A.Max());
            }
            else
            {
                Console.WriteLine("В данных массивах нет максимальных общих элементов");
            }
            Console.WriteLine("Минимальный элемент массива А = " + A.Min());
            Console.WriteLine("Минимальный элемент массива B = " + B.Cast<double>().Min());
            if (B.Cast<double>().Contains(A.Min()))
            {
                Console.WriteLine("Минимальный общий элемент в массивах = " + A.Min());
            }
            else
            {
                Console.WriteLine("В данных массивах нет общих элементов");
            }
            Console.WriteLine("Общая сумма всех элементов = " + (A.Sum() + B.Cast<double>().Sum()));
            Console.WriteLine("Общая произведение всех элементов = " + compositionAB);
            Console.WriteLine("Общая четных элементов A = " + sumA);
            Console.WriteLine("Общая элементов нечетных столбцов В = " + sumB);
            Console.ReadKey();

            //задание 2
            Console.WriteLine("Введите размер M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер N");
            int N = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] massiv1 = new int[M];
            int[] massiv2 = new int[N];
            int counter = 0;
            for (int i = 0; i < massiv1.Length; i++)
            {
                massiv1[i] = random.Next(1, 10);
            }
            for (int i = 0; i < massiv2.Length; i++)
            {
                massiv2[i] = random.Next(1, 15);
            }
            Console.WriteLine("Вывод содержимого двух массивов");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < massiv2.Length; i++)
            {
                Console.Write(massiv2[i] + " ");
            }
            //в цикле пробегаюсь по обоим массивам если встречаются
            //одинаковые элементы в массиве меняю значение второго одинового элемента на -1
            for (int i = 0; i < massiv1.Length - 1; i++)
            {
                for (int j = i + 1; j < massiv1.Length; j++)
                {
                    if (massiv1[i] == massiv1[j])
                    {
                        massiv1[j] = -1;
                    }
                }
            }
            for (int i = 0; i < massiv2.Length - 1; i++)
            {
                for (int j = i + 1; j < massiv2.Length; j++)
                {
                    if (massiv2[i] == massiv2[j])
                    {
                        massiv2[j] = -1;
                    }
                }
            }
            //сравниваю два массива, если нахожу одинаковые элементы меняю один из них на число -2
            for (int i = 0; i < massiv1.Length; i++)
            {
                for (int j = 0; j < massiv2.Length; j++)
                {
                    if (massiv1[i] == massiv2[j] && massiv1[i] > 0)
                    {
                        massiv2[j] = -2;
                    }
                }
            }
            //считаю количество оставшися не одинаковых элементов
            for (int i = 0; i < massiv1.Length; i++)
            {
                if (massiv1[i] > 0)
                {
                    counter++;
                }
            }
            for (int i = 0; i < massiv2.Length; i++)
            {
                if (massiv2[i] > 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("\nВывод на экран оставшихся не одинаковых элементов 2-ух массивов");
            for (int i = 0; i < massiv1.Length; i++)
            {
                Console.Write(massiv1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < massiv2.Length; i++)
            {
                Console.Write(massiv2[i] + " ");
            }
            //обьявляю 3 массив размером counter
            int[] massiv3 = new int[counter];
            int value = 0;
            Console.WriteLine();
            for (int i = 0; i < massiv1.Length; i++)
            {
                if (massiv1[i] > 0)
                {
                    massiv3[value++] = massiv1[i];
                }
            }
            for (int i = 0; i < massiv2.Length; i++)
            {
                if (massiv2[i] > 0)
                {
                    massiv3[value++] = massiv2[i];
                }
            }
            Console.WriteLine("Вывод на экран 3-го массива");
            for (int i = 0; i < massiv3.Length; i++)
            {
                Console.Write(massiv3[i] + " ");
            }
            Console.ReadKey();

            //задание 3
            string text;
            Console.WriteLine("Введите проедложение Палиндор");
            text = Console.ReadLine();
            //удаляю все пробелы со строки
            text = text.Replace(" ", "");
            //привожу все символы к общему регистру
            text = text.ToLower();
            bool isPalindrom = true;
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isPalindrom = false;
                    Console.WriteLine("Строка не является палиндромом");
                    break;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            Console.ReadKey();

            //задание 4
            string str;
            Console.WriteLine("Введите предложение");
            str = Console.ReadLine();
            int wordCount = 1;
            //удаляю первые и последние пробелы в строке
            str = str.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    wordCount++;
                }
            }
            Console.WriteLine(wordCount);
            Console.ReadKey();

            //задание 5
            int[,] arr = new int[5, 5];
            int sumElements = 0, iMax = 0, jMax = 0, iMin = 0, jMin = 0;
            bool count = false;
            Random rand = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                    arr[i, j] = rand.Next(99);
                    if (arr[i, j] > 0)
                    {
                        Console.Write(" ");
                    }
                    else if (arr[i, j] < 10 && arr[i, j] > 0)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
                }
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }
            //если максимальный элемент массива находится выше минимального я меняю их местами
            if (iMin > iMax)
            {
                arr[iMax, jMax] ^= arr[iMin, jMin];
                arr[iMin, jMin] ^= arr[iMax, jMax];
                arr[iMax, jMax] ^= arr[iMin, jMin];
                iMin ^= iMax;
                iMax ^= iMin;
                iMin ^= iMax;
                jMin ^= jMax;
                jMax ^= jMin;
                jMin ^= jMax;
            }
            for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if ((i == iMax && j == jMax) || (i == iMin && j == jMin))
                        {
                            if (count)
                            {
                                count = false;
                                continue;
                            }
                            else
                            {
                                count = true;
                                continue;
                            }
                        }
                        if (count)
                        {
                        sumElements += arr[i, j];
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент массива = " + max);
                Console.WriteLine("Минимальный элемент массива = " + min);
                Console.WriteLine("Cуммa элементов массива, расположенных между минимальным и максимальным элементами = " + sumElements);
                Console.ReadKey();
        }
        }
}
