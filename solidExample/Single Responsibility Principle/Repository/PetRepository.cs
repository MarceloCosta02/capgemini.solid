using solidExample.Single_Responsibility_Principle.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace solidExample.Single_Responsibility_Principle.Repository
{
    public class PetRepository
    {
        public void Save()
        {
            Debug.WriteLine("Pet salvo com sucesso");
        }
        public Pet GetPet()
        {
            return new Pet("Bob", "Dog");
        }

    }
}
