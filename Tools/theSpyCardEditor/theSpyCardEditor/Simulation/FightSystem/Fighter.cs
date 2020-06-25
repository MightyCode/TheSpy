using System.Collections.Generic;

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

        FightSystem FS;

        public Fighter(FightSystem FS)
        {
            Init();
            this.FS = FS;
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

        public abstract string WhichAction();

        public abstract void BeginFight();

        public void InitTurn()
        {
            for (int i = 0; i < PARAMETERS.Length; ++i)
            {
                FightParameters["turn" + PARAMETERS[i]] = FightParameters["fight" + PARAMETERS[i]];
            }
        }

        public abstract void StartTurn();
        public abstract void EndTurn();

        public abstract void InAction(string action);
    }
}
