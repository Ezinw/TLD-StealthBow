using HarmonyLib;
using Il2Cpp;

namespace StealthBow
{
    [HarmonyPatch(typeof(SkillsManager), "Awake")]
    internal class StealthBowSetting
    {

        public static void Postfix(SkillsManager __instance)
        {
            __instance.m_Skill_Archery.m_LevelWhereCanFireFromCrouch = Settings.settings.StealthBow;
        }

    }

    [HarmonyPatch(typeof(Skill_Archery), nameof(Skill_Archery.GetTierBenefits))]
    public class StealthBow
    {
        static void Postfix(ref string __result, Skill_Archery __instance)
        {
            SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

            if (currentTier == SkillTiers.Beginner && Settings.settings.StealthBow == 1 ||
                currentTier == SkillTiers.Novice && Settings.settings.StealthBow == 2 ||
                currentTier == SkillTiers.Novice && Settings.settings.StealthBow == 1 ||
                currentTier == SkillTiers.Skilled && Settings.settings.StealthBow == 3 ||
                currentTier == SkillTiers.Skilled && Settings.settings.StealthBow == 2 ||
                currentTier == SkillTiers.Skilled && Settings.settings.StealthBow == 1 ||
                currentTier == SkillTiers.Expert && Settings.settings.StealthBow == 4 ||
                currentTier == SkillTiers.Expert && Settings.settings.StealthBow == 3 ||
                currentTier == SkillTiers.Expert && Settings.settings.StealthBow == 2 ||
                currentTier == SkillTiers.Expert && Settings.settings.StealthBow == 1)
            { __result += "\nCan fire bow when crouched"; }

        }
    
    }

}
