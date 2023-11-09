namespace TaoOneHacker.DataStructure.Core._14_HashTables._03_Hash_Function_In_C_;

public class Student
{
    private int grade;
    private int cls;
    private string firstName;
    private string lastName;

    public Student(int grade, int cls, string firstName, string lastName)
    {
        this.grade = grade;
        this.cls = cls;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public override int GetHashCode()
    {
        int B = 31;
        int hash = 0;
        hash = hash * B + grade.GetHashCode();
        hash = hash * B + cls.GetHashCode();
        hash = hash * B + firstName.ToLower().GetHashCode();
        hash = hash * B + lastName.ToLower().GetHashCode();
        return hash;
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
        {
            return true;
        }

        if (obj == null)
            return false;
        Student another = (Student)obj;
        return this.grade == another.grade &&
               this.cls == another.cls &&
               this.firstName.ToLower() == another.firstName.ToLower() &&
               this.lastName.ToLower() == another.lastName.ToLower();
    }
}