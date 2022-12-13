double[] ArrayCreator(int min, int max, int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(min, max);
    return array;
}
double MaxMinSubtractor(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    double sub = max - min;
    return sub;
}
Console.WriteLine("Введите min число массива, max число массива, n количествео элементов массива через пробел");
int[] InitialData = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(MaxMinSubtractor(ArrayCreator(InitialData[0], InitialData[1], InitialData[2])));
