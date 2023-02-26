using MelonLoader;

namespace StealthBow;
internal sealed class Implementation : MelonMod
{
	public override void OnInitializeMelon()
	{
		Settings.OnLoad();
	}
}
