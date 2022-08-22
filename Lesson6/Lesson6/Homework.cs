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

            Console.WriteLine("Введіть число для вибору методу сортування (SelectionSort - 1, BubbleSort - 2 , InsertionSort - 3):");
            string methodSort = Console.ReadLine();
            SortAlgorithmType sortAlgorithmType = (SortAlgorithmType)Enum.Parse(typeof(SortAlgorithmType), methodSort,true);

            Console.WriteLine("Введіть число для вибору порядок сортування (Asc - 1, Desk - 2):");
            string orderSort = Console.ReadLine();
            OrderBy orderBy = (OrderBy)Enum.Parse(typeof(OrderBy), orderSort,true);

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

                SortWithOrderBy(arrayForSort, sortAlgorithmType, orderBy);
            }

            else
            {
                Console.WriteLine("Введено некоректні дані. Будь ласка, введіть коректні числа!");
            }
        }

        public static int [] SelectionSort(int[] arr)
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

            Console.WriteLine($"Масив відсортований за допомогою методу сортування SelectionSort:");
            return arr;
        }

        public static int[] BubbleSort(int[] arr)
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
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
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
            return arr;
        }

        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\n");
        }


        //ExtraHomework
        public enum SortAlgorithmType
        {
            SelectionSort=1,
            BubbleSort,
            InsertionSort
        }

        public enum OrderBy
        {
            Asc=1,
            Desk,
        }

        static void SortWithOrderBy(int[] arr, SortAlgorithmType sortAlgorithm, OrderBy orderBy)
        {
            switch (sortAlgorithm)
            {

                case SortAlgorithmType.SelectionSort:
                    arr = SelectionSort(arr);
                    break;
                case SortAlgorithmType.BubbleSort:
                    arr = BubbleSort(arr);
                    break;
                case SortAlgorithmType.InsertionSort:
                    arr = InsertionSort(arr);
                    break;                    

                default:
                    Console.WriteLine("Щось пішло не так, спробуйте ще)");
                    break;
            }
            
            arr = orderBy == OrderBy.Desk ? arr.Reverse().ToArray() : arr;
            printArray(arr);
        }
    }
}