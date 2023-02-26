using ModSettings;

namespace StealthBow
{

    internal class Settings : JsonModSettings
    {
        [Name("StealthBow")]
        [Description("Skill level required to fire bow while crouched.(Changes require game reload)")]
        [Slider(1, 5)]
        public int StealthBow = 5;


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("StealthBow");
        }
    }
}