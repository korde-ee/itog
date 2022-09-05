//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина который меньше либо равна 3 символа. 
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

string[] stringArrayA = new string[5];

for (int i = 0; i < stringArrayA.Length; i++)
{
    Console.Write("Input syting element inn array: ");
    string str = Convert.ToString(Console.ReadLine());
    stringArrayA[i] = str;
}

ShowArray(stringArrayA);
