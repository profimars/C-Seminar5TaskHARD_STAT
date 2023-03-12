// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив 
// и вывести на экран с пояснениями. Найти медианное значение первоначального 
// массива , возможно придется кое-что для этого дополнительно выполнить.
//https://github.com/profimars/C-Seminar5TaskHARD_STAT
void FillArray(int[] AA)
{
    Random rnd = new Random();
    for (int i = 0; i < AA.Length; i++)
        AA[i] = rnd.Next(0, 100);
}
void PrintArray(int[] AA)
{
    foreach (int element in AA)
    {
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}
int[] VseDannie(int[] AA)
{
    int[] QQ = new int[5];
    int max = AA[0];
    int min = AA[0];
    int max_i = 0;
    int min_i = 0;
    int sum = 0;
    int sred = 0;
    int size = AA.Length;
    for (int i = 0; i < size; i++)
    {
        if (AA[i] > max)
        {
            max = AA[i];
            max_i = i;
        }
        else
            if (AA[i] < min)
        {
            min = AA[i];
            min_i = i;
        }
        sum = sum + AA[i];
    }
    sred = sum / size;
    QQ[0] = max;
    QQ[1] = max_i;
    QQ[2] = min;
    QQ[3] = min_i;
    QQ[4] = sred;
    return QQ;
}
int[] Sort(int[] AA)
{
    int size = AA.Length;
    for (int i = 0; i < size; i++)
    {
        int min_index = i;
        for (int j = i + 1; j < size; j++)
        {
            if (AA[j] < AA[min_index])
            {
                min_index = j;
            }
        }
        int q = AA[min_index];
        AA[min_index] = AA[i];
        AA[i] = q;
    }
    return AA;
}
decimal Median(int[] AA)
{
    int size = AA.Length;
    int point = size / 2;
    Console.WriteLine("point = " + point);
    if (size % 2 == 0)
    {
        int element1 = AA[point - 1];
        int element2 = AA[point + 0];
        decimal sred = (element1 + element2) / 2;
        Console.WriteLine("element1 = " + element1);
        Console.WriteLine("element2 = " + element2);
        return sred;
    }
    else
    {
        return AA[point];
    }
}
Console.WriteLine("Введите количество элементов в массиве а");
int a = Convert.ToInt32(Console.ReadLine());
int[] AA = new int[a];
FillArray(AA);
PrintArray(AA);
int[] rezAA = VseDannie(AA);
PrintArray(rezAA);
int[] rezWW = Sort(AA);
PrintArray(rezWW);
decimal median = Median(rezWW);
Console.WriteLine("Медианное значение первоначального массива = " + median);