/*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string[] TypeIn(string text) //Метод для ввода строки от пользователя
{
    System.Console.WriteLine(text);
    string[] array = Console.ReadLine().Split(" ");
    return array;
}
int Randomnumber(int anyvalue) // Создание случайного числа в заданных границах
{
    Random rnd = new Random();
    int randomnumber = rnd.Next(0, anyvalue);
    return randomnumber;

}
void PrintArray(string[] array) // Печать массива
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }

}
//--------------------------
string[] firstarray = TypeIn("Please, type in your text using spacekey: ");
int secondarrayLength= Randomnumber(3);
string[] secondarray = new string[secondarrayLength];
for (int i = 0; i < secondarray.Length; i++)
{
    int pastingItem = Randomnumber (firstarray.Length);
    secondarray[i] = firstarray[pastingItem];
}
PrintArray(firstarray);
Console.Write("==>");
PrintArray(secondarray);