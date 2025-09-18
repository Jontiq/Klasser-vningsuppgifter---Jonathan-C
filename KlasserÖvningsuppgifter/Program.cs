namespace KlasserÖvningsuppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("Alice", 30, 50000m);

            worker1.DisplayEmployeeInfo();
        }
    }
}
