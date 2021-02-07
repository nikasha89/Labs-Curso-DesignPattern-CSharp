using System;

namespace LSPLibrary
{
    public class Bird : AnimalFly, IAnimalFly
    {
        public Bird()
        {
            string getNoise = string.Empty;
            Noises.NoisesByAnimal.TryGetValue(Noises.Animals.Birds, out getNoise);

            Noise = string.IsNullOrEmpty(getNoise) ? string.Empty : getNoise;
        }        
    }
}
