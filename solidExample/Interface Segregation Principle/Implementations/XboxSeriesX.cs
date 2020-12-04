using solidExample.Interface_Segregation_Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace solidExample.Interface_Segregation_Principle.Implementations
{
    public class XboxSeriesX : IVideoGame
    {
        public void Play()
        {
            Debug.WriteLine("Jogando Halo 4");
        }
    }
}
