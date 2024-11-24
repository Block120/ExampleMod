using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Rounds;

namespace ExampleMod
{
    internal class ExampleRoundset : ModRoundSet
    {
        public override string BaseRoundSet => RoundSetType.Default;

        public override int DefinedRounds => 50;

        public override void ModifyRoundModels(RoundModel roundModel, int round)
        {
            switch (round)
            {
                case 49:
                    roundModel.AddBloonGroup<ExampleBloon>();
                    break;
            }
        }
    }
}
