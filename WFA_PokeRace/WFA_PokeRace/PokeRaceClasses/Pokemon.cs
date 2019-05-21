using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PokeRace.PokeRaceClasses
{
    public class Pokemon
    {
        #region Properties
        private PokeRaceEnums.PokemonTypes _poketype;
        private PokeOwner _owner;
        public System.Drawing.Image Picture { get; private set; }
        public string Name { get { return _poketype.ToString(); } }
        public int MinSpeed { get; private set; }
        public int MaxSpeed { get; private set; }
        public PokeOwner Owner {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
                InitializeProperties();
                this.MinSpeed += this._owner.AbilityRating;
            }
        }
        public int RaceCount { get; set; }
        public int RacesWon { get; set; }

        #endregion
        #region Constructors
        public Pokemon(PokeRaceEnums.PokemonTypes PokeType)
        {
            this._poketype = PokeType;
            this.RaceCount = 0;
            this.RacesWon = 0;
            InitializeProperties();
        }
        public Pokemon(PokeRaceEnums.PokemonTypes PokeType,PokeOwner Owner)
        {
            this._poketype = PokeType;
            this.Owner = Owner;
            this.RaceCount = 0;
            this.RacesWon = 0;
            InitializeProperties();
        }
        #endregion
        #region Initialzers
        private void InitializeProperties()
        {
            
            switch (this._poketype)
            {
                case PokeRaceEnums.PokemonTypes.Charizard:
                    this.Picture = WFA_PokeRace.Properties.Resources.charizard;
                    this.MinSpeed = 20;
                    this.MaxSpeed = 30;
                    break;
                case PokeRaceEnums.PokemonTypes.Crobat:
                    this.Picture = WFA_PokeRace.Properties.Resources.crobat;
                    this.MinSpeed = 28;
                    this.MaxSpeed = 37;
                    break;
                case PokeRaceEnums.PokemonTypes.ButterFree:
                    this.Picture = WFA_PokeRace.Properties.Resources.butterfree;
                    this.MinSpeed = 17;
                    this.MaxSpeed = 28;
                    break;
                case PokeRaceEnums.PokemonTypes.Pidgeot:
                    this.Picture = WFA_PokeRace.Properties.Resources.pidgeot;
                    this.MinSpeed = 23;
                    this.MaxSpeed = 35;
                    break;
                case PokeRaceEnums.PokemonTypes.Beautifly:
                    this.Picture = WFA_PokeRace.Properties.Resources.beautifly;
                    this.MinSpeed = 15;
                    this.MaxSpeed = 26;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
