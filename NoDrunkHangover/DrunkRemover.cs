using HutongGames.PlayMaker;
using UnityEngine;

namespace NoDrunkHangover;

public class DrunkRemover : MonoBehaviour
{
	private void Update()
	{
		FsmVariables.GlobalVariables.FindFsmFloat("PlayerDrunk").Value = 0f;
		FsmVariables.GlobalVariables.FindFsmFloat("HangoverLeft").Value = 0f;
		FsmVariables.GlobalVariables.FindFsmFloat("HangoverStrenght").Value = 0f;
	}
}
