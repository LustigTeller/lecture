// Собрать строку с числами от a до b, a >= b


/*
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i >= b; i++)
        result += $"{i} ";
    return result;
}

string NumbersRec (int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersFor(15, 91));
Console.WriteLine(NumbersRec(15, 91));
*/

// Факториал числа
/*
int FactorialFor (int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}


int FactorialRec (int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(7));
Console.WriteLine(FactorialRec(5));
*/

// Текст
/*
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
        Console.WriteLine($"{n++} {new String(word)}"); return;
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("афис", new char[3]);
*/