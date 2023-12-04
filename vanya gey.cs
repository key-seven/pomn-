int i = 0, z = 1;

int[] array = new int[100];

while ((z = int.Parse(Console.ReadLine())) != 0)
{
    array[i] = Convert.ToInt32(z);
}
for (int k = 0; k < i; k++)
{
    Console.WriteLine(array[k]);
}
int max, min;
max = array.Max();
min = array.Min();

Console.WriteLine("Максимальное значение: " + max + "\nМинимальное значение: " + min);