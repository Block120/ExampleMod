using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathsPlusPlus;

namespace ExampleMod.Upgrades
{
    internal class ExampleSixthTier : PathPlusPlus
    {
        public override string Tower => TowerID<ExampleMonkey>();

        public override int ExtendVanillaPath => Top;
    }
}
