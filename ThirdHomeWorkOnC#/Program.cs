// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double x1, double y1, double z1, double x2, double y2, double z2) 
//  {
//     double catet1 = x1 - x2;
//     double catet2 = y1 - y2;
//     double catet3 = z1 - z2;
//     double result = Math.Sqrt(catet1*catet1 + catet2*catet2 + catet3*catet3);
//     return Math.Round(result,2);
//  } 
//  Console.Write("Введите координаты x1: ");
//  double result1 = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите координаты y1: ");
//  double result2 = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите координаты z1: ");
//  double result3 = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите координаты x2: ");
//  double result4 = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите координаты y2: ");
//  double result5 = Convert.ToDouble(Console.ReadLine());
//  Console.Write("Введите координаты z2: ");
//  double result6 = Convert.ToDouble(Console.ReadLine());
//  double answer = Distance(result1, result2, result3, result4, result5, result6);
//  Console.WriteLine($"Расстояние между тремя точками в 3D пространстве: {answer}");

 // ------------------------------------------------------------------------------------------------

 // Напишите программу, которая принимает на вход
 // число (N) и выдаёт таблицу кубов чисел от 1 до N.

 void CubeNumber(int number) 
 {
    // for (int i = 1; i <= number; i++)
    // {
    //     Console.Write($"{Math.Pow(i,3)} ");
    // }
    
// Решил через массив, но немного подогнал так сказать результат:

    int[] array = new int[number + 1];
    for(int i = 1; i < array.Length; i++)
    {
        array[i] = i * i * i;
        Console.Write(array[i] + " ");
    }
 }
 Console.Write("Введите число и увидите последовательность его кубов: ");
 int result = Convert.ToInt32(Console.ReadLine());
 CubeNumber(result);
 
 // ------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число
// и проверяет, является ли оно палиндромом.

// Павел, я знаю что это задание иногда дают на собеседованиях,
// поэтому попытался решить его не только для чисел.

// bool Palindrom(string str) 
// {
//     if(str == "") 
//         throw new Exception("Не-не, ты должен ввести что-нибудь!");
//     char[] charArr = str.ToCharArray();
//     char[] charArrForCompare = str.ToCharArray();
//     Console.WriteLine(charArrForCompare);
//     for (int i = 0; i < charArr.Length / 2; i++) 
//         {
//         char s1 = charArr[i];
//         charArr[i] = charArr[charArr.Length - 1 - i];
//         charArr[charArr.Length - 1 - i] = s1;
//         }
//     Console.WriteLine(charArr);
//     return Enumerable.SequenceEqual(charArr, charArrForCompare);
// }
// Console.Write("Давай, друг, проверим является ли строка палиндромом, вводи скорее: ");
// string str = Console.ReadLine();
// Console.Write($"{Palindrom(str)}");