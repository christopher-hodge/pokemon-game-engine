using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_game
{
    public partial class Form1 : Form
    {
        Engine eg = new Engine();

        public Form1()
        {
            InitializeComponent();
        }

        public void Generate(object sender, EventArgs e)
        {
            string[] pk = { "Rhydon"};
            int lvl =  100 ;

            Pokemon pokemon = eg.GeneratePokemon(pk, lvl);

            

            pokemonDisplayInfo.Text = "Name:" + $"{pokemon.Name}" + Environment.NewLine +
                                      "Pokedex ID:" + $"{pokemon.ID}" + Environment.NewLine +
                                      "Level:" + $"{pokemon.Level}" + Environment.NewLine +
                                      "HP:" + $"{eg.DisplayStat(pokemon.HP[0], "HP", pokemon.HP[2], pokemon.HP[1], lvl, 1)}" + Environment.NewLine +
                                      "ATK:" + $"{eg.DisplayStat(pokemon.ATK[0], "", pokemon.ATK[2], pokemon.ATK[1], lvl, pokemon.ATK[3])}" + Environment.NewLine +
                                      "DEF:" + $"{eg.DisplayStat(pokemon.DEF[0], "", pokemon.DEF[2], pokemon.DEF[1], lvl, pokemon.DEF[3])}" + Environment.NewLine +
                                      "SPE:" + $"{eg.DisplayStat(pokemon.SPE[0], "", pokemon.SPE[2], pokemon.SPE[1], lvl, pokemon.SPE[3])}" + Environment.NewLine +
                                      "SDF:" + $"{eg.DisplayStat(pokemon.SDF[0], "", pokemon.SDF[2], pokemon.SDF[1], lvl, pokemon.SDF[3])}" + Environment.NewLine +
                                      "SPD:" + $"{eg.DisplayStat(pokemon.SPD[0], "", pokemon.SPD[2], pokemon.SPD[1], lvl, pokemon.SPD[3])}" + Environment.NewLine +
                                      "Nature:" + $"{pokemon.Nature}" + Environment.NewLine +
                                      "Gender:" + $"{pokemon.Gender}" + Environment.NewLine +
                                      "Ability:" + $"{pokemon.Ability}" + Environment.NewLine +
                                      "Species:" + $"{pokemon.Species}" + Environment.NewLine +
                                      "Hidden Ability Possible?:" + $"{pokemon.HasHiddenAbility}" + Environment.NewLine +
                                      "Leveling Rate:" + $"{pokemon.LevelingRate}" + Environment.NewLine +
                                      "Base EXP Yield:" + $"{pokemon.BaseExpYield}" + Environment.NewLine +
                                      "Catch Rate:" + $"{pokemon.CatchRate}" + Environment.NewLine +
                                      "Evasion:" + $"{pokemon.Evasion}" + Environment.NewLine +
                                      "EV Yield:" + $"{pokemon.EVYield}" + Environment.NewLine +
                                      "Exp:" + $"{pokemon.Experience}" + Environment.NewLine +
                                      "Gender Ratio:" + $"{pokemon.GenderRatio}" + Environment.NewLine ;
        }
    }
}
