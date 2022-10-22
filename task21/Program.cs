// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки x");
int x1 =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y");
int y1 =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки z");
int z1 =  int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки x");
int x2 =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки y");
int y2 =  int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки z");
int z2 =  int.Parse(Console.ReadLine());

Distance(x1, y1, z1, x2, y2, z2); // Тут я уже не забыл объявить функцию как на семинаре)

void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Pow ((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)*1.0), 0.5); //Теорему Пифагора пришлось загуглить(
    Console.WriteLine($"Расстояние = {distance}");
}
