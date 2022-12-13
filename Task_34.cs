int [] ArrayCreator(int min, int max, int length)
{
    int [] array=new int[length];
    for (int i=0;i<length;i++) array[i]=new Random().Next(min,max);
    return array; 
}
int Counter(int [] array)
{
    int count=0;
    for (int i=0;i<array.Length;i++) 
    {
        if (array[i]%2==0) count+=1;
    }
    return count;
}
Console.WriteLine("Введите min число массива, max число массива, n количествео элементов массива через пробел");
Console.WriteLine("Значения min и max должны быть трехзначными");
int [] InitialData=Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(Counter(ArrayCreator(InitialData[0],InitialData[1],InitialData[2])));
