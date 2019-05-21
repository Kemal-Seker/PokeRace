using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PokeRace.PokeRaceClasses
{
    public class PokeOwner
    {
        #region Properties
        private PokeRaceEnums.PokeOwnerTypes _ownerType;
        public string Name { get { return this._ownerType.ToString(); } }
        public int AbilityRating { get { return (int)_ownerType; } }

        #endregion

        #region Constructors
        public PokeOwner(PokeRaceEnums.PokeOwnerTypes OwnerType)
        {
            this._ownerType = OwnerType;
        }
        #endregion
    }
}
