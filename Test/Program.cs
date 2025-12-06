/*
Console.WriteLine("Matnni kiritin: ");
string text = Console.ReadLine();
int harflar = 0;
int raqamlar = 0;
int boshqa = 0;
for (int i = 0; i < text.Length; i++)
{
    char c = text[i];
    if (char.IsLetter(c))
    {
        harflar++;
    }
    else if (char.IsDigit(c))
    {
        raqamlar++;
    }
    else
        boshqa++;

}
Console.WriteLine($"matndagi harflar soni {harflar}");
Console.WriteLine($"Matndagi raqamlar soni {raqamlar}");
Console.WriteLine($"matndagi boshqa {boshqa}");
*/


/*
Console.WriteLine("Matnni kiriting: ");
string text = Console.ReadLine();
int words = 0;
bool wordStarted = false;
for (int i = 0; i < text.Length; i++)
{
    if (text[i] != ' ' && !wordStarted)
    {
        words++;
        wordStarted = true;
    }
    else if (text[i] == ' ')
        wordStarted = false;
}
Console.WriteLine($"So'zlar soni {words}");
*/

/*
Console.WriteLine("MAtnni kiriting: ");
string text = Console.ReadLine();
int count = 0;
for (int i = 0; i < text.Length; i++)
{
    if (char.IsUpper(text[i]))
    {
        count++;
    }
}
Console.WriteLine($"Matndagi katta harflar soni {count}");
*/

/*
Console.WriteLine("Matnni kiriting: ");
string text = Console.ReadLine();
for (int i = 0; i<text.Length; i++)
{
    Console.WriteLine(text[i]);
}
*/

/*
Console.WriteLine("Matnni kiriting: ");
string text = Console.ReadLine();
string result = "";
string current = "";
for (int i = 0; i < text.Length; i++)
{
    if (text[i] != ' ')
    {
        current += text[i];
    }
    else
    {
        for (int j = current.Length - 1; j >= 0; j--)
        {
            result += current[j];
        }
        result += " ";
        current = "";
    }
}
for (int j = current.Length - 1; j >= 0; j--)
{
    result += current[j];
}
Console.WriteLine(result);
*/

/*
Console.WriteLine("So'zni kiriting: ");
string s = Console.ReadLine();
bool isPalindrome = true;
for (int i = 0; i < s.Length / 2; i++)
{
    if (s[i] != s[s.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}
Console.WriteLine(isPalindrome);
*/


Console.WriteLine("Matnni kiriting: ");
string text = Console.ReadLine();
string result = "";
for (int i = 0; i < text.Length; i++)
{
    if (char.IsLetter(text[i]))
    {
        result += text[i];
    }
}
Console.WriteLine(result);



/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Shaklni tanlang:");
        Console.WriteLine("1 - To'rtburchak");
        Console.WriteLine("2 - Uchburchak");
        Console.Write("Tanlov: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        char symbol = '*';

        Console.Write("\nBalandlik: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.Write("Eni: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        if (choice == 1)
            DrawRectangle(symbol, height, width);
        else if (choice == 2)
            DrawTriangle(symbol, height);
        else
            Console.WriteLine("Noto'g'ri tanlov!");
    }

    static void DrawRectangle(char symbol, int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
                Console.Write(symbol);

            Console.WriteLine();
        }
    }

    static void DrawTriangle(char symbol, int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(symbol);

            Console.WriteLine();
        }
    }
}
*/
