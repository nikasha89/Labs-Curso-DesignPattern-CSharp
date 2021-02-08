namespace BuilderLibrary
{
    public class CarBuilder
    {
        protected Car _car = new Car();

        public Car Car
        {
            get { return _car; }
        }

        public CarBuilder WithModel(string model)
        {
            _car.Model = model;
            return this;
        }
        public CarBuilder WithName(string name)
        {
            _car.Name = name;
            return this;
        }        
    }
}
