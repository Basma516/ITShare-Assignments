namespace C_Session04
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(10.0);
            Cylinder c3 = new Cylinder(2.0, 10.0);
            Console.WriteLine(c1.toString());
            Console.WriteLine($"Volume of the Cylinder :{c1.GetVolume()}");
            Console.WriteLine(c2.toString());
            Console.WriteLine($"Volume of the Cylinder :{c2.GetVolume()}");
            Console.WriteLine(c3.toString());
            Console.WriteLine($"Volume of the Cylinder :{c3.GetVolume()}");



        }
    }
}