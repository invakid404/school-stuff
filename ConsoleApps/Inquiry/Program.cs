namespace Inquiry
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var student = Student.StudentBuilder.FromStdin();
            student.Print();
        }
    }
}