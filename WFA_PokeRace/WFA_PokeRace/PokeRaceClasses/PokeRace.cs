using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PokeRace.PokeRaceClasses
{
    public class PokeRace
    {
        #region Properties
        public PokeArena RaceArena { get; set; }
        public List<Pokemon> Racers { get; set; }
        public bool IsStarted { get; private set; }
        public bool IsFinished { get; private set; }
        public Dictionary<Pokemon,int> SortedRacers { get; private set; }
        #endregion
        #region privateFields
        private List<int> _XPositions;
        private int _initialPosition;
        private int _finishlinePosition;
        #endregion

        #region Constructors
        public PokeRace()
        {
            this.Racers = new List<Pokemon>();
            this.SortedRacers = new Dictionary<Pokemon, int>();
            this._XPositions = new List<int>();
        }
        #endregion

        #region PublicMethods
        public void Start(int InitialPosition,int FinishLinePosition)
        {
            if(IsStarted)
            {
                throw new Exception("Race cannot be started if it is already started..");
            }
            if (Racers.Count < 4)
            {
                throw new Exception("4 racers must be chosen to start the race..");
            }
            if(this.RaceArena == null)
            {
                throw new Exception("Race arena must be chosen to start the race..");
            }
            else
            {
                SetInitials(InitialPosition,FinishLinePosition);
            }
        }

        public void MovePokemons()
        {
            if (!IsFinished)
            {
                Random rnd = new Random();
                foreach (Pokemon item in Racers)
                {
                    SortedRacers[item] += rnd.Next(item.MinSpeed, item.MaxSpeed + 1);
                }
                SortSortedRacers();
                RaceFinishControl();
            }
        }

        #endregion

        #region PrivateMethods
        private void SetInitials(int initialPosition, int finishLinePosition)
        {
            _initialPosition = initialPosition;
            _finishlinePosition = finishLinePosition;

            _XPositions.Clear();
            _XPositions.Add(initialPosition);
            _XPositions.Add(initialPosition);
            _XPositions.Add(initialPosition);
            _XPositions.Add(initialPosition);

            SortedRacers.Clear();
            foreach (Pokemon item in Racers)
            {
                SortedRacers.Add(item, initialPosition);
            }
            IsStarted = true;
            IsFinished = false;
        }
        private void SortSortedRacers()
        {
            SortedRacers.OrderBy(x => x.Value);
        }
        private void RaceFinishControl()
        {
            foreach(KeyValuePair<Pokemon,int> item in SortedRacers)
            {
                if(item.Value >= _finishlinePosition)
                {
                    this.IsFinished = true;
                    this.IsStarted = false;
                }
            }
        }
        #endregion
    }
}
