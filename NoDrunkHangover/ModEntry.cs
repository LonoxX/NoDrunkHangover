using MSCLoader;
using UnityEngine;

namespace NoDrunkHangover;

public class NoDrunkHangover : Mod
{
	public override string ID => "NoDrunkHangover";
	public override string Name => "No Drunk & Hangover";
	public override string Author => "LonoxX";
	public override string Version => "1.0.0";
	public override string Description => "Removes drunk and hangover effects from the player.";
	public override Game SupportedGames => Game.MyWinterCar;

	public override void ModSetup()
	{
		GameObject val = new GameObject("NoDrunkHangover");
		val.AddComponent<DrunkRemover>();
		Object.DontDestroyOnLoad((Object)(object)val);
	}
}
