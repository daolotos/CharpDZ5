
int N = ReadInt("Введите размер массива: ");
float[] array = new float[N];

FillArrayWithRandomNumbers(N, array);

float max = GetMaxValue(array);
float min = GetMinValue(array);

Console.WriteLine("Разница между максимальным и минимальным элементом: " + (max - min));

int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

static void FillArrayWithRandomNumbers(int N, float[] array)
{
    Random rnd = new Random();
    Console.Write("Array = {");
    for (int i = 0; i < N; i++)
    {
        array[i] = (float)rnd.NextDouble() * 10;
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("}");
}

static float GetMaxValue(float[] array)
{
    float max = array[0];
    foreach (float x in array)
    {
        if (x > max)
            max = x;
    }

    return max;
}

static float GetMinValue(float[] array)
{
    float min = array[0];
    foreach (float x in array)
    {
        if (x < min)
            min = x;
    }

    return min;
}
