using TaoOneHacker.DataStructure.Core._14_HashTables._03_Hash_Function_In_C_;
using Xunit;

namespace TaoOneHacker.DataStructure.Tests._14_Hash_Table;

public class StudentTest
{
    [Fact]
    public void TestHashCode()
    {
        int a = 42;
        var ahash = a.GetHashCode();

        int b = -42;
        var bhash = b.GetHashCode();

        double c = 3.1415926;
        var chash = c.GetHashCode();

        string d = "imooc";
        var dhash = d.GetHashCode();

        Student student = new Student(3, 2, "Bobo", "Liu");
        var shash = student.GetHashCode();
    }
}