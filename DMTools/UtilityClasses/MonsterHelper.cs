using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMTools.Models;

namespace DMTools.UtilityClasses
{
    public static class MonsterHelper
    {
        /// <summary>
        /// Calculates all of the various reference stats a monster has
        /// <para>Ability Modifiers, Saving Throws, Skills, etc.</para>
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public static Monster CalculateMonsterStats(Monster monster)
        {
            monster = Monster.CalculateAbilityModifiers(monster);
            monster = Monster.CalculateSavingThrowsModifiers(monster);
            monster = Monster.CalculateSkillsModifiers(monster);

            return monster;
        }

        /// <summary>
        /// NOT BUILT YET
        /// <para>Ups Proficiency Bonus, Level of a monster</para>
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="newLevel"></param>
        /// <returns></returns>
        public static Monster LevelUpMonster(Monster monster, int newLevel)
        {
            if (newLevel < monster.Level)
            {
                // Wasn't a "Level Up"
            }
            return monster;
        }

    }
}