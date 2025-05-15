//매개변수: Value Type VS Reference Type
// + string Type

int[] nums = new int[] { 10 };
string a = "a";

changeValueTypeVar(nums[0]);
Console.WriteLine("원본: " + nums[0]);

changeReferenceTypeVar(nums);
Console.WriteLine("원본: " + nums[0]);

changeStringTypeVar(a);
Console.WriteLine("원본: " + a);


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
void changeStringTypeVar(string  a)
{
    a = "b";
    Console.WriteLine("사본: " + a);

}