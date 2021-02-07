using System.Collections.Generic;
namespace LSPLibrary
{
    public class Noises {
        public enum Animals
        {
            Birds,
            Dogs
        }

        public static Dictionary<Animals, string> NoisesByAnimal => new Dictionary<Animals, string>()
        {
            { Animals.Birds, "Pío, Pío!" },
            { Animals.Dogs, "Guau, guau!" }
        };
    }    
}
