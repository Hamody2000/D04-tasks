namespace taskD04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Line l1 = new Line(5,2,3,4);
            Console.WriteLine(l1.PrintLine());

            Employee e1 = new Employee() { Age = 1, Id= 5, Name= "Mohamed", Salary= 243, };
            Console.WriteLine(e1.toString());

        }
    }
}
