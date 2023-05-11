namespace console_programming;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Adınızı girin:");
        string name = Console.ReadLine();
        Console.WriteLine("Soyadınızı girin:");
        string lastname = Console.ReadLine();
        Console.WriteLine("Merhaba " + name + " " + lastname);

    }
}
