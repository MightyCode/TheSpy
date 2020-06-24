using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class SimulationSystem
    {
        Random rand;

        Dictionary<EMode, List<Card>> cards;
        Dictionary<string, int> parameters;

        public List<CardState> CardsSide;
        public List<CardState> CardsPull;

        List<int> ToPutOnSide;
        List<int> ToPutOnPull;

        CardState shouldBeDraw = null;

        public int Round { get; private set; }

        public SimulationSystem(Dictionary<EMode, List<Card>> cards, Dictionary<string, int> parameters)
        {
            rand = new Random();

            this.cards = cards;
            this.parameters = parameters;
            CardsSide = new List<CardState>();
            CardsPull = new List<CardState>();

            ToPutOnSide = new List<int>();
            ToPutOnPull = new List<int>();

            Round = 0;

            Reset();
        }


        #region remove and add to pull

        public void ComputeCardAvailableAndUnavailable()
        {
            ToPutOnPull.Clear();
            ToPutOnSide.Clear();

            int i;

            // Switch if possible, card from side to pull
            for (i = CardsSide.Count - 1; i >= 0; --i)
            {
                if (!CardsSide[i].NoWeight)
                {
                    if (!CardsSide[i].RetiredFromPull)
                    {
                        if (!CardsSide[i].EmptyNecessaryCondition)
                        {
                            if (CardsSide[i].NecessaryConditionValid(parameters))
                            {
                                ToPutOnPull.Add(i);
                            }
                        }
                        else
                        {
                            ToPutOnPull.Add(i);
                        }
                    }
                }
            }

            // Switch if possible, card from pull to side
            for (i = CardsPull.Count - 1; i >= 0; --i)
            {
                if (!CardsPull[i].EmptyNecessaryCondition)
                {
                    if (!CardsPull[i].NecessaryConditionValid(parameters))
                    {
                        ToPutOnSide.Add(i);
                    }
                }
            }

            for (i = 0; i < ToPutOnPull.Count; ++i)
            {
                CardsPull.Add(CardsSide[ToPutOnPull[i]]);
                CardsSide.RemoveAt(ToPutOnPull[i]);
            }

            for (i = 0; i < ToPutOnSide.Count; ++i)
            {
                RemoveCardToPull(ToPutOnSide[i]);
            }
        }

        public void ManuallyRemoveCardToPull(string id)
        {
            for (int i = 0; i < CardsPull.Count; ++i)
            {
                if (CardsPull[i].InstanceNumber == 0)
                {
                    if (CardsPull[i].Card.IdEquals(id))
                    {
                        CardsPull[i].RetiredFromPull = true;
                        CardsSide.Add(CardsPull[i]);
                        CardsPull.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public void ManuallyAddCardsToPull(string id)
        {
            // Switch if possible, card from side to pull
            for (int i = CardsSide.Count - 1; i >= 0; --i)
            {
                if (!CardsSide[i].NoWeight && !CardsSide[i].RetiredFromPull &&
                    CardsSide[i].Card.IdEquals(id))
                {
                    if (!CardsSide[i].EmptyNecessaryCondition)
                    {
                        if (CardsSide[i].NecessaryConditionValid(parameters))
                        {
                            CardsSide[i].RetiredFromPull = false;
                            CardsPull.Add(CardsSide[i]);
                            CardsSide.RemoveAt(i);
                        }
                    }
                    else
                    {
                        CardsSide[i].RetiredFromPull = false;
                        CardsPull.Add(CardsSide[i]);
                        CardsSide.RemoveAt(i);
                    }

                }
            }
        }

        public void RemoveCardToPull(int place)
        {
            if (CardsPull[place].InstanceNumber == 0)
            {
                CardsPull[place].RetiredFromPull = true;
                CardsSide.Add(CardsPull[place]);
            }

            CardsPull.RemoveAt(place);
        }

        public void RemoveAllCardToPull(string id)
        {
            for (int i = CardsPull.Count - 1; i >= 0; --i)
            {
                if (IsCardId(id, i))
                {
                    if (CardsPull[i].InstanceNumber == 0)
                    {
                        CardsPull[i].RetiredFromPull = true;
                        CardsSide.Add(CardsPull[i]);
                    }

                    CardsPull.RemoveAt(i);
                }
            }
        }


        public bool AddCardToSide(Card card)
        {
            if (card == null) return false;

            int[] weight = SimulationComputations.CumputeWeightAndInitialeBlock(card.Properties["Weight"].Value);

            CardState cardState = new CardState(card, this, 0, weight[0]);
            cardState.TurnWhereUnlock = Round + weight[1];

            CardsSide.Add(cardState);

            return true;
        }

        public void AddNewExistingCardToPull(string id)
        {
            int instanceNumb = MaxInstanceOfCardInPull(id);
            if (instanceNumb != -1)
            {
                Card card = GetOnPull(id).Card;
                int[] weight = SimulationComputations.CumputeWeightAndInitialeBlock(card.Properties["Weight"].Value);

                CardState cardState = new CardState(card, this, 0, weight[0]);
                cardState.TurnWhereUnlock = Round + weight[1];

                CardsPull.Add(cardState);
            }
        }

        #endregion

        #region detect on pull

        public bool IsCardId(string id, int place)
        {
            return CardsPull[place].Card.IdEquals(id);
        }

        public bool IsCard(string id, int place)
        {
            return IsCard(id, place, 0);
        }

        public bool IsCard(string id, int place, int instanceNumber)
        {
            return (CardsPull[place].InstanceNumber == instanceNumber
                    && CardsPull[place].Card.IdEquals(id));
        }

        public bool IsCardInPull(string id)
        {
            return IsCardInPull(id, 0);
        }

        public bool IsCardInPull(string id, int instanceNumb)
        {
            for (int i = 0; i < CardsPull.Count; ++i)
            {
                if (CardsPull[i].InstanceNumber == instanceNumb
                    && CardsPull[i].Card.Properties["Id"].Equals(id))
                {
                    return true;
                }
            }

            return false;
        }

        public int MaxInstanceOfCardInPull(string id)
        {
            int max = -1;
            for (int i = 0; i < CardsPull.Count; ++i)
            {
                if (IsCardId(id, i))
                {
                    max = (max >= CardsPull[i].InstanceNumber) ? max : CardsPull[i].InstanceNumber;
                }
            }

            return max;
        }
        #endregion

        #region get card

        public CardState GetOnPull(string id, int instance = 0)
        {
            for (int i = 0; i < CardsPull.Count; ++i)
            {
                if (CardsPull[i].InstanceNumber == instance && CardsPull[i].Card.IdEquals(id))
                {
                    return CardsPull[i];
                }
            }

            return null;
        }

        public CardState GetOnSide(string id)
        {
            for (int i = 0; i < CardsSide.Count; ++i)
            {
                if (CardsSide[i].Card.IdEquals(id))
                {
                    return CardsSide[i];
                }
            }

            return null;
        }

        public Card GetCard(string id)
        {
            return GetCard(id, EMode.Standard);
        }

        public Card GetCard(string id, EMode mode)
        {
            for (int i = 0; i < cards[mode].Count; ++i)
            {
                if (cards[mode][i].IdEquals(id))
                {
                    return cards[mode][i];
                }
            }

            return null;
        }


        private int SumOfWeight()
        {
            shouldBeDraw = null;
            int sum = 0, i = 0;

            while (i < CardsPull.Count)
            {
                if (CardsPull[i].ShouldbeDraw)
                {
                    shouldBeDraw = CardsPull[i];
                    return -1;
                }
                else
                {
                    sum += CardsPull[i].Weight;
                }
                ++i;
            }

            return sum;
        }

        public CardState TakeRandomCard()
        {
            int temp = SumOfWeight();
            if (shouldBeDraw == null)
            {
                int i = 0;
                temp = rand.Next(1, temp + 1);

                while (i < CardsPull.Count)
                {
                    temp -= CardsPull[i].Weight;
                    if (temp <= 0)
                    {
                        return CardsPull[i];
                    }

                    ++i;
                }

                // Per Default
                return CardsPull[i - 1];

            }
            else
            {
                return shouldBeDraw;
            }
        }

        #endregion

        #region utilisation of simulation 

        public void NextRound()
        {
            ++Round;

            parameters["rand"] = rand.Next(0, 100);
            parameters["rand1"] = rand.Next(0, 100);
            parameters["rand2"] = rand.Next(0, 100);
            parameters["rand3"] = rand.Next(0, 100);

            ComputeCardAvailableAndUnavailable();
        }

        public void RemoveAllRetiredFromPull()
        {
            for (int i = 0; i < CardsSide.Count; ++i)
            {
                CardsSide[i].RetiredFromPull = false;
            }
        }

        private void Reset()
        {
            CardsPull.Clear();
            CardsSide.Clear();

            EMode mode = EMode.Standard;

            for (int i = 0; i < cards[mode].Count; ++i)
            {
                AddCardToSide(cards[mode][i]);
            }
        }

        #endregion
    }
}
