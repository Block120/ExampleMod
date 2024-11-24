using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMod
{
    internal class FastestFiring : ModUpgrade<ExampleMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 3000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 2, 0, 15, null, false, false);

            weaponModel.rate -= 0.1f;
        }
    }
}
