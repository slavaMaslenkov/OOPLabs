namespace _4._2
{
    internal class Program
    {
        /// <summary>
        /// Вычисляет сумму
        /// </summary>
        /// <param name="massiv">Матрица.</param>
        /// <returns>сумму</returns>
        public static double Sum(double[] massiv, int i)
        {
            double summa = 1 / (massiv[i - 1] * massiv[i] * massiv[i + 1]);
            if (i != massiv.Length - 2)
            {
                summa += Sum(massiv, i + 1);
                return summa;
            }
            else
            {
                return summa;
            }
        }

        /// <summary>
        /// Метод с которого начинается выполнение программы.
        /// </summary>
        public static void Main()
        {

            // Создание массива
            double[] massiv = CreateArray();

            Console.Write("Созданный массив       : ");
            OutputArray(massiv);

            double totall = Sum(massiv, 1);

            // Вывод приветсвия
            Console.WriteLine($"Привет всем!");
            // Вывод текущего времени
            Console.WriteLine(DateTime.Now);
            // Вывод результата
            Console.WriteLine($"Сумма равна: {totall}");
        }

        /// <summary>
        /// Генерация одномерного массива длинны n
        /// с необходимыми значениями членов массива.
        /// </summary>
        /// <returns>Массив типа int.</returns>
        private static double[] CreateArray()
        {
            Console.WriteLine($"Введите размер массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] massiv = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($" Введите {i + 1} член массива: ");
                massiv[i] = Convert.ToDouble(Console.ReadLine());
            }

            return massiv;
        }

        /// <summary>
        /// Выводит массив в консоль
        /// </summary>
        /// <param name="massiv">Одномерный массив.</par
        private static void OutputArray(double[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"{massiv[i]} ");
            }

            Console.WriteLine("\n");
        }
    }
}
