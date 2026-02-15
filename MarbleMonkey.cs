global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using MarbleMonkey;
using Il2CppAssets.Scripts.Data.Behaviors.Projectiles;
using Il2CppAssets.Scripts.Simulation.Bloons;
using BTD_Mod_Helper.Api.ModOptions;

[assembly: MelonInfo(typeof(MarbleMonkey.MarbleMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MarbleMonkey;

public class MarbleMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<MarbleMonkey>("MarbleMonkey loaded!");
    }

    public static readonly ModSettingBool ParagonInsane = new ModSettingBool(false)
    {
        displayName = "ParagonInsane",
        description = "If enabled, the Marble Monkey Paragon will be able to stun BADS instead of just everything else",
        requiresRestart = true
    };
}


