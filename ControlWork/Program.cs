/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/


Console.WriteLine("Введите элементы массива (через запятую):");
string[] initialArray = Console.ReadLine().Split(',');
string[] newArray = new string[initialArray.Length];
int newIndex = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= 3)
    {
        newArray[newIndex] = initialArray[i];
        newIndex++;
    }
}
string[] finalArray = new string[newIndex];
Array.Copy(newArray, finalArray, newIndex);
Console.WriteLine("Результат:");
foreach (string element in finalArray)
    Console.Write(element + ", ");
