using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Api;
using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;

namespace ExampleMod.Upgrades
{
    internal class ExampleFourthPath : PathPlusPlus
    {
        public override string Tower => TowerID<ExampleMonkey>();
    }
}
