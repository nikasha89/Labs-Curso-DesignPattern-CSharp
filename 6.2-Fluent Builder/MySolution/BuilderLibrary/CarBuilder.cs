namespace BuilderLibrary
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }        

        public static CarBuilder CreateNew()
        {
            return this;
        }

        public CarBuilder AddModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            return this;
        }  
        
        public Car Build()
        {
            return _car;
        }
    }
}
