// Написать программу для
// перевода римских чисел в десятичные арабские.
Console.Clear();

void Main()
{
Console.Write("Введите римское число: ");
string romNum = Console.ReadLine()!;
bool check = InputValidaition(romNum);
if (check == true)
{
    int result = RomToArabNumber(romNum);
    if (result > 0) Console.Write($" --> {result}");
}
}

bool InputValidaition(string text)
{
    string symbol = "IVXLCDM ";
    bool input = true;
    
    for (int i = 0; i < symbol.Length; i += 2)
    {
        bool exception = true;
        int sum1 = 0;
        int sum2 = 0;
        string check = $"{symbol[i]}{symbol[i+1]}";
        foreach (char el in text)
        {
            if (el == symbol[i])
            {
                sum1 += 1;
            }
            if (el == symbol[i+1])
            {
                sum2 += 1;
            }
        }
        if (exception == text.Contains(check))
        {
            if (sum1 > 1 || sum2 > 1)
            {
                return Error(input);
            }
        }
        else 
        {
            if (sum1 > 3 || sum2 > 1)
            return Error(input);
        }
    }
    return Subsecuence(text, input);
}

bool Subsecuence(string text, bool i)
{
    string symbol = "IVXLCDM ";
    for (int j = text.Length - 1; j > 0; j --)
    {
        char s1 = text[j];
        char s2 = text[j-1];
        int pos1 = symbol.IndexOf(s1);
        int pos2 = symbol.IndexOf(s2);
        if (pos1 > pos2)
        {
            if (pos1 % 2 != 0)
            {
                if (pos1 - pos2 == 1)
                    break;
                else
                    return Error(i);
            }
            if (pos1 % 2 == 0)
            {
                if (pos1 - pos2 == 2)
                    break;
                else   
                    return Error(i);
            }
        }
    }
    return i;
}

bool Error(bool value)
{
    Console.WriteLine("Римское число введено неверно ");
    return value = false;
}

int RomToArabNumber(string roman)
{
    int arNum = 0;
    foreach (char el in roman)
    {
        switch (el)
        {
            case 'I': 
                arNum += 1;
                break;
            case 'V': 
                arNum += 5;
                break;
            case 'X': 
                arNum += 10;
                break;
            case 'L': 
                arNum += 50;
                break;
            case 'C': 
                arNum += 100;
                break;
            case 'D': 
                arNum += 500;
                break;
            case 'M': 
                arNum += 1000;
                break;
            default: 
                Console.Write("Введены недопустимые символы ");
                return arNum = 0;
        }
    }
    arNum = Exception(roman, arNum);
    return arNum;
}

int Exception(string test, int finalNumber)
{
    string symbol = "IVXLCDM";
    for (int i = 0, x = 2; i < symbol.Length - 2; i += 2, x *= 10)
    {
        string check1 = $"{symbol[i]}{symbol[i+1]}";
        string check2 = $"{symbol[i]}{symbol[i+2]}";
        bool exception = true;
        finalNumber -= exception == test.Contains(check1)? x : 0;
        finalNumber -= exception == test.Contains(check2)? x : 0;
    }
    return finalNumber;
}

Main();