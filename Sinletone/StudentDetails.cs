using Singletone;
public class Details
{
    static void Main(string[] args)
    {
        Student std = Student.GetEnrollStudents;
        std.PrintDetails("Here is the details of the sudents");
        Console.ReadLine();
    }
}


