Writer(N());

int N()
{
    Console.WriteLine("введите N");
    var N = Convert.ToInt32(Console.ReadLine());
    while (N < 1)
    {
        Console.WriteLine("введено неправильное значение");
        N = Convert.ToInt32(Console.ReadLine());
    }
    return N;
}


void Writer (int N)
{
    if (N > 0)
    {
        Console.Write(N + (N>1 ? ",":""));
        Writer(N - 1);
    }

}