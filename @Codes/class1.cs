Employee employee1 = new Employee("Minji"); //직원 객체/인스턴스 생성
Employee employee2 = new Employee("Joy", 31);
Employee employee3 = new Employee("Anna", 50, false);
Employee employee4 = new Employee("Kate", 61, false);

Console.WriteLine($"\n직원 수: {employee3.getNumsOfEmployee()}");

employee1.printInformation();
employee1.setAge(27);
employee1.printInformation();

employee2.printInformation();
employee3.printInformation(true, false); //선택적 매개변수
employee4.printInformation2("ID","Name", "Club"); //가변 매개변수

Console.ReadKey();


class Employee
{
    #region 필드
    static int numOfEmployee = 0; //직원의 수
    public int ID;
    public string name;
    //경고: string은 null을 허용하지 않음 => 생성자에서 값을 무조건 줘야 함
    public int age;
    public bool hasJoinedClub; //사내동아리 가입 여부
    #endregion

    #region 생성자
    public Employee(string name)
    {
        ID = ++numOfEmployee;
        this.name = name;
    }

    public Employee(string name, int age, bool hasJoinedClub = true)
    {
        ID = ++numOfEmployee;
        this.name = name;
        this.age = age;
        this.hasJoinedClub = hasJoinedClub;
    }


    #endregion

    #region 메서드
    public void printInformation(bool shouldPrintName = true, bool shouldPrintAge = true)
    {
        Console.WriteLine($"\n아이디: {ID} ");
        if(shouldPrintName == true)
            Console.WriteLine($"이름:{name}");
        if (shouldPrintAge == true)
            Console.WriteLine($"나이:{age}");
        if(hasJoinedClub == true)
            Console.WriteLine($"사내 동아리 가입 멤버입니다.");
    }

    //가변 매개변수
    public void printInformation2(params string[] options)
    {
        Console.WriteLine("\n가변 매개변수로 직원 정보 확인하기");
        foreach(string option in options)
        {
            switch (option)
            {

                case "ID":
                    Console.WriteLine("ID: " + option);
                    break;

                case "Name":
                    Console.WriteLine("Name: " + name);
                    break;

                case "Age":
                    Console.WriteLine("Age: " + name);
                    break;

                case "Club":
                    if (hasJoinedClub)
                        Console.WriteLine("사내 동아리 멤버입니다");
                    else
                        Console.WriteLine("가입한 동아리가 없습니다");
                    break;

            }

        }
    }
    public int getNumsOfEmployee()
    {
        return numOfEmployee;
    }

    public void setAge(int age)
    {
        this.age = age;
    }
    #endregion
}