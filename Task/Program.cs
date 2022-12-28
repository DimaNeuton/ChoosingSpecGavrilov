// Написать программу, которая из имеющегося массивы строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void NewArray(out string[] newArray, string[] array, int k)
{
    newArray = new string[k];
    int i = 0;
    foreach (string a in array)
    {
        if (a.Length <= 3)
        {
            newArray[i] = a;
            i++;
        }
    }
}

void PrintNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    System.Console.Write($"{newArray[i], 5}");
}

string[] array = {"dog", "cat", "bird", "fish", "snake"};
// Определяем количество (k) элементов массива, состоящих из 3 и менее символов
int k = 0;
foreach (string a in array)
{
    if (a.Length <= 3) k++;
}
// создаем массив из k элементов
string[] newArray = new string[k];
// наполняем новый массив нужными элементами
NewArray(out newArray, array, k);
// выводим массив на экран
PrintNewArray(newArray);
