/*매개변수
 * Value Type VS Reference Type
 * string Type
 * ref 키워드
 * out 키워드
 * */

int[] nums = new int[] { 1 };
string a = "a";
string text = "1";

changeValueTypeVar(nums[0]);
Console.WriteLine($"원본: {nums[0]}\n");

changeReferenceTypeVar(nums);
Console.WriteLine($"원본: {nums[0]}\n");

changeStringTypeVar(a);
Console.WriteLine($"원본: {a}\n");

usingRef(ref a);
Console.WriteLine($"원본: {a}\n");

#region ref 키워드
bool answer = int.TryParse(text, out int result);
if (answer == true)
    Console.WriteLine($"성공 결과: {result}");
else
    Console.WriteLine($"실패 변환");

answer = int.TryParse(a, out result);
if (answer == true)
    Console.WriteLine($"성공 결과: {result}");
else
    Console.WriteLine($"변환 실패 ");

#endregion

Console.ReadKey();

void changeValueTypeVar(int num)
{
    ++num;
    Console.WriteLine("사본: " + num);
}

void changeReferenceTypeVar(int[] nums)
{
    ++nums[0];
    Console.WriteLine("사본: " + nums[0]);

}
void changeStringTypeVar(string a)
{
    a = "b";
    Console.WriteLine("사본: " + a);

}

void usingRef(ref string a)
{
    a = "b";
    Console.WriteLine("사본: " + a);

}

