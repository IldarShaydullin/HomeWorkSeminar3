// Задача : Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

/*
bool Pal(int number)
{
    int num = number;
    string result = "";
    while(num > 0)
    {
        int a = num % 10; 
        num = num / 10;   
        result = result + a;
    }

    int y = int.Parse(result);

    if(y == number)
    {
        bool res = true;
        return res;
    }
    else
    {
        bool res = false;
        return res;
    }
}

Console.Write("Input a number : ");

int x = Convert.ToInt32(Console.ReadLine());
bool go = Pal(x);

Console.WriteLine(go);
*/

// Задача : Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// AB = √ (x b — x a) 2 + (y b — y a) 2 + (z b — z a) 2

/*
double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    distance = Math.Round(distance, 2);
    return distance;
}

Console.Write("Enter the x coordinate of point one : ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y coordinate of point one : ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the z coordinate of point one : ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the x coordinate of point second : ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the y coordinate of point second : ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the z coordinate of point second : ");
double zB = Convert.ToDouble(Console.ReadLine());

double dis = FindDistance(xA, yA, zA, xB, yB, zB);
Console.Write(dis);
*/

// Задача: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(double N)
{
    double count = 1;
    while(N >= count)
    {
        double result = Math.Pow(count, 3);
        Console.Write(result + " ");
        count++;
    }
}

Console.Write("Enter a number : ");
double num = Convert.ToDouble(Console.ReadLine());

Cube(num);
*/








