namespace class11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Student student1 = new Student();

            student1.FirstName = "Miroslav";

            Student student2 = new Student();

            student2.FirstName = "Zoran";

            student2 = student1;

            student1.FirstName = "Almir";




        }
    }
}
