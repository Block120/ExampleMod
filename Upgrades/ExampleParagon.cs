using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;

namespace ExampleMod.Upgrades
{
    internal class ExampleParagon : ModParagonUpgrade<ExampleMonkey>
    {
        public override int Cost => 100000;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);

            towerModel.range = 0;
            attackModel.range = 1000;
            towerModel.isGlobalRange = true;

            weaponModel.rate -= 0.3f;

            projectileModel.GetDamageModel().damage += 100;
        }
    }
}
