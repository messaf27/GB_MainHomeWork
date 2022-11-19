
void PrintStringArray(string[] arr )
{
    Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i]);
        if(i != (arr.GetLength(0) - 1))
          Console.Write(", ");  
    }
    Console.Write("]");
}

int CheckArraySymbolsNum(string[] arrIn, int symMum)
{
    int counter = 0;

    for (int i = 0; i < arrIn.GetLength(0); i++)
        if(arrIn[i].Length <= symMum)
            counter++;  

    return counter;        
}

string[] ArrayProcess(string[] arrIn, int symMum)
{
    int indexOut = 0;
    string[] arrOut = new string[CheckArraySymbolsNum(arrIn, symMum)]; 

    for (int i = 0; i < arrIn.GetLength(0); i++)
    {
        if(arrIn[i].Length <= symMum)
        {
            arrOut[indexOut] = arrIn[i];
            indexOut++;
        }
    }

    return arrOut;
}

Console.Write("\r\n=========== Контрольная работа =============\r\n");

string[] inArray = {"reg", "27", "Egor", "Orlenok", "3", "5", "years"};
Console.Write("Исходный массив: "); PrintStringArray(inArray); Console.WriteLine();

string[] outArray = ArrayProcess(inArray, 3);
Console.Write("Полученный массив: "); PrintStringArray(outArray); Console.WriteLine();

/*
Terminal:

=========== Контрольная работа =============
Исходный массив: [reg, 27, Egor, Orlenok, 3, 5, years]
Полученный массив: [reg, 27, 3, 5]
PS D:\01 ОБУЧЕНИЕ\GeekBrains\Итоги блока. Выбор специализации\HW_Main\HW_Project\HW_Program> 

*/