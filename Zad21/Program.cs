using static System.Console;
//using System.Math;
Clear();
WriteLine("Введите координаты первой точки  - ");
string[] tokens = Console.ReadLine().Split();
//Parse element 0
int a1 = int.Parse(tokens[0]);
//Parse element 1
int a2 = int.Parse(tokens[1]);
int a3 = int.Parse(tokens[2]);
WriteLine("Введите координаты второй точки  - ");
string[] tokens2 = Console.ReadLine().Split();
int b1 = int.Parse(tokens2[0]);
int b2 = int.Parse(tokens2[1]);
int b3 = int.Parse(tokens2[2]);
double sum = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2));
//sum = Math.Round(sum, 2);
WriteLine(sum);