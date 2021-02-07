namespace OCPLibrary.BusinessClasses
{
    public interface IAnimal
    {
        string Name { get; set; }
        AnimalClass Class { get; set; }
        AnimalOrder Order { get; set; }

        string ToString();
    }
}