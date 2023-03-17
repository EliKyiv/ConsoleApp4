// See https://aka.ms/new-console-template for more information

Console.WriteLine(LargestOf3(12, 13, 15));

Console.WriteLine(LowestOf3(12, 15, 13));

Console.WriteLine(CloserTo20(12, 15));

int[] arr = { 1, 2, 3, 4, 5 };
int sum = SumOfArrayElements(arr);
Console.WriteLine("Sum of array elements is: " + sum);

int[] arr1 = { 1, 2, 3, 4, 5 };
int max = GetMaxValue(arr1);
Console.WriteLine("The largest value in the array is: " + max);

static int LargestOf3(int a, int b, int c)
{
    int result;
    if (b > c)
    {
        if (a > b)
        { result = a; }
        else { result = b; }
    }
    else
    {
        if (a > c)
        { result = a; }
        else { result = c; }
    }
    return result;
}

static int LowestOf3(int a, int b, int c)
{
    int result;
    if (b < c)
    {
        if (a < b)
        { result = a; }
        else { result = b; }
    }
    else
    {
        if (a < c)
        { result = a; }
        else { result = c; }
    }
    return result;
}

static int CloserTo20(int a, int b)
{
    int result;
    int da;
    int db;
    da = Math.Abs(20 - a);
    db = Math.Abs(20 - b);
    if (da > db)
    { result = b; }
    else
    { result = a; }

    return result;
}

static int SumOfArrayElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

static int GetMaxValue(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}