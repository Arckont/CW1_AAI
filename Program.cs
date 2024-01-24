/*Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int Prompt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());    
}

string[] Mas1(int size)
{
    string[] mas1 = new string[size];
    for (int i = 0; i < mas1.Length; i++)
    {
        Console.Write($"Введите строку {i+1} : ");
        mas1[i] = Console.ReadLine()!;
    }
    return mas1;
}

string[] Mas2(string[] array)
{
    string[] mas1 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < mas1.Length; i++)
    {
        if (array[i].Length <=3)
        {
            mas1[count] = array[i];
            count++;
        }
    }
    string[] mas2 = new string[count];
    for (int i = 0; i < count; i++)
        mas2[i] = mas1[i];
    return mas2;
}

void Mas3(string[] array)
{
   Console.Write("[");
   for (int i=0; i<array.Length; i++)
   {
    Console.Write('"'+$"{array[i]}"+'"');
    if (i<array.Length-1) 
        Console.Write(", ");
   }
   Console.Write("]");
    return;
}

int sizeArray = Prompt("Введите количество строк - ");
string[] array1 = Mas1(sizeArray);
string[] array2 = Mas2(array1);
Mas3(array1);
Console.Write(" ---> ");
Mas3(array2);