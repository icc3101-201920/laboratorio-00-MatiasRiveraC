using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Hand
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        public Hand(List<CombatCard> combatCards, List<SpecialCard> specialCards)
        {
            this.combatCards = combatCards;
            this.specialCards = specialCards;
        }

        public void AddCombatCard(CombatCard combatCard)
        {

        }
        public void AddSpecialCard(SpecialCard specialCard)
        {

        }
        public void DestroyCombatCard(int cardId)
        {

        }
        public void DestroySpecialCard(int cardId)
        {

        }
    }
}
