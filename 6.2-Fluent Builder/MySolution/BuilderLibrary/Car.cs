namespace BuilderLibrary
{
    public sealed class Car
    {
        public string Name;
        public string Model;

        public override string ToString()
        {
            return $"Mi automovil es {Name}, Modelo: {Model}";
        }
    }
}
