// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
		// лучше обойтись исключительно массивами.
		// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
		// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
		// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[9] {"123", "23", "hello", "world", "res","1234", "1567", "-2", "Ufa"};
string[] array2 = new string[array1.Length];
void ArrayCheck(string[] array1, string[] array2) // Проверка на количество символов 
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
ArrayCheck(array1, array2);
Console.WriteLine("Все элеменнты массива где количество символов в строке <= 3");
PrintArray(array2);
