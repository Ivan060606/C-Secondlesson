Console.Write("ВВедите количество программистов в комнате ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
Console.Write("В комнате "+b);
if (100<a) a=a%100;
if (4<a && a<21) Console.WriteLine(" программистов");
else
    {
    a=a%10;
    if (a==1) Console.WriteLine(" программист");
    else if (1<a && a<5) Console.WriteLine(" программистa");
    else Console.WriteLine(" программистов");
    }