int sum = 0;
int x = 1;
while (x < 101)
{
    Console.WriteLine(x);
    sum = sum + x;
    x = x + 1;
}

Console.WriteLine(sum);