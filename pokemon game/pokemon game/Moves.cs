using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_game
{
    public class Moves
    {
        public string ID { get; }

        public string Name { get; }

        public string Type { get; }

        public string Category { get; }

        public int BasePP { get; }

        public int Power { get; }

        public int TimesHit { get; }

        public double Accuracy { get; }

        public double ChanceToInflict { get; }
        public string Infliction { get; }

        public double ChanceToInflictSelf { get; }
        public string SelfInfliction { get; }

        public bool MakesContact { get; }

        public bool LocksUser { get; }

        public bool Recharge { get; }
    }
}
