// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите для первой точки х1: ");
int y1 = ReadInt("Введите для первой точки y1: ");
int z1 = ReadInt("Введите для первой точки z1: ");

int x2 = ReadInt("Введите для первой точки х2: ");
int y2 = ReadInt("Введите для первой точки y2: ");
int z2 = ReadInt("Введите для первой точки z2: ");

double cathet1 = (x2 - x1) * (x2 - x1);
double cathet2 = (y2 - y1) * (y2 - y1);
double cathet3 = (z2 - z1) * (z2 - z1);

double D = Math.Sqrt(cathet1 + cathet2 + cathet3);

Console.WriteLine(D);

