int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine(" Ведите число с консоли: ");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i++;
}
