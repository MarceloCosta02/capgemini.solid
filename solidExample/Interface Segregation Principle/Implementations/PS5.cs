using solidExample.Interface_Segregation_Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace solidExample.Interface_Segregation_Principle.Implementations
{    
    public class PS5 : IVideoGame
    {
        public void Play()
        {
            Debug.WriteLine("Jogando God of War");
        }
    }
}
