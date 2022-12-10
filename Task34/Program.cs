
int N = ReadInt("Введите размер массива: ");

int[] array = new int[N];

Random rnd = new Random();
Console.Write("Array = {");
for (int i = 0; i < N; i++)
{
    array[i] = rnd.Next(100, 1000);
    Console.Write(array[i] + ", ");
}
Console.WriteLine("}");

int evenCount = 0;
foreach (int value in array)
{
    if (value % 2 == 0)
        evenCount++;
}

Console.WriteLine("Количество четных чисел: " + evenCount);


int ReadInt(string prompt)
{
    Console.Write(prompt);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

