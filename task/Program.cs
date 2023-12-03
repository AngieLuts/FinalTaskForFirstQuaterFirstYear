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