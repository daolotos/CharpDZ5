
int a = ReadInt("Введите натуральное число A: ");
int b = ReadInt("Введите натуральное число B: ");

int result = NaturalExp(a, b);

Console.WriteLine("A в степени B: " + result);


int NaturalExp(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
        result = result * a;
    return result;
}

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

