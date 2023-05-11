namespace operatorler;
class Program
{
    static void Main(string[] args)
    {
        //Atama ve işlemli atama
        Console.WriteLine("****Atama ve işlemli atama****");
        int x = 3;
        int y = 3;
        y = y + 2;

        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        //Mantıksal operatorler
        Console.WriteLine("****Mantıksal operatorler****");

        bool isSucces = true;
        bool isComoplete = false;

        if (isSucces && isComoplete)
            Console.WriteLine("Perfect!");
        if (isSucces || isComoplete)
            Console.WriteLine("Great!");
        if (isSucces && !isComoplete)
            Console.WriteLine("Fine!");

        //İlişkisel operatorler
        Console.WriteLine("****İlişkisel operatorler****");
        int a = 3;
        int b = 4;
        bool sonuc = a < b;
        Console.WriteLine(sonuc);
        sonuc = a > b;
        Console.WriteLine(sonuc);
        sonuc = a >= b;
        Console.WriteLine(sonuc);
        sonuc = a <= b;
        Console.WriteLine(sonuc);
        sonuc = a == b;
        Console.WriteLine(sonuc);
        sonuc = a != b;
        Console.WriteLine(sonuc);


        Console.WriteLine("****Aritmetik operatorler*****");


        // /,*,+,-
        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1 / sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sonuc1++;
        Console.WriteLine(sonuc1);

        // % : mod alır
        int sonuc2 = 20 % 3;
        Console.WriteLine(sonuc2);
    }
}
