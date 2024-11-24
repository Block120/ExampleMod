using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Bloons;

namespace ExampleMod
{
    internal class ExampleBloon : ModBloon
    {
        public override string BaseBloon => BloonType.Moab;

        public override void ModifyBaseBloonModel(BloonModel bloonModel)
        {
            bloonModel.RemoveAllChildren();
            bloonModel.AddToChildren(BloonType.Lead, 4);

            bloonModel.bloonProperties = Il2Cpp.BloonProperties.Lead;
        }
    }
}