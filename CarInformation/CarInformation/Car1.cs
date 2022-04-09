namespace CarInformation
{
    public class Car
    {
        private string brand;
        private string model;

        public Car()
        {
        }

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public Car(string brand, string model, string color, int maxSpeed)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}