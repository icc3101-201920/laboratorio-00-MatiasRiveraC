using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Board
    {
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;
        private List<SpecialCard>[] specialMeleeCards;
        private List<SpecialCard>[] specialRangeCards;
        private List<SpecialCard>[] specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;


        public List<CombatCard>[] MeleeCards { get { return meleeCards; } }
        public List<CombatCard>[] RangeCards { get { return rangeCards; } }
        public List<CombatCard>[] LongRangeCards { get { return longRangeCards; } }
        public List<SpecialCard>[] SpecialMeleeCards { get { return specialMeleeCards; } }
        public List<SpecialCard>[] SpecialRangeCards { get { return specialRangeCards; } }
        public List<SpecialCard>[] SpecialLongRangeCards { get { return specialLongRangeCards; } }
        public List<SpecialCard> CaptainCards { get { return captainCards; } }
        public List<SpecialCard> WeatherCards { get { return weatherCards; } }

        public Board(List<CombatCard>[] meleeCards, List<CombatCard>[] rangeCards, List<CombatCard>[] longRangeCards,
            List<SpecialCard>[] specialMeleeCards, List<SpecialCard>[] specialRangeCards, List<SpecialCard>[] specialLongRangeCards,
            List<SpecialCard> captainCards, List<SpecialCard> weatherCards)
        {
            this.meleeCards = meleeCards;
            this.rangeCards = rangeCards;
            this.longRangeCards = longRangeCards;
            this.specialMeleeCards = specialMeleeCards;
            this.specialRangeCards = specialRangeCards;
            this.specialLongRangeCards = specialLongRangeCards;
            this.captainCards = captainCards;
            this.weatherCards = weatherCards;
        }
        public void AddComnatCard(int playerId, CombatCard combatCard)
        {

        }

        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {

        }

        public void DestroyCombatCards()
        {

        }

        public void DestroySpecialCards()
        {

        }
        public int[] GetMeleeAttackPoints()
        {
            return new int[] { };
        }
        public int[] GetRangeAttackPoints()
        {
            return new int[] { };
        }
        public int[] GetLongRangeAttackPoints()
        {
            return new int[] { };
        }

    }
}
