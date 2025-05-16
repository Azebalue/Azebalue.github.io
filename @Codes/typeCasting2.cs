
object stringO = "Hello";
object intO = 123;
object floatO = 12.3;

//Unboxing
Console.WriteLine("문자열 길이"+ ((string)stringO).Length);

//as
string? str = stringO as string;
if(str != null)
    Console.WriteLine(str);

str = intO as string;
if (str != null)
    Console.WriteLine(str);

int? intN = stringO as int?;
if (intN != null)
    Console.WriteLine(intN);

//ConvertType
int convertedInt = Convert.ToInt32(floatO);
Console.WriteLine($"ConvertType : {floatO} => {convertedInt}");

//is 연산자
if(intO is int)
{
    Console.WriteLine($"intO타입: int {(int)intO}");
}
else if(intO is string)
    Console.WriteLine("intO타입: string");


Console.ReadKey();

