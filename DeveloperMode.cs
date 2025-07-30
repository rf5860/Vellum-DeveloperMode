using HarmonyLib;
using MelonLoader;

// ReSharper disable InconsistentNaming, RedundantAssignment, UnusedMember.Local, ArrangeTypeMemberModifiers
namespace DeveloperMode
{
    public class DeveloperModeMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("VellumMod has started!");
        }

        private static bool IsDeveloper_Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
    
    
    [HarmonyPatch(typeof(ParseManager), "IsDeveloper")]
    public static class ParseManager_IsDeveloper_Patch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}