using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using PathsPlusPlus;

namespace ExampleMod.Upgrades
{
    internal class PlasmaGod : UpgradePlusPlus<ExampleSixthTier>
    {
        public override int Cost => 20000;

        public override int Tier => 6;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 10, 0, 100, null, false, false);

            weaponModel.rate -= 0.2f;
        }
    }
}
