// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// (int[], int) array = Array(5);
// (int[], int count) Array(int size)
// {
//     int[] result = new int[size];
//     var count = 0;
//     Console.Write("Массив [ ");
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-1000, 1000);
//         if (result[i] > 0)
//         {
//             count++;
//         }
//                 Console.Write(result[i] + " ");
        
//     }
//     Console.Write("] - ");
//     Console.WriteLine($"Количество чисел больше 0 равно {count}");
//     return (result, count);
// }



Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел больше 0 равно {count}");


