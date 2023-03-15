// See https://aka.ms/new-console-template for more information

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
