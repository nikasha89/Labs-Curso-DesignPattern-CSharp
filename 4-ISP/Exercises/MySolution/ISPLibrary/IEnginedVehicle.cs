using System;

namespace ISPLibrary
{
    public interface IEnginedVehicle : IVehicle
    {
        int StartEngine();
        int StopEngine();       
    }
}

