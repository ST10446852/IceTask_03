namespace IceTask_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rectangle", 5.5, 6.7);
            r.Display();

            Circle c = new Circle("Circle", 3.5);
            c.Display();

            Console.ReadKey();

        }
    }
}
