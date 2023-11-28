try
{
    student[] stud = new student[10];
    double totalAverage = 0;
    for (int i = 0; i < stud.Length; i++)
    {
        Console.WriteLine($"введите данные для студента №{i + 1}:");
        Console.WriteLine("введите имя и фамилию:");
        string name = Console.ReadLine();
        Console.WriteLine("курс:");
        int kurs = int.Parse(Console.ReadLine());
        Console.WriteLine("введите оценки за 5 сессий:");
        int[] ses = new int[5];
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine($"введите оценку за сессию{j + 1}:");
            ses[j] = int.Parse(Console.ReadLine());
        }
        stud[i].fio = name;
        stud[i].kurs = kurs;
        stud[i].SES = ses;
        totalAverage += CalculateAverage(ses);

    }
    Array.Sort(stud, (x, y) => x.fio.CompareTo(y.fio));
    double overallArage = totalAverage / stud.Length;
    bool found = false;
    Console.WriteLine("студенты с средним баллом выше среднего:");
    foreach (var student in stud)
    {
        double studentAverage = CalculateAverage(student.SES);
        if (studentAverage > overallArage)
        {
            Console.WriteLine($"имя: {student.fio}, средний балл: {studentAverage}");
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("нет студентов с средним баллом выше общего среднего");
    }
    static double CalculateAverage(int[] arr)
    {
        double sum = 0;
        foreach (var num in arr)
        {
            sum += num;
        }
        return sum / arr.Length;
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct student
{
    public string fio;
    public int kurs;
    public int[] SES;
}
