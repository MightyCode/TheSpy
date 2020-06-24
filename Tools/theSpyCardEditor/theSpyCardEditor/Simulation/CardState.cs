using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class CardState
    {
        public Card Card { get; }

        public bool EmptyNecessaryCondition => necessaryCondition == null;

        private BoolExpression necessaryCondition;

        public bool RetiredFromPull { get; set; }

        public bool Blocked => sgs.Round < TurnWhereUnlock;

        public int TurnWhereUnlock { get; set; }

        public int InstanceNumber { get; }

        int weight;
        public int Weight {
            get => weight;
            set
            {
                weight = value;
                ShouldbeDraw = weight == -1;
                NoWeight = weight == -2;
            }
        }

        public bool NoWeight { get; private set; }

        public bool ShouldbeDraw { get; private set; }

        private SimulationSystem sgs;

        public CardState(Card card, SimulationSystem sgs, int InstanceNumber, int weight)
        {
            Card = card;
            this.sgs = sgs;
            this.InstanceNumber = InstanceNumber;
            Weight = weight;
            RetiredFromPull = false;

            if (
                SimulationComputations.IsEmptyProperty(Card.Properties["NecessaryConditions"].Value))
            {
                necessaryCondition = null;
            } else
            {
                if (Card.Properties["NecessaryConditions"].Value.First() != '(')
                {
                    necessaryCondition = SimulationComputations.EvaluateBooleanExpression(
                         "(" + Card.Properties["NecessaryConditions"].Value + ")");
                }
                else
                {
                    necessaryCondition =
                            SimulationComputations.EvaluateBooleanExpression(Card.Properties["NecessaryConditions"].Value);
                }
            }
        }

        public bool NecessaryConditionValid(Dictionary<string, int> parameters)
        {
            if (necessaryCondition != null)
            {
                return necessaryCondition.Value(parameters);
            }

            return false;
        }

        public CardState Copy(int InstanceNumber)
        {
            CardState cardState = new CardState(Card, sgs, InstanceNumber, Weight);

            cardState.ShouldbeDraw = ShouldbeDraw;
            cardState.TurnWhereUnlock  = TurnWhereUnlock;
            cardState.RetiredFromPull = RetiredFromPull;

            return cardState;
        }
    }
}
