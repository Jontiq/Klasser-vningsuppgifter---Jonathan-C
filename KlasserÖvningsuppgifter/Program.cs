namespace KlasserÖvningsuppgifter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee worker1 = new Employee("Alice", 30, 50000m);

            //worker1.DisplayEmployeeInfo();

            //Movie movie1 = new Movie("Inception", "Christopher Nolan", 7);

            //movie1.PrintMovieInfo();

            MathHelper matte = new MathHelper(5, 7);

            Console.WriteLine(MathHelper.Add(10, 15));
            Console.WriteLine(MathHelper.Subtract(10, 15));
            Console.WriteLine(MathHelper.Multiply(10, 15));
            Console.WriteLine(MathHelper.Divide(10, 15));


        }
    }
}
