Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b/100>0) 
    {
    string a = Convert.ToString(b); 
    Console.WriteLine(a[2]);
    }
else
    {
    Console.WriteLine("третьей цифры нет");
    }
