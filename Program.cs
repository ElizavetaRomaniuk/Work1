//Из массива строк сформировать массив строк, длина кототрых меньше, 
//либо равна 3 символам. 


static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(string[] arrayFill)
{
    for (int i = 0; i < arrayFill.Length; i++)
    {
        System.Console.WriteLine($"Please enter ({i+1}) element of array");
        arrayFill[i] = Console.ReadLine();
        System.Console.WriteLine();
    }
}

int count = 0;

void arrayCounting(string[] arrayCount)
{
    for(int i = 0; i < arrayCount.Length; i++)
    {
        if(arrayCount[i].Length < 4)
        {
            count = count + 1;
        }
    }
}

void arrayCompareLengthOfString(string[] arrayCLOS, string[] arrayShow)
{
    for (int i = 0, index = 0; i < arrayCLOS.Length; i++)
    {
        if (arrayCLOS[i].Length < 4)
        {
            arrayShow[index] = arrayCLOS[i];
            index = index + 1;
        }
    }
}


