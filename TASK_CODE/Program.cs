// See https://aka.ms/new-console-template for more information

string[] array = {"hello", "2", "world", ":-)"};

Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    int length = array[i].Length;
    if (length <= 3)
    {
        Console.Write(array [i] + ", ");
    }
}
Console.Write("]");