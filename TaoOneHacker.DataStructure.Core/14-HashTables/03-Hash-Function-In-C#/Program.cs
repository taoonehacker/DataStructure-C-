using System;

namespace TaoOneHacker.DataStructure.Core._14_HashTables._03_Hash_Function_In_C_;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 42;
        Console.WriteLine(a.GetHashCode());

        int b = -42;
        Console.WriteLine(b.GetHashCode());

        double c = 3.1415926;
        Console.WriteLine(c.GetHashCode());

        string d = "imooc";
        Console.WriteLine(d.GetHashCode());

        Student student = new Student(3,2,"Bobo","Liu");
        Console.WriteLine(student.GetHashCode());
        
    }
}