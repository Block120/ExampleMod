using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMod
{
    internal class ALotOfDamge : ModUpgrade<ExampleMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 5000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage += 30;
        }
    }
}
