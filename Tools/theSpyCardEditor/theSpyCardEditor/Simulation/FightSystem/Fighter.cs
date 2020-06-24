using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    abstract class Fighter
    {
        public static readonly string[] PARAMETERS = new string[]
        {
            "Damage", "DamageMultiplicator", 
            "Defence", "DamageReceivedMultiplicator",
            "DamageEachTurn",
            "DamageEachTurnMultiplicator", 
            "RegenDefence", "RegenDefenceMultiplicator", 
            "RegenAttack", "RegenAttackMultiplicator", 
            "CriticalPourcent",
            "DodgePourcent",
            "BlockReduce",
            "MaxLife", "Life"

        };

        public const string ACTION_ATTACK = "attack";
        public const string ACTION_DEFENCE = "defence";
        public const string ACTION_DODGE = "dodge";
        public const string ACTION_NOTHING = "nothing";

        public Dictionary<string, int> FightParameters;

        public Fighter()
        {
            Init();
        }

        public void Init()
        {
            FightParameters = new Dictionary<string, int>();

            for (int i = 0; i < PARAMETERS.Length; ++i)
            {
                FightParameters.Add("fight" + PARAMETERS[i], 0);
                FightParameters.Add("turn" + PARAMETERS[i], 0);
            }
        }

        public abstract string WitchAction();

        public abstract string Action(string action);
    }
}
