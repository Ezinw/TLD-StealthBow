using HarmonyLib;
using Il2Cpp;

namespace StealthBow
{
    [HarmonyPatch(typeof(SkillsManager), "Awake")]
    internal class StealthBow
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Archery.m_LevelWhereCanFireFromCrouch = Settings.settings.StealthBow;
        }

    }

}