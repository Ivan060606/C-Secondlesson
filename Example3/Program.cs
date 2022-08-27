Console.WriteLine("ВВедите цифру, обозначающую день недели");
int a = Convert.ToInt32(Console.ReadLine());
if (0<a && a<8)
    {
    if (0<a && a<6) Console.WriteLine("Будний день");
    else Console.WriteLine("Выходной день");
    }
else Console.WriteLine("введите корректную цифру");