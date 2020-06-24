using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theSpyCardEditor
{
    public enum EGamePhase
    {
        Text, BackText, End
    }

    public partial class GameSimulation : Form
    {
        Dictionary<Card, bool> deathObtained;
        Dictionary<Card, bool> questObtained;

        GameSimulationState GSS;

        Dictionary<string, int> parameters;

        Card currentCard;
        SimulationSystem SS;
        EGamePhase currentPhase;
        // Left or Right;
        string backSide;

        List<string> labels;

        public GameSimulation(Dictionary<EMode, List<Card>> cards, Dictionary<string, int> parameters)
        {
            InitializeComponent();
            this.parameters = parameters;

            deathObtained = new Dictionary<Card, bool>();
            questObtained = new Dictionary<Card, bool>();
            foreach(Card death in cards[EMode.Death])
            {
                deathObtained.Add(death, false);
            }
            foreach (Card quest in cards[EMode.Quest])
            {
                questObtained.Add(quest, false);
            }


            SS = new SimulationSystem(cards, parameters);
            GSS = new GameSimulationState(parameters, SS);

            NextRound();
        }

        private void NextRound()
        {
            Console.WriteLine("\n-New Round for card draw-\n");
            SS.NextRound();

            currentCard = SS.TakeRandomCard().Card;

            SetGamePhase(EGamePhase.Text);
            GSS.RefleshParameters();
            GSS.AvailableCardsChange(SS.CardsPull);
        }
        
        private void DeathReset()
        {
            string key;
            for(int i = 0; i < parameters.Count; ++i)
            {
                key = parameters.ElementAt(i).Key;

                if (key.Equals("money") || key.Equals("cover") ||
                    key.Equals("population") || key.Equals("worship"))
                {
                    parameters[key] = 50;
                } else if (!key.StartsWith("global"))
                {
                    parameters[key] = 0;
                }
            }

            SS.RemoveAllRetiredFromPull();
            NextRound();
        }


        #region game phase

        private void SetGamePhase(EGamePhase gamePhase)
        {
            switch (gamePhase)
            {
                case EGamePhase.Text:
                    TextGamePhase();
                    break;
                case EGamePhase.BackText:
                    BackTextGamePhase();
                    break;
                case EGamePhase.End:

                    break;
            }

            currentPhase = gamePhase;

            labelCoverValue.Text = parameters["cover"] + "";
            labelMoneyValue.Text = parameters["money"] + "";
            labelPopulationValue.Text = parameters["population"] + "";
            labelWorshipValue.Text = parameters["worship"] + "";
        }

        private void TextGamePhase()
        {
            textBoxText.Visible = true;
            textBoxBack.Visible = false;
            textBoxLeftText.Visible = false;
            textBoxRightText.Visible = false;

            textBoxTitle.Text = currentCard.Properties["Header"].Value;
            SetText(currentCard.Properties["Text"].Value);

            LoadCardImage(currentCard.Properties["Background"].Value);
            CheckQuest();

            switch (currentCard.Type)
            {
                case EMode.Standard:
                    TextGamePhaseStandard();
                    textBoxLeftText.Visible = true;
                    textBoxRightText.Visible = true;
                    break;
                case EMode.Description:
                    buttonLeft.Text = "Suite";
                    buttonRight.Text = "Suite";

                    break;
                case EMode.Death:
                    buttonLeft.Text = "Suite";
                    buttonRight.Text = "Suite";
                    deathObtained[currentCard] = true;
                    break;
                case EMode.Fight:

                    break;
            }
        }

        private void SetText(string text)
        {
            List<Tuple<Color, string>> parts = Utils.StringToColoredString(text);
            textBoxText.Text = "";
            for (int i = 0; i < parts.Count; ++i)
            {
                textBoxText.SelectionColor = parts[i].Item1;
                textBoxText.AppendText(parts[i].Item2);
            }
        }

        public void TextGamePhaseStandard()
        {
            textBoxLeftText.Text = currentCard.Properties["TextLeft"].Value;
            textBoxRightText.Text = currentCard.Properties["TextRight"].Value;

            buttonLeft.Text = "Choix de gauche";
            buttonRight.Text = "Choix de droite";
        }

        private void BackTextGamePhase()
        {
            LoadCardImage("backcard");
            textBoxText.Visible = false;

            buttonLeft.Text = "Suite";
            buttonRight.Text = "Suite";

            textBoxBack.Visible = true;
            textBoxLeftText.Visible = false;
            textBoxRightText.Visible = false;

            textBoxBack.Text = SimulationComputations.ReturnTextFromLabels(
                currentCard.Properties["BackText" + backSide].Value, labels);
        }

        #endregion


        private void LoadCardImage(string name)
        {
            if (SimulationComputations.IsEmptyProperty(name)) name = "card-game-title";

            pictureCard.Image = Image.FromFile(
                    ImageExtension.GetPathWithoutExtension(Utils.RESOURCES_PATH + name)
                    );
        }

        private void NextStep()
        {
            string propertyEffect = "";
            switch (currentCard.Type)
            {
                case EMode.Standard:
                    // If in text and not null display 
                    if (currentPhase == EGamePhase.Text && !SimulationComputations.IsEmptyProperty(
                            currentCard.Properties["BackText" + backSide].Value))
                    {
                        labels = SimulationComputations.GetLabels(parameters, 
                            currentCard.Properties["Conditions" + backSide].Value);
                        SetGamePhase(EGamePhase.BackText);
                    }
                    else
                    {
                        propertyEffect = "Effect" + backSide;
                    }
                    break;
                case EMode.Description:
                    labels = SimulationComputations.GetLabels(parameters,
                        currentCard.Properties["Conditions"].Value);
                    propertyEffect = "Effect";
                    break;
                case EMode.Death:

                    DeathReset();
                    break;
                case EMode.Fight:

                    break;
            }


            if (!propertyEffect.Equals(""))
            {
                ReadEffect(propertyEffect);
            }
        }

        #region effect
        private void ReadEffect(string effect)
        {
            string effectContent = SimulationComputations.ReturnTextFromLabels(currentCard.Properties[effect].Value, labels);
            Console.WriteLine("\n-Analyse effect : " + effect + " = " + effectContent +  " -\n");
            try
            {
                EffectActionList EAL = SimulationComputations.CreateActionList(currentCard, effectContent, parameters);
                ExecuteEffect(EAL);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, 
                    "Error at card " + currentCard.Properties["Id"].Value + " effect : "  + effect);
            }
        }

        private void ExecuteEffect(EffectActionList EAL)
        {
            while (EAL.Next())
            {
                Console.WriteLine(EAL.CurrentActions + " |" + EAL.CurrentArg1 + " [" + EAL.CurrentArg2 +
                    " \\" + EAL.CurrentArg3 + " /" + EAL.CurrentArg4);

                switch (EAL.CurrentActions)
                {
                    case EEffectAction.Add:
                        if (EAL.CurrentArg1.Equals("new"))
                        {
                            SS.AddNewExistingCardToPull(EAL.CurrentArg2);
                        }
                        else { 
                            SS.ManuallyAddCardsToPull(EAL.CurrentArg1);
                        }
                        break;


                    case EEffectAction.Block:
                        SS.GetOnPull(EAL.CurrentArg1, Convert.ToInt32(EAL.CurrentArg2)).TurnWhereUnlock 
                            = SS.Round + Convert.ToInt32(EAL.CurrentArg3);
                        break;


                    case EEffectAction.Computation:
                        int result = SimulationComputations.EvaluateNumberExpression(EAL.CurrentArg3).Value(parameters);
                        switch (EAL.CurrentArg2)
                        {
                            case "=": parameters[EAL.CurrentArg1] = result; break;
                            case "+=": parameters[EAL.CurrentArg1] += result; break;
                            case "-=": parameters[EAL.CurrentArg1] -= result; break;
                            case "*=": parameters[EAL.CurrentArg1] *= result; break;
                            case "/=": parameters[EAL.CurrentArg1] /= result; break;
                        }

                        break;


                    case EEffectAction.Go:
                        switch (EAL.CurrentArg1)
                        {
                            case "card":
                                currentCard = SS.GetCard(EAL.CurrentArg2, EMode.Standard);
                                break;
                            case "description":
                                currentCard = SS.GetCard(EAL.CurrentArg2, EMode.Description);
                                break;
                            case "death":
                                currentCard = SS.GetCard(EAL.CurrentArg2, EMode.Death);
                                break;
                            case "fight":
                                currentCard = SS.GetCard(EAL.CurrentArg2, EMode.Fight);
                                break;
                        }

                        SetGamePhase(EGamePhase.Text);
                        GSS.RefleshParameters();
                        GSS.AvailableCardsChange(SS.CardsPull);
                        return;

                    case EEffectAction.Release:
                        SS.GetOnSide(EAL.CurrentArg1).RetiredFromPull = false;
                        break;


                    case EEffectAction.Remove:
                        SS.ManuallyRemoveCardToPull(EAL.CurrentArg1);
                        break;

                    default:
                        throw new Exception("Unknown action : " + EAL.CurrentActions);
                }
            }

            NextRound();
        }

        #endregion

        #region instant effect button

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (currentPhase == EGamePhase.Text) backSide = "Left";
            NextStep();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (currentPhase == EGamePhase.Text) backSide = "Right";
            NextStep();
        }

        private void buttonGameState_Click(object sender, EventArgs e)
        {
            GSS.Show();
        }

        private void buttonOpenInventory_Click(object sender, EventArgs e)
        {
        }

        private void buttonOpenQuests_Click(object sender, EventArgs e)
        {
            new AchievementScreen(questObtained, false).ShowDialog();
        }

        private void buttonOpenDeath_Click(object sender, EventArgs e)
        {
            new AchievementScreen(deathObtained, true).ShowDialog();
        }

        #endregion

        private void CheckQuest()
        {
            foreach(Card card in questObtained.Keys)
            {
                if (currentCard.IdEquals(card.Properties["Id"].Value)){
                    Console.WriteLine("FOUND");
                    if (!questObtained[card]){
                        questObtained[card] = true;
                    }
                    break;
                }
            }
        }

        private void PrintLabel()
        {
            Console.WriteLine("Labels : ");
            foreach (string part in labels)
            {
                Console.WriteLine("-" + part);
            }
            Console.WriteLine("");
        }
    }
}
