// Вид 1 

void Method1()
{
    Console.WriteLine("Автор...");
}
// Method1();


// Вид 2 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("текст сообщения", 3);


// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(3, "text");
// Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
// string res = Method4(3, "text");
// Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }




// Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить на черточки,
// маленькие буквы "к" заменить большими буквами "К",
// а большие буквы "С" заменить на маленькие "с".


// string text = " - Я думал, - сказал князь, улыбаясь - что, "
//             + "ежели бы вас послали вместо нашего милого Винцегероде"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречевы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             0123
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.Write(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.Write(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С');
// Console.Write(newText);


int[] arr = { 9, 6, 4, 8, 4, 7, 5, 4, 3 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);