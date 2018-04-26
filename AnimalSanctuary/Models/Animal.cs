using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalSanctuary.Models
{
    public class Animal
    {
        private int AnimalId;
        private string Name;
        private string Species;
        private string Sex;
        private string HabitatType;
        private bool MedicalEmergency;
        private int VetId;
        private Vet Vet;
    }
}
