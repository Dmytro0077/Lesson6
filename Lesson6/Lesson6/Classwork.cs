////Array

////Приклад1
////Declare a single-dimensional array of 5 integers.
//        int[] array1 = new int[5];
//// Declare and set array element values.
//int[] array2 = new int[] { 1, 3, 5, 7, 9 };
//// Alternative syntax.
//int[] array3 = { 1, 2, 3, 4, 5, 6 };


////Приклад2
//// Declare a two dimensional array.
//        int[,] multiDimensionalArray1 = new int[2, 3];
//// Declare and set array element values.
//int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };


////Приклад3
//// Declare a jagged array.
//        int[][] jaggedArray = new int[6][];


////Приклад4
//string[] weekDays2 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//Console.WriteLine(weekDays2[0]);
//Console.WriteLine(weekDays2[1]);
//Console.WriteLine(weekDays2[2]);
//Console.WriteLine(weekDays2[3]);
//Console.WriteLine(weekDays2[4]);
//Console.WriteLine(weekDays2[5]);
//Console.WriteLine(weekDays2[6]);


////Приклад5
//// Two - dimensional array.
//int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//// The same array with dimensions specified.
//int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
//// A similar array with string elements.
//string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
//                                        { "five", "six" } };
//// Three-dimensional array.
//int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
//                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
//// The same array with dimensions specified.
//int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
//                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

////// Accessing array elements.
////System.Console.WriteLine(array2D[0, 0]);
////System.Console.WriteLine(array2D[0, 1]);
////System.Console.WriteLine(array2D[1, 0]);
////System.Console.WriteLine(array2D[1, 1]);
////System.Console.WriteLine(array2D[3, 0]);
////System.Console.WriteLine(array2Db[1, 0]);
////System.Console.WriteLine(array3Da[1, 0, 1]);
////System.Console.WriteLine(array3D[1, 1, 2]);


//// Getting the total count of elements or the length of a given dimension.
//var allLength = array3D.Length;
//var total = 1;
//for (int i = 0; i < array3D.Rank; i++)
//{
//    total *= array3D.GetLength(i);
//}
//System.Console.WriteLine("{0} equals {1}", allLength, total);


////Приклад6
//int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
//foreach (int i in numbers)
//{
//    System.Console.Write("{0} ", i);
//}


////Приклад7
//int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
//foreach (int i in numbers2D)
//{
//    System.Console.Write("{0} ", i);
//}


////Приклад8
//static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
//// Change the array by reversing its elements.
//static void ChangeArray(string[] arr) => Array.Reverse(arr);
//static void ChangeArrayElements(string[] arr)
//{
//    // Change the value of the first three array elements.
//    arr[0] = "Mon";
//    arr[1] = "Wed";
//    arr[2] = "Fri";
//}

//// Declare and initialize an array.
//string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//// Display the array elements.
//DisplayArray(weekDays);
//Console.WriteLine();
//// Reverse the array.
//ChangeArray(weekDays);
//// Display the array again to verify that it stays reversed.
//Console.WriteLine("Array weekDays after the call to ChangeArray:");
//DisplayArray(weekDays);
//Console.WriteLine();
//// Assign new values to individual array elements.
//ChangeArrayElements(weekDays);
//// Display the array again to verify that it has changed.
//Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
//DisplayArray(weekDays);


////приклад9
//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine(result);
//}


//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum();


////приклад10
//void Sum(int initialValue, params int[] numbers)
//{
//    int result = initialValue;
//    foreach (var n in numbers)
//    {
//        result += n;
//    }
//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(10, nums);
//Sum(1, 2, 3, 4);
//Sum(1, 2, 3);
//Sum(20);


////приклад11
//int[][] jaggedArray = new int[3][];

//jaggedArray[0] = new int[5];
//jaggedArray[1] = new int[4];
//jaggedArray[2] = new int[2];

//jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
//jaggedArray[1] = new int[] { 0, 2, 4, 6 };
//jaggedArray[2] = new int[] { 11, 22 };


////Приклад12
//int[][] jaggedArray2 = new int[][]
//{
//new int[] { 1, 3, 5, 7, 9 },
//new int[] { 0, 2, 4, 6 },
//new int[] { 11, 22 }
//};


////Приклад13
//int[][] jaggedArray3 =
//{
//    new int[] { 1, 3, 5, 7, 9 },
//    new int[] { 0, 2, 4, 6 },
//    new int[] { 11, 22 }
//};

//// Assign 77 to the second element ([1]) of the first array ([0]):
//jaggedArray3[0][1] = 77;
//// Assign 88 to the second element ([1]) of the third array ([2]):
//jaggedArray3[2][1] = 88;


//////Приклад14
//// Declare the array of two elements.
//int[][] arr = new int[2][];
//// Initialize the elements.
//arr[0] = new int[5] { 1, 3, 5, 7, 9 };
//arr[1] = new int[4] { 2, 4, 6, 8 };
//// Display the array elements.
//for (int i = 0; i < arr.Length; i++)
//{
//    System.Console.Write("Element({0}): ", i);
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
//    }
//    System.Console.WriteLine();
//}
//// Keep the console window open in debug mode.
//System.Console.WriteLine("Press any key to exit.");
//System.Console.ReadKey();


////Приклад15
var tuple = (5, 10);

Console.WriteLine(tuple.Item1);

Console.WriteLine(tuple.Item2);

tuple.Item1 += 26;

Console.WriteLine(tuple.Item1);

(int, int) tuple2 = (5, 10);
(string, int, double) person = ("Tom", 25, 81.23);