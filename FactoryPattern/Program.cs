namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numWheel;
            bool vehicleDesign = false;
            do
            {
                Console.WriteLine("How many tires should the vehicle have?");
                vehicleDesign = int.TryParse(Console.ReadLine(), out numWheel);
            } while (!vehicleDesign);

            var vehicle = VehicleFactory.GetVehicle(numWheel);
            vehicle.Drive();

            }
    }
}
