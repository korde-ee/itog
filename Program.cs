//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина который меньше либо равна 3 символа. 
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

string[] MyNewArray(string[] array)
{
    int m = 0;
    string[] stringArrayB = new string[5];

    for(int j = 0; j < array.Count(); j++)
    {
        if(array[j].Length <= 3)
        {   
            stringArrayB[m] = array[j];
            m++;
        }
    }
    return stringArrayB;
}

void CheckArray(string[] array)
{
    int count = 0;
    for(int j = 0; j < array.Count(); j++)
    {   
        if(array[j].Length <= 3) count++;
    }
    if(count == 0)
    {
        Console.Write("В заданном массиве нет элементов длина которых меньше 3х символов");
    }
}

int size = 5;
string[] stringArrayA = new string[size];

for (int i = 0; i < stringArrayA.Length; i++)
{
    Console.Write("Input element in array: ");
    string str = Convert.ToString(Console.ReadLine());
    stringArrayA[i] = str;
}

ShowArray(stringArrayA);
//CheckArray(stringArrayA);

string[] MyNewStringArray = MyNewArray(stringArrayA);

ShowArray(MyNewStringArray);