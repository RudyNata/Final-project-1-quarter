// Написать прогрумму, которая из имеющегося массива строк формирует
// массив из строк, длинна которых меньше либо равно 3 символа
// "hello", "2", "world", ":=)"

void PrintArray(string[] collection)
{
    int count = collection.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{collection[position]}, "); 
    }
    Console.WriteLine();
}

string[] Array1 (string[] mass)
{
    int lenghtNewArr = 0;
    for (int index = 0; index < mass.Length; index++)
    {
        if(mass[index].Length < 4) lenghtNewArr++;
    }

    string[] newArr = new string[lenghtNewArr];
    int j = 0;

    for (int index = 0; index < mass.Length; index++)
    {
        if(mass[index].Length < 4)
        {
            newArr[j] = mass[index];
            j++;
        }
    }
    return newArr;
}

string[] array = {"hello", "2", "world", ":=)"};
string[] arrNew = Array1(array);
PrintArray(arrNew);