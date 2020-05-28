using System;

namespace gitdemoappconsole
{
  class Student
  {
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student() { StudentID = 1, Name = "Sneha", Address = "Ahmedabad" };
      Console.WriteLine(student.Name+" "+student.Name+" "+student.Address);
      Console.WriteLine("Hello World!");
    }
  }
}
