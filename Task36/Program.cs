
int N = ReadInt("Введите размер массива: ");
int[] array = new int[N];

FillArrayWithRandomNumbers(N, array);

int evenCount = GetSummOfElementsWithUnevenIndexes(array);

Console.WriteLine("Сумма элементов с нечетными индексами: " + evenCount);


int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

static void FillArrayWithRandomNumbers(int N, int[] array)
{
    Random rnd = new Random();
    Console.Write("Array = {");
    for (int i = 0; i < N; i++)
    {
        array[i] = rnd.Next(-99, 100);
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("}");
}

static int GetSummOfElementsWithUnevenIndexes(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }

    return summ;
}