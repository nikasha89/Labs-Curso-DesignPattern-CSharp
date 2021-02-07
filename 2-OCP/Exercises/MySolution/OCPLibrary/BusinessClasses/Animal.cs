namespace OCPLibrary.BusinessClasses
{
    public class Animal:IAnimal
    {
        public string Name { get; set; }
        public AnimalClass Class { get; set; }
        public AnimalOrder Order { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, Clase: {Class}, Order: {Order}"; 
        }
    }
}
