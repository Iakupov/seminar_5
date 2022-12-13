int[] ArrayCreator(int min, int max, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(min, max);
    return array;
}
int SumCounter(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1) sum += array[i];
    }
    return sum;
}
Console.WriteLine("Введите min число массива, max число массива, n количествео элементов массива через пробел");
int[] InitialData = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(SumCounter(ArrayCreator(InitialData[0], InitialData[1], InitialData[2])));
