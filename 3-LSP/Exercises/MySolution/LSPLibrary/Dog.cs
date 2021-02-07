namespace LSPLibrary
{
    public class Dog : Animal, IAnimal
    {
        public Dog()
        {
            string getNoise = string.Empty;
            Noises.NoisesByAnimal.TryGetValue(Noises.Animals.Dogs, out getNoise);

            Noise = string.IsNullOrEmpty(getNoise) ? string.Empty : getNoise;
        }
    }
}
