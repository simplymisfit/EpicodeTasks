using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicodeElektrownie
{
    public class PowerPlant
    {
        public int Identifier { get; set; }
        public int AvailableEnergy { get; set; }
        public List<PowerPlant> Neighbours { get; set; }

        public PowerPlant(int identifier, int availableEnergy, List<PowerPlant> neighbours)
        {
            Identifier = identifier;
            AvailableEnergy = availableEnergy;
            Neighbours = neighbours;
        }
    }
}
