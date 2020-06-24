﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class EnemyFighterFactory
    {
        private static Dictionary<string, EnemyFighter> enemies;
        public static Dictionary<string, EnemyFighter>.KeyCollection Keys => enemies.Keys;

        public static void InitEnemyFighters()
        {
            enemies = new Dictionary<string, EnemyFighter>()
            {
                { "terniaAdvisor",  new FighterTerniaAdvisor()}
            };
        }

        public static EnemyFighter GetEnemy(string name)
        {
            if (enemies == null)
            {
                InitEnemyFighters();
            }

            if (enemies.ContainsKey(name))
            {
                enemies[name].Init();
                return enemies[name];
            }

            return null;
        }
    }
}
