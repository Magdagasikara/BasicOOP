namespace BasicOOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // Area calculations for circles with radiuses 5 and 6

            Circle bestCircle = new Circle(6);
            bestCircle.GetArea();

            Circle worseCircle = new Circle(5);
            worseCircle.GetArea();
        }

    }
}