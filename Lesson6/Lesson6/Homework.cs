namespace Lesson6
{
    internal class Homework
    {
        public static void Main()
        {
            Console.WriteLine("Введіть a:");
            string? a1 = Console.ReadLine();
            Console.WriteLine("Введіть b:");
            string? b1 = Console.ReadLine();
            Console.WriteLine("Введіть c:");
            string? c1 = Console.ReadLine();
            Console.WriteLine("Введіть f:");
            string? f1 = Console.ReadLine();
            Console.WriteLine("Введіть h:");
            string? h1 = Console.ReadLine();

            bool resulta = int.TryParse(a1, out int a);
            bool resultb = int.TryParse(b1, out int b);
            bool resultc = int.TryParse(c1, out int c);
            bool resultf = int.TryParse(f1, out int f);
            bool resulth = int.TryParse(h1, out int h);

            if (resulta && resultb && resultc && resultf && resulth)
            {
                int[] arrayForSort = new int[5] { a, b, c, f, h };
                Console.WriteLine();
                Console.WriteLine($"Введений масив перед сортуванням:");
                printArray(arrayForSort);

                SelectionSort(arrayForSort);
                BubbleSort(arrayForSort);
                InsertionSort(arrayForSort);

                Sort(SortAlgorithmType.SelectionSort, arrayForSort);
                Sort(SortAlgorithmType.BubbleSort, arrayForSort);
                Sort(SortAlgorithmType.InsertionSort, arrayForSort);

                SortWithOrderBy(OrderBy.Asc, SortAlgorithmType.SelectionSort, arrayForSort);
                SortWithOrderBy(OrderBy.Asc, SortAlgorithmType.BubbleSort, arrayForSort);
                SortWithOrderBy(OrderBy.Asc, SortAlgorithmType.InsertionSort, arrayForSort);
                SortWithOrderBy(OrderBy.Desk, SortAlgorithmType.SortDesk, arrayForSort);              

            }

            else
            {
                Console.WriteLine("Введено некоректні дані. Будь ласка, введіть коректні числа!");
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minElement = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[minElement])
                        minElement = j;

                int temp = arr[minElement];
                arr[minElement] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("Масив відсортований за допомогою методу сортування SelectionSort:");
            printArray(arr);
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

            Console.WriteLine("Масив відсортований за допомогою методу сортування BubbleSort:");
            printArray(arr);
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            Console.WriteLine("Масив відсортований за допомогою методу сортування Insertion Sort:");
            printArray(arr);
        }

        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\n");
        }


        //EctraHomework
        enum SortAlgorithmType
        {
            SelectionSort,
            BubbleSort,
            InsertionSort,
            SortDesk,
        }

        enum OrderBy
        {
            Asc,
            Desk,
        }

        static void Sort(SortAlgorithmType sortAlgorithm, int[] arr)
        {
            switch (sortAlgorithm)
            {

                case SortAlgorithmType.SelectionSort:
                    SelectionSort(arr);
                    break;
                case SortAlgorithmType.BubbleSort:
                    BubbleSort(arr);
                    break;
                case SortAlgorithmType.InsertionSort:
                    InsertionSort(arr);
                    break;
                case SortAlgorithmType.SortDesk:
                    SortDesk(arr);
                    break;


                default:
                    Console.WriteLine("Щось пішло не так, спробуйте ще)");
                    break;
            }
        }

        public static void SortDesk(int[] arr)
        {
            for (int a = 0; a < arr.Length; a++)
                for (int b = arr.Length - 1; b > a; b--)
                    if (arr[b] > arr[b - 1])
                    {
                        int temp = arr[b];
                        arr[b] = arr[b - 1];
                        arr[b - 1] = temp;
                    }

            Console.WriteLine("Масив відсортований від найбільшого до найменшого введеного значення:");
            printArray(arr);
        }

        static void SortWithOrderBy(OrderBy orderBy, SortAlgorithmType sortAlgorithm, int[] arr)
        {
            switch (orderBy)
            {

                case OrderBy.Asc:
                    Sort(sortAlgorithm, arr);
                    break;
                case OrderBy.Desk:
                    Sort(sortAlgorithm, arr);                                 
                    break;

                default:
                    Console.WriteLine("Щось пішло не так, спробуйте ще)");
                    break;
            }
        }
    }
}