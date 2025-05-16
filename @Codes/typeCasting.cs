
int int1 = 100;
double double1 = int1; //암시적 변환
Console.WriteLine($"int1:{int1}, double1: {double1}");

double double2 = 123.456; 
int int2 = (int) double2; //명시적 변환
Console.WriteLine($"int2:{int2}, double2: {double2}");


Console.ReadKey();

