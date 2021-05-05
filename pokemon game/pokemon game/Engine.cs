using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_game
{
    class Engine
    {
        private readonly Random random = new Random();

        string[] encounters = { "1" };
        int[] encountersLvl = { 1 };

        public int GenerateIV()
        {
            int i =  random.Next(32);

            return i;
        }

        public string GenerateGender(int genderRatio)
        {
            var i = random.Next(1, 1000);
            var gender = "";

            if (genderRatio == 0)
            {
                gender = "Genderless";
            }

           else
            {  
                if (i <= genderRatio)
                {
                    gender = "Male";
                }

                else
                {
                    gender = "Female";
                }
            }
            return gender;
        }

        public int GenerateAbility(bool hasHiddenAbility, int numberOfAbilites)
        {
            int i = 0;

            if (hasHiddenAbility == true)
            {
                i = random.Next(0, numberOfAbilites - 1);
                return i;
            }

            else
            {
                i = random.Next(0, numberOfAbilites);
                return i;
            }
        }

        // add a pokemon to this arguement
        public int GenerateHiddenAbility(int hiddenAbilityIndex)
        {
            int i = hiddenAbilityIndex;

            return i;
        }

        public string GenerateNature()
        {
            string[] natures = {"Hardy", "Lonely", "Brave",  "Adamant",
                                "Naughty", "Bold", "Docile", "Relaxed",
                                "Impish", "Lax", "Timid", "Hasty",
                                "Serious", "Jolly", "Naive", "Modest",
                                "Mild", "Quiet", "Bashful", "Rash",
                                "Calm", "Gentle", "Sassy", "Careful",
                                "Quirky" };

            int j = random.Next(0, natures.Length - 1);

            string i = natures[j];

            return i;
        }

        // id is string to account for variants/forms eg. 42, 42a, 42b
        public Pokemon GeneratePokemon(string[] pokemonEncounters, int pokemonLvl)
        {

            // set i equal to a random number from the list of encounters 
            int i = random.Next(encounters.Length - 1);

            // setting encountered ID to the list at the index of i ^
            string encounteredPokemonID = pokemonEncounters[i];

            string pokemonName = ""; // pokemon[pokemonID].Name
            string pokemonSpecies = ""; //pokemon[pokemonID].Species

            string[] types = { "" }; // change to pokemon[pokemonID].Types
            string[] ability = { "ability 1", "ability 2", "ability 3" }; // pokemon[pokemonID].Abilities
            string[] moveset = { "" }; // pokemon[pokemonID].Moveset
            string nature = GenerateNature();

            double[] hp = { 105, 0, GenerateIV() }; // first 0 -> pokemon[pokemonID].BaseHP
            double[] atk = { 130, 0, GenerateIV(), SetNatureModifier(nature, 0) }; // first 0 -> pokemon[pokemonID].BaseATK
            double[] def = { 120, 0, GenerateIV(), SetNatureModifier(nature, 1) }; // first 0 -> pokemon[pokemonID].BaseDEF  
            double[] spe = { 45, 0, GenerateIV(), SetNatureModifier(nature, 2) }; // first 0 -> pokemon[pokemonID].BaseSPE
            double[] sdf = { 45, 0, GenerateIV(), SetNatureModifier(nature, 3) }; // first 0 -> pokemon[pokemonID].BaseSDF
            double[] spd = { 40, 0, GenerateIV(), SetNatureModifier(nature, 4) }; // first 0 -> pokemon[pokemonID].BaseSPD

            int lvl = pokemonLvl;
            int exp = 0;

            int genderRatio = 500; // pokemon[pokemonID].GenderRatio
            int catchRate = 0; // pokemon[pokemonID].catchRate

            string[] eggGroup = { "" }; // change to pokemon[pokemonID].EggGroups
            int[] hatchTime = { 0 }; // change to pokemon[pokemonID].HatchTime
            int[] height = { 0 }; // change to pokemon[pokemonID].Height
            int[] weight = { 0 }; // change to pokemon[pokemonID].Weight
            string evYield = ""; // change to pokemon[pokemonID].EVYield
            int baseExpYield = 0; // change to pokemon[pokemonID].BaseExpYield
            string levelingRate = ""; // change to pokemon[pokemonID].levelingRate
            double evasion = 0;

            Pokemon pokemon = new Pokemon(encounteredPokemonID, pokemonName, pokemonSpecies, types, ability[GenerateAbility(true, ability.Length)],
                genderRatio, GenerateGender(genderRatio), catchRate,
                moveset, nature, hp, atk, def, spe, sdf, spd, lvl, exp, 
                true, eggGroup, hatchTime, height, weight, evYield,
                baseExpYield, levelingRate, evasion);               //pokemon[encounteredPokemonID].hasHiddenAbility for both true values

            return pokemon;
        }

        public double SetNatureModifier(string nature, int statIndex)
        {
            double i = 0;

            switch (nature)
            {
                // {ATK, DEF, SPE, SDF, SPD}
                case "Lonely":
                    double[] lonelyMods = { 1.1, .9, 1, 1, 1 };
                    i = lonelyMods[statIndex];
                    return i;

                case "Brave":
                    double[] braveMods = { 1.1, 1, 1, 1, .9 };
                    i = braveMods[statIndex];
                    return i;

                case "Adamant":
                    double[] adamantMods = { 1.1, 1, .9, 1, 1 };
                    i = adamantMods[statIndex];
                    return i;

                case "Naughty":
                    double[] naughtyMods = { 1.1, 1, 1, .9, 1 };
                    i = naughtyMods[statIndex];
                    return i;

                case "Bold":
                    double[] boldMods = { .9, 1.1, 1, 1, 1 };
                    i = boldMods[statIndex];
                    return i;

                case "Relaxed":
                    double[] relaxedMods = { 1, 1.1, 1, 1, .9 };
                    i = relaxedMods[statIndex];
                    return i;

                case "Impish":
                    double[] impishMods = { 1, 1.1, .9, 1, 1 };
                    i = impishMods[statIndex];
                    return i;

                case "Lax":
                    double[] laxMods = { 1, 1.1, 1, .9, 1 };
                    i = laxMods[statIndex];
                    return i;

                case "Timid":
                    double[] timidMods = { .9, 1, 1, 1, 1.1 };
                    i = timidMods[statIndex];
                    return i;

                case "Hasty":
                    double[] hastyMods = { 1, .9, 1, 1, 1.1 };
                    i = hastyMods[statIndex];
                    return i;

                case "Jolly":
                    double[] jollyMods = { 1, .9, 1, 1, 1.1 };
                    i = jollyMods[statIndex];
                    return i;

                case "Naive":
                    double[] naiveMods = { 1, 1, 1, .9, 1.1 };
                    i = naiveMods[statIndex];
                    return i;

                case "Modest":
                    double[] modestMods = { .9, 1, 1.1, 1, 1 };
                    i = modestMods[statIndex];
                    return i;

                case "Mild":
                    double[] mildMods = { 1, .9, 1.1, 1, 1 };
                    i = mildMods[statIndex];
                    return i;

                case "Quiet":
                    double[] quietMods = { 1, 1, 1.1, 1, .9 };
                    i = quietMods[statIndex];
                    return i;

                case "Rash":
                    double[] rashMods = { 1, 1, 1.1, .9, 1 };
                    i = rashMods[statIndex];
                    return i;

                case "Calm":
                    double[] calmMods = { .9, 1, 1, 1.1, 1 };
                    i = calmMods[statIndex];
                    return i;

                case "Gentle":
                    double[] gentleMods = { .9, 1, 1, 1.1, 1 };
                    i = gentleMods[statIndex];
                    return i;

                case "Sassy":
                    double[] sassyMods = { 1, .9, 1, 1.1, 1 };
                    i = sassyMods[statIndex];
                    return i;

                case "Careful":
                    double[] carefulMods = { 1, 1, .9, 1.1, 1 };
                    i = carefulMods[statIndex];
                    return i;

                default:
                    i = 1;
                    return i;
            }
        }

        public int Damage(int attack, int power, int attackerLevel, int defense, int targets,
            int weather, int critical, int random, int stab, int type, int burn, int other)
        {
            double damage = (((((2 * attackerLevel / 5) + 2) * power * attack/defense) / 50) + 2  * targets * weather * critical * random * stab * type * burn * other);

            return (int)damage;
        }

        public bool MoveHits(int moveAccuracy, double stageModifier, double other)
        {
            double hitRatio = moveAccuracy * stageModifier * other;

            double hitTrue = random.Next(1, 100);

            if (hitTrue >= hitRatio)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public Array InitiativeArray(Pokemon[] pokemonInBattle, string[] battlefieldEffects)
        {
            Pokemon[] sortedInitiativeOfPokemon = new Pokemon[pokemonInBattle.Length];

            if (battlefieldEffects.Contains("Trick Room"))
            {
                sortedInitiativeOfPokemon.OrderByDescending(x => x.SPE).ToArray();
            }

            else
            {
                sortedInitiativeOfPokemon.OrderBy(x => x.SPE).ToArray();
            }

            return sortedInitiativeOfPokemon;
        }

        public int DisplayStat(double stat, string statName, double statIV, double statEV, int level, double natureMod)
        {
            double i = 0;

            switch(statName)
            {
                case "HP":
                    i = ((((2 * stat + statIV + (statEV / 4)) * level)) / 100) + level + 10;
                    return (int)i;

                default:
                    i = (((((2 * stat + statIV + (statEV / 4)) * level)) / 100) + 5 ) * natureMod;
                    return (int)i;
            }
        }

        // sets the amount of EXP needed to level up
        public int ExpPerLevel(string levelingRate, int currentLevel)
        {
            double i = 0;

            switch (levelingRate)
            {
                case "Erratic" :
                    ErraticExpPerLevel(currentLevel);
                    return (int)i;

                case "Fast":
                    i = (4 * (currentLevel ^ 3)) / 5;
                    return (int)i;

                case "Medium Fast":
                    i = currentLevel ^ 3;
                    return (int)i;

                case "Medium Slow":
                    i = (6 / 5 * (currentLevel ^ 3) - (15 * (currentLevel ^ 2)) + (100 * (currentLevel))) - 140;
                    return (int)i;

                case "Slow":
                    i = (5 * (currentLevel ^ 3)) / 4;
                    return (int)i;

                case "Fluctuating":
                    FluctuatingExpPerLevel(currentLevel);
                    return (int)i;
            }

            return (int)i;
        }

        // Erratic & Fluctuating are needed for ExpPerLevel Method
        public int ErraticExpPerLevel(int currentLevel)
        {
            int i = 0;

            switch (currentLevel)
            {
                case int n when (n < 50):
                    i = (100 - currentLevel * (currentLevel ^ 3)) / 50;
                    return i;

                case int n when (50 <= n || n < 68):
                    i = (15 - currentLevel * (currentLevel ^ 3)) / 50;
                    return i;

                case int n when (68 <= n || n < 98):
                    i = ((1911 - (10 * currentLevel) / 3) * (currentLevel ^ 3)) / 500;
                    return i;

                case int n when (98 <= n || n < 100):
                    i = (160 - currentLevel * (currentLevel ^ 3)) / 100;
                    return i;

                default:
                    break;
            }

            return i;
        }

        public int FluctuatingExpPerLevel(int currentLevel)
        {
            int i = 0;

            switch (currentLevel)
            {
                case int n when (n < 15):
                    i = (currentLevel ^ 3) * ((((currentLevel + 1) / 3) + 24) / 50);
                    return i;

                case int n when (15 <= n || n < 36):
                    i = (currentLevel ^ 3) * ((currentLevel + 14) / 50);
                    return i;

                case int n when (36 <= n || n < 100):
                    i = (currentLevel ^ 3) * (((currentLevel / 2) + 32) / 50);
                    return i;

                default:
                    break;
            }

            return i;
        }
    }
}
