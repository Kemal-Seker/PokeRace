using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PokeRace.PokeRaceClasses
{
    public class PokeArena
    {
        public Image ArenaImage { get; private set; }
        public Color FloorColor { get; private set; }
        public PokeArena(PokeRaceEnums.PokeArenaTypes ArenaType)
        {
            switch (ArenaType)
            {
                case PokeRaceEnums.PokeArenaTypes.GreenArena:
                    this.ArenaImage = WFA_PokeRace.Properties.Resources.GreenArena;
                    this.FloorColor = Color.ForestGreen;
                    break;
                case PokeRaceEnums.PokeArenaTypes.SandyArena:
                    this.ArenaImage = WFA_PokeRace.Properties.Resources.SandyArena;
                    this.FloorColor = Color.SandyBrown;
                    break;
                case PokeRaceEnums.PokeArenaTypes.RockArena:
                    this.ArenaImage = WFA_PokeRace.Properties.Resources.RockArena;
                    this.FloorColor = Color.LightGray;
                    break;
                default:
                    break;
            }
        }
    }
}
