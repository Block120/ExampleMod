using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using UnityEngine;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;


namespace ExampleMod
{
    internal class ExampleMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 1000;

        public override string Description => "A custom monkey with 21 upgrades and a paragon.";

        public override string DisplayName => "Example Monkey";

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override ModSettingHotkey Hotkey => KeyCode.O;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            attackModel.RemoveWeapon(towerModel.GetAttackModel().weapons[0]);
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("SuperMonkey-200").GetWeapon().Duplicate());
            var weaponModel = towerModel.GetAttackModel().weapons[0];
            var projectileModel = weaponModel.projectile;

            towerModel.range = 50;
            attackModel.range = 50;

            weaponModel.rate = 1;

            projectileModel.pierce = 3;
            var behavior = projectileModel.GetBehavior<TravelStraitModel>(); if (behavior != null)
            {
                behavior.Lifespan = 3.0f;
            }
                projectileModel.GetDamageModel().damage = 3;
        }
    }
}
